using System.Web;
using System.Web.Mvc;
using 自定义权限控制.Error;

namespace 自定义权限控制
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //注册错误过滤器
            filters.Add(new LogDebugAttribute());
        }
    }
}
