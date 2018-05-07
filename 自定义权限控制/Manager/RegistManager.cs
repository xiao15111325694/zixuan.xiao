using Domian;
using Domin;
using System.Threading.Tasks;

namespace 自定义权限控制.Manager
{
    public class RegistManager
    {
        private ModelDBContext db = new ModelDBContext();

        public async Task<RegisterState> CreateAsync(User user, string password)
        {
            user.Password = password;
            using (var dbContextTransaction = db.Database.BeginTransaction())
            {
                db.User.Add(user);
                await db.SaveChangesAsync();

                dbContextTransaction.Commit();
                return RegisterState.Success;
            }
        }
    }
}