using Sequor.ApplicationService;
using Sequor.Domain.Interfaces.Repositories;
using Sequor.Domain.Interfaces.Services;
using Sequor.Domain.Services;
using Sequor.Infrastructure.Repositories;
using Sequor.Domain.Services.Cadastro;
using Sequor.Domain.Interfaces.Services.Cadastro;

[assembly: WebActivator.PreApplicationStartMethod(typeof(Sequor.WebMvc.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(Sequor.WebMvc.App_Start.NinjectWebCommon), "Stop")]

namespace Sequor.WebMvc.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using Sequor.ApplicationService.Cadastro;
    using Sequor.ApplicationService.LES.Interfaces;
    using Sequor.ApplicationService.LES.Interfaces.Cadastro;
    using Sequor.Domain;
    using Sequor.Domain.Interfaces;
    using Sequor.Domain.Interfaces.Repositories.Cadastro;
    using Sequor.Domain.Interfaces.Repositories.Recebimento;
    using Sequor.Domain.Interfaces.Services.Cadastro;
    using Sequor.Domain.Services.Cadastro;
    using Sequor.Infrastructure;

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
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));

            kernel.Bind<IClienteAppService>().To<ClienteAppService>();
            kernel.Bind<IWSQOLRECEBIMENTOFOLHAROSTOAppService>().To<WSQOLRECEBIMENTOFOLHAROSTOAppService>();
                        
            kernel.Bind<IClienteService>().To<ClienteService>();
            kernel.Bind<IWSQOLRECEBIMENTOFOLHAROSTOService>().To<WSQOLRECEBIMENTOFOLHAROSTOService>();
                        
            kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            kernel.Bind<IWSQOLRECEBIMENTOFOLHAROSTORepository>().To<WSQOLRECEBIMENTOFOLHAROSTORepository>();

            //kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            //kernel.Bind<IClienteAppService>().To<ClienteAppService>();
            ////kernel.Bind<IProdutoAppService>().To<ProdutoAppService>();

            //kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            //kernel.Bind<IClienteService>().To<ClienteService>();
            ////kernel.Bind<IProdutoService>().To<ProdutoService>();

            //kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            //kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            ////kernel.Bind<IProdutoRepository>().To<ProdutoRepository>();
        }
    }
}
