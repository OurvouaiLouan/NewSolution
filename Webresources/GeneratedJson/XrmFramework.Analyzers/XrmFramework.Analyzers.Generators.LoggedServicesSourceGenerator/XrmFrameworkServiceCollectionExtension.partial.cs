#if PLUGIN || CORE_PROJECT
using BoDi;

namespace XrmFramework
{
    partial class InternalDependencyProvider
    {
        static partial void RegisterServices(IObjectContainer container)
        {
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
        }
    }
}
#endif
