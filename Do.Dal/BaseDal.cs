using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Do.Db.Oracle;
using Webdiyer.WebControls.Mvc;

namespace Do.Dal
{
    public class BaseDal<T> where T:class
    {
        PlatFormDB db = new PlatFormDB();
        public DbSet<T> DbSet
        {
            get { return db.Set<T>(); }
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }


        #region 查询
        /// <summary>
        /// 获取实体列表
        /// </summary>
        /// <returns></returns>
        public List<T> GetList()
        {
            return DbSet.ToList();
        }

        public T GetById(object id)
        {
            return DbSet.Find(id);
        }

        public T GetFirstRecord(Expression<Func<T, bool>> lambda)
        {
            return DbSet.Where(lambda).FirstOrDefault();
        }

        /// <summary>
        /// 传入lambda想查什么就查什么
        /// </summary>
        /// <param name="lambda"></param>
        /// <returns></returns>
        public List<T> GetList(Expression<Func<T, bool>> lambda)
        {
            return DbSet.Where(lambda).ToList();
        }
        /// <summary>
        /// 带排序的lambda表达式查询列表
        /// </summary>
        /// <param name="lambda"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public List<T> GetList(Expression<Func<T, bool>> lambda, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy)
        {
            return orderBy(DbSet.Where(lambda)).ToList();
        }

        public PagedList<T> GetList(int pageIndex,int pageSize)
        {
            return DbSet.ToList().ToPagedList(pageIndex,pageSize);
        }

        #endregion

        #region 插入
        /// <summary>
        /// 新增实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Insert(T entity)
        {
            DbSet.Add(entity);
            return SaveChanges();
        }

        /// <summary>
        /// 批量插入实体
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Insert(List<T> list)
        {
            return list.Sum(entity => Insert(entity));
        }
        #endregion

        #region 修改
        public int AddOrUpdate(T entity)
        {
            DbSet.AddOrUpdate(entity);
            return SaveChanges();
        }

        /// <summary>
        /// 修改实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return SaveChanges();
        }

        public void Update(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Update(item);
            }
        }

        public void Update(Expression<Func<T, bool>> lambda)
        {
            var list = DbSet.Where(lambda);
            Update(list);
        }

        #endregion

        #region 删除
        /// <summary>
        /// 删除实体by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(object id)
        {
            var obj = DbSet.Find(id);
            DbSet.Remove(obj);
            return SaveChanges();
        }

        /// <summary>
        /// 删除实体by T
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Delete(T entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
            return SaveChanges();
        }
        /// <summary>
        /// 批量删除实体
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Delete(List<T> list )
        {
            return list.Sum(entity => Delete(entity));
        }

        /// <summary>
        /// 传入Lambda表达式删除对应的记录
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public int Delete(Expression<Func<T, bool>> predicate)
        {
            var entities = DbSet.Where(predicate).ToList();
            return entities.Count > 0 ? Delete(entities) : 0;
        }
        #endregion

    }
}
