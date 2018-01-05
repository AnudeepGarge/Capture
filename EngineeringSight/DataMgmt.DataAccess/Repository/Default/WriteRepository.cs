using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMgmt.DataAccess.Repository.Default
{
    public class WriteRepository<TContext> : IWriteRepository where TContext : DbContext, new()
    {
        #region Constants and Enums

        #endregion

        #region Private and Protected Member Variables 
        TContext _context;
        #endregion

        #region Private and Protected Methods
        private T PerformOperation<T>(T data, EntityState state, bool saveChanges) where T : class, new()
        {
            _context.Entry(data).State = state;

            if (saveChanges)
                _context.SaveChanges();

            return data;
        }

        
        #endregion

        #region Constructors
        public WriteRepository()
        {
            _context = new TContext();
        }


        #endregion

        #region Public Properties
        protected TContext Context
        {
            get
            {
                return _context;
            }
        }
        #endregion

        #region Public Methods
        public T Delete<T>(T data, bool saveChanges = true) where T : class, new()
        {
            return PerformOperation(data, EntityState.Deleted, saveChanges);
        }
        
        public T Insert<T>(T data, bool saveChanges = true) where T : class, new()
        {
            return PerformOperation(data, EntityState.Added, saveChanges);
        }

        public T Update<T>(T data, bool saveChanges = true) where T : class, new()
        {
            return PerformOperation(data, EntityState.Modified, saveChanges);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion

    }
}
