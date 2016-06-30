using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using System.Web.Routing;
using Microsoft.Practices.Unity.Utility;
using Zxxk.Gkbb.Web.Controllers;

namespace Zxxk.Gkbb.Web
{
    public class UnityControllerFactory: DefaultControllerFactory
    {
        public IUnityContainer Container { get; private set; }
        public UnityControllerFactory(string containerName = "")
        {
            IUnityContainer container = new UnityContainer();
            UnityConfigurationSection configSection = ConfigurationManager.GetSection(UnityConfigurationSection.SectionName) as UnityConfigurationSection;
            if (null == configSection && !string.IsNullOrEmpty(containerName))
            {
                throw new ConfigurationErrorsException("Cannot find <unity> configuration section");
            }

            if (string.IsNullOrEmpty(containerName))
            {
                configSection.Configure(container);
            }
            else
            {
                configSection.Configure(container, containerName);
            }
            this.Container = container;
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
                return null;
            Guard.ArgumentNotNull(controllerType, "controllerType");
            return (IController)this.Container.Resolve(controllerType);
        }
    }
}