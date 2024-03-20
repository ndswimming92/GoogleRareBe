using Microsoft.EntityFrameworkCore;
using GoogleRareBe.Data;
using GoogleRareBe.Models;
using GoogleRareBe.DTO;

namespace GoogleRareBe
{
    public class GoogleRareBeDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReaction> PostReactions { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserTypeChangeRequest> UserTypeChangeRequests { get; set; }

        public GoogleRareBeDbContext(DbContextOptions<GoogleRareBeDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(CategoryData.Categories);
            modelBuilder.Entity<Comment>().HasData(CommentData.Comments);
            modelBuilder.Entity<Post>().HasData(PostsData.Posts);
            modelBuilder.Entity<User>().HasData(RareUsersData.Users);
            modelBuilder.Entity<Reaction>().HasData(ReactionsData.Reactions);
            modelBuilder.Entity<Subscription>().HasData(SubscriptionData.Subscriptions);
            modelBuilder.Entity<Tag>().HasData(TagsData.Tags);
        }
    }
}
