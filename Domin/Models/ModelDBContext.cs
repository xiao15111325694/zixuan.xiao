using System.Data.Entity;
using System.Reflection.Emit;

namespace Domian
{
    public class ModelDBContext : DbContext
    {
        static ModelDBContext()
        {
            Database.SetInitializer<ModelDBContext>(null);
        }
        public ModelDBContext() : base("Name=ModelDBContext")
        {

        }
        public ModelDBContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        { }

        public DbSet<User> User { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<UserRole> UserRole { get; set; }

        public DbSet<UserGroup> UserGroup { get; set; }

        public DbSet<RoomGroup> RoomGroup { get; set; }

        public DbSet<Paragraph> Paragraph { get; set; }

        public DbSet<Node> Node { get; set; }

        public DbSet<ParagraphNode> ParagraphNode { get; set; }

        public DbSet<UserMessage> UserMessage { get; set; }

        public DbSet<UserCollection> UserCollection { get; set; }
    }
}