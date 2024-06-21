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
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Synthetics = Pulumi.Synthetics;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var variableV2Foo = new Synthetics.SyntheticsCreateVariableV2("variableV2Foo", new()
    ///     {
    ///         Variables = new[]
    ///         {
    ///             new Synthetics.Inputs.SyntheticsCreateVariableV2VariableArgs
    ///             {
    ///                 Description = "The most awesome variable. Full of snakes.",
    ///                 Name = "terraform-test121",
    ///                 Secret = false,
    ///                 Value = "barv3--oopsasdasd",
    ///             },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [SyntheticsResourceType("synthetics:index/syntheticsCreateVariableV2:SyntheticsCreateVariableV2")]
    public partial class SyntheticsCreateVariableV2 : global::Pulumi.CustomResource
    {
        [Output("variables")]
        public Output<ImmutableArray<Outputs.SyntheticsCreateVariableV2Variable>> Variables { get; private set; } = null!;


        /// <summary>
        /// Create a SyntheticsCreateVariableV2 resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SyntheticsCreateVariableV2(string name, SyntheticsCreateVariableV2Args args, CustomResourceOptions? options = null)
            : base("synthetics:index/syntheticsCreateVariableV2:SyntheticsCreateVariableV2", name, args ?? new SyntheticsCreateVariableV2Args(), MakeResourceOptions(options, ""))
        {
        }

        private SyntheticsCreateVariableV2(string name, Input<string> id, SyntheticsCreateVariableV2State? state = null, CustomResourceOptions? options = null)
            : base("synthetics:index/syntheticsCreateVariableV2:SyntheticsCreateVariableV2", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/Displayr/pulumi-signalfx-synthetics/releases/download/v0.0.11/",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SyntheticsCreateVariableV2 resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SyntheticsCreateVariableV2 Get(string name, Input<string> id, SyntheticsCreateVariableV2State? state = null, CustomResourceOptions? options = null)
        {
            return new SyntheticsCreateVariableV2(name, id, state, options);
        }
    }

    public sealed class SyntheticsCreateVariableV2Args : global::Pulumi.ResourceArgs
    {
        [Input("variables", required: true)]
        private InputList<Inputs.SyntheticsCreateVariableV2VariableArgs>? _variables;
        public InputList<Inputs.SyntheticsCreateVariableV2VariableArgs> Variables
        {
            get => _variables ?? (_variables = new InputList<Inputs.SyntheticsCreateVariableV2VariableArgs>());
            set => _variables = value;
        }

        public SyntheticsCreateVariableV2Args()
        {
        }
        public static new SyntheticsCreateVariableV2Args Empty => new SyntheticsCreateVariableV2Args();
    }

    public sealed class SyntheticsCreateVariableV2State : global::Pulumi.ResourceArgs
    {
        [Input("variables")]
        private InputList<Inputs.SyntheticsCreateVariableV2VariableGetArgs>? _variables;
        public InputList<Inputs.SyntheticsCreateVariableV2VariableGetArgs> Variables
        {
            get => _variables ?? (_variables = new InputList<Inputs.SyntheticsCreateVariableV2VariableGetArgs>());
            set => _variables = value;
        }

        public SyntheticsCreateVariableV2State()
        {
        }
        public static new SyntheticsCreateVariableV2State Empty => new SyntheticsCreateVariableV2State();
    }
}
