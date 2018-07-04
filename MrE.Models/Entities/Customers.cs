using MrE.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MrE.Models.Entities
{
    [Table("Customers")]
    public class Customers : IPerson, ICreatable, IDeletable, IUpdatable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "CustomerID")]

        public int CustomerID { get; set; }



        public bool IsDeleted { get; set; }

        [ForeignKey("UserCreated")]
        public int UserID { get; set; }
        public User UserCreated { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("UserUpdated")]
        [Display(Name = "Date Updated")]
        public DateTime? DateUpdated { get; set; }
        public int? UserUpdateID { get; set; }
        public User UserUpdated { get; set; }

        [ForeignKey("UserDeleted")]
        public int? UserDeletedID { get; set; }
        public User UserDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }

    }
}
