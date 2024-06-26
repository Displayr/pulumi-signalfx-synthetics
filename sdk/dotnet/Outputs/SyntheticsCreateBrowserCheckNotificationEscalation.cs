// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Synthetics.Outputs
{

    [OutputType]
    public sealed class SyntheticsCreateBrowserCheckNotificationEscalation
    {
        public readonly int? AfterMinutes;
        public readonly bool? Call;
        public readonly bool? Email;
        public readonly bool? IsRepeat;
        public readonly ImmutableArray<Outputs.SyntheticsCreateBrowserCheckNotificationEscalationNotificationWindow> NotificationWindows;
        public readonly ImmutableArray<Outputs.SyntheticsCreateBrowserCheckNotificationEscalationNotifyWho> NotifyWhos;
        public readonly bool? Sms;

        [OutputConstructor]
        private SyntheticsCreateBrowserCheckNotificationEscalation(
            int? afterMinutes,

            bool? call,

            bool? email,

            bool? isRepeat,

            ImmutableArray<Outputs.SyntheticsCreateBrowserCheckNotificationEscalationNotificationWindow> notificationWindows,

            ImmutableArray<Outputs.SyntheticsCreateBrowserCheckNotificationEscalationNotifyWho> notifyWhos,

            bool? sms)
        {
            AfterMinutes = afterMinutes;
            Call = call;
            Email = email;
            IsRepeat = isRepeat;
            NotificationWindows = notificationWindows;
            NotifyWhos = notifyWhos;
            Sms = sms;
        }
    }
}
