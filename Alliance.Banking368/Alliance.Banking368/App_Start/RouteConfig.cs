// <copyright file="RouteConfig.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is CardsRepository class.</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Alliance.Banking368
{
    /// <summary>
    /// Class for RouteConfig
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// Method for registrations
        /// </summary>
        /// <param name="routes">routes for project</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}