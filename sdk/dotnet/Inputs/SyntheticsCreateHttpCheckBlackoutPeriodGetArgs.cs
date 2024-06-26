// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateHttpCheckBlackoutPeriodGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        [Input("durationInMinutes")]
        public Input<int>? DurationInMinutes { get; set; }

        [Input("endDate")]
        public Input<string>? EndDate { get; set; }

        [Input("endTime")]
        public Input<string>? EndTime { get; set; }

        [Input("isRepeat")]
        public Input<bool>? IsRepeat { get; set; }

        [Input("monthlyRepeatType")]
        public Input<string>? MonthlyRepeatType { get; set; }

        [Input("repeatType")]
        public Input<string>? RepeatType { get; set; }

        [Input("startDate")]
        public Input<string>? StartDate { get; set; }

        [Input("startTime")]
        public Input<string>? StartTime { get; set; }

        [Input("timezone")]
        public Input<string>? Timezone { get; set; }

        [Input("updatedAt")]
        public Input<string>? UpdatedAt { get; set; }

        public SyntheticsCreateHttpCheckBlackoutPeriodGetArgs()
        {
        }
        public static new SyntheticsCreateHttpCheckBlackoutPeriodGetArgs Empty => new SyntheticsCreateHttpCheckBlackoutPeriodGetArgs();
    }
}
