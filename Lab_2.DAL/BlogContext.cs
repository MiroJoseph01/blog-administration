using Lab_2.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab_2.DAL
{
    public class BlogContext : DbContext
    {
        public BlogContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Initial Catalog=Blog;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
            .HasOne(s => s.Author)
            .WithMany(g => g.Posts)
            .HasForeignKey(s => s.AuthorId);

            var author1 = new Author { Id = 1, Name = "Tom", Surname = "Potter" };
            var author2 = new Author { Id = 2, Name = "Alice", Surname = "Smith" };

            var topic1 = new Topic { Id = 1, Name = "Nature" };
            var topic2 = new Topic { Id = 2, Name = "Networks" };

            modelBuilder.Entity<Author>().HasData(new Author[] { author1, author2 });

            modelBuilder.Entity<Topic>().HasData(new Topic[] { topic1, topic2 });

            modelBuilder.Entity<Post>().HasData(new Post[] {
                new Post { Id = 1, Title = "Title1", Body = "Lore Ipsum 1", AuthorId = author1.Id, TopicId = topic2.Id },
                new Post { Id = 2, Title = "Title2", Body = "Lore Ipsum 2", AuthorId = author1.Id, TopicId = topic1.Id },
                new Post { Id = 3, Title = "Title3", Body = "Lore Ipsum 3", AuthorId = author2.Id, TopicId = topic2.Id },
                new Post { Id = 4, Title = "Title4", Body = "Lore Ipsum 4", AuthorId = author2.Id, TopicId = topic2.Id },
                new Post { Id = 5, Title = "Title5", Body = "Lore Ipsum 5", AuthorId = author2.Id, TopicId = topic2.Id }
            });         
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Author> Authors { get; set; }


        public DbSet<Topic> Topics { get; set; }
    }
}
