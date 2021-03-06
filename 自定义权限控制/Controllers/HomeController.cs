﻿using Domian;
using Domin;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using 自定义权限控制.Error;
using 自定义权限控制.Manager;

namespace 自定义权限控制.Controllers
{

    //[LogError]
    //[LogDebug]
    public class HomeController : Controller
    {

        public ActionResult Index(string token)
       {
            ModelDBContext db = new ModelDBContext();

            var enti = db.Paragraph.Find(1);
            var entity = db.User;
            var name = System.Web.HttpContext.Current.User.Identity.Name;
            ViewBag.Title = "Home Page";
            return View();
        }

        [MVCAuthorize(Roles = "VIP9,ActiveUser")]
        public ActionResult Chat()
        {

            var account = HttpContext.User.Identity.Name;
            ModelDBContext db = new ModelDBContext();
            //ViewBag.UserName =db.User.Where(x=>x.Email == account).FirstOrDefault().FullName;         
            return View();
        }

        public async Task<ActionResult> sendEmail(string email)
        {
            // 异步发送邮件
            await Task.Run(() =>
            {
                new EmailManager().SendEmail(email, "Hi 尊敬的客户你好,你可以点击下方链接重置密码",
                    "哈哈 骗你的，哈哈 测试邮件内容，测试邮件内容", email, "zwz4563515");
            });
            return Json("yes", JsonRequestBehavior.AllowGet);
        }

    }
}
