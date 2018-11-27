using Microsoft.EntityFrameworkCore;
using VisualTaskBoard.Models;

namespace VisualTaskBoard.Data
{
    public class NodeContext : DbContext
    {
        public NodeContext(DbContextOptions<NodeContext> options) : base(options)
        {

        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Node> Nodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().ToTable("Group");
            modelBuilder.Entity<Node>().ToTable("Node");
        }
    }
}
