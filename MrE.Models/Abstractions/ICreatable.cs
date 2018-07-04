using MrE.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrE.Models.Abstractions
{
    public interface ICreatable
    {
        User UserCreated { get; set; }
        int UserID { get; set; }
        DateTime DateCreated { get; set; }
    }
}
