using assignmentxcore_classlibrary.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace assignment_xcore.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticleAuthorEntity>()
                .HasKey(x => new { x.ArticleId, x.AuthorId });
            modelBuilder.Entity<ArticleTagEntity>()
                .HasKey(z => new { z.ArticleId, z.TagId });
        }

        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<ArticleEntity> Articles { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<ContentTypeEntity> ContentTypes { get; set; }
        public DbSet<ArticleAuthorEntity> ArticleAuthors { get; set; }
        public DbSet<ArticleTagEntity> ArticleTags { get; set; }
    }
}
