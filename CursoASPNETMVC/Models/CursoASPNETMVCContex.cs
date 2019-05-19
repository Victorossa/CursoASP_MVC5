using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CursoASPNETMVC.Models
{
    public class CursoASPNETMVCContex : DbContext
    {
        public CursoASPNETMVCContex() : base("DefaultConnection")
        {

        }
        public DbSet<Persona> Personas { get; set; }

    }
}