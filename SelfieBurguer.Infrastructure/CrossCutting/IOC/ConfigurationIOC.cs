using Autofac;
using AutoMapper;
using RestApiModeloDDD.Infrastructure.Data.Repositorys;
using SelfieBurguer.Application;
using SelfieBurguer.Application.Interfaces;
using SelfieBurguer.Application.Profiles;
using SelfieBurguer.Domain.Core.Interfaces.Repositories;
using SelfieBurguer.Domain.Core.Interfaces.Services;
using SelfieBurguer.Domain.Services;

namespace SelfieBurguer.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();

            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();

            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new CategoriasProfile());
                cfg.AddProfile(new ClientesProfile());
                cfg.AddProfile(new ComprasProfile());
                cfg.AddProfile(new ProdutosProfile());
                cfg.AddProfile(new PedidosProfile());
                cfg.AddProfile(new UsuariosProfile());

            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();
        }

        #endregion IOC
    }
}