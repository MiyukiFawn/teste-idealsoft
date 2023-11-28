using API.Model;
using Microsoft.EntityFrameworkCore;

namespace API;
public class ApiDbContext : DbContext {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlServer("Server=tcp:miyuki.database.windows.net,1433;Initial Catalog=Idealsoft;Persist Security Info=False;User ID=dbadmin@miyukifgamesgmail.onmicrosoft.com;Password=Diga_0_nome;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Authentication=\"Active Directory Password\";");
    }

    public DbSet<Person> Person { get; set; }
}
