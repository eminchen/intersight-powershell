using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityAdapterUnitDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityAdapterUnitDescriptor")]
    public class InitializeIntersightCapabilityAdapterUnitDescriptor : PSCmdlet
    {
        public InitializeIntersightCapabilityAdapterUnitDescriptor()
        {
            AdapterGeneration = CapabilityAdapterUnitDescriptor.AdapterGenerationEnum.NUMBER_4;
            ClassId = CapabilityAdapterUnitDescriptor.ClassIdEnum.CapabilityAdapterUnitDescriptor;
            ObjectType = CapabilityAdapterUnitDescriptor.ObjectTypeEnum.CapabilityAdapterUnitDescriptor;

        }
        // <summary>
        /// <para type="description">"Generation of the adapter.\n* `4` - Fourth generation adapters (14xx). The PIDs of these adapters end with the string 04.\n* `2` - Second generation VIC adapters (12xx). The PIDs of these adapters end with the string 02.\n* `3` - Third generation adapters (13xx). The PIDs of these adapters end with the string 03.\n* `5` - Fifth generation adapters (15xx). The PIDs of these adapters contain the V5 string."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityAdapterUnitDescriptor.AdapterGenerationEnum AdapterGeneration
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityAdapterUnitDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Order in which the ports are connected; sequential or cyclic."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ConnectivityOrder
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The port speed for ethernet ports in Mbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EthernetPortSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityFeatureConfig> Features
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The port speed for fibre channel ports in Mbps."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long FibreChannelPortSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The number of SCSI I/O Queue resources to allocate."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long FibreChannelScsiIoqLimit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates that the Azure Stack Host QoS feature is supported by this adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsAzureQosSupported
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates that the GENEVE offload feature is supported by this adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool IsGeneveSupported
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum Ring Size value for vNIC Receive Queue."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxEthRxRingSize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum Ring Size value for vNIC Transmit Queue."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxEthTxRingSize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum number of vNIC interfaces that can be RoCEv2 enabled."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxRocev2Interfaces
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Dce Ports for the adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumDcePorts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityAdapterUnitDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates PCI Link status of adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long PciLink
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Prom card type for the adapter."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PromCardType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityAdapterUnitDescriptor initObject = new Intersight.Model.CapabilityAdapterUnitDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdapterGeneration"))
            {
                initObject.AdapterGeneration = this.AdapterGeneration;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("ConnectivityOrder"))
            {
                initObject.ConnectivityOrder = this.ConnectivityOrder;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EthernetPortSpeed"))
            {
                initObject.EthernetPortSpeed = this.EthernetPortSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Features"))
            {
                initObject.Features = this.Features;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FibreChannelPortSpeed"))
            {
                initObject.FibreChannelPortSpeed = this.FibreChannelPortSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FibreChannelScsiIoqLimit"))
            {
                initObject.FibreChannelScsiIoqLimit = this.FibreChannelScsiIoqLimit;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsAzureQosSupported"))
            {
                initObject.IsAzureQosSupported = this.IsAzureQosSupported;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("IsGeneveSupported"))
            {
                initObject.IsGeneveSupported = this.IsGeneveSupported;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxEthRxRingSize"))
            {
                initObject.MaxEthRxRingSize = this.MaxEthRxRingSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxEthTxRingSize"))
            {
                initObject.MaxEthTxRingSize = this.MaxEthTxRingSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxRocev2Interfaces"))
            {
                initObject.MaxRocev2Interfaces = this.MaxRocev2Interfaces;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumDcePorts"))
            {
                initObject.NumDcePorts = this.NumDcePorts;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PciLink"))
            {
                initObject.PciLink = this.PciLink;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PromCardType"))
            {
                initObject.PromCardType = this.PromCardType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityCatalog.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityCatalog")]
    public class InitializeIntersightCapabilityCatalog : PSCmdlet
    {
        public InitializeIntersightCapabilityCatalog()
        {
            ClassId = CapabilityCatalog.ClassIdEnum.CapabilityCatalog;
            ObjectType = CapabilityCatalog.ObjectTypeEnum.CapabilityCatalog;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityCatalog.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A unique name for the catalog."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityCatalog.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"A reference to a organizationOrganization resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.OrganizationOrganizationRelationship Organization
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityCatalog initObject = new Intersight.Model.CapabilityCatalog();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Organization"))
            {
                initObject.Organization = this.Organization;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityChassisDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityChassisDescriptor")]
    public class InitializeIntersightCapabilityChassisDescriptor : PSCmdlet
    {
        public InitializeIntersightCapabilityChassisDescriptor()
        {
            ClassId = CapabilityChassisDescriptor.ClassIdEnum.CapabilityChassisDescriptor;
            ObjectType = CapabilityChassisDescriptor.ObjectTypeEnum.CapabilityChassisDescriptor;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityChassisDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityChassisDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Revision for the chassis enclosure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityChassisDescriptor initObject = new Intersight.Model.CapabilityChassisDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityChassisManufacturingDef.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityChassisManufacturingDef")]
    public class InitializeIntersightCapabilityChassisManufacturingDef : PSCmdlet
    {
        public InitializeIntersightCapabilityChassisManufacturingDef()
        {
            ClassId = CapabilityChassisManufacturingDef.ClassIdEnum.CapabilityChassisManufacturingDef;
            ObjectType = CapabilityChassisManufacturingDef.ObjectTypeEnum.CapabilityChassisManufacturingDef;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Caption for Chassis enclosure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Caption
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Chassis Code Name for Chassis enclosure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ChassisCodeName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityChassisManufacturingDef.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description for Chassis enclosure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityChassisManufacturingDef.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Identifier for a Chassis enclosure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Pid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Name for Chassis enclosure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProductName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SKU information for Chassis enclosure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Sku
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VID information for Chassis enclosure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityChassisManufacturingDef initObject = new Intersight.Model.CapabilityChassisManufacturingDef();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Caption"))
            {
                initObject.Caption = this.Caption;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ChassisCodeName"))
            {
                initObject.ChassisCodeName = this.ChassisCodeName;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pid"))
            {
                initObject.Pid = this.Pid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductName"))
            {
                initObject.ProductName = this.ProductName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sku"))
            {
                initObject.Sku = this.Sku;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vid"))
            {
                initObject.Vid = this.Vid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityCimcFirmwareDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityCimcFirmwareDescriptor")]
    public class InitializeIntersightCapabilityCimcFirmwareDescriptor : PSCmdlet
    {
        public InitializeIntersightCapabilityCimcFirmwareDescriptor()
        {
            ClassId = CapabilityCimcFirmwareDescriptor.ClassIdEnum.CapabilityCimcFirmwareDescriptor;
            ObjectType = CapabilityCimcFirmwareDescriptor.ObjectTypeEnum.CapabilityCimcFirmwareDescriptor;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityCimcFirmwareDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityCimcFirmwareDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Revision information for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityCimcFirmwareDescriptor initObject = new Intersight.Model.CapabilityCimcFirmwareDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityEquipmentPhysicalDef.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityEquipmentPhysicalDef")]
    public class InitializeIntersightCapabilityEquipmentPhysicalDef : PSCmdlet
    {
        public InitializeIntersightCapabilityEquipmentPhysicalDef()
        {
            ClassId = CapabilityEquipmentPhysicalDef.ClassIdEnum.CapabilityEquipmentPhysicalDef;
            ObjectType = CapabilityEquipmentPhysicalDef.ObjectTypeEnum.CapabilityEquipmentPhysicalDef;
            Pid = CapabilityEquipmentPhysicalDef.PidEnum.UCSFI6454;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityEquipmentPhysicalDef.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Depth information for a Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float Depth
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Height information for a Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float Height
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Max Power information for a Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxPower
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Min Power information for a Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MinPower
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Nominal Power information for a Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NominalPower
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityEquipmentPhysicalDef.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Identifier for a Switch/Fabric-Interconnect.\n* `UCS-FI-6454` - The standard 4th generation UCS Fabric Interconnect with 54 ports.\n* `UCS-FI-64108` - The expanded 4th generation UCS Fabric Interconnect with 108 ports.\n* `UCS-FI-6536` - The standard 5th generation UCS Fabric Interconnect with 36 ports.\n* `unknown` - Unknown device type, usage is TBD."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityEquipmentPhysicalDef.PidEnum Pid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SKU information for Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Sku
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VID information for Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Weight information for a Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float Weight
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Width information for a Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float Width
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityEquipmentPhysicalDef initObject = new Intersight.Model.CapabilityEquipmentPhysicalDef();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Depth"))
            {
                initObject.Depth = this.Depth;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Height"))
            {
                initObject.Height = this.Height;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxPower"))
            {
                initObject.MaxPower = this.MaxPower;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinPower"))
            {
                initObject.MinPower = this.MinPower;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NominalPower"))
            {
                initObject.NominalPower = this.NominalPower;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pid"))
            {
                initObject.Pid = this.Pid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sku"))
            {
                initObject.Sku = this.Sku;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vid"))
            {
                initObject.Vid = this.Vid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Weight"))
            {
                initObject.Weight = this.Weight;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Width"))
            {
                initObject.Width = this.Width;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityEquipmentSlotArray.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityEquipmentSlotArray")]
    public class InitializeIntersightCapabilityEquipmentSlotArray : PSCmdlet
    {
        public InitializeIntersightCapabilityEquipmentSlotArray()
        {
            ClassId = CapabilityEquipmentSlotArray.ClassIdEnum.CapabilityEquipmentSlotArray;
            ObjectType = CapabilityEquipmentSlotArray.ObjectTypeEnum.CapabilityEquipmentSlotArray;
            Pid = CapabilityEquipmentSlotArray.PidEnum.UCSFI6454;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityEquipmentSlotArray.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"First Index information for a Switch/Fabric-Interconnect hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float FirstIndex
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Height information for a Switch/Fabric-Interconnect hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float Height
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Horizontal Start Offset information for a Switch/Fabric-Interconnect hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float HorizontalStartOffset
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inline Group Separation information for a Switch/Fabric-Interconnect hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float InlineGroupSeparation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inline Group Size information for a Switch/Fabric-Interconnect hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float InlineGroupSize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Inline Offset information for a Switch/Fabric-Interconnect hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float InlineOffset
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Location information for a Switch/Fabric-Interconnect hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Location
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of Slots information for a Switch/Fabric-Interconnect hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumberOfSlots
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityEquipmentSlotArray.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Orientation information for a Switch/Fabric-Interconnect hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Orientation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Identifier for a Switch/Fabric-Interconnect.\n* `UCS-FI-6454` - The standard 4th generation UCS Fabric Interconnect with 54 ports.\n* `UCS-FI-64108` - The expanded 4th generation UCS Fabric Interconnect with 108 ports.\n* `UCS-FI-6536` - The standard 5th generation UCS Fabric Interconnect with 36 ports.\n* `unknown` - Unknown device type, usage is TBD."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityEquipmentSlotArray.PidEnum Pid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Selector information for a Switch/Fabric-Interconnect hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Selector
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SKU information for Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Sku
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Slots per line information for a Switch/Fabric-Interconnect hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long SlotsPerLine
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Transverse Group Separation information for a Switch/Fabric-Interconnect hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float TransverseGroupSeparation
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Transverse Group Size information for a Switch/Fabric-Interconnect hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float TransverseGroupSize
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Transverse Offset information for a Switch/Fabric-Interconnect hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float TransverseOffset
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Vertical Start Offset information for a Switch/Fabric-Interconnect hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float VerticalStartOffset
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VID information for Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Width information for a Switch/Fabric-Interconnect hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public float Width
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityEquipmentSlotArray initObject = new Intersight.Model.CapabilityEquipmentSlotArray();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FirstIndex"))
            {
                initObject.FirstIndex = this.FirstIndex;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Height"))
            {
                initObject.Height = this.Height;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("HorizontalStartOffset"))
            {
                initObject.HorizontalStartOffset = this.HorizontalStartOffset;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InlineGroupSeparation"))
            {
                initObject.InlineGroupSeparation = this.InlineGroupSeparation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InlineGroupSize"))
            {
                initObject.InlineGroupSize = this.InlineGroupSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("InlineOffset"))
            {
                initObject.InlineOffset = this.InlineOffset;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Location"))
            {
                initObject.Location = this.Location;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumberOfSlots"))
            {
                initObject.NumberOfSlots = this.NumberOfSlots;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Orientation"))
            {
                initObject.Orientation = this.Orientation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Pid"))
            {
                initObject.Pid = this.Pid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Selector"))
            {
                initObject.Selector = this.Selector;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sku"))
            {
                initObject.Sku = this.Sku;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SlotsPerLine"))
            {
                initObject.SlotsPerLine = this.SlotsPerLine;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TransverseGroupSeparation"))
            {
                initObject.TransverseGroupSeparation = this.TransverseGroupSeparation;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TransverseGroupSize"))
            {
                initObject.TransverseGroupSize = this.TransverseGroupSize;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("TransverseOffset"))
            {
                initObject.TransverseOffset = this.TransverseOffset;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VerticalStartOffset"))
            {
                initObject.VerticalStartOffset = this.VerticalStartOffset;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vid"))
            {
                initObject.Vid = this.Vid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Width"))
            {
                initObject.Width = this.Width;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityFanModuleDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityFanModuleDescriptor")]
    public class InitializeIntersightCapabilityFanModuleDescriptor : PSCmdlet
    {
        public InitializeIntersightCapabilityFanModuleDescriptor()
        {
            ClassId = CapabilityFanModuleDescriptor.ClassIdEnum.CapabilityFanModuleDescriptor;
            ObjectType = CapabilityFanModuleDescriptor.ObjectTypeEnum.CapabilityFanModuleDescriptor;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityFanModuleDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityFanModuleDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Revision for the chassis enclosure."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityFanModuleDescriptor initObject = new Intersight.Model.CapabilityFanModuleDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityFanModuleManufacturingDef.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityFanModuleManufacturingDef")]
    public class InitializeIntersightCapabilityFanModuleManufacturingDef : PSCmdlet
    {
        public InitializeIntersightCapabilityFanModuleManufacturingDef()
        {
            ClassId = CapabilityFanModuleManufacturingDef.ClassIdEnum.CapabilityFanModuleManufacturingDef;
            ObjectType = CapabilityFanModuleManufacturingDef.ObjectTypeEnum.CapabilityFanModuleManufacturingDef;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Caption for a fan module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Caption
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityFanModuleManufacturingDef.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description for a fan module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityFanModuleManufacturingDef.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Identifier for a fan module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Pid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Name for Fan Module Unit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProductName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SKU information for a fan module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Sku
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VID information for a fan module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityFanModuleManufacturingDef initObject = new Intersight.Model.CapabilityFanModuleManufacturingDef();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Caption"))
            {
                initObject.Caption = this.Caption;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pid"))
            {
                initObject.Pid = this.Pid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductName"))
            {
                initObject.ProductName = this.ProductName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sku"))
            {
                initObject.Sku = this.Sku;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vid"))
            {
                initObject.Vid = this.Vid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityFeatureConfig.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityFeatureConfig")]
    public class InitializeIntersightCapabilityFeatureConfig : PSCmdlet
    {
        public InitializeIntersightCapabilityFeatureConfig()
        {
            ClassId = CapabilityFeatureConfig.ClassIdEnum.CapabilityFeatureConfig;
            FeatureName = CapabilityFeatureConfig.FeatureNameEnum.RoCEv2;
            ObjectType = CapabilityFeatureConfig.ObjectTypeEnum.CapabilityFeatureConfig;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityFeatureConfig.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Name of the feature that identifies the specific adapter configuration.\n* `RoCEv2` - Capability indicator of the RDMA over Converged Ethernet (RoCE) feature version 2.\n* `RoCEv1` - Capability indicator of the RDMA over Converged Ethernet (RoCE) feature version 1.\n* `VMQ` - Capability indicator of the Virtual Machine Queue (VMQ) feature.\n* `VMMQ` - Capability indicator of the Virtual Machine Multi-Queue (VMMQ) feature.\n* `VMQInterrupts` - Capability indicator of the Virtual Machine Queue (VMQ) Interrupts feature.\n* `NVGRE` - Capability indicator of the Network Virtualization using Generic Routing Encapsulation (NVGRE) feature.\n* `ARFS` - Capability indicator of the Accelerated Receive Flow Steering (ARFS) feature.\n* `VXLAN` - Capability indicator of the Virtual Extensible LAN (VXLAN) feature."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityFeatureConfig.FeatureNameEnum FeatureName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Firmware version from which support for this feature is available."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MinFwVersion
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityFeatureConfig.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SupportedFwVersions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> SupportedInAdapters
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<CapabilityFeatureConfig.SupportedInGenerationsEnum> SupportedInGenerations
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityFeatureConfig initObject = new Intersight.Model.CapabilityFeatureConfig();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("FeatureName"))
            {
                initObject.FeatureName = this.FeatureName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinFwVersion"))
            {
                initObject.MinFwVersion = this.MinFwVersion;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SupportedFwVersions"))
            {
                initObject.SupportedFwVersions = this.SupportedFwVersions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SupportedInAdapters"))
            {
                initObject.SupportedInAdapters = this.SupportedInAdapters;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SupportedInGenerations"))
            {
                initObject.SupportedInGenerations = this.SupportedInGenerations;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityFexDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityFexDescriptor")]
    public class InitializeIntersightCapabilityFexDescriptor : PSCmdlet
    {
        public InitializeIntersightCapabilityFexDescriptor()
        {
            ClassId = CapabilityFexDescriptor.ClassIdEnum.CapabilityFexDescriptor;
            ObjectType = CapabilityFexDescriptor.ObjectTypeEnum.CapabilityFexDescriptor;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityFexDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityFexDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Revision for the fabric extender."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityFexDescriptor initObject = new Intersight.Model.CapabilityFexDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityFexManufacturingDef.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityFexManufacturingDef")]
    public class InitializeIntersightCapabilityFexManufacturingDef : PSCmdlet
    {
        public InitializeIntersightCapabilityFexManufacturingDef()
        {
            ClassId = CapabilityFexManufacturingDef.ClassIdEnum.CapabilityFexManufacturingDef;
            ObjectType = CapabilityFexManufacturingDef.ObjectTypeEnum.CapabilityFexManufacturingDef;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Caption for Fabric extender."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Caption
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityFexManufacturingDef.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description for Fabric extender."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Code Name for Fabric extender."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string FexCodeName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityFexManufacturingDef.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Identifier for a Fabric extender."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Pid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Name for Fabric extender."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProductName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SKU information for Fabric extender."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Sku
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VID information for Fabric extender."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityFexManufacturingDef initObject = new Intersight.Model.CapabilityFexManufacturingDef();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Caption"))
            {
                initObject.Caption = this.Caption;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FexCodeName"))
            {
                initObject.FexCodeName = this.FexCodeName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pid"))
            {
                initObject.Pid = this.Pid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductName"))
            {
                initObject.ProductName = this.ProductName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sku"))
            {
                initObject.Sku = this.Sku;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vid"))
            {
                initObject.Vid = this.Vid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityIoCardCapabilityDef.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityIoCardCapabilityDef")]
    public class InitializeIntersightCapabilityIoCardCapabilityDef : PSCmdlet
    {
        public InitializeIntersightCapabilityIoCardCapabilityDef()
        {
            ClassId = CapabilityIoCardCapabilityDef.ClassIdEnum.CapabilityIoCardCapabilityDef;
            ObjectType = CapabilityIoCardCapabilityDef.ObjectTypeEnum.CapabilityIoCardCapabilityDef;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityIoCardCapabilityDef.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Device connector support on Iocard."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DcSupported
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityIoCardCapabilityDef.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityIoCardCapabilityDef initObject = new Intersight.Model.CapabilityIoCardCapabilityDef();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DcSupported"))
            {
                initObject.DcSupported = this.DcSupported;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityIoCardDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityIoCardDescriptor")]
    public class InitializeIntersightCapabilityIoCardDescriptor : PSCmdlet
    {
        public InitializeIntersightCapabilityIoCardDescriptor()
        {
            ClassId = CapabilityIoCardDescriptor.ClassIdEnum.CapabilityIoCardDescriptor;
            ObjectType = CapabilityIoCardDescriptor.ObjectTypeEnum.CapabilityIoCardDescriptor;
            UifConnectivity = CapabilityIoCardDescriptor.UifConnectivityEnum.Inline;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityIoCardDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Number of hif ports per blade for the iocard module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long NumHifPorts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityIoCardDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Revision for the iocard module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Connectivity information between UIF Uplink ports and IOM ports.\n* `inline` - UIF uplink ports and IOM ports are connected inline.\n* `cross-connected` - UIF uplink ports and IOM ports are cross-connected, a case in washington chassis."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityIoCardDescriptor.UifConnectivityEnum UifConnectivity
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityIoCardDescriptor initObject = new Intersight.Model.CapabilityIoCardDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NumHifPorts"))
            {
                initObject.NumHifPorts = this.NumHifPorts;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UifConnectivity"))
            {
                initObject.UifConnectivity = this.UifConnectivity;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityIoCardManufacturingDef.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityIoCardManufacturingDef")]
    public class InitializeIntersightCapabilityIoCardManufacturingDef : PSCmdlet
    {
        public InitializeIntersightCapabilityIoCardManufacturingDef()
        {
            ClassId = CapabilityIoCardManufacturingDef.ClassIdEnum.CapabilityIoCardManufacturingDef;
            ObjectType = CapabilityIoCardManufacturingDef.ObjectTypeEnum.CapabilityIoCardManufacturingDef;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Caption for a chassis Iocard module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Caption
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityIoCardManufacturingDef.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description for a chassis Iocard module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityIoCardManufacturingDef.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Identifier for a chassis Iocard module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Pid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Name for IO Card Module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProductName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SKU information for a chassis Iocard module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Sku
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VID information for a chassis Iocard module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityIoCardManufacturingDef initObject = new Intersight.Model.CapabilityIoCardManufacturingDef();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Caption"))
            {
                initObject.Caption = this.Caption;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pid"))
            {
                initObject.Pid = this.Pid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductName"))
            {
                initObject.ProductName = this.ProductName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sku"))
            {
                initObject.Sku = this.Sku;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vid"))
            {
                initObject.Vid = this.Vid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityPortGroupAggregationDef.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityPortGroupAggregationDef")]
    public class InitializeIntersightCapabilityPortGroupAggregationDef : PSCmdlet
    {
        public InitializeIntersightCapabilityPortGroupAggregationDef()
        {
            ClassId = CapabilityPortGroupAggregationDef.ClassIdEnum.CapabilityPortGroupAggregationDef;
            ObjectType = CapabilityPortGroupAggregationDef.ObjectTypeEnum.CapabilityPortGroupAggregationDef;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Aggregation capability for port group."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string AggregationCap
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityPortGroupAggregationDef.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Indicates support for 40G port group capability."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Hw40GPortGroupCap
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityPortGroupAggregationDef.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The type of port group for which this capability is defined."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Pgtype
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityPortGroupAggregationDef initObject = new Intersight.Model.CapabilityPortGroupAggregationDef();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AggregationCap"))
            {
                initObject.AggregationCap = this.AggregationCap;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Hw40GPortGroupCap"))
            {
                initObject.Hw40GPortGroupCap = this.Hw40GPortGroupCap;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pgtype"))
            {
                initObject.Pgtype = this.Pgtype;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityPortRange.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityPortRange")]
    public class InitializeIntersightCapabilityPortRange : PSCmdlet
    {
        public InitializeIntersightCapabilityPortRange()
        {
            ClassId = CapabilityPortRange.ClassIdEnum.CapabilityPortRange;
            ObjectType = CapabilityPortRange.ObjectTypeEnum.CapabilityPortRange;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityPortRange.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ending Port ID in this range of ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndPortId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Ending Slot ID in this range of ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EndSlotId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityPortRange.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Starting Port ID in this range of ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StartPortId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Starting Slot ID in this range of ports."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long StartSlotId
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityPortRange initObject = new Intersight.Model.CapabilityPortRange();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("EndPortId"))
            {
                initObject.EndPortId = this.EndPortId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EndSlotId"))
            {
                initObject.EndSlotId = this.EndSlotId;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("StartPortId"))
            {
                initObject.StartPortId = this.StartPortId;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StartSlotId"))
            {
                initObject.StartSlotId = this.StartSlotId;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityPsuDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityPsuDescriptor")]
    public class InitializeIntersightCapabilityPsuDescriptor : PSCmdlet
    {
        public InitializeIntersightCapabilityPsuDescriptor()
        {
            ClassId = CapabilityPsuDescriptor.ClassIdEnum.CapabilityPsuDescriptor;
            ObjectType = CapabilityPsuDescriptor.ObjectTypeEnum.CapabilityPsuDescriptor;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityPsuDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityPsuDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Revision for the power supply."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityPsuDescriptor initObject = new Intersight.Model.CapabilityPsuDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityPsuManufacturingDef.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityPsuManufacturingDef")]
    public class InitializeIntersightCapabilityPsuManufacturingDef : PSCmdlet
    {
        public InitializeIntersightCapabilityPsuManufacturingDef()
        {
            ClassId = CapabilityPsuManufacturingDef.ClassIdEnum.CapabilityPsuManufacturingDef;
            ObjectType = CapabilityPsuManufacturingDef.ObjectTypeEnum.CapabilityPsuManufacturingDef;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Caption for a power supply unit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Caption
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityPsuManufacturingDef.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description for a power supply unit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityPsuManufacturingDef.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Identifier for a power supply unit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Pid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Name for Power Supplu Unit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProductName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SKU information for a power supply unit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Sku
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VID information for a power supply unit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityPsuManufacturingDef initObject = new Intersight.Model.CapabilityPsuManufacturingDef();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Caption"))
            {
                initObject.Caption = this.Caption;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pid"))
            {
                initObject.Pid = this.Pid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductName"))
            {
                initObject.ProductName = this.ProductName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sku"))
            {
                initObject.Sku = this.Sku;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vid"))
            {
                initObject.Vid = this.Vid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityServerModelsCapabilityDef.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityServerModelsCapabilityDef")]
    public class InitializeIntersightCapabilityServerModelsCapabilityDef : PSCmdlet
    {
        public InitializeIntersightCapabilityServerModelsCapabilityDef()
        {
            ClassId = CapabilityServerModelsCapabilityDef.ClassIdEnum.CapabilityServerModelsCapabilityDef;
            ObjectType = CapabilityServerModelsCapabilityDef.ObjectTypeEnum.CapabilityServerModelsCapabilityDef;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityServerModelsCapabilityDef.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<string> Models
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityServerModelsCapabilityDef.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Type of the server. Example, BladeM6, RackM5."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ServerType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityServerModelsCapabilityDef initObject = new Intersight.Model.CapabilityServerModelsCapabilityDef();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Models"))
            {
                initObject.Models = this.Models;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("ServerType"))
            {
                initObject.ServerType = this.ServerType;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilityServerSchemaDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilityServerSchemaDescriptor")]
    public class InitializeIntersightCapabilityServerSchemaDescriptor : PSCmdlet
    {
        public InitializeIntersightCapabilityServerSchemaDescriptor()
        {
            ClassId = CapabilityServerSchemaDescriptor.ClassIdEnum.CapabilityServerSchemaDescriptor;
            ObjectType = CapabilityServerSchemaDescriptor.ObjectTypeEnum.CapabilityServerSchemaDescriptor;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityServerSchemaDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Redfish property name for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string LocatorLedName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilityServerSchemaDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Redfish version information for the server."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string RedfishSchema
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilityServerSchemaDescriptor initObject = new Intersight.Model.CapabilityServerSchemaDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LocatorLedName"))
            {
                initObject.LocatorLedName = this.LocatorLedName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("RedfishSchema"))
            {
                initObject.RedfishSchema = this.RedfishSchema;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilitySiocModuleCapabilityDef.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilitySiocModuleCapabilityDef")]
    public class InitializeIntersightCapabilitySiocModuleCapabilityDef : PSCmdlet
    {
        public InitializeIntersightCapabilitySiocModuleCapabilityDef()
        {
            ClassId = CapabilitySiocModuleCapabilityDef.ClassIdEnum.CapabilitySiocModuleCapabilityDef;
            ObjectType = CapabilitySiocModuleCapabilityDef.ObjectTypeEnum.CapabilitySiocModuleCapabilityDef;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySiocModuleCapabilityDef.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Device connector support on SIOC."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DcSupported
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySiocModuleCapabilityDef.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilitySiocModuleCapabilityDef initObject = new Intersight.Model.CapabilitySiocModuleCapabilityDef();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DcSupported"))
            {
                initObject.DcSupported = this.DcSupported;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilitySiocModuleDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilitySiocModuleDescriptor")]
    public class InitializeIntersightCapabilitySiocModuleDescriptor : PSCmdlet
    {
        public InitializeIntersightCapabilitySiocModuleDescriptor()
        {
            ClassId = CapabilitySiocModuleDescriptor.ClassIdEnum.CapabilitySiocModuleDescriptor;
            ObjectType = CapabilitySiocModuleDescriptor.ObjectTypeEnum.CapabilitySiocModuleDescriptor;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySiocModuleDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySiocModuleDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Revision for the SIOC module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilitySiocModuleDescriptor initObject = new Intersight.Model.CapabilitySiocModuleDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilitySiocModuleManufacturingDef.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilitySiocModuleManufacturingDef")]
    public class InitializeIntersightCapabilitySiocModuleManufacturingDef : PSCmdlet
    {
        public InitializeIntersightCapabilitySiocModuleManufacturingDef()
        {
            ClassId = CapabilitySiocModuleManufacturingDef.ClassIdEnum.CapabilitySiocModuleManufacturingDef;
            ObjectType = CapabilitySiocModuleManufacturingDef.ObjectTypeEnum.CapabilitySiocModuleManufacturingDef;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Caption for a chassis SIOC module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Caption
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySiocModuleManufacturingDef.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description for a chassis SIOC module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySiocModuleManufacturingDef.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Identifier for a chassis SIOC module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Pid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Name for SIOC Module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProductName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SKU information for a chassis SIOC module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Sku
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VID information for a chassis SIOC module."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilitySiocModuleManufacturingDef initObject = new Intersight.Model.CapabilitySiocModuleManufacturingDef();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Caption"))
            {
                initObject.Caption = this.Caption;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pid"))
            {
                initObject.Pid = this.Pid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductName"))
            {
                initObject.ProductName = this.ProductName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sku"))
            {
                initObject.Sku = this.Sku;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vid"))
            {
                initObject.Vid = this.Vid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilitySwitchCapability.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilitySwitchCapability")]
    public class InitializeIntersightCapabilitySwitchCapability : PSCmdlet
    {
        public InitializeIntersightCapabilitySwitchCapability()
        {
            ClassId = CapabilitySwitchCapability.ClassIdEnum.CapabilitySwitchCapability;
            ObjectType = CapabilitySwitchCapability.ObjectTypeEnum.CapabilitySwitchCapability;
            Pid = CapabilitySwitchCapability.PidEnum.UCSFI6454;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchCapability.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Default Fcoe VLAN associated with this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long DefaultFcoeVlan
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Dynamic VIFs support on this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool DynamicVifsSupported
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fan Modules support on this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool FanModulesSupported
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityPortRange> FcEndHostModeReservedVsans
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Fc Uplink ports auto negotiation speed support on this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool FcUplinkPortsAutoNegotiationSupported
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Locator Beacon LED support on this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool LocatorBeaconSupported
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum allowed physical ports on this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxPorts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum allowed physical slots on this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxSlots
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of network limitations for this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.CapabilitySwitchNetworkLimits NetworkLimits
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchCapability.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Identifier for a Switch/Fabric-Interconnect.\n* `UCS-FI-6454` - The standard 4th generation UCS Fabric Interconnect with 54 ports.\n* `UCS-FI-64108` - The expanded 4th generation UCS Fabric Interconnect with 108 ports.\n* `UCS-FI-6536` - The standard 5th generation UCS Fabric Interconnect with 36 ports.\n* `unknown` - Unknown device type, usage is TBD."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchCapability.PidEnum Pid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityPortRange> PortsSupporting100gSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityPortRange> PortsSupporting10gSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityPortRange> PortsSupporting1gSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityPortRange> PortsSupporting25gSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityPortRange> PortsSupporting40gSpeed
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityPortRange> PortsSupportingBreakout
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityPortRange> PortsSupportingFcoe
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityPortRange> PortsSupportingServerRole
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityPortRange> ReservedVsans
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Sereno Adaptor with Netflow support on this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool SerenoNetflowSupported
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SKU information for Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Sku
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of storage limitations for this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.CapabilitySwitchStorageLimits StorageLimits
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilitySwitchingModeCapability> SwitchingModeCapabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"List of system limitations for this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Model.CapabilitySwitchSystemLimits SystemLimits
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityPortRange> UnifiedPorts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The Slider rule for Unified ports on this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string UnifiedRule
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VID information for Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilitySwitchCapability initObject = new Intersight.Model.CapabilitySwitchCapability();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("DefaultFcoeVlan"))
            {
                initObject.DefaultFcoeVlan = this.DefaultFcoeVlan;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("DynamicVifsSupported"))
            {
                initObject.DynamicVifsSupported = this.DynamicVifsSupported;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FanModulesSupported"))
            {
                initObject.FanModulesSupported = this.FanModulesSupported;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcEndHostModeReservedVsans"))
            {
                initObject.FcEndHostModeReservedVsans = this.FcEndHostModeReservedVsans;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("FcUplinkPortsAutoNegotiationSupported"))
            {
                initObject.FcUplinkPortsAutoNegotiationSupported = this.FcUplinkPortsAutoNegotiationSupported;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("LocatorBeaconSupported"))
            {
                initObject.LocatorBeaconSupported = this.LocatorBeaconSupported;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxPorts"))
            {
                initObject.MaxPorts = this.MaxPorts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxSlots"))
            {
                initObject.MaxSlots = this.MaxSlots;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("NetworkLimits"))
            {
                initObject.NetworkLimits = this.NetworkLimits;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Pid"))
            {
                initObject.Pid = this.Pid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PortsSupporting100gSpeed"))
            {
                initObject.PortsSupporting100gSpeed = this.PortsSupporting100gSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PortsSupporting10gSpeed"))
            {
                initObject.PortsSupporting10gSpeed = this.PortsSupporting10gSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PortsSupporting1gSpeed"))
            {
                initObject.PortsSupporting1gSpeed = this.PortsSupporting1gSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PortsSupporting25gSpeed"))
            {
                initObject.PortsSupporting25gSpeed = this.PortsSupporting25gSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PortsSupporting40gSpeed"))
            {
                initObject.PortsSupporting40gSpeed = this.PortsSupporting40gSpeed;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PortsSupportingBreakout"))
            {
                initObject.PortsSupportingBreakout = this.PortsSupportingBreakout;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PortsSupportingFcoe"))
            {
                initObject.PortsSupportingFcoe = this.PortsSupportingFcoe;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("PortsSupportingServerRole"))
            {
                initObject.PortsSupportingServerRole = this.PortsSupportingServerRole;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ReservedVsans"))
            {
                initObject.ReservedVsans = this.ReservedVsans;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SerenoNetflowSupported"))
            {
                initObject.SerenoNetflowSupported = this.SerenoNetflowSupported;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sku"))
            {
                initObject.Sku = this.Sku;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("StorageLimits"))
            {
                initObject.StorageLimits = this.StorageLimits;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SwitchingModeCapabilities"))
            {
                initObject.SwitchingModeCapabilities = this.SwitchingModeCapabilities;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("SystemLimits"))
            {
                initObject.SystemLimits = this.SystemLimits;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UnifiedPorts"))
            {
                initObject.UnifiedPorts = this.UnifiedPorts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("UnifiedRule"))
            {
                initObject.UnifiedRule = this.UnifiedRule;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vid"))
            {
                initObject.Vid = this.Vid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilitySwitchDescriptor.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilitySwitchDescriptor")]
    public class InitializeIntersightCapabilitySwitchDescriptor : PSCmdlet
    {
        public InitializeIntersightCapabilitySwitchDescriptor()
        {
            ClassId = CapabilitySwitchDescriptor.ClassIdEnum.CapabilitySwitchDescriptor;
            ObjectType = CapabilitySwitchDescriptor.ObjectTypeEnum.CapabilitySwitchDescriptor;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An array of relationships to capabilityCapability resources."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.CapabilityCapabilityRelationship> Capabilities
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchDescriptor.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Detailed information about the endpoint."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The total expected memory for this hardware."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long ExpectedMemory
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The model of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Model
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchDescriptor.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Revision for the fabric interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Revision
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The vendor of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vendor
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The firmware or software version of the endpoint, for which this capability information is applicable."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Version
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilitySwitchDescriptor initObject = new Intersight.Model.CapabilitySwitchDescriptor();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Capabilities"))
            {
                initObject.Capabilities = this.Capabilities;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ExpectedMemory"))
            {
                initObject.ExpectedMemory = this.ExpectedMemory;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Model"))
            {
                initObject.Model = this.Model;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Revision"))
            {
                initObject.Revision = this.Revision;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vendor"))
            {
                initObject.Vendor = this.Vendor;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Version"))
            {
                initObject._Version = this.Version;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilitySwitchManufacturingDef.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilitySwitchManufacturingDef")]
    public class InitializeIntersightCapabilitySwitchManufacturingDef : PSCmdlet
    {
        public InitializeIntersightCapabilitySwitchManufacturingDef()
        {
            ClassId = CapabilitySwitchManufacturingDef.ClassIdEnum.CapabilitySwitchManufacturingDef;
            ObjectType = CapabilitySwitchManufacturingDef.ObjectTypeEnum.CapabilitySwitchManufacturingDef;
            Pid = CapabilitySwitchManufacturingDef.PidEnum.UCSFI6454;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Caption for Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Caption
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchManufacturingDef.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Description for Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Description
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The unique identifier of this Managed Object instance."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Moid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"An unique identifer for a capability descriptor."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchManufacturingDef.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Part Number for Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string PartNumber
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Identifier for a Switch/Fabric-Interconnect.\n* `UCS-FI-6454` - The standard 4th generation UCS Fabric Interconnect with 54 ports.\n* `UCS-FI-64108` - The expanded 4th generation UCS Fabric Interconnect with 108 ports.\n* `UCS-FI-6536` - The standard 5th generation UCS Fabric Interconnect with 36 ports.\n* `unknown` - Unknown device type, usage is TBD."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchManufacturingDef.PidEnum Pid
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Product Name for Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string ProductName
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"SKU information for Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Sku
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.MoTag> Tags
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VID information for Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Vid
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilitySwitchManufacturingDef initObject = new Intersight.Model.CapabilitySwitchManufacturingDef();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Caption"))
            {
                initObject.Caption = this.Caption;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Description"))
            {
                initObject.Description = this.Description;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Moid"))
            {
                initObject.Moid = this.Moid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                initObject.Name = this.Name;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("PartNumber"))
            {
                initObject.PartNumber = this.PartNumber;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Pid"))
            {
                initObject.Pid = this.Pid;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("ProductName"))
            {
                initObject.ProductName = this.ProductName;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Sku"))
            {
                initObject.Sku = this.Sku;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Tags"))
            {
                initObject.Tags = this.Tags;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Vid"))
            {
                initObject.Vid = this.Vid;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilitySwitchNetworkLimits.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilitySwitchNetworkLimits")]
    public class InitializeIntersightCapabilitySwitchNetworkLimits : PSCmdlet
    {
        public InitializeIntersightCapabilitySwitchNetworkLimits()
        {
            ClassId = CapabilitySwitchNetworkLimits.ClassIdEnum.CapabilitySwitchNetworkLimits;
            ObjectType = CapabilitySwitchNetworkLimits.ObjectTypeEnum.CapabilitySwitchNetworkLimits;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchNetworkLimits.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum Compressed configurable VLANs on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxCompressedPortVlanCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable VLANs on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaxUncompressedPortVlanCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configured and enabled Traffic Monitoring sessions on this Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumActiveTrafficMonitoringSessions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Ethernet port-channels on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumEthernetPortChannels
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Ethernet Uplink ports on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumEthernetUplinkPorts
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Fibre Channel port-channel member ports on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumFcPortChannelMembers
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Fibre Channel port-channels on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumFcPortChannels
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable IGMP Groups on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumIgmpGroups
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable ports per each port-channel on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumPortChannelMembers
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Primary Private VLANs on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumPrimaryVlan
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Secondary Private VLANs on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumSecondaryVlan
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Secondary VLANs per each Primary VLAN on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumSecondaryVlanPerPrimary
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum allowes VIFs on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumVifs
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable VLANs on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumVlans
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Minimum required fans in 'active' state for this Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MinimumActiveFans
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchNetworkLimits.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilitySwitchNetworkLimits initObject = new Intersight.Model.CapabilitySwitchNetworkLimits();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxCompressedPortVlanCount"))
            {
                initObject.MaxCompressedPortVlanCount = this.MaxCompressedPortVlanCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaxUncompressedPortVlanCount"))
            {
                initObject.MaxUncompressedPortVlanCount = this.MaxUncompressedPortVlanCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumActiveTrafficMonitoringSessions"))
            {
                initObject.MaximumActiveTrafficMonitoringSessions = this.MaximumActiveTrafficMonitoringSessions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumEthernetPortChannels"))
            {
                initObject.MaximumEthernetPortChannels = this.MaximumEthernetPortChannels;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumEthernetUplinkPorts"))
            {
                initObject.MaximumEthernetUplinkPorts = this.MaximumEthernetUplinkPorts;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumFcPortChannelMembers"))
            {
                initObject.MaximumFcPortChannelMembers = this.MaximumFcPortChannelMembers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumFcPortChannels"))
            {
                initObject.MaximumFcPortChannels = this.MaximumFcPortChannels;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumIgmpGroups"))
            {
                initObject.MaximumIgmpGroups = this.MaximumIgmpGroups;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumPortChannelMembers"))
            {
                initObject.MaximumPortChannelMembers = this.MaximumPortChannelMembers;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumPrimaryVlan"))
            {
                initObject.MaximumPrimaryVlan = this.MaximumPrimaryVlan;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumSecondaryVlan"))
            {
                initObject.MaximumSecondaryVlan = this.MaximumSecondaryVlan;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumSecondaryVlanPerPrimary"))
            {
                initObject.MaximumSecondaryVlanPerPrimary = this.MaximumSecondaryVlanPerPrimary;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumVifs"))
            {
                initObject.MaximumVifs = this.MaximumVifs;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumVlans"))
            {
                initObject.MaximumVlans = this.MaximumVlans;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MinimumActiveFans"))
            {
                initObject.MinimumActiveFans = this.MinimumActiveFans;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilitySwitchStorageLimits.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilitySwitchStorageLimits")]
    public class InitializeIntersightCapabilitySwitchStorageLimits : PSCmdlet
    {
        public InitializeIntersightCapabilitySwitchStorageLimits()
        {
            ClassId = CapabilitySwitchStorageLimits.ClassIdEnum.CapabilitySwitchStorageLimits;
            ObjectType = CapabilitySwitchStorageLimits.ObjectTypeEnum.CapabilitySwitchStorageLimits;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchStorageLimits.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum user zones per Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumUserZoneCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Virtual Fibre Channel interfaces on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumVirtualFcInterfaces
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable Virtual Fibre Channel interfaces per blade."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumVirtualFcInterfacesPerBladeServer
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum configurable VSANs on Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumVsans
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Zone limit per Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumZoneCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchStorageLimits.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilitySwitchStorageLimits initObject = new Intersight.Model.CapabilitySwitchStorageLimits();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumUserZoneCount"))
            {
                initObject.MaximumUserZoneCount = this.MaximumUserZoneCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumVirtualFcInterfaces"))
            {
                initObject.MaximumVirtualFcInterfaces = this.MaximumVirtualFcInterfaces;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumVirtualFcInterfacesPerBladeServer"))
            {
                initObject.MaximumVirtualFcInterfacesPerBladeServer = this.MaximumVirtualFcInterfacesPerBladeServer;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumVsans"))
            {
                initObject.MaximumVsans = this.MaximumVsans;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumZoneCount"))
            {
                initObject.MaximumZoneCount = this.MaximumZoneCount;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilitySwitchSystemLimits.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilitySwitchSystemLimits")]
    public class InitializeIntersightCapabilitySwitchSystemLimits : PSCmdlet
    {
        public InitializeIntersightCapabilitySwitchSystemLimits()
        {
            ClassId = CapabilitySwitchSystemLimits.ClassIdEnum.CapabilitySwitchSystemLimits;
            ObjectType = CapabilitySwitchSystemLimits.ObjectTypeEnum.CapabilitySwitchSystemLimits;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchSystemLimits.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum UCS chassis that can be connected to this Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumChassisCount
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum UCS Fabric-extenders (FEX) per Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumFexPerDomain
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Maximum UCS servers per Switch/Fabric-Interconnect."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long MaximumServersPerDomain
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchSystemLimits.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilitySwitchSystemLimits initObject = new Intersight.Model.CapabilitySwitchSystemLimits();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumChassisCount"))
            {
                initObject.MaximumChassisCount = this.MaximumChassisCount;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumFexPerDomain"))
            {
                initObject.MaximumFexPerDomain = this.MaximumFexPerDomain;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MaximumServersPerDomain"))
            {
                initObject.MaximumServersPerDomain = this.MaximumServersPerDomain;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize CapabilitySwitchingModeCapability.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightCapabilitySwitchingModeCapability")]
    public class InitializeIntersightCapabilitySwitchingModeCapability : PSCmdlet
    {
        public InitializeIntersightCapabilitySwitchingModeCapability()
        {
            ClassId = CapabilitySwitchingModeCapability.ClassIdEnum.CapabilitySwitchingModeCapability;
            ObjectType = CapabilitySwitchingModeCapability.ObjectTypeEnum.CapabilitySwitchingModeCapability;
            SwitchingMode = CapabilitySwitchingModeCapability.SwitchingModeEnum.EndHost;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public Dictionary<string, object> AdditionalProperties
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchingModeCapability.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchingModeCapability.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Switching mode type (endhost, switch) of the switch.\n* `end-host` - In end-host mode, the fabric interconnects appear to the upstream devices as end hosts with multiple links.In this mode, the switch does not run Spanning Tree Protocol and avoids loops by following a set of rules for traffic forwarding.In case of ethernet switching mode - Ethernet end-host mode is also known as Ethernet host virtualizer.\n* `switch` - In switch mode, the switch runs Spanning Tree Protocol to avoid loops, and broadcast and multicast packets are handled in the traditional way.This is the traditional switch mode."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public CapabilitySwitchingModeCapability.SwitchingModeEnum SwitchingMode
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"VP Compression support on this switch."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool VpCompressionSupported
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.CapabilitySwitchingModeCapability initObject = new Intersight.Model.CapabilitySwitchingModeCapability();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("SwitchingMode"))
            {
                initObject.SwitchingMode = this.SwitchingMode;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("VpCompressionSupported"))
            {
                initObject.VpCompressionSupported = this.VpCompressionSupported;
            }
            WriteObject(initObject);
        }

    }
}