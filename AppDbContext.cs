using ksiegarniaAplikacja.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ksiegarniaAp {
	public class AppDbContext : IdentityDbContext {
		public DbSet<Book> Books { get; set; }
		public DbSet<Cart> Carts { get; set; }
		public AppDbContext() { }
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
	}
}
