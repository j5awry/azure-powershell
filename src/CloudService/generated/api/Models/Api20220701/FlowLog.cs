// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>A flow log resource.</summary>
    public partial class FlowLog :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLog,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogInternal,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.Resource();

        /// <summary>Flag to enable/disable flow logging.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public bool? Enabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).Enabled = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; }

        /// <summary>The file type of flow log.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.FlowLogFormatType? FormatType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).FormatType; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).FormatType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.FlowLogFormatType)""); }

        /// <summary>The version (revision) of the flow log.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public int? FormatVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).FormatVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).FormatVersion = value ?? default(int); }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Id = value ?? null; }

        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogInternal.Etag { get => this._etag; set { {_etag = value;} } }

        /// <summary>
        /// Internal Acessors for FlowAnalyticConfigurationNetworkWatcherFlowAnalyticsConfiguration
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ITrafficAnalyticsConfigurationProperties Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogInternal.FlowAnalyticConfigurationNetworkWatcherFlowAnalyticsConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).FlowAnalyticConfigurationNetworkWatcherFlowAnalyticsConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).FlowAnalyticConfigurationNetworkWatcherFlowAnalyticsConfiguration = value; }

        /// <summary>Internal Acessors for FlowAnalyticsConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ITrafficAnalyticsProperties Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogInternal.FlowAnalyticsConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).FlowAnalyticsConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).FlowAnalyticsConfiguration = value; }

        /// <summary>Internal Acessors for Format</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogFormatParameters Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogInternal.Format { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).Format; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).Format = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormat Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.FlowLogPropertiesFormat()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for RetentionPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IRetentionPolicyParameters Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogInternal.RetentionPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).RetentionPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).RetentionPolicy = value; }

        /// <summary>Internal Acessors for TargetResourceGuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogInternal.TargetResourceGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).TargetResourceGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).TargetResourceGuid = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Type = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Name; }

        /// <summary>Flag to enable/disable traffic analytics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public bool? NetworkWatcherFlowAnalyticConfigurationEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).NetworkWatcherFlowAnalyticConfigurationEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).NetworkWatcherFlowAnalyticConfigurationEnabled = value ?? default(bool); }

        /// <summary>
        /// The interval in minutes which would decide how frequently TA service should do flow analytics.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public int? NetworkWatcherFlowAnalyticConfigurationTrafficAnalyticsInterval { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).NetworkWatcherFlowAnalyticConfigurationTrafficAnalyticsInterval; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).NetworkWatcherFlowAnalyticConfigurationTrafficAnalyticsInterval = value ?? default(int); }

        /// <summary>The resource guid of the attached workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string NetworkWatcherFlowAnalyticConfigurationWorkspaceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).NetworkWatcherFlowAnalyticConfigurationWorkspaceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).NetworkWatcherFlowAnalyticConfigurationWorkspaceId = value ?? null; }

        /// <summary>The location of the attached workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string NetworkWatcherFlowAnalyticConfigurationWorkspaceRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).NetworkWatcherFlowAnalyticConfigurationWorkspaceRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).NetworkWatcherFlowAnalyticConfigurationWorkspaceRegion = value ?? null; }

        /// <summary>Resource Id of the attached workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string NetworkWatcherFlowAnalyticConfigurationWorkspaceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).NetworkWatcherFlowAnalyticConfigurationWorkspaceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).NetworkWatcherFlowAnalyticConfigurationWorkspaceResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormat _property;

        /// <summary>Properties of the flow log.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormat Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.FlowLogPropertiesFormat()); set => this._property = value; }

        /// <summary>The provisioning state of the flow log.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).ProvisioningState; }

        /// <summary>Number of days to retain flow log records.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public int? RetentionPolicyDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).RetentionPolicyDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).RetentionPolicyDay = value ?? default(int); }

        /// <summary>Flag to enable/disable retention.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public bool? RetentionPolicyEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).RetentionPolicyEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).RetentionPolicyEnabled = value ?? default(bool); }

        /// <summary>ID of the storage account which is used to store the flow log.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string StorageId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).StorageId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).StorageId = value ?? null; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Guid of network security group to which flow log will be applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string TargetResourceGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).TargetResourceGuid; }

        /// <summary>ID of network security group to which flow log will be applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string TargetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).TargetResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormatInternal)Property).TargetResourceId = value ?? null; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="FlowLog" /> instance.</summary>
        public FlowLog()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// A flow log resource.
    public partial interface IFlowLog :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResource
    {
        /// <summary>Flag to enable/disable flow logging.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to enable/disable flow logging.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A unique read-only string that changes whenever the resource is updated.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get;  }
        /// <summary>The file type of flow log.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The file type of flow log.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.FlowLogFormatType) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.FlowLogFormatType? FormatType { get; set; }
        /// <summary>The version (revision) of the flow log.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version (revision) of the flow log.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(int) })]
        int? FormatVersion { get; set; }
        /// <summary>Flag to enable/disable traffic analytics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to enable/disable traffic analytics.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NetworkWatcherFlowAnalyticConfigurationEnabled { get; set; }
        /// <summary>
        /// The interval in minutes which would decide how frequently TA service should do flow analytics.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The interval in minutes which would decide how frequently TA service should do flow analytics.",
        SerializedName = @"trafficAnalyticsInterval",
        PossibleTypes = new [] { typeof(int) })]
        int? NetworkWatcherFlowAnalyticConfigurationTrafficAnalyticsInterval { get; set; }
        /// <summary>The resource guid of the attached workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource guid of the attached workspace.",
        SerializedName = @"workspaceId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkWatcherFlowAnalyticConfigurationWorkspaceId { get; set; }
        /// <summary>The location of the attached workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the attached workspace.",
        SerializedName = @"workspaceRegion",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkWatcherFlowAnalyticConfigurationWorkspaceRegion { get; set; }
        /// <summary>Resource Id of the attached workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource Id of the attached workspace.",
        SerializedName = @"workspaceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkWatcherFlowAnalyticConfigurationWorkspaceResourceId { get; set; }
        /// <summary>The provisioning state of the flow log.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the flow log.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Number of days to retain flow log records.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of days to retain flow log records.",
        SerializedName = @"days",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionPolicyDay { get; set; }
        /// <summary>Flag to enable/disable retention.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to enable/disable retention.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RetentionPolicyEnabled { get; set; }
        /// <summary>ID of the storage account which is used to store the flow log.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ID of the storage account which is used to store the flow log.",
        SerializedName = @"storageId",
        PossibleTypes = new [] { typeof(string) })]
        string StorageId { get; set; }
        /// <summary>Guid of network security group to which flow log will be applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Guid of network security group to which flow log will be applied.",
        SerializedName = @"targetResourceGuid",
        PossibleTypes = new [] { typeof(string) })]
        string TargetResourceGuid { get;  }
        /// <summary>ID of network security group to which flow log will be applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ID of network security group to which flow log will be applied.",
        SerializedName = @"targetResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetResourceId { get; set; }

    }
    /// A flow log resource.
    internal partial interface IFlowLogInternal :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IResourceInternal
    {
        /// <summary>Flag to enable/disable flow logging.</summary>
        bool? Enabled { get; set; }
        /// <summary>A unique read-only string that changes whenever the resource is updated.</summary>
        string Etag { get; set; }
        /// <summary>Parameters that define the configuration of traffic analytics.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ITrafficAnalyticsConfigurationProperties FlowAnalyticConfigurationNetworkWatcherFlowAnalyticsConfiguration { get; set; }
        /// <summary>Parameters that define the configuration of traffic analytics.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ITrafficAnalyticsProperties FlowAnalyticsConfiguration { get; set; }
        /// <summary>Parameters that define the flow log format.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogFormatParameters Format { get; set; }
        /// <summary>The file type of flow log.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.FlowLogFormatType? FormatType { get; set; }
        /// <summary>The version (revision) of the flow log.</summary>
        int? FormatVersion { get; set; }
        /// <summary>Flag to enable/disable traffic analytics.</summary>
        bool? NetworkWatcherFlowAnalyticConfigurationEnabled { get; set; }
        /// <summary>
        /// The interval in minutes which would decide how frequently TA service should do flow analytics.
        /// </summary>
        int? NetworkWatcherFlowAnalyticConfigurationTrafficAnalyticsInterval { get; set; }
        /// <summary>The resource guid of the attached workspace.</summary>
        string NetworkWatcherFlowAnalyticConfigurationWorkspaceId { get; set; }
        /// <summary>The location of the attached workspace.</summary>
        string NetworkWatcherFlowAnalyticConfigurationWorkspaceRegion { get; set; }
        /// <summary>Resource Id of the attached workspace.</summary>
        string NetworkWatcherFlowAnalyticConfigurationWorkspaceResourceId { get; set; }
        /// <summary>Properties of the flow log.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IFlowLogPropertiesFormat Property { get; set; }
        /// <summary>The provisioning state of the flow log.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Parameters that define the retention policy for flow log.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.IRetentionPolicyParameters RetentionPolicy { get; set; }
        /// <summary>Number of days to retain flow log records.</summary>
        int? RetentionPolicyDay { get; set; }
        /// <summary>Flag to enable/disable retention.</summary>
        bool? RetentionPolicyEnabled { get; set; }
        /// <summary>ID of the storage account which is used to store the flow log.</summary>
        string StorageId { get; set; }
        /// <summary>Guid of network security group to which flow log will be applied.</summary>
        string TargetResourceGuid { get; set; }
        /// <summary>ID of network security group to which flow log will be applied.</summary>
        string TargetResourceId { get; set; }

    }
}