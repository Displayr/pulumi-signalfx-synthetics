// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsHttpV2CheckTestInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("active", required: true)]
        public Input<bool> Active { get; set; } = null!;

        [Input("body", required: true)]
        public Input<string> Body { get; set; } = null!;

        [Input("createdAt", required: true)]
        public Input<string> CreatedAt { get; set; } = null!;

        [Input("frequency", required: true)]
        public Input<int> Frequency { get; set; } = null!;

        [Input("headers", required: true)]
        private InputList<Inputs.SyntheticsHttpV2CheckTestHeaderInputArgs>? _headers;
        public InputList<Inputs.SyntheticsHttpV2CheckTestHeaderInputArgs> Headers
        {
            get => _headers ?? (_headers = new InputList<Inputs.SyntheticsHttpV2CheckTestHeaderInputArgs>());
            set => _headers = value;
        }

        /// <summary>
        /// The ID of this resource.
        /// </summary>
        [Input("id", required: true)]
        public Input<int> Id { get; set; } = null!;

        [Input("locationIds")]
        private InputList<string>? _locationIds;
        public InputList<string> LocationIds
        {
            get => _locationIds ?? (_locationIds = new InputList<string>());
            set => _locationIds = value;
        }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("requestMethod", required: true)]
        public Input<string> RequestMethod { get; set; } = null!;

        [Input("schedulingStrategy", required: true)]
        public Input<string> SchedulingStrategy { get; set; } = null!;

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        [Input("updatedAt", required: true)]
        public Input<string> UpdatedAt { get; set; } = null!;

        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public SyntheticsHttpV2CheckTestInputArgs()
        {
        }
        public static new SyntheticsHttpV2CheckTestInputArgs Empty => new SyntheticsHttpV2CheckTestInputArgs();
    }
}
