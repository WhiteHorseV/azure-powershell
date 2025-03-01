// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>Result of the List Domain Topics operation.</summary>
    public partial class DomainTopicsListResult :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDomainTopicsListResult,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDomainTopicsListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>A link for the next page of domain topics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDomainTopic> _value;

        /// <summary>A collection of Domain Topics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDomainTopic> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="DomainTopicsListResult" /> instance.</summary>
        public DomainTopicsListResult()
        {

        }
    }
    /// Result of the List Domain Topics operation.
    public partial interface IDomainTopicsListResult :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable
    {
        /// <summary>A link for the next page of domain topics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A link for the next page of domain topics.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>A collection of Domain Topics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A collection of Domain Topics.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDomainTopic) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDomainTopic> Value { get; set; }

    }
    /// Result of the List Domain Topics operation.
    internal partial interface IDomainTopicsListResultInternal

    {
        /// <summary>A link for the next page of domain topics.</summary>
        string NextLink { get; set; }
        /// <summary>A collection of Domain Topics.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDomainTopic> Value { get; set; }

    }
}