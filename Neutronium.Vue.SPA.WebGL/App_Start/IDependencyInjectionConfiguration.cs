using System;
using CommonServiceLocator;

namespace Neutronium.Vue.SPA.WebGL
{
    public interface IDependencyInjectionConfiguration
    {
        Lazy<IServiceLocator> GetServiceLocator();

        void Register<T>(T implementation);
    }
}