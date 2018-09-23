using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth.Service.Models
{
    public partial class Roles
    {
        public Roles()
        {
            RoleClaims = new HashSet<RoleClaims>();
            UserRoles = new HashSet<UserRoles>();
        }

        public string Id { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(256)]
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }

        [InverseProperty("Role")]
        public ICollection<RoleClaims> RoleClaims { get; set; }
        [InverseProperty("Role")]
        public ICollection<UserRoles> UserRoles { get; set; }
    }
}
