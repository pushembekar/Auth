using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth.Service.Models
{
    public partial class UserClaims
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("UserClaims")]
        public Users User { get; set; }
    }
}
