using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.DAL.Maps.Ves;

namespace IMSDataAccessTests.Configuration
{
    public class DynamicNHibernateHelper
    {
        public static ISessionFactory CreateSessionFactory(string connectionString)
        {
            NHibernate.Cfg.Configuration config = Fluently.Configure().
                Database(MsSqlConfiguration.MsSql2008.ShowSql().ConnectionString(connectionString)).
                Mappings(m => m.FluentMappings.AddFromAssemblyOf<VesselCategoriesMap>()).
                CurrentSessionContext<ThreadStaticSessionContext>().
                BuildConfiguration();
            return config.BuildSessionFactory();
        }
    }
}