
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WcfService1.Cor.Models;


namespace WcfService1.Persistance
{
    public class WaterLogicDbContext : IdentityDbContext<IdentityUser>
    {
        private static WaterLogicDbContext instance;
        public DbSet<Machine> Machines { get; set; }
        public DbSet<MCategory> Categories { get; set; }
        public DbSet<WcfService1.Cor.Models.Customer> Customers { get; set; }

        public static WaterLogicDbContext getContext()
        {
            if (instance == null)
            {
                instance = new WaterLogicDbContext();
                return instance;
            }
            else
            {
                return instance;
            }
        }

        private WaterLogicDbContext()
            
        {

        }
    }
}
