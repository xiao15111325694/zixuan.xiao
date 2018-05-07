using Domian;
using Domin;

namespace 自定义权限控制.Repository
{
    public class LoginRepository
    {
        public ModelDBContext _context;

        public LoginRepository(ModelDBContext context)
        {
            _context = context;
        }
    }
}