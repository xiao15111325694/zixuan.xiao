using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 自定义权限控制.Error
{
    public class LogDebugAttribute: HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
            //处理错误消息，将其跳转到一个页面
            LogHelp.Debug(filterContext.Exception.ToString());
            //页面跳转到错误页面
            filterContext.HttpContext.Response.Redirect("/Home/Index");
        }
    }
}