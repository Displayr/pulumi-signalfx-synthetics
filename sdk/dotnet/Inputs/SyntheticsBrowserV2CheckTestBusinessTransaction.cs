// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsBrowserV2CheckTestBusinessTransactionArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public string? Name { get; set; }

        [Input("steps", required: true)]
        private List<Inputs.SyntheticsBrowserV2CheckTestBusinessTransactionStepArgs>? _steps;
        public List<Inputs.SyntheticsBrowserV2CheckTestBusinessTransactionStepArgs> Steps
        {
            get => _steps ?? (_steps = new List<Inputs.SyntheticsBrowserV2CheckTestBusinessTransactionStepArgs>());
            set => _steps = value;
        }

        public SyntheticsBrowserV2CheckTestBusinessTransactionArgs()
        {
        }
        public static new SyntheticsBrowserV2CheckTestBusinessTransactionArgs Empty => new SyntheticsBrowserV2CheckTestBusinessTransactionArgs();
    }
}
