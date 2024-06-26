// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Inputs
{

    public sealed class SyntheticsCreateHttpCheckNotificationArgs : global::Pulumi.ResourceArgs
    {
        [Input("call")]
        public Input<bool>? Call { get; set; }

        [Input("email")]
        public Input<bool>? Email { get; set; }

        [Input("escalations")]
        private InputList<Inputs.SyntheticsCreateHttpCheckNotificationEscalationArgs>? _escalations;
        public InputList<Inputs.SyntheticsCreateHttpCheckNotificationEscalationArgs> Escalations
        {
            get => _escalations ?? (_escalations = new InputList<Inputs.SyntheticsCreateHttpCheckNotificationEscalationArgs>());
            set => _escalations = value;
        }

        [Input("muted")]
        public Input<bool>? Muted { get; set; }

        [Input("notificationWindows")]
        private InputList<Inputs.SyntheticsCreateHttpCheckNotificationNotificationWindowArgs>? _notificationWindows;
        public InputList<Inputs.SyntheticsCreateHttpCheckNotificationNotificationWindowArgs> NotificationWindows
        {
            get => _notificationWindows ?? (_notificationWindows = new InputList<Inputs.SyntheticsCreateHttpCheckNotificationNotificationWindowArgs>());
            set => _notificationWindows = value;
        }

        [Input("notifyAfterFailureCount")]
        public Input<int>? NotifyAfterFailureCount { get; set; }

        [Input("notifyOnLocationFailure")]
        public Input<bool>? NotifyOnLocationFailure { get; set; }

        [Input("notifyWhos")]
        private InputList<Inputs.SyntheticsCreateHttpCheckNotificationNotifyWhoArgs>? _notifyWhos;
        public InputList<Inputs.SyntheticsCreateHttpCheckNotificationNotifyWhoArgs> NotifyWhos
        {
            get => _notifyWhos ?? (_notifyWhos = new InputList<Inputs.SyntheticsCreateHttpCheckNotificationNotifyWhoArgs>());
            set => _notifyWhos = value;
        }

        [Input("sms")]
        public Input<bool>? Sms { get; set; }

        public SyntheticsCreateHttpCheckNotificationArgs()
        {
        }
        public static new SyntheticsCreateHttpCheckNotificationArgs Empty => new SyntheticsCreateHttpCheckNotificationArgs();
    }
}
