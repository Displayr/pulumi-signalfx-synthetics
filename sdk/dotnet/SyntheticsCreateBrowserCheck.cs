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
    [SyntheticsResourceType("synthetics:index/syntheticsCreateBrowserCheck:SyntheticsCreateBrowserCheck")]
    public partial class SyntheticsCreateBrowserCheck : global::Pulumi.CustomResource
    {
        [Output("autoRetry")]
        public Output<bool?> AutoRetry { get; private set; } = null!;

        [Output("autoUpdateUserAgent")]
        public Output<bool?> AutoUpdateUserAgent { get; private set; } = null!;

        [Output("blackoutPeriods")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateBrowserCheckBlackoutPeriod>> BlackoutPeriods { get; private set; } = null!;

        [Output("browsers")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateBrowserCheckBrowser>> Browsers { get; private set; } = null!;

        [Output("checkConnections")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateBrowserCheckCheckConnection>> CheckConnections { get; private set; } = null!;

        [Output("cookies")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateBrowserCheckCookie>> Cookies { get; private set; } = null!;

        [Output("dnsOverrides")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateBrowserCheckDnsOverride>> DnsOverrides { get; private set; } = null!;

        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        [Output("enforceSslValidation")]
        public Output<bool?> EnforceSslValidation { get; private set; } = null!;

        [Output("excludedFiles")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateBrowserCheckExcludedFile>> ExcludedFiles { get; private set; } = null!;

        [Output("frequency")]
        public Output<int> Frequency { get; private set; } = null!;

        [Output("httpMethod")]
        public Output<string?> HttpMethod { get; private set; } = null!;

        [Output("httpRequestBody")]
        public Output<string?> HttpRequestBody { get; private set; } = null!;

        [Output("httpRequestHeaders")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateBrowserCheckHttpRequestHeader>> HttpRequestHeaders { get; private set; } = null!;

        [Output("integrations")]
        public Output<ImmutableArray<int>> Integrations { get; private set; } = null!;

        [Output("javascriptFiles")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateBrowserCheckJavascriptFile>> JavascriptFiles { get; private set; } = null!;

        [Output("lastUpdated")]
        public Output<string> LastUpdated { get; private set; } = null!;

        [Output("locations")]
        public Output<ImmutableArray<int>> Locations { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("notifications")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateBrowserCheckNotification>> Notifications { get; private set; } = null!;

        [Output("roundRobin")]
        public Output<bool?> RoundRobin { get; private set; } = null!;

        [Output("steps")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateBrowserCheckStep>> Steps { get; private set; } = null!;

        [Output("successCriterias")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateBrowserCheckSuccessCriteria>> SuccessCriterias { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        [Output("thresholdMonitors")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateBrowserCheckThresholdMonitor>> ThresholdMonitors { get; private set; } = null!;

        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;

        [Output("url")]
        public Output<string> Url { get; private set; } = null!;

        [Output("userAgent")]
        public Output<string?> UserAgent { get; private set; } = null!;

        [Output("viewports")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateBrowserCheckViewport>> Viewports { get; private set; } = null!;

        [Output("waitForFullMetrics")]
        public Output<bool?> WaitForFullMetrics { get; private set; } = null!;


        /// <summary>
        /// Create a SyntheticsCreateBrowserCheck resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SyntheticsCreateBrowserCheck(string name, SyntheticsCreateBrowserCheckArgs args, CustomResourceOptions? options = null)
            : base("synthetics:index/syntheticsCreateBrowserCheck:SyntheticsCreateBrowserCheck", name, args ?? new SyntheticsCreateBrowserCheckArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SyntheticsCreateBrowserCheck(string name, Input<string> id, SyntheticsCreateBrowserCheckState? state = null, CustomResourceOptions? options = null)
            : base("synthetics:index/syntheticsCreateBrowserCheck:SyntheticsCreateBrowserCheck", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SyntheticsCreateBrowserCheck resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SyntheticsCreateBrowserCheck Get(string name, Input<string> id, SyntheticsCreateBrowserCheckState? state = null, CustomResourceOptions? options = null)
        {
            return new SyntheticsCreateBrowserCheck(name, id, state, options);
        }
    }

    public sealed class SyntheticsCreateBrowserCheckArgs : global::Pulumi.ResourceArgs
    {
        [Input("autoRetry")]
        public Input<bool>? AutoRetry { get; set; }

        [Input("autoUpdateUserAgent")]
        public Input<bool>? AutoUpdateUserAgent { get; set; }

        [Input("blackoutPeriods")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckBlackoutPeriodArgs>? _blackoutPeriods;
        public InputList<Inputs.SyntheticsCreateBrowserCheckBlackoutPeriodArgs> BlackoutPeriods
        {
            get => _blackoutPeriods ?? (_blackoutPeriods = new InputList<Inputs.SyntheticsCreateBrowserCheckBlackoutPeriodArgs>());
            set => _blackoutPeriods = value;
        }

        [Input("browsers")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckBrowserArgs>? _browsers;
        public InputList<Inputs.SyntheticsCreateBrowserCheckBrowserArgs> Browsers
        {
            get => _browsers ?? (_browsers = new InputList<Inputs.SyntheticsCreateBrowserCheckBrowserArgs>());
            set => _browsers = value;
        }

        [Input("checkConnections")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckCheckConnectionArgs>? _checkConnections;
        public InputList<Inputs.SyntheticsCreateBrowserCheckCheckConnectionArgs> CheckConnections
        {
            get => _checkConnections ?? (_checkConnections = new InputList<Inputs.SyntheticsCreateBrowserCheckCheckConnectionArgs>());
            set => _checkConnections = value;
        }

        [Input("cookies")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckCookieArgs>? _cookies;
        public InputList<Inputs.SyntheticsCreateBrowserCheckCookieArgs> Cookies
        {
            get => _cookies ?? (_cookies = new InputList<Inputs.SyntheticsCreateBrowserCheckCookieArgs>());
            set => _cookies = value;
        }

        [Input("dnsOverrides")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckDnsOverrideArgs>? _dnsOverrides;
        public InputList<Inputs.SyntheticsCreateBrowserCheckDnsOverrideArgs> DnsOverrides
        {
            get => _dnsOverrides ?? (_dnsOverrides = new InputList<Inputs.SyntheticsCreateBrowserCheckDnsOverrideArgs>());
            set => _dnsOverrides = value;
        }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("enforceSslValidation")]
        public Input<bool>? EnforceSslValidation { get; set; }

        [Input("excludedFiles")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckExcludedFileArgs>? _excludedFiles;
        public InputList<Inputs.SyntheticsCreateBrowserCheckExcludedFileArgs> ExcludedFiles
        {
            get => _excludedFiles ?? (_excludedFiles = new InputList<Inputs.SyntheticsCreateBrowserCheckExcludedFileArgs>());
            set => _excludedFiles = value;
        }

        [Input("frequency", required: true)]
        public Input<int> Frequency { get; set; } = null!;

        [Input("httpMethod")]
        public Input<string>? HttpMethod { get; set; }

        [Input("httpRequestBody")]
        public Input<string>? HttpRequestBody { get; set; }

        [Input("httpRequestHeaders")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckHttpRequestHeaderArgs>? _httpRequestHeaders;
        public InputList<Inputs.SyntheticsCreateBrowserCheckHttpRequestHeaderArgs> HttpRequestHeaders
        {
            get => _httpRequestHeaders ?? (_httpRequestHeaders = new InputList<Inputs.SyntheticsCreateBrowserCheckHttpRequestHeaderArgs>());
            set => _httpRequestHeaders = value;
        }

        [Input("integrations")]
        private InputList<int>? _integrations;
        public InputList<int> Integrations
        {
            get => _integrations ?? (_integrations = new InputList<int>());
            set => _integrations = value;
        }

        [Input("javascriptFiles")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckJavascriptFileArgs>? _javascriptFiles;
        public InputList<Inputs.SyntheticsCreateBrowserCheckJavascriptFileArgs> JavascriptFiles
        {
            get => _javascriptFiles ?? (_javascriptFiles = new InputList<Inputs.SyntheticsCreateBrowserCheckJavascriptFileArgs>());
            set => _javascriptFiles = value;
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
        private InputList<Inputs.SyntheticsCreateBrowserCheckNotificationArgs>? _notifications;
        public InputList<Inputs.SyntheticsCreateBrowserCheckNotificationArgs> Notifications
        {
            get => _notifications ?? (_notifications = new InputList<Inputs.SyntheticsCreateBrowserCheckNotificationArgs>());
            set => _notifications = value;
        }

        [Input("roundRobin")]
        public Input<bool>? RoundRobin { get; set; }

        [Input("steps")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckStepArgs>? _steps;
        public InputList<Inputs.SyntheticsCreateBrowserCheckStepArgs> Steps
        {
            get => _steps ?? (_steps = new InputList<Inputs.SyntheticsCreateBrowserCheckStepArgs>());
            set => _steps = value;
        }

        [Input("successCriterias")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckSuccessCriteriaArgs>? _successCriterias;
        public InputList<Inputs.SyntheticsCreateBrowserCheckSuccessCriteriaArgs> SuccessCriterias
        {
            get => _successCriterias ?? (_successCriterias = new InputList<Inputs.SyntheticsCreateBrowserCheckSuccessCriteriaArgs>());
            set => _successCriterias = value;
        }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("thresholdMonitors")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckThresholdMonitorArgs>? _thresholdMonitors;
        public InputList<Inputs.SyntheticsCreateBrowserCheckThresholdMonitorArgs> ThresholdMonitors
        {
            get => _thresholdMonitors ?? (_thresholdMonitors = new InputList<Inputs.SyntheticsCreateBrowserCheckThresholdMonitorArgs>());
            set => _thresholdMonitors = value;
        }

        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        [Input("userAgent")]
        public Input<string>? UserAgent { get; set; }

        [Input("viewports")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckViewportArgs>? _viewports;
        public InputList<Inputs.SyntheticsCreateBrowserCheckViewportArgs> Viewports
        {
            get => _viewports ?? (_viewports = new InputList<Inputs.SyntheticsCreateBrowserCheckViewportArgs>());
            set => _viewports = value;
        }

        [Input("waitForFullMetrics")]
        public Input<bool>? WaitForFullMetrics { get; set; }

        public SyntheticsCreateBrowserCheckArgs()
        {
        }
        public static new SyntheticsCreateBrowserCheckArgs Empty => new SyntheticsCreateBrowserCheckArgs();
    }

    public sealed class SyntheticsCreateBrowserCheckState : global::Pulumi.ResourceArgs
    {
        [Input("autoRetry")]
        public Input<bool>? AutoRetry { get; set; }

        [Input("autoUpdateUserAgent")]
        public Input<bool>? AutoUpdateUserAgent { get; set; }

        [Input("blackoutPeriods")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckBlackoutPeriodGetArgs>? _blackoutPeriods;
        public InputList<Inputs.SyntheticsCreateBrowserCheckBlackoutPeriodGetArgs> BlackoutPeriods
        {
            get => _blackoutPeriods ?? (_blackoutPeriods = new InputList<Inputs.SyntheticsCreateBrowserCheckBlackoutPeriodGetArgs>());
            set => _blackoutPeriods = value;
        }

        [Input("browsers")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckBrowserGetArgs>? _browsers;
        public InputList<Inputs.SyntheticsCreateBrowserCheckBrowserGetArgs> Browsers
        {
            get => _browsers ?? (_browsers = new InputList<Inputs.SyntheticsCreateBrowserCheckBrowserGetArgs>());
            set => _browsers = value;
        }

        [Input("checkConnections")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckCheckConnectionGetArgs>? _checkConnections;
        public InputList<Inputs.SyntheticsCreateBrowserCheckCheckConnectionGetArgs> CheckConnections
        {
            get => _checkConnections ?? (_checkConnections = new InputList<Inputs.SyntheticsCreateBrowserCheckCheckConnectionGetArgs>());
            set => _checkConnections = value;
        }

        [Input("cookies")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckCookieGetArgs>? _cookies;
        public InputList<Inputs.SyntheticsCreateBrowserCheckCookieGetArgs> Cookies
        {
            get => _cookies ?? (_cookies = new InputList<Inputs.SyntheticsCreateBrowserCheckCookieGetArgs>());
            set => _cookies = value;
        }

        [Input("dnsOverrides")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckDnsOverrideGetArgs>? _dnsOverrides;
        public InputList<Inputs.SyntheticsCreateBrowserCheckDnsOverrideGetArgs> DnsOverrides
        {
            get => _dnsOverrides ?? (_dnsOverrides = new InputList<Inputs.SyntheticsCreateBrowserCheckDnsOverrideGetArgs>());
            set => _dnsOverrides = value;
        }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("enforceSslValidation")]
        public Input<bool>? EnforceSslValidation { get; set; }

        [Input("excludedFiles")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckExcludedFileGetArgs>? _excludedFiles;
        public InputList<Inputs.SyntheticsCreateBrowserCheckExcludedFileGetArgs> ExcludedFiles
        {
            get => _excludedFiles ?? (_excludedFiles = new InputList<Inputs.SyntheticsCreateBrowserCheckExcludedFileGetArgs>());
            set => _excludedFiles = value;
        }

        [Input("frequency")]
        public Input<int>? Frequency { get; set; }

        [Input("httpMethod")]
        public Input<string>? HttpMethod { get; set; }

        [Input("httpRequestBody")]
        public Input<string>? HttpRequestBody { get; set; }

        [Input("httpRequestHeaders")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckHttpRequestHeaderGetArgs>? _httpRequestHeaders;
        public InputList<Inputs.SyntheticsCreateBrowserCheckHttpRequestHeaderGetArgs> HttpRequestHeaders
        {
            get => _httpRequestHeaders ?? (_httpRequestHeaders = new InputList<Inputs.SyntheticsCreateBrowserCheckHttpRequestHeaderGetArgs>());
            set => _httpRequestHeaders = value;
        }

        [Input("integrations")]
        private InputList<int>? _integrations;
        public InputList<int> Integrations
        {
            get => _integrations ?? (_integrations = new InputList<int>());
            set => _integrations = value;
        }

        [Input("javascriptFiles")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckJavascriptFileGetArgs>? _javascriptFiles;
        public InputList<Inputs.SyntheticsCreateBrowserCheckJavascriptFileGetArgs> JavascriptFiles
        {
            get => _javascriptFiles ?? (_javascriptFiles = new InputList<Inputs.SyntheticsCreateBrowserCheckJavascriptFileGetArgs>());
            set => _javascriptFiles = value;
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
        private InputList<Inputs.SyntheticsCreateBrowserCheckNotificationGetArgs>? _notifications;
        public InputList<Inputs.SyntheticsCreateBrowserCheckNotificationGetArgs> Notifications
        {
            get => _notifications ?? (_notifications = new InputList<Inputs.SyntheticsCreateBrowserCheckNotificationGetArgs>());
            set => _notifications = value;
        }

        [Input("roundRobin")]
        public Input<bool>? RoundRobin { get; set; }

        [Input("steps")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckStepGetArgs>? _steps;
        public InputList<Inputs.SyntheticsCreateBrowserCheckStepGetArgs> Steps
        {
            get => _steps ?? (_steps = new InputList<Inputs.SyntheticsCreateBrowserCheckStepGetArgs>());
            set => _steps = value;
        }

        [Input("successCriterias")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckSuccessCriteriaGetArgs>? _successCriterias;
        public InputList<Inputs.SyntheticsCreateBrowserCheckSuccessCriteriaGetArgs> SuccessCriterias
        {
            get => _successCriterias ?? (_successCriterias = new InputList<Inputs.SyntheticsCreateBrowserCheckSuccessCriteriaGetArgs>());
            set => _successCriterias = value;
        }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        [Input("thresholdMonitors")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckThresholdMonitorGetArgs>? _thresholdMonitors;
        public InputList<Inputs.SyntheticsCreateBrowserCheckThresholdMonitorGetArgs> ThresholdMonitors
        {
            get => _thresholdMonitors ?? (_thresholdMonitors = new InputList<Inputs.SyntheticsCreateBrowserCheckThresholdMonitorGetArgs>());
            set => _thresholdMonitors = value;
        }

        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("url")]
        public Input<string>? Url { get; set; }

        [Input("userAgent")]
        public Input<string>? UserAgent { get; set; }

        [Input("viewports")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckViewportGetArgs>? _viewports;
        public InputList<Inputs.SyntheticsCreateBrowserCheckViewportGetArgs> Viewports
        {
            get => _viewports ?? (_viewports = new InputList<Inputs.SyntheticsCreateBrowserCheckViewportGetArgs>());
            set => _viewports = value;
        }

        [Input("waitForFullMetrics")]
        public Input<bool>? WaitForFullMetrics { get; set; }

        public SyntheticsCreateBrowserCheckState()
        {
        }
        public static new SyntheticsCreateBrowserCheckState Empty => new SyntheticsCreateBrowserCheckState();
    }
}
