using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Do.Dal;
using Webdiyer.WebControls.Mvc;

namespace Do.Bll
{
    public class BaseBll<T> where T:class 
    {
        public BaseDal<T> dal = new BaseDal<T>();

        #region 查询
        /// <summary>
        /// 获取实体列表
        /// </summary>
        /// <returns></returns>
        public List<T> GetList()
        {
            return dal.GetList();
        }
        /// <summary>
        /// 根据主键查询实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(object id)
        {
            return dal.GetById(id);
        }
        /// <summary>
        /// 根据lambda表达式查询返回第一条记录
        /// </summary>
        /// <param name="lambda"></param>
        /// <returns></returns>
        public T GetFirstRecord(Expression<Func<T, bool>> lambda)
        {
            return dal.GetFirstRecord(lambda);
        }

        /// <summary>
        /// 传入lambda想查什么就查什么
        /// </summary>
        /// <param name="lambda"></param>
        /// <returns></returns>
        public List<T> GetList(Expression<Func<T, bool>> lambda)
        {
            return dal.GetList(lambda);
        }
        /// <summary>
        /// 带排序和查询条件
        /// </summary>
        /// <param name="lambda"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public List<T> GetList(Expression<Func<T, bool>> lambda,Func<IQueryable<T>,IOrderedQueryable<T>> orderBy)
        {
            return dal.GetList(lambda, orderBy);
        }

        public PagedList<T> GetList(int pageIndex, int pageSize)
        {
            return dal.GetList(pageIndex, pageSize);
        }

        #endregion

        #region 插入
        /// <summary>
        /// 插入单个实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Insert(T entity)
        {
            return dal.Insert(entity);
        }
        /// <summary>
        /// 批量插入实体
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Insert(List<T> list)
        {
            return dal.Insert(list);
        }
        #endregion

        #region 修改
        public int Update(T entity)
        {
            return dal.Update(entity);
        }

        public int AddOrUpdate(T entity)
        {
            return dal.AddOrUpdate(entity);
        }

        public void Update(IEnumerable<T> ie)
        {
            foreach (var item in ie)
            {
                Update(item);
            }
        }

        public void Update(Expression<Func<T, bool>> lambda)
        {
            dal.Update(lambda);
        }

        #endregion

        #region 删除
        /// <summary>
        /// 删除实体by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(object id)
        {
            return dal.Delete(id);
        }
        /// <summary>
        /// 删除单个实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Delete(T entity)
        {
            return dal.Delete(entity);
        }
        /// <summary>
        /// 批量删除实体
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Delete(List<T> list)
        {
            return dal.Delete(list);
        }

        /// <summary>
        /// 传入Lambda表达式删除对应记录
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public int Delete(Expression<Func<T,bool>> predicate)
        {
            return dal.Delete(predicate);
        }

        #endregion

    }
}
