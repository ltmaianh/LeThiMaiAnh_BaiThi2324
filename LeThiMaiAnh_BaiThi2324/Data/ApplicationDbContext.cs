using System.Net.Mime;
using Microsoft.EntityFrameworkCore;
namespace LeThiMaiAnh_BaiThi2324.Data{
    public class ApplicationDbContext: DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        private DbSet<LTMA076Person> person;

        public DbSet<LTMA076Person> GetPerson()
        {
            return person;
        }

        public void SetPerson(DbSet<LTMA076Person> value)
        {
            person = value;
        }
    }
}