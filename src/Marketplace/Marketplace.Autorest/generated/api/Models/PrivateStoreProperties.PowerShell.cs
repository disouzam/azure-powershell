// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.PowerShell;

    /// <summary>
    /// Describes the json payload on whether or not the private store is enabled for a given tenant
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(PrivateStorePropertiesTypeConverter))]
    public partial class PrivateStoreProperties
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.PrivateStoreProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStoreProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStoreProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PrivateStoreProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.PrivateStoreProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStoreProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStoreProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PrivateStoreProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PrivateStoreProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PrivateStoreProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStoreProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.PrivateStoreProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PrivateStoreProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NotificationsSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).NotificationsSetting = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.INotificationsSettingsProperties) content.GetValueForProperty("NotificationsSetting",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).NotificationsSetting, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.NotificationsSettingsPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Availability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).Availability = (string) content.GetValueForProperty("Availability",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).Availability, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateStoreId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).PrivateStoreId = (string) content.GetValueForProperty("PrivateStoreId",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).PrivateStoreId, global::System.Convert.ToString);
            }
            if (content.Contains("ETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).ETag, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateStoreName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).PrivateStoreName = (string) content.GetValueForProperty("PrivateStoreName",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).PrivateStoreName, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IsGov"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).IsGov = (bool?) content.GetValueForProperty("IsGov",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).IsGov, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("CollectionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).CollectionId = (System.Collections.Generic.List<string>) content.GetValueForProperty("CollectionId",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).CollectionId, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Branding"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).Branding = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesBranding) content.GetValueForProperty("Branding",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).Branding, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.PrivateStorePropertiesBrandingTypeConverter.ConvertFrom);
            }
            if (content.Contains("NotificationSettingRecipient"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).NotificationSettingRecipient = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRecipient>) content.GetValueForProperty("NotificationSettingRecipient",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).NotificationSettingRecipient, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRecipient>(__y, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.RecipientTypeConverter.ConvertFrom));
            }
            if (content.Contains("NotificationSettingSendToAllMarketplaceAdmin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).NotificationSettingSendToAllMarketplaceAdmin = (bool?) content.GetValueForProperty("NotificationSettingSendToAllMarketplaceAdmin",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).NotificationSettingSendToAllMarketplaceAdmin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.PrivateStoreProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PrivateStoreProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NotificationsSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).NotificationsSetting = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.INotificationsSettingsProperties) content.GetValueForProperty("NotificationsSetting",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).NotificationsSetting, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.NotificationsSettingsPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Availability"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).Availability = (string) content.GetValueForProperty("Availability",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).Availability, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateStoreId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).PrivateStoreId = (string) content.GetValueForProperty("PrivateStoreId",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).PrivateStoreId, global::System.Convert.ToString);
            }
            if (content.Contains("ETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).ETag, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateStoreName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).PrivateStoreName = (string) content.GetValueForProperty("PrivateStoreName",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).PrivateStoreName, global::System.Convert.ToString);
            }
            if (content.Contains("TenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).TenantId = (string) content.GetValueForProperty("TenantId",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).TenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IsGov"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).IsGov = (bool?) content.GetValueForProperty("IsGov",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).IsGov, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("CollectionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).CollectionId = (System.Collections.Generic.List<string>) content.GetValueForProperty("CollectionId",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).CollectionId, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("Branding"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).Branding = (Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesBranding) content.GetValueForProperty("Branding",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).Branding, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.PrivateStorePropertiesBrandingTypeConverter.ConvertFrom);
            }
            if (content.Contains("NotificationSettingRecipient"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).NotificationSettingRecipient = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRecipient>) content.GetValueForProperty("NotificationSettingRecipient",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).NotificationSettingRecipient, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IRecipient>(__y, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.RecipientTypeConverter.ConvertFrom));
            }
            if (content.Contains("NotificationSettingSendToAllMarketplaceAdmin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).NotificationSettingSendToAllMarketplaceAdmin = (bool?) content.GetValueForProperty("NotificationSettingSendToAllMarketplaceAdmin",((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IPrivateStorePropertiesInternal)this).NotificationSettingSendToAllMarketplaceAdmin, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Describes the json payload on whether or not the private store is enabled for a given tenant
    [System.ComponentModel.TypeConverter(typeof(PrivateStorePropertiesTypeConverter))]
    public partial interface IPrivateStoreProperties

    {

    }
}