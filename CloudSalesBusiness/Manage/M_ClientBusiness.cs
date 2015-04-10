﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CloudSalesEntity;
using CloudSalesDAL;

namespace CloudSalesBusiness
{
    public class M_ClientBusiness
    {
        #region 查询
        #endregion

        #region 添加

        /// <summary>
        /// 添加客户端
        /// </summary>
        /// <param name="model">M_Clients 对象</param>
        /// <param name="loginName">登陆账号</param>
        /// <param name="loginPwd">密码</param>
        /// <returns></returns>
        public static string InsertClient(M_Clients model, string loginName, string loginPwd)
        {
            string clientid = new M_ClientDAL().InsertClient(model.CompanyName, loginName, loginPwd);
            return clientid;
        }

        #endregion

        #region 编辑
        #endregion

    }
}
