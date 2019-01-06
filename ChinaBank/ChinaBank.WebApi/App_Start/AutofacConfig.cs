using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChinaBank.WebApi.App_Start
{
    using System.Reflection;
    using Autofac.Integration.WebApi;
    using Autofac.Integration.Mvc;
    using Autofac;
    using IService;
    using ChinaBank.Service;
    using System.Web.Http;
    using System.Web.Mvc;
    
    public class AutofacConfig
    {
        /// <summary>
        /// 项目初始化，实例化IOC容器
        /// </summary>
        public static void Register()
        {
            var builder = new ContainerBuilder();
            SetupResolveRoles(builder);
            
            
            //注册所有的ApiControllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            var container = builder.Build();
            //注册api容器需要使用HttpConfiguration对象
            HttpConfiguration config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
        /// <summary>
        /// 将实现类与接口注入到IOC容器中
        /// </summary>
        /// <param name="containerBuilder"></param>
        public static void SetupResolveRoles(ContainerBuilder containerBuilder)
        {
            // 格式为：  containerBuilder.RegisterType<实体dal层>().As<接口层>();
            containerBuilder.RegisterType<Demo>().As<IDemo>();
        }
    }
}