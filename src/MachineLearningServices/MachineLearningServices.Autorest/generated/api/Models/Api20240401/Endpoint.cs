// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Describes the endpoint configuration for the container</summary>
    public partial class Endpoint :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IEndpoint,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IEndpointInternal
    {

        /// <summary>Backing field for <see cref="HostIP" /> property.</summary>
        private string _hostIP;

        /// <summary>Host IP over which the application is exposed from the container</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string HostIP { get => this._hostIP; set => this._hostIP = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the Endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Protocol" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.Protocol? _protocol;

        /// <summary>Protocol over which communication will happen over this endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.Protocol? Protocol { get => this._protocol; set => this._protocol = value; }

        /// <summary>Backing field for <see cref="Published" /> property.</summary>
        private int? _published;

        /// <summary>Port over which the application is exposed from container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? Published { get => this._published; set => this._published = value; }

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private int? _target;

        /// <summary>Application port inside the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? Target { get => this._target; set => this._target = value; }

        /// <summary>Creates an new <see cref="Endpoint" /> instance.</summary>
        public Endpoint()
        {

        }
    }
    /// Describes the endpoint configuration for the container
    public partial interface IEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>Host IP over which the application is exposed from the container</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Host IP over which the application is exposed from the container",
        SerializedName = @"hostIp",
        PossibleTypes = new [] { typeof(string) })]
        string HostIP { get; set; }
        /// <summary>Name of the Endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the Endpoint",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Protocol over which communication will happen over this endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Protocol over which communication will happen over this endpoint",
        SerializedName = @"protocol",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.Protocol) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.Protocol? Protocol { get; set; }
        /// <summary>Port over which the application is exposed from container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Port over which the application is exposed from container.",
        SerializedName = @"published",
        PossibleTypes = new [] { typeof(int) })]
        int? Published { get; set; }
        /// <summary>Application port inside the container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Application port inside the container.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(int) })]
        int? Target { get; set; }

    }
    /// Describes the endpoint configuration for the container
    internal partial interface IEndpointInternal

    {
        /// <summary>Host IP over which the application is exposed from the container</summary>
        string HostIP { get; set; }
        /// <summary>Name of the Endpoint</summary>
        string Name { get; set; }
        /// <summary>Protocol over which communication will happen over this endpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.Protocol? Protocol { get; set; }
        /// <summary>Port over which the application is exposed from container.</summary>
        int? Published { get; set; }
        /// <summary>Application port inside the container.</summary>
        int? Target { get; set; }

    }
}