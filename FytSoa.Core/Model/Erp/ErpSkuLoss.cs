﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FytSoa.Core.Model.Erp
{
    /// <summary>
    /// 条形码报损
    /// </summary>
    public class ErpSkuLoss
    {
        /// <summary>
        /// Desc:唯一ID
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Guid { get; set; }

        /// <summary>
        /// Desc:条形码编号
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string SkuGuid { get; set; }

        /// <summary>
        /// Desc:报损数量
        /// Default:
        /// Nullable:False
        /// </summary>           
        public int Counts { get; set; }

        /// <summary>
        /// Desc:报损说明
        /// Default:
        /// Nullable:False
        /// </summary>           
        public string Summary { get; set; }

        /// <summary>
        /// Desc:添加时间
        /// Default:
        /// Nullable:False
        /// </summary>           
        public DateTime AddDate { get; set; } = DateTime.Now;

        /// <summary>
        /// 状态 0=无销售 / 1=已销售
        /// </summary>
        public int Types { get; set; } = 0;

        /// <summary>
        /// 如果销售了，属于订单号的唯一编号
        /// </summary>
        public string OrderGuid { get; set; }
    }
}
