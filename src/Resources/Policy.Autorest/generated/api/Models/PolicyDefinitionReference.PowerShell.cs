// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Policy.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.PowerShell;

    /// <summary>The policy definition reference.</summary>
    [System.ComponentModel.TypeConverter(typeof(PolicyDefinitionReferenceTypeConverter))]
    public partial class PolicyDefinitionReference
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.PolicyDefinitionReference"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReference" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReference DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PolicyDefinitionReference(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.PolicyDefinitionReference"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReference" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReference DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PolicyDefinitionReference(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PolicyDefinitionReference" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PolicyDefinitionReference" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReference FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.PolicyDefinitionReference"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PolicyDefinitionReference(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PolicyDefinitionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).PolicyDefinitionId = (string) content.GetValueForProperty("PolicyDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).PolicyDefinitionId, global::System.Convert.ToString);
            }
            if (content.Contains("DefinitionVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).DefinitionVersion = (string) content.GetValueForProperty("DefinitionVersion",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).DefinitionVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IParameterValues) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ParameterValuesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("GroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).GroupName = (System.Collections.Generic.List<string>) content.GetValueForProperty("GroupName",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).GroupName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.PolicyDefinitionReference"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PolicyDefinitionReference(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PolicyDefinitionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).PolicyDefinitionId = (string) content.GetValueForProperty("PolicyDefinitionId",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).PolicyDefinitionId, global::System.Convert.ToString);
            }
            if (content.Contains("DefinitionVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).DefinitionVersion = (string) content.GetValueForProperty("DefinitionVersion",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).DefinitionVersion, global::System.Convert.ToString);
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IParameterValues) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ParameterValuesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("GroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).GroupName = (System.Collections.Generic.List<string>) content.GetValueForProperty("GroupName",((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionReferenceInternal)this).GroupName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The policy definition reference.
    [System.ComponentModel.TypeConverter(typeof(PolicyDefinitionReferenceTypeConverter))]
    public partial interface IPolicyDefinitionReference

    {

    }
}