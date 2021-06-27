using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcGitHub2.Models
{
    public class ApplicationDbcontext : DbContext

    {


        public DbSet<Persona> Persona { get; set; }
    }



}
