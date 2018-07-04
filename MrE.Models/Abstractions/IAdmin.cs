using MrE.Models.Entities;
using System;

namespace MrE.Models.Abstractions
{
    public interface IAdmin
    {
        string FirstName { get; set; }
        string Surname { get; set; }
        string Password { get; set; }
        Contact Contact { get; set; }

        
    }
}
