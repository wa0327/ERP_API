﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ErpApi.Data;
using ErpApi.Data.Common;

namespace ErpApi.Services
{
    [TestClass]
    public class UserServiceTest
    {
        private IDaoFactory factory;

        [TestInitialize]
        public void TestInitialize()
        {
            this.factory = new CommonDaoFactory();
        }

        [TestMethod]
        public void GetProfile_backyardId_jacktsai()
        {
            IUserService target = new UserService(this.factory);
            var actual = target.GetProfile("jacktsai");

            Assert.IsNotNull(actual);
            Assert.IsNotNull(actual.User);
            Assert.AreEqual(2733, actual.User.Id);
            Assert.AreEqual("jacktsai", actual.User.Name);
            Assert.AreEqual("Jack Tsai", actual.User.FullName);
            Assert.AreEqual("研發", actual.User.Department);
            Assert.AreEqual(0, actual.User.Degree);
            Assert.AreEqual("/privilege/homepages/erp.asp", actual.User.Homepage);
            Assert.AreEqual("3628", actual.User.ExtNumber);
            Assert.AreEqual("jacktsai", actual.User.BackyardId);
            Assert.IsNotNull(actual.SubCatIds);
            Assert.AreEqual(2, actual.SubCatIds.Count());
            Assert.AreEqual(25, actual.SubCatIds.ElementAt(0));
            Assert.AreEqual(39, actual.SubCatIds.ElementAt(1));
        }

        [TestMethod]
        public void GetProfile_backyardId_kevin113()
        {
            IUserService target = new UserService(this.factory);
            var actual = target.GetProfile("kevin113");

            Assert.IsNotNull(actual);
            Assert.IsNotNull(actual.User);
            Assert.AreEqual(2121, actual.User.Id);
            Assert.AreEqual("kevincheng", actual.User.Name);
            Assert.AreEqual("鄭凱文", actual.User.FullName);
            Assert.AreEqual("研發", actual.User.Department);
            Assert.AreEqual(0, actual.User.Degree);
            Assert.AreEqual("/privilege/homepages/ERP.asp", actual.User.Homepage);
            Assert.AreEqual("151", actual.User.ExtNumber);
            Assert.AreEqual("kevin113", actual.User.BackyardId);
            Assert.IsNotNull(actual.SubCatIds);
            Assert.AreEqual(0, actual.SubCatIds.Count());
        }
    }
}