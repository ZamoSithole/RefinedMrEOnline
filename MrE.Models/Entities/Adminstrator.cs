using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using MrE.Models.Abstractions;

namespace MrE.Models.Entities
{
    [Table("Administartors")]
    public class Adminstrator : IAdmin, ICreatable, IDeletable, IUpdatable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "AdminID")]

        public int AdminID { get; set; }

        [Display(Name = "FirstName"), Required(ErrorMessage = "Fill out Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Surname is required")]
       public string Surname { get; set; }
        
        [Display( Name = "Password")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Password should be 8 characters")]
        [DataType(DataType.Password, ErrorMessage ="Less than 8 characters ")]
        public string Password { get; set; }
        public int ContactID { get; set; }
        public Contact Contact { get; set; }

        public bool IsDeleted { get; set; }

        [ForeignKey("UserCreated")]
        public int UserID { get; set; }
        public User UserCreated { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("UserUpdated")]
        [Display(Name ="Date Updated")]
        public DateTime? DateUpdated { get; set; }
        public int? UserUpdateID { get; set; }
       public User UserUpdated { get; set; }

        [ForeignKey("UserDeleted")]
        public int? UserDeletedID { get; set; }
        public User UserDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }


    }
}
