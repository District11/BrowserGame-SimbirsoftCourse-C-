using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Browser_game.Data;

namespace Browser_game.Models
{
    public class User : IdentityUser
    {
        /*public int Year { get; set; }
       override public string  Email { get; set; }
        public string Name { get; set; }*/
    }
}