// <copyright file="HomeController.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is HomeController class.</summary>
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Alliance.Banking368.Data.Context;
namespace Alliance.Banking368.Controllers
{
    /// <summary>
    /// Controller class to generate and display View using Model class
    /// </summary>
    public class HomeController : Controller
    {
       /// <summary>
       /// Method to get view
       /// </summary>
       /// <returns>returns a view</returns>
        public ActionResult Index()
        {
            return this.View();
        }
        /// <summary>
        /// Method to get AccountSummary View
        /// </summary>
        /// <returns>returns a view</returns>
        public ActionResult AccountSummary()
        {
            return this.View();
        }
        /// <summary>
        /// Method to get MiniStatement View
        /// </summary>
        /// <returns>returns a view</returns>
        public ActionResult MiniStatement()
        {
            return this.View();
        }
        /// <summary>
        /// Method to get Logout View
        /// </summary>
        /// <returns>returns a view</returns>
        public ActionResult Logout()
        {
            return this.View();
        }
    }
}
