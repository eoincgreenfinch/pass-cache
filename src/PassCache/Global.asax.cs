﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="N/A">
//   Public domain
// </copyright>
// <summary>
//   The application.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PassCache
{
    using System.Web.Optimization;
    using System.Web.Routing;

    /// <summary>
    /// The application.
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// The entry method.
        /// </summary>
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundlesConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}