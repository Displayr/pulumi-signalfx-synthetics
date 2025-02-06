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
    /// ## Example Usage
    /// </summary>
    [SyntheticsResourceType("synthetics:index/syntheticsCreateBrowserCheckV2:SyntheticsCreateBrowserCheckV2")]
    public partial class SyntheticsCreateBrowserCheckV2 : global::Pulumi.CustomResource
    {
        [Output("tests")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateBrowserCheckV2Test>> Tests { get; private set; } = null!;


        /// <summary>
        /// Create a SyntheticsCreateBrowserCheckV2 resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SyntheticsCreateBrowserCheckV2(string name, SyntheticsCreateBrowserCheckV2Args args, CustomResourceOptions? options = null)
            : base("synthetics:index/syntheticsCreateBrowserCheckV2:SyntheticsCreateBrowserCheckV2", name, args ?? new SyntheticsCreateBrowserCheckV2Args(), MakeResourceOptions(options, ""))
        {
        }

        private SyntheticsCreateBrowserCheckV2(string name, Input<string> id, SyntheticsCreateBrowserCheckV2State? state = null, CustomResourceOptions? options = null)
            : base("synthetics:index/syntheticsCreateBrowserCheckV2:SyntheticsCreateBrowserCheckV2", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SyntheticsCreateBrowserCheckV2 resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SyntheticsCreateBrowserCheckV2 Get(string name, Input<string> id, SyntheticsCreateBrowserCheckV2State? state = null, CustomResourceOptions? options = null)
        {
            return new SyntheticsCreateBrowserCheckV2(name, id, state, options);
        }
    }

    public sealed class SyntheticsCreateBrowserCheckV2Args : global::Pulumi.ResourceArgs
    {
        [Input("tests", required: true)]
        private InputList<Inputs.SyntheticsCreateBrowserCheckV2TestArgs>? _tests;
        public InputList<Inputs.SyntheticsCreateBrowserCheckV2TestArgs> Tests
        {
            get => _tests ?? (_tests = new InputList<Inputs.SyntheticsCreateBrowserCheckV2TestArgs>());
            set => _tests = value;
        }

        public SyntheticsCreateBrowserCheckV2Args()
        {
        }
        public static new SyntheticsCreateBrowserCheckV2Args Empty => new SyntheticsCreateBrowserCheckV2Args();
    }

    public sealed class SyntheticsCreateBrowserCheckV2State : global::Pulumi.ResourceArgs
    {
        [Input("tests")]
        private InputList<Inputs.SyntheticsCreateBrowserCheckV2TestGetArgs>? _tests;
        public InputList<Inputs.SyntheticsCreateBrowserCheckV2TestGetArgs> Tests
        {
            get => _tests ?? (_tests = new InputList<Inputs.SyntheticsCreateBrowserCheckV2TestGetArgs>());
            set => _tests = value;
        }

        public SyntheticsCreateBrowserCheckV2State()
        {
        }
        public static new SyntheticsCreateBrowserCheckV2State Empty => new SyntheticsCreateBrowserCheckV2State();
    }
}
