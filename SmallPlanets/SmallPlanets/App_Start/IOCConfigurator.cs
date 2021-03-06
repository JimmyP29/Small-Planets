﻿using Microsoft.Practices.Unity;
using SmallPlanets.DAL;
using SmallPlanets.DAL.Interfaces;
using SmallPlanets.Infrastructure;
using SmallPlanets.Interfaces;
using SmallPlanets.Services;
using System.Web.Mvc;

namespace SmallPlanets.App_Start
{
    public static class IOCConfigurator
    {
        public static void ConfigureUnityContainer()
        {
            IUnityContainer container = new UnityContainer();
            RegisterServices(container);
            RegisterRepositories(container);
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<IAPIConsumer, APIConsumerService>();
            container.RegisterType<ISolarSystem, SolarSystemService>();
        }

        private static void RegisterRepositories(IUnityContainer container)
        {
            container.RegisterType<ILogRepository, LogRepository>();
        }
    }
}