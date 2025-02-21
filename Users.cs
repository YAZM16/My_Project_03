using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace My_Project_03.Models
{
    public partial class Users
    {
        public int UserId { get; set; }

        public string? UserName { get; set; }

        public string? Email { get; set; }
    }
}
