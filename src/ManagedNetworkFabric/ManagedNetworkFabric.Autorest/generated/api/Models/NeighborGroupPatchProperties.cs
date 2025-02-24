// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Extensions;

    /// <summary>Neighbor Group Patch properties.</summary>
    public partial class NeighborGroupPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPatchPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResource __annotationResource = new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.AnnotationResource();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPatchableProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPatchableProperties __neighborGroupPatchableProperties = new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.NeighborGroupPatchableProperties();

        /// <summary>Switch configuration description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public string Annotation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)__annotationResource).Annotation; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)__annotationResource).Annotation = value ?? null; }

        /// <summary>An array of destination IPv4 Addresses or IPv6 Addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupDestination Destination { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPatchablePropertiesInternal)__neighborGroupPatchableProperties).Destination; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPatchablePropertiesInternal)__neighborGroupPatchableProperties).Destination = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="NeighborGroupPatchProperties" /> instance.</summary>
        public NeighborGroupPatchProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__annotationResource), __annotationResource);
            await eventListener.AssertObjectIsValid(nameof(__annotationResource), __annotationResource);
            await eventListener.AssertNotNull(nameof(__neighborGroupPatchableProperties), __neighborGroupPatchableProperties);
            await eventListener.AssertObjectIsValid(nameof(__neighborGroupPatchableProperties), __neighborGroupPatchableProperties);
        }
    }
    /// Neighbor Group Patch properties.
    public partial interface INeighborGroupPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResource,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPatchableProperties
    {

    }
    /// Neighbor Group Patch properties.
    internal partial interface INeighborGroupPatchPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPatchablePropertiesInternal
    {

    }
}