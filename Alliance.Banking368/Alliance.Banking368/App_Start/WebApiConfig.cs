// <copyright file="WebApiConfig.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is WebApiConfig class.</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Alliance.Banking368
{
    /// <summary>
    /// Class for WebApiConfig
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Method for registrations
        /// </summary>
        /// <param name="config">Configurations of the project</param>
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
