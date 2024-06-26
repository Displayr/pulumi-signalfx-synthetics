// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as synthetics from "@pulumi/synthetics";
 *
 * const datasourceCheckApi = synthetics.syntheticsApiV2Check({
 *     tests: [{
 *         id: 489,
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function syntheticsApiV2Check(args: SyntheticsApiV2CheckArgs, opts?: pulumi.InvokeOptions): Promise<SyntheticsApiV2CheckResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("synthetics:index/syntheticsApiV2Check:syntheticsApiV2Check", {
        "tests": args.tests,
    }, opts);
}

/**
 * A collection of arguments for invoking syntheticsApiV2Check.
 */
export interface SyntheticsApiV2CheckArgs {
    tests: inputs.SyntheticsApiV2CheckTest[];
}

/**
 * A collection of values returned by syntheticsApiV2Check.
 */
export interface SyntheticsApiV2CheckResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly tests: outputs.SyntheticsApiV2CheckTest[];
}
/**
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as synthetics from "@pulumi/synthetics";
 *
 * const datasourceCheckApi = synthetics.syntheticsApiV2Check({
 *     tests: [{
 *         id: 489,
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function syntheticsApiV2CheckOutput(args: SyntheticsApiV2CheckOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<SyntheticsApiV2CheckResult> {
    return pulumi.output(args).apply((a: any) => syntheticsApiV2Check(a, opts))
}

/**
 * A collection of arguments for invoking syntheticsApiV2Check.
 */
export interface SyntheticsApiV2CheckOutputArgs {
    tests: pulumi.Input<pulumi.Input<inputs.SyntheticsApiV2CheckTestArgs>[]>;
}
