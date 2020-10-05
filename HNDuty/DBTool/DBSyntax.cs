using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using HNDuty.Models;
namespace HNDuty.DBTool
{
    public class DBSyntax:DBUtility
    {
        #region 公告

        //公告列表(已發佈的才需要顯示)
        public List<Notice> ListNotice()
        {
            string SQL = "SELECT * FROM Notice WHERE Status = 1 Order By NID DESC";

            DataSet ds = this.ExecuteSearch(SQL);
            DataTable dt = ds.Tables[0];
            List<Notice> list = new List<Notice>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Notice notice = new Notice();
                    notice.NID = dr.Field<int>("NID");
                    notice.NoticeDate = dr.Field<string>("NoticeDate");
                    notice.NoticeTopic = dr.Field<string>("NoticeTopic");
                    notice.Creator = dr.Field<string>("Creator");
                    notice.CreateDate = dr.Field<DateTime>("CreateDate");
                    notice.Modifier = dr.Field<string>("Modifier");
                    notice.ModifyDate = dr.Field<DateTime>("ModifyDate");
                    list.Add(notice);
                }
            }
            else
            {
                list = null;
            }

            return list;

        }
        

        #endregion


    }
}