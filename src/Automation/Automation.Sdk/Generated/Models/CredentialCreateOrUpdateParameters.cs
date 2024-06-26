// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create or update credential operation.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class CredentialCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the CredentialCreateOrUpdateParameters class.
        /// </summary>
        public CredentialCreateOrUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CredentialCreateOrUpdateParameters class.
        /// </summary>

        /// <param name="name">Gets or sets the name of the credential.
        /// </param>

        /// <param name="userName">Gets or sets the user name of the credential.
        /// </param>

        /// <param name="password">Gets or sets the password of the credential.
        /// </param>

        /// <param name="description">Gets or sets the description of the credential.
        /// </param>
        public CredentialCreateOrUpdateParameters(string name, string userName, string password, string description = default(string))

        {
            this.Name = name;
            this.UserName = userName;
            this.Password = password;
            this.Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets gets or sets the name of the credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the user name of the credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.userName")]
        public string UserName {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the password of the credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.password")]
        public string Password {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the description of the credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.description")]
        public string Description {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (this.UserName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "UserName");
            }
            if (this.Password == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Password");
            }




        }
    }
}