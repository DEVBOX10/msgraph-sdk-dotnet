// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    
    using Microsoft.Graph.Core;

    /// <summary>
    /// The type UserChangePasswordRequestBody.
    /// </summary>
    [DataContract]
    public partial class UserChangePasswordRequestBody
    {
    
        /// <summary>
        /// Gets or sets CurrentPassword.
        /// </summary>
        [DataMember(Name = "currentPassword", EmitDefaultValue = false, IsRequired = false)]
        public string CurrentPassword { get; set; }
    
        /// <summary>
        /// Gets or sets NewPassword.
        /// </summary>
        [DataMember(Name = "newPassword", EmitDefaultValue = false, IsRequired = false)]
        public string NewPassword { get; set; }
    
    }
}
