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
    /// QmsCheckMaster Server
    /// </summary>
    public partial class QMSService : IQMSService
    {
        #region QmsCheckMaster分页查询

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageSize">单页的记录数</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="isAsc">是否正序排序</param>
        /// <param name="orderField">排序字段 为空时默认为 CREATION_DATE </param>
        /// <param name="sWhere">查询条件；多条件是目前只支持 and；表达式 System.Linq.Dynamic的形式</param>
        /// <returns>符合查询条件的List结果</returns>
        public List<QmsCheckMaster> GetQmsCheckMasterByPage(int pageSize, int pageIndex, bool isAsc, string orderField, string sWhere)
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
            Expression<Func<QmsCheckMaster, bool>> whereLamda = SerializerHelper.ConvertParamWhereToLinq<QmsCheckMaster>(sWhere); 

            using (IQmsCheckMasterBLL QmsCheckMasterBLL = BLLContainer.Resolve<IQmsCheckMasterBLL>())
            {
                List<QmsCheckMaster> models = QmsCheckMasterBLL.GetModelsByPage(pageSize, pageIndex, isAsc, orderStr, whereLamda);
                return models;
            }
        }

        /// <summary>
        /// 返回记录总数 配合分页查询用
        /// </summary>
        /// <param name="sWhere">查询条件；多条件是目前只支持 and；表达式 System.Linq.Dynamic的形式</param>
        /// <returns>符合查询条件的记录数</returns>
        public int GetQmsCheckMasterCount(string sWhere)
        {
            Expression<Func<QmsCheckMaster, bool>> whereLamda = SerializerHelper.ConvertParamWhereToLinq<QmsCheckMaster>(sWhere); 
            using (IQmsCheckMasterBLL QmsCheckMasterBLL = BLLContainer.Resolve<IQmsCheckMasterBLL>())
            {
                return QmsCheckMasterBLL.GetCount(whereLamda);
            }
        }

        #endregion QmsCheckMaster分页查询

        #region Add、Update、Delete

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="mQmsCheckMaster">模型</param>
        /// <returns>是否成功</returns>
        public bool AddQmsCheckMaster(QmsCheckMaster mQmsCheckMaster)
        {
            if (mQmsCheckMaster == null) return false;
            using (IQmsCheckMasterBLL QmsCheckMasterBLL = BLLContainer.Resolve<IQmsCheckMasterBLL>())
            {
                return QmsCheckMasterBLL.Add(mQmsCheckMaster);
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="mQmsCheckMaster">模型</param>
        /// <returns>是否成功</returns>
        public bool UpdateQmsCheckMaster(QmsCheckMaster mQmsCheckMaster)
        {
            if (mQmsCheckMaster == null) return false;
            using (IQmsCheckMasterBLL QmsCheckMasterBLL = BLLContainer.Resolve<IQmsCheckMasterBLL>())
            {
                return QmsCheckMasterBLL.Update(mQmsCheckMaster);
            }
        }

        /// <summary>
        /// 按照关键字段删除
        /// </summary>
        /// <param name="Ids">关键字段数组</param>
        /// <returns>是否成功</returns>
        public bool DelQmsCheckMasters(string[] Ids)
        {
            using (IQmsCheckMasterBLL QmsCheckMasterBLL = BLLContainer.Resolve<IQmsCheckMasterBLL>())
            {
                try
                {
                    List<QmsCheckMaster> entitys = new List<QmsCheckMaster>();
                    foreach (string id in Ids)
                    {
                        QmsCheckMaster item = QmsCheckMasterBLL.GetFirstOrDefault(id);
                        entitys.Add(item);
                    }
                    return QmsCheckMasterBLL.Delete(entitys);
                }
                catch { return false; }
            }
        }

        /// <summary>
        /// 按照关键字段删除
        /// </summary>
        /// <param name="Id">关键字段</param>
        /// <returns>是否成功</returns>
        public bool DelQmsCheckMaster(string Id)
        {
            using (IQmsCheckMasterBLL QmsCheckMasterBLL = BLLContainer.Resolve<IQmsCheckMasterBLL>())
            {
                try
                {
                    QmsCheckMaster item = QmsCheckMasterBLL.GetFirstOrDefault(Id);
                    return QmsCheckMasterBLL.Delete(item);
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
        public List<QmsCheckMaster> GetQmsCheckMasters(string sWhere)
        {
            Expression<Func<QmsCheckMaster, bool>> whereLamda = SerializerHelper.ConvertParamWhereToLinq<QmsCheckMaster>(sWhere);
            using (IQmsCheckMasterBLL QmsCheckMasterBLL = BLLContainer.Resolve<IQmsCheckMasterBLL>())
            {
                List<QmsCheckMaster> models = QmsCheckMasterBLL.GetModels(whereLamda);
                return models;
            }
        }

        /// <summary>
        /// 根据关键字段的值获取记录
        /// </summary>
        /// <param name="Id">关键字段的值</param>
        /// <returns>符合查询条件的记录</returns>
        public QmsCheckMaster GetQmsCheckMasterById(string Id)
        {
            using (IQmsCheckMasterBLL QmsCheckMasterBLL = BLLContainer.Resolve<IQmsCheckMasterBLL>())
            {
                QmsCheckMaster model = QmsCheckMasterBLL.GetFirstOrDefault(Id);
                return model;
            }
        }

        #endregion Search

        #region 其他

        #endregion 其他

    }
}
