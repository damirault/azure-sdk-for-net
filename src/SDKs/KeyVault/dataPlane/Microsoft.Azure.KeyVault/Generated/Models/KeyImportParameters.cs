// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.KeyVault.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The key import parameters.
    /// </summary>
    public partial class KeyImportParameters
    {
        /// <summary>
        /// Initializes a new instance of the KeyImportParameters class.
        /// </summary>
        public KeyImportParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyImportParameters class.
        /// </summary>
        /// <param name="key">The Json web key</param>
        /// <param name="hsm">Whether to import as a hardware key (HSM) or
        /// software key.</param>
        /// <param name="keyAttributes">The key management attributes.</param>
        /// <param name="tags">Application specific metadata in the form of
        /// key-value pairs.</param>
        public KeyImportParameters(Microsoft.Azure.KeyVault.WebKey.JsonWebKey key, bool? hsm = default(bool?), KeyAttributes keyAttributes = default(KeyAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Hsm = hsm;
            Key = key;
            KeyAttributes = keyAttributes;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether to import as a hardware key (HSM) or software
        /// key.
        /// </summary>
        [JsonProperty(PropertyName = "Hsm")]
        public bool? Hsm { get; set; }

        /// <summary>
        /// Gets or sets the Json web key
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public Microsoft.Azure.KeyVault.WebKey.JsonWebKey Key { get; set; }

        /// <summary>
        /// Gets or sets the key management attributes.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public KeyAttributes KeyAttributes { get; set; }

        /// <summary>
        /// Gets or sets application specific metadata in the form of key-value
        /// pairs.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Key == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Key");
            }
        }
    }
}
