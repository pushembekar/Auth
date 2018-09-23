﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth.Service.Models
{
    public partial class UserLogins
    {
        [StringLength(128)]
        public string LoginProvider { get; set; }
        [StringLength(128)]
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("UserLogins")]
        public Users User { get; set; }
    }
}
