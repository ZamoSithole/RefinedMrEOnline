using System;
using MrE.Models.Entities;
using System.Collections.Generic;
using System.Text;

namespace MrE.Models.Abstractions
{
    public interface IPerson
    {
        string FirstName {get; set;}
        string Surname { get; set; }
        //string Email { get; set; }
        string Password { get; set; }
        Contact Contact { get; set; }
    }
}
