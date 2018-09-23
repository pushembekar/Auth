using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth.Service.Models
{
    public partial class Users
    {
        public Users()
        {
            UserClaims = new HashSet<UserClaims>();
            UserLogins = new HashSet<UserLogins>();
            UserRoles = new HashSet<UserRoles>();
            UserTokens = new HashSet<UserTokens>();
        }

        [Required]
        public string Id { get; set; }
        [StringLength(256)]
        public string UserName { get; set; }
        [StringLength(256)]
        public string NormalizedUserName { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        [StringLength(256)]
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed => true;
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed => true;
        public bool TwoFactorEnabled => false;
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled => false;
        public int AccessFailedCount { get; set; }

        [InverseProperty("User")]
        public ICollection<UserClaims> UserClaims { get; set; }
        [InverseProperty("User")]
        public ICollection<UserLogins> UserLogins { get; set; }
        [InverseProperty("User")]
        public ICollection<UserRoles> UserRoles { get; set; }
        [InverseProperty("User")]
        public ICollection<UserTokens> UserTokens { get; set; }
    }
}
