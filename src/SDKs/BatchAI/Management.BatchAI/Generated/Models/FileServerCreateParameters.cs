// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// File Server creation parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FileServerCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the FileServerCreateParameters class.
        /// </summary>
        public FileServerCreateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileServerCreateParameters class.
        /// </summary>
        /// <param name="vmSize">VM size.</param>
        /// <param name="sshConfiguration">SSH configuration.</param>
        /// <param name="dataDisks">Data disks.</param>
        /// <param name="subnet">Subnet identifier.</param>
        public FileServerCreateParameters(string vmSize, SshConfiguration sshConfiguration, DataDisks dataDisks, ResourceId subnet = default(ResourceId))
        {
            VmSize = vmSize;
            SshConfiguration = sshConfiguration;
            DataDisks = dataDisks;
            Subnet = subnet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets VM size.
        /// </summary>
        /// <remarks>
        /// The size of the virtual machine for the File Server. For
        /// information about available VM sizes from the Virtual Machines
        /// Marketplace, see Sizes for Virtual Machines (Linux).
        /// </remarks>
        [JsonProperty(PropertyName = "properties.vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets SSH configuration.
        /// </summary>
        /// <remarks>
        /// SSH configuration for the File Server node.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.sshConfiguration")]
        public SshConfiguration SshConfiguration { get; set; }

        /// <summary>
        /// Gets or sets data disks.
        /// </summary>
        /// <remarks>
        /// Settings for the data disks which will be created for the File
        /// Server.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.dataDisks")]
        public DataDisks DataDisks { get; set; }

        /// <summary>
        /// Gets or sets subnet identifier.
        /// </summary>
        /// <remarks>
        /// Identifier of an existing virtual network subnet to put the File
        /// Server in. If not provided, a new virtual network and subnet will
        /// be created.
        /// </remarks>
        [JsonProperty(PropertyName = "properties.subnet")]
        public ResourceId Subnet { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VmSize == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VmSize");
            }
            if (SshConfiguration == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SshConfiguration");
            }
            if (DataDisks == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataDisks");
            }
            if (SshConfiguration != null)
            {
                SshConfiguration.Validate();
            }
            if (DataDisks != null)
            {
                DataDisks.Validate();
            }
            if (Subnet != null)
            {
                Subnet.Validate();
            }
        }
    }
}
