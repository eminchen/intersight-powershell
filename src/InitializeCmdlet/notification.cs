using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Intersight.Api;
using Intersight.Model;

namespace Intersight.PowerShell
{
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NotificationAbstractCondition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNotificationAbstractCondition")]
    public class InitializeIntersightNotificationAbstractCondition : PSCmdlet
    {
        public InitializeIntersightNotificationAbstractCondition()
        {

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationAbstractCondition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationAbstractCondition.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.NotificationAbstractCondition initObject = new Intersight.Model.NotificationAbstractCondition();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NotificationAccountSubscription.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNotificationAccountSubscription")]
    public class InitializeIntersightNotificationAccountSubscription : PSCmdlet
    {
        public InitializeIntersightNotificationAccountSubscription()
        {
            ClassId = NotificationAccountSubscription.ClassIdEnum.NotificationAccountSubscription;
            ObjectType = NotificationAccountSubscription.ObjectTypeEnum.NotificationAccountSubscription;
            Type = NotificationAccountSubscription.TypeEnum.Email;
            Verify = NotificationAccountSubscription.VerifyEnum.None;

        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.NotificationAction> Actions
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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationAccountSubscription.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<Model.NotificationAbstractCondition> Conditions
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Subscription can be switched on/off without necessity to change the subscription\nsettings: notification methods, conditions, etc.\nEx.: Subscription MO can be configured, but switched off."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
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
        /// <para type="description">"The name of the subscription."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^[a-zA-Z0-9_.-]{1,64}$")]
        public string Name
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationAccountSubscription.ObjectTypeEnum ObjectType
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
        /// <para type="description">"The chosen subscription type imposes it is own validation rules.\nWhen 'email' type is chosen, actions array can contain only one entry and it is entry should be of can\nbe only notification.SendEmail; conditions can contain only notification.AlarmMoCondition and condition\ntypes should be unique.\nWhen the 'webhook' type is chosen, the actions array can contain only one entry and it is entry should be of can\nbe only notification.TriggerWebhook; conditions can contain up to a limited amount of entries and all of them\nshould be of type notification.MoCondition.\n* `email` - Email type requires usage of notification.SendEmail complex types for actionsand notification.AlarmMoCondition complex types for conditions.\n* `webhook` - Webhook type requires usage of notification.TriggerWebhook complex types for actionsand notification.MoCondition complex types for conditions."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationAccountSubscription.TypeEnum Type
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Used to verify the actions of the Subscription MO. For a 'webhook' type Ping event is sent to verify\nthat the webhook server is accessible. For an 'email' type there will be a verification email sent.\n* `none` - No actions will be verified. Default value.\n* `all` - All actions will be re-verified. The previous state of the verification will be preserved."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationAccountSubscription.VerifyEnum Verify
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.NotificationAccountSubscription initObject = new Intersight.Model.NotificationAccountSubscription();
            if (this.MyInvocation.BoundParameters.ContainsKey("Actions"))
            {
                initObject.Actions = this.Actions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Conditions"))
            {
                initObject.Conditions = this.Conditions;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
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
            if (this.MyInvocation.BoundParameters.ContainsKey("Type"))
            {
                initObject.Type = this.Type;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Verify"))
            {
                initObject.Verify = this.Verify;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NotificationAction.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNotificationAction")]
    public class InitializeIntersightNotificationAction : PSCmdlet
    {
        public InitializeIntersightNotificationAction()
        {

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
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationAction.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property.\nThe enum values provides the list of concrete types that can be instantiated from this abstract type."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationAction.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.NotificationAction initObject = new Intersight.Model.NotificationAction();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NotificationAggregationSettings.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNotificationAggregationSettings")]
    public class InitializeIntersightNotificationAggregationSettings : PSCmdlet
    {
        public InitializeIntersightNotificationAggregationSettings()
        {
            ClassId = NotificationAggregationSettings.ClassIdEnum.NotificationAggregationSettings;
            ObjectType = NotificationAggregationSettings.ObjectTypeEnum.NotificationAggregationSettings;

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

        public NotificationAggregationSettings.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Show if aggregation is enabled or not. If aggregation is enabled, events will be grouped and delivered\nas one notification, if it is disabled - each event will be delivered as independent notification."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Limit of events in one group. If this limit is reached, a window will be closed regardless of the time limit."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public long EventsLimit
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationAggregationSettings.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Time in seconds which means the max time after which the window will be closed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Size
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Time in seconds which means how long after the last event Intersight should wait for the next event to come.\nIf there's no new event that matches with the same Subscription within this time, then the window will be closed."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Step
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.NotificationAggregationSettings initObject = new Intersight.Model.NotificationAggregationSettings();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("EventsLimit"))
            {
                initObject.EventsLimit = this.EventsLimit;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Size"))
            {
                initObject.Size = this.Size;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Step"))
            {
                initObject.Step = this.Step;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NotificationAlarmMoCondition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNotificationAlarmMoCondition")]
    public class InitializeIntersightNotificationAlarmMoCondition : PSCmdlet
    {
        public InitializeIntersightNotificationAlarmMoCondition()
        {
            ClassId = NotificationAlarmMoCondition.ClassIdEnum.NotificationAlarmMoCondition;
            ObjectType = NotificationAlarmMoCondition.ObjectTypeEnum.NotificationAlarmMoCondition;

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

        public NotificationAlarmMoCondition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The condition can be switched on/off with out necessity to change the subscription\nsettings: actions, conditions, etc.\nEx.: Subscription MO can be configured, but switched off."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"MoType for which the condition is created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MoType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationAlarmMoCondition.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<NotificationAlarmMoCondition.OperationsEnum> Operations
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<NotificationAlarmMoCondition.SeverityEnum> Severity
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.NotificationAlarmMoCondition initObject = new Intersight.Model.NotificationAlarmMoCondition();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MoType"))
            {
                initObject.MoType = this.MoType;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Operations"))
            {
                initObject.Operations = this.Operations;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Severity"))
            {
                initObject.Severity = this.Severity;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NotificationMoCondition.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNotificationMoCondition")]
    public class InitializeIntersightNotificationMoCondition : PSCmdlet
    {
        public InitializeIntersightNotificationMoCondition()
        {
            ClassId = NotificationMoCondition.ClassIdEnum.NotificationMoCondition;
            ObjectType = NotificationMoCondition.ObjectTypeEnum.NotificationMoCondition;

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

        public NotificationMoCondition.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The condition can be switched on/off with out necessity to change the subscription\nsettings: actions, conditions, etc.\nEx.: Subscription MO can be configured, but switched off."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public bool Enabled
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"MoType for which the condition is created."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string MoType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationMoCondition.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Odata filter string managed internally. It is built with specific ObjectType properties."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string OdataFilter
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description"></para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public List<NotificationMoCondition.OperationsEnum> Operations
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.NotificationMoCondition initObject = new Intersight.Model.NotificationMoCondition();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Enabled"))
            {
                initObject.Enabled = this.Enabled;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("MoType"))
            {
                initObject.MoType = this.MoType;
            }
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("OdataFilter"))
            {
                initObject.OdataFilter = this.OdataFilter;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Operations"))
            {
                initObject.Operations = this.Operations;
            }
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NotificationSendEmail.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNotificationSendEmail")]
    public class InitializeIntersightNotificationSendEmail : PSCmdlet
    {
        public InitializeIntersightNotificationSendEmail()
        {
            ClassId = NotificationSendEmail.ClassIdEnum.NotificationSendEmail;
            ObjectType = NotificationSendEmail.ObjectTypeEnum.NotificationSendEmail;

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

        public NotificationSendEmail.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Email of the recipient, who expects to be notified about the event that happens in Intersight."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Email
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationSendEmail.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.NotificationSendEmail initObject = new Intersight.Model.NotificationSendEmail();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            if (this.MyInvocation.BoundParameters.ContainsKey("Email"))
            {
                initObject.Email = this.Email;
            }
            initObject.ObjectType = this.ObjectType;
            WriteObject(initObject);
        }

    }
    /// <summary>
    /// <para type="synopsis">This is the cmdlet to Initialize NotificationTriggerWebhook.</para>
    /// </summary>
    [Cmdlet(VerbsData.Initialize, "IntersightNotificationTriggerWebhook")]
    public class InitializeIntersightNotificationTriggerWebhook : PSCmdlet
    {
        public InitializeIntersightNotificationTriggerWebhook()
        {
            ClassId = NotificationTriggerWebhook.ClassIdEnum.NotificationTriggerWebhook;
            ObjectType = NotificationTriggerWebhook.ObjectTypeEnum.NotificationTriggerWebhook;

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

        public NotificationTriggerWebhook.ClassIdEnum ClassId
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the 'ClassId' property."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public NotificationTriggerWebhook.ObjectTypeEnum ObjectType
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"The secret is used to build the Authorization header, which will be attached to each webhook notification.\nBy this header developers of the webhooks servers can make sure that events are received from the trusted source - Intersight."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]

        public string Secret
        {
            get;
            set;
        }
        // <summary>
        /// <para type="description">"Payload URL of the recipient app, which is intended to serve the events that happens in Intersight."</para>
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, ValueFromPipeline = false)]
        [ValidatePattern("^https:\\/\\/[\\w.-]+(?:\\.[\\w\\.-]+)+[\\w\\-\\._~:/?#[\\]@!\\$&'\\(\\)\\*\\+,;=.]+$")]
        public string Url
        {
            get;
            set;
        }

        protected override void ProcessRecord()
        {
            Intersight.Model.NotificationTriggerWebhook initObject = new Intersight.Model.NotificationTriggerWebhook();
            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalProperties"))
            {
                initObject.AdditionalProperties = this.AdditionalProperties;
            }
            initObject.ClassId = this.ClassId;
            initObject.ObjectType = this.ObjectType;
            if (this.MyInvocation.BoundParameters.ContainsKey("Secret"))
            {
                initObject.Secret = this.Secret;
            }
            if (this.MyInvocation.BoundParameters.ContainsKey("Url"))
            {
                initObject.Url = this.Url;
            }
            WriteObject(initObject);
        }

    }
}