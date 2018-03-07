// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel.DataAnnotations;
using Trackable.Models;

namespace Trackable.Web.Dtos
{
    public class UserDto
    {
        /// <summary>
        /// Autogenerated User Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// User Email
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// User Role
        /// </summary>
        [Required]
        public Role Role { get; set; }
    }
}
