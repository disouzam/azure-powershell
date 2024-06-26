// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>Container App container Custom scaling rule.</summary>
    public partial class HttpScaleRule :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRule,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRuleInternal
    {

        /// <summary>Backing field for <see cref="Auth" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth[] _auth;

        /// <summary>Authentication secrets for the custom scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth[] Auth { get => this._auth; set => this._auth = value; }

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRuleMetadata _metadata;

        /// <summary>Metadata properties to describe http scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRuleMetadata Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.HttpScaleRuleMetadata()); set => this._metadata = value; }

        /// <summary>Creates an new <see cref="HttpScaleRule" /> instance.</summary>
        public HttpScaleRule()
        {

        }
    }
    /// Container App container Custom scaling rule.
    public partial interface IHttpScaleRule :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>Authentication secrets for the custom scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Authentication secrets for the custom scale rule.",
        SerializedName = @"auth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth[] Auth { get; set; }
        /// <summary>Metadata properties to describe http scale rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metadata properties to describe http scale rule.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRuleMetadata) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRuleMetadata Metadata { get; set; }

    }
    /// Container App container Custom scaling rule.
    internal partial interface IHttpScaleRuleInternal

    {
        /// <summary>Authentication secrets for the custom scale rule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IScaleRuleAuth[] Auth { get; set; }
        /// <summary>Metadata properties to describe http scale rule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IHttpScaleRuleMetadata Metadata { get; set; }

    }
}