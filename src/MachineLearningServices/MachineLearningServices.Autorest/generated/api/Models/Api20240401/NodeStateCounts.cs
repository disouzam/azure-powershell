// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Counts of various compute node states on the amlCompute.</summary>
    public partial class NodeStateCounts :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INodeStateCounts,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INodeStateCountsInternal
    {

        /// <summary>Backing field for <see cref="IdleNodeCount" /> property.</summary>
        private int? _idleNodeCount;

        /// <summary>Number of compute nodes in idle state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? IdleNodeCount { get => this._idleNodeCount; }

        /// <summary>Backing field for <see cref="LeavingNodeCount" /> property.</summary>
        private int? _leavingNodeCount;

        /// <summary>Number of compute nodes which are leaving the amlCompute.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? LeavingNodeCount { get => this._leavingNodeCount; }

        /// <summary>Internal Acessors for IdleNodeCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INodeStateCountsInternal.IdleNodeCount { get => this._idleNodeCount; set { {_idleNodeCount = value;} } }

        /// <summary>Internal Acessors for LeavingNodeCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INodeStateCountsInternal.LeavingNodeCount { get => this._leavingNodeCount; set { {_leavingNodeCount = value;} } }

        /// <summary>Internal Acessors for PreemptedNodeCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INodeStateCountsInternal.PreemptedNodeCount { get => this._preemptedNodeCount; set { {_preemptedNodeCount = value;} } }

        /// <summary>Internal Acessors for PreparingNodeCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INodeStateCountsInternal.PreparingNodeCount { get => this._preparingNodeCount; set { {_preparingNodeCount = value;} } }

        /// <summary>Internal Acessors for RunningNodeCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INodeStateCountsInternal.RunningNodeCount { get => this._runningNodeCount; set { {_runningNodeCount = value;} } }

        /// <summary>Internal Acessors for UnusableNodeCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INodeStateCountsInternal.UnusableNodeCount { get => this._unusableNodeCount; set { {_unusableNodeCount = value;} } }

        /// <summary>Backing field for <see cref="PreemptedNodeCount" /> property.</summary>
        private int? _preemptedNodeCount;

        /// <summary>Number of compute nodes which are in preempted state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? PreemptedNodeCount { get => this._preemptedNodeCount; }

        /// <summary>Backing field for <see cref="PreparingNodeCount" /> property.</summary>
        private int? _preparingNodeCount;

        /// <summary>Number of compute nodes which are being prepared.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? PreparingNodeCount { get => this._preparingNodeCount; }

        /// <summary>Backing field for <see cref="RunningNodeCount" /> property.</summary>
        private int? _runningNodeCount;

        /// <summary>Number of compute nodes which are running jobs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? RunningNodeCount { get => this._runningNodeCount; }

        /// <summary>Backing field for <see cref="UnusableNodeCount" /> property.</summary>
        private int? _unusableNodeCount;

        /// <summary>Number of compute nodes which are in unusable state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? UnusableNodeCount { get => this._unusableNodeCount; }

        /// <summary>Creates an new <see cref="NodeStateCounts" /> instance.</summary>
        public NodeStateCounts()
        {

        }
    }
    /// Counts of various compute node states on the amlCompute.
    public partial interface INodeStateCounts :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>Number of compute nodes in idle state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of compute nodes in idle state.",
        SerializedName = @"idleNodeCount",
        PossibleTypes = new [] { typeof(int) })]
        int? IdleNodeCount { get;  }
        /// <summary>Number of compute nodes which are leaving the amlCompute.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of compute nodes which are leaving the amlCompute.",
        SerializedName = @"leavingNodeCount",
        PossibleTypes = new [] { typeof(int) })]
        int? LeavingNodeCount { get;  }
        /// <summary>Number of compute nodes which are in preempted state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of compute nodes which are in preempted state.",
        SerializedName = @"preemptedNodeCount",
        PossibleTypes = new [] { typeof(int) })]
        int? PreemptedNodeCount { get;  }
        /// <summary>Number of compute nodes which are being prepared.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of compute nodes which are being prepared.",
        SerializedName = @"preparingNodeCount",
        PossibleTypes = new [] { typeof(int) })]
        int? PreparingNodeCount { get;  }
        /// <summary>Number of compute nodes which are running jobs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of compute nodes which are running jobs.",
        SerializedName = @"runningNodeCount",
        PossibleTypes = new [] { typeof(int) })]
        int? RunningNodeCount { get;  }
        /// <summary>Number of compute nodes which are in unusable state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of compute nodes which are in unusable state.",
        SerializedName = @"unusableNodeCount",
        PossibleTypes = new [] { typeof(int) })]
        int? UnusableNodeCount { get;  }

    }
    /// Counts of various compute node states on the amlCompute.
    internal partial interface INodeStateCountsInternal

    {
        /// <summary>Number of compute nodes in idle state.</summary>
        int? IdleNodeCount { get; set; }
        /// <summary>Number of compute nodes which are leaving the amlCompute.</summary>
        int? LeavingNodeCount { get; set; }
        /// <summary>Number of compute nodes which are in preempted state.</summary>
        int? PreemptedNodeCount { get; set; }
        /// <summary>Number of compute nodes which are being prepared.</summary>
        int? PreparingNodeCount { get; set; }
        /// <summary>Number of compute nodes which are running jobs.</summary>
        int? RunningNodeCount { get; set; }
        /// <summary>Number of compute nodes which are in unusable state.</summary>
        int? UnusableNodeCount { get; set; }

    }
}