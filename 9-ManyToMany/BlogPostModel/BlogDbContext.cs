using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ManyToMany.BlogPostModel
{
    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Istka2024ManyToManyBlog;Trusted_Connection=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostTag>()
                .HasKey(p => new { p.PostsId, p.TagsId });

            modelBuilder.Entity<PostTag>()
                .HasOne(p => p.Post).WithMany(p => p.PostTags)
                .HasForeignKey(p=>p.PostsId);
            
            modelBuilder.Entity<PostTag>()
                .HasOne(p => p.Tag).WithMany(p => p.PostTags)
                .HasForeignKey(p=>p.TagsId);

        }
    }
}
