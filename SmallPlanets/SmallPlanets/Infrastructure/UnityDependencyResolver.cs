using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SmallPlanets.Infrastructure
{
    public class UnityDependencyResolver : IDependencyResolver
    {
        private readonly IUnityContainer _unityContainer;

        public UnityDependencyResolver(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
        }
        public object GetService(Type serviceType)
        {
            try
            {
                return _unityContainer.Resolve(serviceType);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _unityContainer.ResolveAll(serviceType);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}