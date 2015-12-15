using Microsoft.AspNet.Identity.EntityFramework;
using MiracleMachine.data.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiracleMachine.data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public IDbSet<Prop> Props { get; set; }
        public IDbSet<Theory> Theories { get; set; }
        public IDbSet<NewTrick> NewTricks { get; set; }
    }
}
