using System.Reflection;
using System.Web.Mvc;
using Common.Logging;
using Data.Contracts;
using Data.Memory;
using Domain.DefaultImpl;
using Domain.Impl.Nz;
using Domain.Services;
using Infonetica.ContactApp.UI.Web.App_Start;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;

[assembly: WebActivator.PreApplicationStartMethod(typeof(SimpleInjectorInitializer), "Initialize")]

namespace Infonetica.ContactApp.UI.Web.App_Start
{
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.RegisterMvcAttributeFilterProvider();
       
            // Using Entity Framework? Please read this: http://simpleinjector.codeplex.com/discussions/363935
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {
            // Please note that if you updated the SimpleInjector.MVC3 package from a previous version, this
            // SimpleInjectorInitializer class replaces the previous SimpleInjectorMVC3 class. You should
            // move the registrations from the old SimpleInjectorMVC3.InitializeContainer to this method,
            // and remove the SimpleInjectorMVC3 and SimpleInjectorMVC3Extensions class from the App_Start
            // folder.

           container.Register<IContactLister, ContactLister>();
            container.Register<IContactStore, MemoryContactStore>();
            container.Register<ILog, NoLogging>();
        }
    }
}