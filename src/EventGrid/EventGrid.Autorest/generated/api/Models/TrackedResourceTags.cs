// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>Tags of the resource.</summary>
    public partial class TrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ITrackedResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ITrackedResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="TrackedResourceTags" /> instance.</summary>
        public TrackedResourceTags()
        {

        }
    }
    /// Tags of the resource.
    public partial interface ITrackedResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IAssociativeArray<string>
    {

    }
    /// Tags of the resource.
    internal partial interface ITrackedResourceTagsInternal

    {

    }
}