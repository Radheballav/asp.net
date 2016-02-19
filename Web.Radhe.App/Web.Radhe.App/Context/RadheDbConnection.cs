using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Web.Radhe.App.Models;

namespace Web.Radhe.App.Context
{
    public class RadheDbConnection :DbContext
    {
        public RadheDbConnection() : base("DefaultConnection")
        {

        }
        public DbSet<Student> Students { get; set; }
       
    }
}