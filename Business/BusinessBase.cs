using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Dao;
using Entities;

namespace Business
{
    public class DataProvider : IDisposable
    {
        private readonly DbContext _context;

        public DataProvider()
        {
            this._context = DbContext.CreateContext();
        }

        #region Crud

        public void AddOrUpdate<T>(T model) where T: EntityBase
        {
            _context.AddOrUpdate(model);
        }

        public void Delete<T>(T model) where T : EntityBase
        {
            _context.Delete(model);
        }

        #endregion

        #region Transaction

        public void SaveChanges()
        {
            _context.GetValidationErrors();
            _context.SaveChanges();
        }

        public void RejectChanges()
        {
            _context.RejectChanges();
        }

        #endregion

        #region Query

        public IEnumerable<T> GetAll<T>() where T: EntityBase
        {
            return this._context.GetAll<T>();
        }

        public T GetById<T>(params object[] keyValues) where T : EntityBase
        {
            return this._context.GetById<T>(keyValues);
        }

        public int ExecuteFreeSqlCommand(string query)
        {
            return this._context.Database.ExecuteSqlCommand(query);
        }


        #endregion

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
