// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// NatRulesOperations operations.
    /// </summary>
    public partial interface INatRulesOperations
    {
        /// <summary>
        /// Retrieves the details of a nat ruleGet.
        /// </summary>
        /// <remarks>
        /// Retrieves the details of a nat ruleGet.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnGateway.
        /// </param>
        /// <param name='gatewayName'>
        /// The name of the gateway.
        /// </param>
        /// <param name='natRuleName'>
        /// The name of the nat rule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<VpnGatewayNatRule>> GetWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string natRuleName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates a nat rule to a scalable vpn gateway if it doesn&#39;t exist else
        /// updates the existing nat rules.
        /// </summary>
        /// <remarks>
        /// Creates a nat rule to a scalable vpn gateway if it doesn&#39;t exist else
        /// updates the existing nat rules.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnGateway.
        /// </param>
        /// <param name='gatewayName'>
        /// The name of the gateway.
        /// </param>
        /// <param name='natRuleName'>
        /// The name of the nat rule.
        /// </param>
        /// <param name='natRuleParameters'>
        /// Parameters supplied to create or Update a Nat Rule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<VpnGatewayNatRule>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string natRuleName, VpnGatewayNatRule natRuleParameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes a nat rule.
        /// </summary>
        /// <remarks>
        /// Deletes a nat rule.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnGateway.
        /// </param>
        /// <param name='gatewayName'>
        /// The name of the gateway.
        /// </param>
        /// <param name='natRuleName'>
        /// The name of the nat rule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string natRuleName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves all nat rules for a particular virtual wan vpn gateway.
        /// </summary>
        /// <remarks>
        /// Retrieves all nat rules for a particular virtual wan vpn gateway.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnGateway.
        /// </param>
        /// <param name='gatewayName'>
        /// The name of the gateway.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<VpnGatewayNatRule>>> ListByVpnGatewayWithHttpMessagesAsync(string resourceGroupName, string gatewayName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates a nat rule to a scalable vpn gateway if it doesn&#39;t exist else
        /// updates the existing nat rules.
        /// </summary>
        /// <remarks>
        /// Creates a nat rule to a scalable vpn gateway if it doesn&#39;t exist else
        /// updates the existing nat rules.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnGateway.
        /// </param>
        /// <param name='gatewayName'>
        /// The name of the gateway.
        /// </param>
        /// <param name='natRuleName'>
        /// The name of the nat rule.
        /// </param>
        /// <param name='natRuleParameters'>
        /// Parameters supplied to create or Update a Nat Rule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<VpnGatewayNatRule>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string natRuleName, VpnGatewayNatRule natRuleParameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes a nat rule.
        /// </summary>
        /// <remarks>
        /// Deletes a nat rule.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnGateway.
        /// </param>
        /// <param name='gatewayName'>
        /// The name of the gateway.
        /// </param>
        /// <param name='natRuleName'>
        /// The name of the nat rule.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string natRuleName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves all nat rules for a particular virtual wan vpn gateway.
        /// </summary>
        /// <remarks>
        /// Retrieves all nat rules for a particular virtual wan vpn gateway.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<VpnGatewayNatRule>>> ListByVpnGatewayNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}