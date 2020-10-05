using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HNDuty.Models;
using HNDuty.DBTool;

namespace HNDuty.Service
{
    public class NoticeService
    {
        DBSyntax baseDao = new DBSyntax();

        //公告列表
        public List<Notice> ListNotices()
        {
            List<Notice> list = baseDao.ListNotice();
            
            return list;   
        }

    }
}