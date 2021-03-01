using System.Data.Entity;
using DataAccess.Concrete.EntityFramework.Mappings;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class MembershipContext : DbContext
    {
        public MembershipContext()
        {
            Database.SetInitializer<MembershipContext>(null);
        }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
        }
    }
}
