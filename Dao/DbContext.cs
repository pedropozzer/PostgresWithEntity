using Dao.Mapping;
using Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Dao
{
    public class DbContext : System.Data.Entity.DbContext
    {
        DbContext(DbConnection connection)
            : base(connection, true)
        {
            this.Database.Log = SaveLogs;
            this.Database.Initialize(false);
        }

        public void SaveLogs(string log)
        {
            var x = log;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            MappingModels(modelBuilder);
        }

        private static void MappingModels(DbModelBuilder modelBuilder)
        {
            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => typeof(IMap).IsAssignableFrom(p));

            foreach (var type in types)
            {
                if (type != typeof(IMap))
                {
                    var instance = Activator.CreateInstance(type);
                    ((IMap)instance).Mapping(modelBuilder);
                }
            }

            modelBuilder.Conventions.Remove<StoreGeneratedIdentityKeyConvention>();
        }

        public static DbContext CreateContext()
        {
            var conn = new NpgsqlConnection("server=localhost;userid=postgres;password=181271;database=posto_polif1");
            return new DbContext(conn);
        }

        public void RejectChanges()
        {
            foreach (var entry in this.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        {
                            entry.CurrentValues.SetValues(entry.OriginalValues);
                            entry.State = EntityState.Unchanged;
                            break;
                        }
                    case EntityState.Deleted:
                        {
                            entry.State = EntityState.Unchanged;
                            break;
                        }
                    case EntityState.Added:
                        {
                            entry.State = EntityState.Detached;
                            break;
                        }
                }
            }
        }

        public T GetById<T>(params object[] keyValues) where T : EntityBase
        {
            return this.Set<T>().Find(keyValues);
        }

        public IEnumerable<T> GetAll<T>() where T : EntityBase
        {
            return this.Set<T>().AsNoTracking();
        }

        public void Delete<T>(T model) where T : EntityBase
        {
            this.Set<T>().Remove(model);
        }

        public void AddOrUpdate<T>(T model) where T : EntityBase
        {
            this.Set<T>().AddOrUpdate(model);
        }
    }
}
