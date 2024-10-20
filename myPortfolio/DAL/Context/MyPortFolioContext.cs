using Microsoft.EntityFrameworkCore;
using myPortfolio.DAL.Entities;

namespace myPortfolio.DAL.Context
{
	public class MyPortFolioContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=ENES\\SQLEXPRESS;initial Catalog=MyPortfolioDb;integrated Security=true;TrustServerCertificate=True;");
		}
		public DbSet<About> Abouts { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Experience> Experiences { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Portfolio> Portfolios { get; set; }
		public DbSet<Skils> Skils { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }

	}
}
