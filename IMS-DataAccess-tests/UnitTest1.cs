using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IMSDataAccessTests.Configuration;
using IMSDataAccessTests.Repositories;
using TUFMAN.Domain.Ves;
using System.Collections.Generic;
using System.Linq;
using HibernatingRhinos.Profiler.Appender.NHibernate;
using NHibernate;

namespace IMS_DataAccess_tests
{
    [TestClass]
    public class IMS_DAL_Tests
    {
        [TestMethod]
        public void TestVesselCategoriesAccess()
        {
            //NHibernateProfiler.Initialize();

            UnitOfWork unitOfWork = new UnitOfWork(NHibernateHelper.SessionFactory);
            Repository repo = new Repository(unitOfWork.Session);

            List<TUFMAN.Domain.Ves.VesselCategories> list = repo.GetAll<TUFMAN.Domain.Ves.VesselCategories>().ToList();
            Assert.IsTrue(list.Count > 0);
            unitOfWork.Rollback();
        }

        [TestMethod]
        public void TestVesselCategoriesSync()
        {
            // this test will synchronise the vesselcategories table from tufman_ws on nousql50 to the portal
            //NHibernateProfiler.Initialize();

            // portal connection
            UnitOfWork unitOfWorkIMS = new UnitOfWork(NHibernateHelper.SessionFactory);
            Repository repoIMS = new Repository(unitOfWorkIMS.Session);

            // tufman connection
            UnitOfWork unitOfWorkTUFMAN = new UnitOfWork(DynamicNHibernateHelper.CreateSessionFactory("Server=NOUSQL50\\SQLEXPRESS;Database=tufman_ws;Trusted_Connection=True"));
            Repository repoTUFMAN = new Repository(unitOfWorkTUFMAN.Session);

            List<TUFMAN.Domain.Ves.VesselCategories> list2 = repoTUFMAN.GetAll<TUFMAN.Domain.Ves.VesselCategories>().ToList();
            Assert.IsTrue(list2.Count > 0);
            unitOfWorkTUFMAN.Rollback();

            var xa = unitOfWorkIMS.Session.BeginTransaction();
            foreach (TUFMAN.Domain.Ves.VesselCategories vesselCategory in list2)
            {
                repoIMS.SaveOrUpdate(vesselCategory);
            }
            xa.Commit();

            List<TUFMAN.Domain.Ves.VesselCategories> list1 = repoIMS.GetAll<TUFMAN.Domain.Ves.VesselCategories>().ToList();
            Assert.IsTrue(list1.Count > 0);
            unitOfWorkIMS.Rollback();
        }
    }
}
