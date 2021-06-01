using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities.ContextEntities
{
    public class ContextDB :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=DESKTOP-U48HV9B;database=DD;Integrated_Security=true");
        }
    }
}
