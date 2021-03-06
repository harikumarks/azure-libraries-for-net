// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Compute.Fluent
{
    using Microsoft.Azure.Management.Compute.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using System.Collections.Generic;

    internal partial class VirtualMachineImageImpl
    {
        /// <summary>
        /// Gets OS disk image in the virtual machine image.
        /// </summary>
        Models.OSDiskImage Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineImage.OSDiskImage
        {
            get
            {
                return this.OSDiskImage();
            }
        }

        /// <summary>
        /// Gets the resource ID of this image.
        /// </summary>
        string Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineImage.Id
        {
            get
            {
                return this.Id();
            }
        }

        /// <summary>
        /// Gets the version of the virtual machine image.
        /// </summary>
        string Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineImage.Version
        {
            get
            {
                return this.Version();
            }
        }

        /// <summary>
        /// Gets the publisher name of the virtual machine image.
        /// </summary>
        string Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineImage.PublisherName
        {
            get
            {
                return this.PublisherName();
            }
        }

        /// <summary>
        /// Gets the commercial name of the virtual machine image (SKU).
        /// </summary>
        string Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineImage.Sku
        {
            get
            {
                return this.Sku();
            }
        }

        /// <summary>
        /// Gets the purchase plan for the virtual machine image.
        /// </summary>
        Models.PurchasePlan Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineImage.Plan
        {
            get
            {
                return this.Plan();
            }
        }

        /// <summary>
        /// Gets the region in which virtual machine image is available.
        /// </summary>
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.Region Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineImage.Location
        {
            get
            {
                return this.Location();
            }
        }

        /// <summary>
        /// Gets the name of the virtual machine image offer this image is part of.
        /// </summary>
        string Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineImage.Offer
        {
            get
            {
                return this.Offer();
            }
        }

        /// <summary>
        /// Gets data disk images in the virtual machine image, indexed by the disk LUN.
        /// </summary>
        System.Collections.Generic.IReadOnlyDictionary<int, Models.DataDiskImage> Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineImage.DataDiskImages
        {
            get
            {
                return this.DataDiskImages();
            }
        }

        /// <summary>
        /// Gets the image reference representing the publisher, offer, SKU and version of the virtual machine image.
        /// </summary>
        Models.ImageReference Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineImage.ImageReference
        {
            get
            {
                return this.ImageReference();
            }
        }
    }
}