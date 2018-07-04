using MrE.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MrE.Models.Abstractions
{
    public interface IUpdatable
    {
        DateTime? DateUpdate { get; set; }
        int? UserUpdateID { get; set; }
         User UserUpdated { get; set; }
    }
}
