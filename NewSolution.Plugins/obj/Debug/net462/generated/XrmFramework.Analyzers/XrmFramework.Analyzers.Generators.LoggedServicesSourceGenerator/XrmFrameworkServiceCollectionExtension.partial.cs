#if PLUGIN || CORE_PROJECT
using BoDi;
using XrmFramework;

namespace XrmFramework
{
    partial class InternalDependencyProvider
    {
        static partial void RegisterServices(IObjectContainer container)
        {
            RegisterService<IService, DefaultService, LoggedIService>(container);

        }
    }
}
#endif
#if CORE_PROJECT

namespace Microsoft.Extensions.DependencyInjection
{
    partial class XrmFrameworkServiceCollectionExtension
    {
        static partial void RegisterServices(IServiceCollection serviceCollection)
        {
            RegisterService<IService>(serviceCollection);

        }
    }
}
#endif
