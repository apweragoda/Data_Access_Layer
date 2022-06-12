using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Fly_Buy_API.Repository.Models
{
    public partial class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        [StringLength(100)]
        [Required]
        public string FirstName { get; set; }
        [Column("last_name")]
        [StringLength(100)]
        [Required]
        public string LastName { get; set; }
        [Column("email")]
        [StringLength(100)]
        [Required]
        public string Email { get; set; }
        [Column("password")]
        [StringLength(100)]
        [Required]
        public string Password { get; set; }
        [Column("address")]
        [StringLength(100)]
        public string Address { get; set; }
    }
}
