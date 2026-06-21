using Microsoft.EntityFrameworkCore;
using NUBIFIE_Web_Portal.Models;

namespace NUBIFIE_Web_Portal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberRegistration>()
                .Property(b => b.RegDate)
                .HasDefaultValueSql("format(dateadd(hour,(1),getutcdate()),'dd/MM/yyyy')");

            // Mark RefID and FullName as computed columns
            modelBuilder.Entity<MemberRegistration>()
                .Property(b => b.RefID)
                .ValueGeneratedOnAddOrUpdate()
                .HasComputedColumnSql("concat([StateID],[LGAID],right(concat('000000',[ID]),(5)))");

            modelBuilder.Entity<MemberRegistration>()
                .Property(b => b.FullName)
                .ValueGeneratedOnAddOrUpdate()
                .HasComputedColumnSql("concat([Surname],', ',[Othername])");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<News> News { get; set; }
        public DbSet<SysOption> SysOptions { get; set; }
        public DbSet<News> MediaNews { get; set; }
        public DbSet<NewsGroup> NewsGroup { get; set; }
        // public DbSet<NewsDetailsModel> NewsDetailsModels { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventPicture> EventsPictures { get; set; }
        public DbSet<Activity_> Activities { get; set; }
        public DbSet<ActivityPicture> ActivityPictures { get; set; }
        public DbSet<NACM> NACM { get; set; }
        public DbSet<NSS_ZCS> NSS_ZCS { get; set; }
        public DbSet<MemberRegistration> MemeberRegistrations { get; set; }
        public DbSet<MMO> MMO { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<LGA> LGA { get; set; }
    }
}
