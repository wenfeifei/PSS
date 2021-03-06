﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Insigma.Eyes.PSS.Model
{
    /// <summary>
    /// 销售商品信息
    /// </summary>
    [DataContract]
    public class SalesCommodityModel
    {
        [DataMember]
        public int ID
        {
            get;
            set;
        }

        /// <summary>
        /// 销售订单ID
        /// </summary>
        [DataMember]
        public int SalesOrderID
        {
            get;
            set;
        }

        /// <summary>
        /// 商品ID
        /// </summary>
        [DataMember]
        public int CommodityID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 商品名称
        /// </summary>
        [DataMember]
        public string CommodityName
        {
            get;
            set;
        }

        /// <summary>
        /// 商品型号
        /// </summary>
        [DataMember]
        public string CommodityType
        {
            get;
            set;
        }

        /// <summary>
        /// 商品生产厂家
        /// </summary>
        [DataMember]
        public string CommodityManufacturer
        {
            get;
            set;
        }

        /// <summary>
        /// 库存
        /// </summary>
        [DataMember]
        public int CommodityInventory
        {
            get;
            set;
        }

        /// <summary>
        /// 商品推荐销售单价
        /// </summary>
        [DataMember]
        public decimal CommodityUnitPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 商品单位
        /// </summary>
        [DataMember]
        public string CommodityUnit
        {
            get;
            set;
        }

        /// <summary>
        /// 销售数量
        /// </summary>
        [DataMember]
        public int Count
        {
            get;
            set;
        }

        /// <summary>
        /// 销售价格
        /// </summary>
        [DataMember]
        public decimal SalesPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 销售总金额
        /// </summary>
        [DataMember]
        public decimal TotalPrice
        {
            get;
            set;
        }
    }
}
