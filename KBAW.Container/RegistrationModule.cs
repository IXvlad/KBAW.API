using System;
using System.Linq;
using System.Reflection;
using Autofac;
using Autofac.Builder;
using KBAW.Container.Dependencies;
using Module = Autofac.Module;

namespace KBAW.Container
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies()
                .Where(ass => ass.FullName != null && ass.FullName.StartsWith("TestAutofac"))
                .ToArray();
            
            builder.RegisterAssemblyTypes<IScoped>(assemblies, setLifeTime => setLifeTime.InstancePerLifetimeScope());
            builder.RegisterAssemblyTypes<ITransient>(assemblies, setLifeTime => setLifeTime.InstancePerDependency());
            builder.RegisterAssemblyTypes<ISingleton>(assemblies, setLifeTime => setLifeTime.SingleInstance());
        }
    }
    
    internal static class ContainerBuilderExtensions
    {
        internal static void RegisterAssemblyTypes<T>(
            this ContainerBuilder builder, Assembly[] assemblies, Action<IRegistrationBuilder<object, ReflectionActivatorData, DynamicRegistrationStyle>> setLifeTime)
        {
            builder.RegisterAssemblyTypes(assemblies)
                .Where(type => typeof(T).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
                .AsImplementedInterfaces()
                .AsSelf()
                .Apply(setLifeTime);
        }

        private static T Apply<T>(this T obj, Action<T> action)
        {
            action(obj);
            return obj;
        }
    }
}