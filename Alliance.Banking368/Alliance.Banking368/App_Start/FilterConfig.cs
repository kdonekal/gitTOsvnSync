// <copyright file="FilterConfig.cs" company="AGS">
// Copyright (c) 2015 All Rights Reserved
// </copyright>
// <summary> This is FilterConfig class.</summary>
using System.Web;
using System.Web.Mvc;

namespace Alliance.Banking368
{
    /// <summary>
    /// Class for FilterConfig
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// Method for registrations
        /// </summary>
        /// <param name="filters">Global filters collection</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}