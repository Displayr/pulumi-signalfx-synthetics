// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateBrowserCheckV2TestAdvancedSettingGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("authentications")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckV2TestAdvancedSettingAuthenticationGetArgs>? _authentications;
        public InputList<Inputs.SyntheticsCreateBrowserCheckV2TestAdvancedSettingAuthenticationGetArgs> Authentications
        {
            get => _authentications ?? (_authentications = new InputList<Inputs.SyntheticsCreateBrowserCheckV2TestAdvancedSettingAuthenticationGetArgs>());
            set => _authentications = value;
        }

        [Input("cookies")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckV2TestAdvancedSettingCookieGetArgs>? _cookies;
        public InputList<Inputs.SyntheticsCreateBrowserCheckV2TestAdvancedSettingCookieGetArgs> Cookies
        {
            get => _cookies ?? (_cookies = new InputList<Inputs.SyntheticsCreateBrowserCheckV2TestAdvancedSettingCookieGetArgs>());
            set => _cookies = value;
        }

        [Input("headers")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckV2TestAdvancedSettingHeaderGetArgs>? _headers;
        public InputList<Inputs.SyntheticsCreateBrowserCheckV2TestAdvancedSettingHeaderGetArgs> Headers
        {
            get => _headers ?? (_headers = new InputList<Inputs.SyntheticsCreateBrowserCheckV2TestAdvancedSettingHeaderGetArgs>());
            set => _headers = value;
        }

        [Input("hostOverrides")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckV2TestAdvancedSettingHostOverrideGetArgs>? _hostOverrides;
        public InputList<Inputs.SyntheticsCreateBrowserCheckV2TestAdvancedSettingHostOverrideGetArgs> HostOverrides
        {
            get => _hostOverrides ?? (_hostOverrides = new InputList<Inputs.SyntheticsCreateBrowserCheckV2TestAdvancedSettingHostOverrideGetArgs>());
            set => _hostOverrides = value;
        }

        [Input("userAgent")]
        public Input<string>? UserAgent { get; set; }

        [Input("verifyCertificates")]
        public Input<bool>? VerifyCertificates { get; set; }

        public SyntheticsCreateBrowserCheckV2TestAdvancedSettingGetArgs()
        {
        }
        public static new SyntheticsCreateBrowserCheckV2TestAdvancedSettingGetArgs Empty => new SyntheticsCreateBrowserCheckV2TestAdvancedSettingGetArgs();
    }
}
