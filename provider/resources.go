// Copyright 2016-2024, Pulumi Corporation.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

package synthetics

import (
	"path"

	// Allow embedding bridge-metadata.json in the provider.
	_ "embed"

	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge/tokens"
	shimv2 "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim/sdk-v2"

	"github.com/displayr/pulumi-signalfx-synthetics/provider/pkg/version"
	"github.com/splunk/terraform-provider-synthetics/synthetics"
)

// all of the token components used below.
const (
	// This variable controls the default name of the package in the package
	// registries for nodejs and python:
	mainPkg = "synthetics"
	// modules:
	mainMod = "index" // the pulumi-signalfx-synthetics module
)

//go:embed cmd/pulumi-resource-pulumi-signalfx-synthetics/bridge-metadata.json
var metadata []byte

// Provider returns additional overlaid schema and metadata associated with the provider.
func Provider() tfbridge.ProviderInfo {
	// Create a Pulumi provider mapping
	prov := tfbridge.ProviderInfo{
		// Instantiate the Terraform provider
		//
		// The [pulumi-terraform-bridge](https://github.com/pulumi/pulumi-terraform-bridge) supports 3
		// types of Terraform providers:
		//
		// 1. Providers written with the terraform-plugin-sdk/v1:
		//
		//    If the provider you are bridging is written with the terraform-plugin-sdk/v1, then you
		//    will need to adapt the boilerplate:
		//
		//    - Change the import "shimv2" to "shimv1" and change the associated import to
		//      "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim/sdk-v1".
		//
		//    You can then proceed as normal.
		//
		// 2. Providers written with terraform-plugin-sdk/v2:
		//
		//    This boilerplate is already geared towards providers written with the
		//    terraform-plugin-sdk/v2, since it is the most common provider framework used. No
		//    adaptions are needed.
		//
		// 3. Providers written with terraform-plugin-framework:
		//
		//    If the provider you are bridging is written with the terraform-plugin-framework, then
		//    you will need to adapt the boilerplate:
		//
		//    - Remove the `shimv2` import and add:
		//
		//      	pfbridge "github.com/pulumi/pulumi-terraform-bridge/pf/tfbridge"
		//
		//    - Replace `shimv2.NewProvider` with `pfbridge.ShimProvider`.
		//
		//    - In provider/cmd/pulumi-tfgen-pulumi-signalfx-synthetics/main.go, replace the
		//      "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfgen" import with
		//      "github.com/pulumi/pulumi-terraform-bridge/pf/tfgen". Remove the `version.Version`
		//      argument to `tfgen.Main`.
		//
		//    - In provider/cmd/pulumi-resource-pulumi-signalfx-synthetics/main.go, replace the
		//      "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge" import with
		//      "github.com/pulumi/pulumi-terraform-bridge/pf/tfbridge". Replace the arguments to the
		//      `tfbridge.Main` so it looks like this:
		//
		//      	tfbridge.Main(context.Background(), "pulumi-signalfx-synthetics", pulumi-signalfx-synthetics.Provider(),
		//			tfbridge.ProviderMetadata{PulumiSchema: pulumiSchema})
		//
		//   Detailed instructions can be found at
		//   https://github.com/pulumi/pulumi-terraform-bridge/blob/master/pf/README.md#how-to-upgrade-a-bridged-provider-to-plugin-framework.
		//   After that, you can proceed as normal.
		//
		// This is where you give the bridge a handle to the upstream terraform provider. SDKv2
		// convention is to have a function at "github.com/iwahbe/terraform-provider-pulumi-signalfx-synthetics/provider".New
		// which takes a version and produces a factory function. The provider you are bridging may
		// not do that. You will need to find the function (generally called in upstream's main.go)
		// that produces a:
		//
		// - *"github.com/hashicorp/terraform-plugin-sdk/v2/helper/schema".Provider (for SDKv2)
		// - *"github.com/hashicorp/terraform-plugin-sdk/v1/helper/schema".Provider (for SDKv1)
		// - "github.com/hashicorp/terraform-plugin-framework/provider".Provider (for plugin-framework)
		//
		//nolint:lll
		P: shimv2.NewProvider(synthetics.Provider()),

		Name:    "synthetics",
		Version: version.Version,
		// DisplayName is a way to be able to change the casing of the provider name when being
		// displayed on the Pulumi registry
		DisplayName: "pulumi-signalfx-synthetics",
		// Change this to your personal name (or a company name) that you would like to be shown in
		// the Pulumi Registry if this package is published there.
		Publisher: "displayr",
		// LogoURL is optional but useful to help identify your package in the Pulumi Registry
		// if this package is published there.
		//
		// You may host a logo on a domain you control or add an SVG logo for your package
		// in your repository and use the raw content URL for that file as your logo URL.
		LogoURL: "",
		// PluginDownloadURL is an optional URL used to download the Provider
		// for use in Pulumi programs
		// e.g https://github.com/org/pulumi-provider-name/releases/
		PluginDownloadURL: "https://github.com/Displayr/pulumi-signalfx-synthetics/releases/download/v0.0.11/",
		Description:       "A Pulumi package for creating and managing pulumi-signalfx-synthetics cloud resources.",
		// category/cloud tag helps with categorizing the package in the Pulumi Registry.
		// For all available categories, see `Keywords` in
		// https://www.pulumi.com/docs/guides/pulumi-packages/schema/#package.
		Keywords:   []string{"displayr", "pulumi-signalfx-synthetics", "category/cloud"},
		License:    "Apache-2.0",
		Homepage:   "https://www.pulumi.com",
		Repository: "https://github.com/displayr/pulumi-signalfx-synthetics",
		// The GitHub Org for the provider - defaults to `terraform-providers`. Note that this should
		// match the TF provider module's require directive, not any replace directives.
		GitHubOrg:    "splunk",
		MetadataInfo: tfbridge.NewProviderMetadata(metadata),
		Config: map[string]*tfbridge.SchemaInfo{
			"apikey": {
				Default: &tfbridge.DefaultInfo{
					EnvVars: []string{"OBSERVABILITY_API_TOKEN"},
				},
			},
		},
		Resources: map[string]*tfbridge.ResourceInfo{
			"synthetics_create_api_check_v2":  {Tok: tfbridge.MakeResource(mainPkg, mainMod, "SyntheticsCreateApiCheckV2")},
			"synthetics_create_browser_check": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "SyntheticsCreateBrowserCheck")},
			"synthetics_create_browser_check_v2": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "SyntheticsCreateBrowserCheckV2"),
			},
			"synthetics_create_http_check": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "SyntheticsCreateHttpCheck")},
			"synthetics_create_http_check_v2": {
				Tok: tfbridge.MakeResource(mainPkg, mainMod, "SyntheticsCreateHttpCheckV2"),
			},
			"synthetics_create_location_v2":   {Tok: tfbridge.MakeResource(mainPkg, mainMod, "SyntheticsCreateLocationV2")},
			"synthetics_create_port_check_v2": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "SyntheticsCreatePortCheckV2")},
			"synthetics_create_variable_v2":   {Tok: tfbridge.MakeResource(mainPkg, mainMod, "SyntheticsCreateVariableV2")},
		},
		DataSources: map[string]*tfbridge.DataSourceInfo{
			"synthetics_api_v2_check":       {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "syntheticsApiV2Check")},
			"synthetics_browser_v2_check":   {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "syntheticsBrowserV2Check")},
			"synthetics_check":              {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "syntheticsCheck")},
			"synthetics_devices_v2_check":   {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "syntheticsDevicesV2Check")},
			"synthetics_http_v2_check":      {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "syntheticsHttpV2Check")},
			"synthetics_location_v2_check":  {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "syntheticsLocationV2Check")},
			"synthetics_locations_v2_check": {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "syntheticsLocationsV2Check")},
			"synthetics_port_v2_check":      {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "syntheticsPortV2Check")},
			"synthetics_variable_v2_check":  {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "syntheticsVariableV2Check")},
			"synthetics_variables_v2_check": {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "syntheticsVariablesV2Check")},
		},
		JavaScript: &tfbridge.JavaScriptInfo{
			// List any npm dependencies and their versions
			Dependencies: map[string]string{
				"@pulumi/pulumi": "^3.0.0",
			},
			DevDependencies: map[string]string{
				"@types/node": "^10.0.0", // so we can access strongly typed node definitions.
				"@types/mime": "^2.0.0",
			},
		},
		Python: &tfbridge.PythonInfo{
			// List any Python dependencies and their version ranges
			Requires: map[string]string{
				"pulumi": ">=3.0.0,<4.0.0",
			},
		},
		Golang: &tfbridge.GolangInfo{
			ImportBasePath: path.Join(
				"github.com/displayr/pulumi-signalfx-synthetics/sdk/",
				tfbridge.GetModuleMajorVersion(version.Version),
				"go",
				mainPkg,
			),
			GenerateResourceContainerTypes: true,
		},
		CSharp: &tfbridge.CSharpInfo{
			PackageReferences: map[string]string{
				"Pulumi": "3.*",
			},
		},
	}

	// MustComputeTokens maps all resources and datasources from the upstream provider into Pulumi.
	//
	// tokens.SingleModule puts every upstream item into your provider's main module.
	//
	// You shouldn't need to override anything, but if you do, use the [tfbridge.ProviderInfo.Resources]
	// and [tfbridge.ProviderInfo.DataSources].
	prov.MustComputeTokens(tokens.SingleModule("pulumi-signalfx-synthetics_", mainMod,
		tokens.MakeStandard(mainPkg)))

	prov.MustApplyAutoAliases()
	prov.SetAutonaming(255, "-")

	return prov
}
