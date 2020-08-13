[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Interparking.WeppApp.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Interparking.WeppApp.App_Start.NinjectWebCommon), "Stop")]

namespace Interparking.WeppApp.App_Start
{
    using System;
    using System.Collections.Generic;
    using System.Web;
    using Interparking.DAL.Abstraction;
    using Interparking.DAL.Concrete;
    using Interparking.DAL.Model;
    using Interparking.WeppApp.Automapper;
    using Interparking.WeppApp.Command;
    using Interparking.WeppApp.Query;
    using MediatR;
    using MediatR.Ninject;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Extensions.Conventions;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using WebGrease.Css.ImageAssemblyAnalysis;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUserRepository>().To<UserRepository>();
            kernel.Bind<IRouteRepository>().To<RouteRepository>();
            kernel.Bind<IParkingRepository>().To<ParkingRepository>();




            kernel.BindMediatR();
            kernel.Bind<IRequestHandler<CreateRouteCommand, bool>>().To<CreateRouteCommandHandler>();
            kernel.Bind<IRequestHandler<CreateUserCommand, bool>>().To<CreateUserCommandHandler>();
            kernel.Bind<IRequestHandler<GetRoutesByUserIdQuery, List<RouteModel>>>().To<GetRoutesByUserIdHandler>();
            kernel.Bind<IRequestHandler<GetRouteByRouteIDQuery, RouteModel>>().To<GetRouteByRouteIDQueryHandler>();
            kernel.Load<AutoMapperModule>();
        }        
    }
}