using System.Net.Mime;
using Microsoft.EntityFrameworkCore;

namespace LeThiMaiAnh_BaiThi2324.Data{
    public class ApplicationDbContext: DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<LTMA076Person> LTMA076Person { get;set;}
    }
}