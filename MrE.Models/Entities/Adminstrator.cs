using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using MrE.Models.Abstractions;

namespace MrE.Models.Entities
{
    [Table("Administartors")]
    public class Adminstrator : IPerson, ICreatable/*, IDeletable, IUpdatable, IAdmin*/
    {
    }
}
