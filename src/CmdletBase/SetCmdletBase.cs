﻿using Intersight.Client;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Reflection;
using System.Linq;

namespace Intersight.PowerShell
{
    public class SetCmdletBase : CmdletBase
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false)]
        public SwitchParameter Json { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = false)]
        public SwitchParameter WithHttpInfo { get; set; }

        public SetCmdletBase()
        {
        }

        protected override void ProcessRecord()
        {
            try
            {
                if (this.ModelObject == null)
                {
                    throw new Exception(string.Format("{0} ModelObject should not be null", this.MyInvocation.InvocationName));
                }

                if (!this.MyInvocation.BoundParameters.ContainsKey("Moid"))
                {
                    throw new Exception("Moid cannot be empty or null.");
                }

                var changedPropeties = GetChangedProperty();
                foreach (var item in changedPropeties)
                {
                    PropertyInfo propertyInfo = this.ModelObject.GetType().GetProperty(item.Key);
                    if (propertyInfo != null)
                    {
                        propertyInfo.SetValue(this.ModelObject, this.MyInvocation.BoundParameters[item.Key]);
                    }
                }

                if (Json.IsPresent)
                {
                    WriteRequestJson();
                }

                var methodInfo = GetMethodInfo(MethodName);
                var moidVal = ModelObject.GetType().GetProperty("Moid").GetValue(ModelObject);
                Object[] argList = new[] { moidVal, ModelObject, null };
                var result = methodInfo.Invoke(ApiInstance, argList);
                if (Json.IsPresent)
                {
                    WriteResponseJson(result);
                }
                else if (WithHttpInfo.IsPresent)
                {
                    WriteObject(result);
                }
                else
                {
                    WriteResponseData(result);
                }
            }
            catch (Exception ex)
            {
                throw ex.InnerException ?? ex;
            }
        }

        private object GetMoByMoid(object moid)
        {
            string methodName = string.Format("{0}ByMoid", this.MyInvocation.MyCommand.Name.Replace("Set-Intersight", "Get"));
            var getMethodInfo = this.ApiInstance.GetType().GetMethod(methodName);
            if (getMethodInfo != null)
            {
                object[] argList = new[] { moid };
                var result = getMethodInfo.Invoke(ApiInstance, argList);
                return result;
            }
            return ModelObject;
        }

        private Dictionary<string, object> GetChangedProperty()
        {
            var changedProperties = new Dictionary<string, object>();
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                changedProperties.Add("Moid", this.MyInvocation.BoundParameters["Moid"]);
            }

            var getObject = GetMoByMoid(this.MyInvocation.BoundParameters["Moid"]);

            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                changedProperties.Add("Name", this.MyInvocation.BoundParameters["Name"]);
            }
            else if (getObject != null)
            {
                var nameInfo = getObject.GetType().GetProperty("Name");
                if (nameInfo != null)
                {
                    var nameValue = nameInfo.GetValue(getObject);
                    changedProperties.Add("Name", nameValue);
                    this.MyInvocation.BoundParameters.Add("Name", nameValue);
                }
            }

            foreach (var propName in this.MyInvocation.BoundParameters)
            {
                if (propName.Key == "Moid" || propName.Key == "Name")
                {
                    continue;
                }

                var getPropertyInfo = getObject.GetType().GetProperty(propName.Key);
                if (getPropertyInfo != null)
                {
                    var getVal = getPropertyInfo.GetValue(getObject);
                    if (getVal == null)
                    {
                        if (getVal != propName.Value)
                        {
                            changedProperties.Add(propName.Key, propName.Value);
                        }
                        continue;
                    }

                    if (propName.Value == null)
                    {
                        if (getVal != propName.Value)
                        {
                            changedProperties.Add(propName.Key, propName.Value);
                        }
                        continue;
                    }

                    if ((getVal.GetType().Name == "String" || getVal.GetType().IsPrimitive))
                    {
                        if (!(getVal.Equals(propName.Value)))
                        {
                            changedProperties.Add(propName.Key, propName.Value);
                        }
                    }
                    else if (getVal.GetType().Name == "List`1")
                    {
                        List<Object> getCollection = new List<Object>((IEnumerable<Object>)getVal);
                        List<Object> paramCollection = new List<Object>((IEnumerable<Object>)propName.Value);
                        if (!Enumerable.SequenceEqual(paramCollection, getCollection))
                        {
                            changedProperties.Add(propName.Key, propName.Value);
                        }

                    }
                    else if (getVal.GetType().IsEnum)
                    {
                        if (getVal != propName.Value)
                        {
                            changedProperties.Add(propName.Key, propName.Value);
                        }
                    }
                    else
                    {
                        if (getVal != propName.Value)
                        {
                            changedProperties.Add(propName.Key, propName.Value);
                        }
                    }
                }
            }

            return changedProperties;
        }
    }
}
