/*******************************************************************************
 * Copyright © 2018 代码生成器 版权所有
 * Author: LanGerp 
 * Description: 快速开发平台
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BFM.BLL.Container;
using BFM.BLL.IBLL;
using BFM.Common.Base.Helper;
using BFM.Common.Base.Utils;
using BFM.ContractModel;

namespace BFM.WCFService
{
    /// <summary>
    /// RsFactory Server
    /// </summary>
    public partial class RSMService : IRSMService
    {
        #region RsFactory分页查询

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageSize">单页的记录数</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="isAsc">是否正序排序</param>
        /// <param name="orderField">排序字段 为空时默认为 CREATION_DATE </param>
        /// <param name="sWhere">查询条件；多条件是目前只支持 and；表达式 System.Linq.Dynamic的形式</param>
        /// <returns>符合查询条件的List结果</returns>
        public List<RsFactory> GetRsFactoryByPage(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere)
        {
            string orderStr = "";
            if (string.IsNullOrEmpty(orderField))
            {
                orderStr = "CREATION_DATE";
            }
            else
            {
                orderStr = orderField;
            }
            Expression<Func<RsFactory, bool>> whereLamda = SerializerHelper.ConvertParamWhereToLinq<RsFactory>(sWhere); 

            using (IRsFactoryBLL RsFactoryBLL = BLLContainer.Resolve<IRsFactoryBLL>())
            {
                List<RsFactory> models = RsFactoryBLL.GetModelsByPage(pageSize, pageIndex, isAsc, orderStr, whereLamda);
                return models;
            }
        }

        /// <summary>
        /// 返回记录总数 配合分页查询用
        /// </summary>
        /// <param name="sWhere">查询条件；多条件是目前只支持 and；表达式 System.Linq.Dynamic的形式</param>
        /// <returns>符合查询条件的记录数</returns>
        public int GetRsFactoryCount(string sWhere)
        {
            Expression<Func<RsFactory, bool>> whereLamda = SerializerHelper.ConvertParamWhereToLinq<RsFactory>(sWhere); 
            using (IRsFactoryBLL RsFactoryBLL = BLLContainer.Resolve<IRsFactoryBLL>())
            {
                return RsFactoryBLL.GetCount(whereLamda);
            }
        }

        #endregion RsFactory分页查询

        #region Add、Update、Delete

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="mRsFactory">模型</param>
        /// <returns>是否成功</returns>
        public bool AddRsFactory(RsFactory mRsFactory)
        {
            if (mRsFactory == null) return false;
            using (IRsFactoryBLL RsFactoryBLL = BLLContainer.Resolve<IRsFactoryBLL>())
            {
                return RsFactoryBLL.Add(mRsFactory);
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="mRsFactory">模型</param>
        /// <returns>是否成功</returns>
        public bool UpdateRsFactory(RsFactory mRsFactory)
        {
            if (mRsFactory == null) return false;
            using (IRsFactoryBLL RsFactoryBLL = BLLContainer.Resolve<IRsFactoryBLL>())
            {
                return RsFactoryBLL.Update(mRsFactory);
            }
        }

        /// <summary>
        /// 按照关键字段删除
        /// </summary>
        /// <param name="Ids">关键字段数组</param>
        /// <returns>是否成功</returns>
        public bool DelRsFactorys(string[] Ids)
        {
            using (IRsFactoryBLL RsFactoryBLL = BLLContainer.Resolve<IRsFactoryBLL>())
            {
                try
                {
                    List<RsFactory> entitys = new List<RsFactory>();
                    foreach (string id in Ids)
                    {
                        RsFactory item = RsFactoryBLL.GetFirstOrDefault(id);
                        entitys.Add(item);
                    }
                    return RsFactoryBLL.Delete(entitys);
                }
                catch { return false; }
            }
        }

        /// <summary>
        /// 按照关键字段删除
        /// </summary>
        /// <param name="Id">关键字段</param>
        /// <returns>是否成功</returns>
        public bool DelRsFactory(string Id)
        {
            using (IRsFactoryBLL RsFactoryBLL = BLLContainer.Resolve<IRsFactoryBLL>())
            {
                try
                {
                    RsFactory item = RsFactoryBLL.GetFirstOrDefault(Id);
                    return RsFactoryBLL.Delete(item);
                }
                catch { return false; }
            }
        }

        #endregion Add、Update、Delete

        #region Search

        /// <summary>
        /// 根据查询条件获取记录
        /// </summary>
        /// <param name="sWhere">查询条件；多条件是目前只支持 and；表达式 System.Linq.Dynamic的形式</param>
        /// <returns>符合查询条件的List</returns>
        public List<RsFactory> GetRsFactorys(string sWhere)
        {
            Expression<Func<RsFactory, bool>> whereLamda = SerializerHelper.ConvertParamWhereToLinq<RsFactory>(sWhere);
            using (IRsFactoryBLL RsFactoryBLL = BLLContainer.Resolve<IRsFactoryBLL>())
            {
                List<RsFactory> models = RsFactoryBLL.GetModels(whereLamda);
                return models;
            }
        }

        /// <summary>
        /// 根据关键字段的值获取记录
        /// </summary>
        /// <param name="Id">关键字段的值</param>
        /// <returns>符合查询条件的记录</returns>
        public RsFactory GetRsFactoryById(string Id)
        {
            using (IRsFactoryBLL RsFactoryBLL = BLLContainer.Resolve<IRsFactoryBLL>())
            {
                RsFactory model = RsFactoryBLL.GetFirstOrDefault(Id);
                return model;
            }
        }

        #endregion Search

        #region 其他

        #endregion 其他

    }
}
