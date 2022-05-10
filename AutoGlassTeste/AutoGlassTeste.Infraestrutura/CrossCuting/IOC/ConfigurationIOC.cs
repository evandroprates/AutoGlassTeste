using Autofac;
using AutoGlassTeste.Application;
using AutoGlassTeste.Application.Interfaces;
using AutoGlassTeste.Domain.Core.Interfaces.Repository;
using AutoGlassTeste.Domain.Core.Interfaces.Services;
using AutoGlassTeste.Domain.Service;
using AutoGlassTeste.Infraestrutura.Data.Repositorys;
using AutoMapper;
using DotNetOpenAuth.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGlassTeste.Infraestrutura.CrossCuting
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();
            //builder.RegisterType<MapperProduto>().As<Profile>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();

            #endregion
        }
    }
}
