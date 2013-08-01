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
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get { return _sessionFactory ?? (_sessionFactory = CreateSessionFactory()); }
        }

        private static ISessionFactory CreateSessionFactory()
        {
            FluentNHibernate.Cfg.FluentConfiguration config = Fluently.Configure()
                .Database(PostgreSQLConfiguration.Standard
                .ConnectionString(c => c
                .Host("rimf.ffa.int")       //202.4.229.96
                .Port(5432)
                .Database("norma_prod")
                .Username("ofp_admin")
                .Password("ofp_admin")))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<IMS.DAL.Maps.Ves.VesselCategoriesMap>());

            return config.BuildSessionFactory();

        }
    }
}