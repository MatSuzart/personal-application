using PersonalApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PersonalApplication
{
    public class ModelContext : DbContext
    { 
    public ModelContext() :base("DBFConnectionString")
    {

    }

    
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Renda> Rendas { get; set; }
        public DbSet<Despesa> Despesas { get; set; }


    }
}