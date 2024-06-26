// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package synthetics

import (
	"context"
	"reflect"

	"github.com/displayr/pulumi-signalfx-synthetics/sdk/go/synthetics/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## Example Usage
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/displayr/pulumi-signalfx-synthetics/sdk/go/synthetics"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := synthetics.SyntheticsVariableV2Check(ctx, &synthetics.SyntheticsVariableV2CheckArgs{
//				Variables: []synthetics.SyntheticsVariableV2CheckVariable{
//					{
//						Id: 246,
//					},
//				},
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// <!--End PulumiCodeChooser -->
func SyntheticsVariableV2Check(ctx *pulumi.Context, args *SyntheticsVariableV2CheckArgs, opts ...pulumi.InvokeOption) (*SyntheticsVariableV2CheckResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv SyntheticsVariableV2CheckResult
	err := ctx.Invoke("synthetics:index/syntheticsVariableV2Check:syntheticsVariableV2Check", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking syntheticsVariableV2Check.
type SyntheticsVariableV2CheckArgs struct {
	Variables []SyntheticsVariableV2CheckVariable `pulumi:"variables"`
}

// A collection of values returned by syntheticsVariableV2Check.
type SyntheticsVariableV2CheckResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id        string                              `pulumi:"id"`
	Variables []SyntheticsVariableV2CheckVariable `pulumi:"variables"`
}

func SyntheticsVariableV2CheckOutput(ctx *pulumi.Context, args SyntheticsVariableV2CheckOutputArgs, opts ...pulumi.InvokeOption) SyntheticsVariableV2CheckResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (SyntheticsVariableV2CheckResult, error) {
			args := v.(SyntheticsVariableV2CheckArgs)
			r, err := SyntheticsVariableV2Check(ctx, &args, opts...)
			var s SyntheticsVariableV2CheckResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(SyntheticsVariableV2CheckResultOutput)
}

// A collection of arguments for invoking syntheticsVariableV2Check.
type SyntheticsVariableV2CheckOutputArgs struct {
	Variables SyntheticsVariableV2CheckVariableArrayInput `pulumi:"variables"`
}

func (SyntheticsVariableV2CheckOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*SyntheticsVariableV2CheckArgs)(nil)).Elem()
}

// A collection of values returned by syntheticsVariableV2Check.
type SyntheticsVariableV2CheckResultOutput struct{ *pulumi.OutputState }

func (SyntheticsVariableV2CheckResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*SyntheticsVariableV2CheckResult)(nil)).Elem()
}

func (o SyntheticsVariableV2CheckResultOutput) ToSyntheticsVariableV2CheckResultOutput() SyntheticsVariableV2CheckResultOutput {
	return o
}

func (o SyntheticsVariableV2CheckResultOutput) ToSyntheticsVariableV2CheckResultOutputWithContext(ctx context.Context) SyntheticsVariableV2CheckResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o SyntheticsVariableV2CheckResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v SyntheticsVariableV2CheckResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o SyntheticsVariableV2CheckResultOutput) Variables() SyntheticsVariableV2CheckVariableArrayOutput {
	return o.ApplyT(func(v SyntheticsVariableV2CheckResult) []SyntheticsVariableV2CheckVariable { return v.Variables }).(SyntheticsVariableV2CheckVariableArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(SyntheticsVariableV2CheckResultOutput{})
}
