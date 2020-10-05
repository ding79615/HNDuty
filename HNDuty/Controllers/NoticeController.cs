using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HNDuty.Service;
using HNDuty.Models;

namespace HNDuty.Controllers
{
    public class NoticeController : Controller
    {
        //首頁
        public ActionResult Index()
        {
            //取得列表資料
            NoticeService ns = new NoticeService();
            List<Notice> list = ns.ListNotices();

            if (list == null)
            {
                ViewBag.Total = 0;
            }
            else
            {
                ViewBag.Total = list.Count();
            }

            return View(list);
        }

        //新增公告
        [HttpGet]
        public ActionResult AddNotice()
        {
            return View();
        }



    }


}