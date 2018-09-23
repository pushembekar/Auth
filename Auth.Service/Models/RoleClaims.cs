using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth.Service.Models
{
    public partial class RoleClaims
    {
        public int Id { get; set; }
        [Required]
        public string RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("RoleClaims")]
        public Roles Role { get; set; }
    }
}
