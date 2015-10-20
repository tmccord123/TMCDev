﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMC.Web;
using TMC.Web.Controllers;

namespace TMC.Web.Tests.Controllers
{
    using System.Threading.Tasks;

    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            Task<ActionResult> result = controller.Index("Test") as Task<ActionResult>;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
