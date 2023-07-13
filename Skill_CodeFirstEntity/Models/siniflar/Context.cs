using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Skill_CodeFirstEntity.Models.siniflar
{
    public class Context:DbContext
    {
        public DbSet<Yetenekler> Yetenklers { get; set; }
    }

}