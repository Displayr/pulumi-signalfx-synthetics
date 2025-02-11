// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics
{
    /// <summary>
    /// **Note**: This is a Rigor (Legacy) resource
    /// </summary>
    [SyntheticsResourceType("synthetics:index/syntheticsCreateHttpCheck:SyntheticsCreateHttpCheck")]
    public partial class SyntheticsCreateHttpCheck : global::Pulumi.CustomResource
    {
        [Output("autoRetry")]
        public Output<bool?> AutoRetry { get; private set; } = null!;

        [Output("blackoutPeriods")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateHttpCheckBlackoutPeriod>> BlackoutPeriods { get; private set; } = null!;

        [Output("checkConnections")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateHttpCheckCheckConnection>> CheckConnections { get; private set; } = null!;

        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        [Output("frequency")]
        public Output<int> Frequency { get; private set; } = null!;

        [Output("httpMethod")]
        public Output<string?> HttpMethod { get; private set; } = null!;

        [Output("httpRequestBody")]
        public Output<string?> HttpRequestBody { get; private set; } = null!;

        [Output("httpRequestHeaders")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateHttpCheckHttpRequestHeader>> HttpRequestHeaders { get; private set; } = null!;

        [Output("integrations")]
        public Output<ImmutableArray<int>> Integrations { get; private set; } = null!;

        [Output("lastUpdated")]
        public Output<string> LastUpdated { get; private set; } = null!;

        [Output("locations")]
        public Output<ImmutableArray<int>> Locations { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("notifications")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateHttpCheckNotification>> Notifications { get; private set; } = null!;

        [Output("roundRobin")]
        public Output<bool?> RoundRobin { get; private set; } = null!;

        [Output("successCriterias")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateHttpCheckSuccessCriteria>> SuccessCriterias { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a SyntheticsCreateHttpCheck resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SyntheticsCreateHttpCheck(string name, SyntheticsCreateHttpCheckArgs args, CustomResourceOptions? options = null)
            : base("synthetics:index/syntheticsCreateHttpCheck:SyntheticsCreateHttpCheck", name, args ?? new SyntheticsCreateHttpCheckArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SyntheticsCreateHttpCheck(string name, Input<string> id, SyntheticsCreateHttpCheckState? state = null, CustomResourceOptions? options = null)
            : base("synthetics:index/syntheticsCreateHttpCheck:SyntheticsCreateHttpCheck", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/Displayr/pulumi-signalfx-synthetics/releases/download/v0.2.0/",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SyntheticsCreateHttpCheck resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SyntheticsCreateHttpCheck Get(string name, Input<string> id, SyntheticsCreateHttpCheckState? state = null, CustomResourceOptions? options = null)
        {
            return new SyntheticsCreateHttpCheck(name, id, state, options);
        }
    }

    public sealed class SyntheticsCreateHttpCheckArgs : global::Pulumi.ResourceArgs
    {
        [Input("autoRetry")]
        public Input<bool>? AutoRetry { get; set; }

        [Input("blackoutPeriods")]
        private InputList<Inputs.SyntheticsCreateHttpCheckBlackoutPeriodArgs>? _blackoutPeriods;
        public InputList<Inputs.SyntheticsCreateHttpCheckBlackoutPeriodArgs> BlackoutPeriods
        {
            get => _blackoutPeriods ?? (_blackoutPeriods = new InputList<Inputs.SyntheticsCreateHttpCheckBlackoutPeriodArgs>());
            set => _blackoutPeriods = value;
        }

        [Input("checkConnections")]
        private InputList<Inputs.SyntheticsCreateHttpCheckCheckConnectionArgs>? _checkConnections;
        public InputList<Inputs.SyntheticsCreateHttpCheckCheckConnectionArgs> CheckConnections
        {
            get => _checkConnections ?? (_checkConnections = new InputList<Inputs.SyntheticsCreateHttpCheckCheckConnectionArgs>());
            set => _checkConnections = value;
        }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("frequency", required: true)]
        public Input<int> Frequency { get; set; } = null!;

        [Input("httpMethod")]
        public Input<string>? HttpMethod { get; set; }

        [Input("httpRequestBody")]
        public Input<string>? HttpRequestBody { get; set; }

        [Input("httpRequestHeaders")]
        private InputList<Inputs.SyntheticsCreateHttpCheckHttpRequestHeaderArgs>? _httpRequestHeaders;
        public InputList<Inputs.SyntheticsCreateHttpCheckHttpRequestHeaderArgs> HttpRequestHeaders
        {
            get => _httpRequestHeaders ?? (_httpRequestHeaders = new InputList<Inputs.SyntheticsCreateHttpCheckHttpRequestHeaderArgs>());
            set => _httpRequestHeaders = value;
        }

        [Input("integrations")]
        private InputList<int>? _integrations;
        public InputList<int> Integrations
        {
            get => _integrations ?? (_integrations = new InputList<int>());
            set => _integrations = value;
        }

        [Input("lastUpdated")]
        public Input<string>? LastUpdated { get; set; }

        [Input("locations")]
        private InputList<int>? _locations;
        public InputList<int> Locations
        {
            get => _locations ?? (_locations = new InputList<int>());
            set => _locations = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("notifications")]
        private InputList<Inputs.SyntheticsCreateHttpCheckNotificationArgs>? _notifications;
        public InputList<Inputs.SyntheticsCreateHttpCheckNotificationArgs> Notifications
        {
            get => _notifications ?? (_notifications = new InputList<Inputs.SyntheticsCreateHttpCheckNotificationArgs>());
            set => _notifications = value;
        }

        [Input("roundRobin")]
        public Input<bool>? RoundRobin { get; set; }

        [Input("successCriterias")]
        private InputList<Inputs.SyntheticsCreateHttpCheckSuccessCriteriaArgs>? _successCriterias;
        public InputList<Inputs.SyntheticsCreateHttpCheckSuccessCriteriaArgs> SuccessCriterias
        {
            get => _successCriterias ?? (_successCriterias = new InputList<Inputs.SyntheticsCreateHttpCheckSuccessCriteriaArgs>());
            set => _successCriterias = value;
        }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public SyntheticsCreateHttpCheckArgs()
        {
        }
        public static new SyntheticsCreateHttpCheckArgs Empty => new SyntheticsCreateHttpCheckArgs();
    }

    public sealed class SyntheticsCreateHttpCheckState : global::Pulumi.ResourceArgs
    {
        [Input("autoRetry")]
        public Input<bool>? AutoRetry { get; set; }

        [Input("blackoutPeriods")]
        private InputList<Inputs.SyntheticsCreateHttpCheckBlackoutPeriodGetArgs>? _blackoutPeriods;
        public InputList<Inputs.SyntheticsCreateHttpCheckBlackoutPeriodGetArgs> BlackoutPeriods
        {
            get => _blackoutPeriods ?? (_blackoutPeriods = new InputList<Inputs.SyntheticsCreateHttpCheckBlackoutPeriodGetArgs>());
            set => _blackoutPeriods = value;
        }

        [Input("checkConnections")]
        private InputList<Inputs.SyntheticsCreateHttpCheckCheckConnectionGetArgs>? _checkConnections;
        public InputList<Inputs.SyntheticsCreateHttpCheckCheckConnectionGetArgs> CheckConnections
        {
            get => _checkConnections ?? (_checkConnections = new InputList<Inputs.SyntheticsCreateHttpCheckCheckConnectionGetArgs>());
            set => _checkConnections = value;
        }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("frequency")]
        public Input<int>? Frequency { get; set; }

        [Input("httpMethod")]
        public Input<string>? HttpMethod { get; set; }

        [Input("httpRequestBody")]
        public Input<string>? HttpRequestBody { get; set; }

        [Input("httpRequestHeaders")]
        private InputList<Inputs.SyntheticsCreateHttpCheckHttpRequestHeaderGetArgs>? _httpRequestHeaders;
        public InputList<Inputs.SyntheticsCreateHttpCheckHttpRequestHeaderGetArgs> HttpRequestHeaders
        {
            get => _httpRequestHeaders ?? (_httpRequestHeaders = new InputList<Inputs.SyntheticsCreateHttpCheckHttpRequestHeaderGetArgs>());
            set => _httpRequestHeaders = value;
        }

        [Input("integrations")]
        private InputList<int>? _integrations;
        public InputList<int> Integrations
        {
            get => _integrations ?? (_integrations = new InputList<int>());
            set => _integrations = value;
        }

        [Input("lastUpdated")]
        public Input<string>? LastUpdated { get; set; }

        [Input("locations")]
        private InputList<int>? _locations;
        public InputList<int> Locations
        {
            get => _locations ?? (_locations = new InputList<int>());
            set => _locations = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("notifications")]
        private InputList<Inputs.SyntheticsCreateHttpCheckNotificationGetArgs>? _notifications;
        public InputList<Inputs.SyntheticsCreateHttpCheckNotificationGetArgs> Notifications
        {
            get => _notifications ?? (_notifications = new InputList<Inputs.SyntheticsCreateHttpCheckNotificationGetArgs>());
            set => _notifications = value;
        }

        [Input("roundRobin")]
        public Input<bool>? RoundRobin { get; set; }

        [Input("successCriterias")]
        private InputList<Inputs.SyntheticsCreateHttpCheckSuccessCriteriaGetArgs>? _successCriterias;
        public InputList<Inputs.SyntheticsCreateHttpCheckSuccessCriteriaGetArgs> SuccessCriterias
        {
            get => _successCriterias ?? (_successCriterias = new InputList<Inputs.SyntheticsCreateHttpCheckSuccessCriteriaGetArgs>());
            set => _successCriterias = value;
        }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("url")]
        public Input<string>? Url { get; set; }

        public SyntheticsCreateHttpCheckState()
        {
        }
        public static new SyntheticsCreateHttpCheckState Empty => new SyntheticsCreateHttpCheckState();
    }
}
