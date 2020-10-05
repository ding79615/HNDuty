using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HNDuty.Models
{
    public class Notice
    {
        /// <summary> 公告編號 </summary>
        public int NID { get; set; }

        /// <summary> 公告日期 </summary>
        public string NoticeDate { get; set; }

        /// <summary> 公告主題 </summary>
        public string NoticeTopic { get; set; }

        /// <summary> 公告內文 </summary>
        public string NoticeContent { get; set; }

        /// <summary> 公告狀態(0:未發布;1:已發布;2:刪除) </summary>
        public int Status { get; set; }

        /// <summary> 公告建立者員編 </summary>
        public string Creator { get; set; }

        /// <summary> 公告更新者員編 </summary>
        public string Modifier { get; set; }

        /// <summary> 公告建立時間 </summary>
        public DateTime CreateDate { get; set; }

        /// <summary> 公告更新時間 </summary>
        public DateTime ModifyDate { get; set; }

    }
}