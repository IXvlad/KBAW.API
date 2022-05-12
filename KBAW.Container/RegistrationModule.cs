using System;
using System.Collections.Generic;
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
            Assembly[] assemblies = GetCustomAssemblies();

            builder.RegisterAssemblyTypes<IScoped>(assemblies, setLifeTime => setLifeTime.InstancePerLifetimeScope());
            builder.RegisterAssemblyTypes<ITransient>(assemblies, setLifeTime => setLifeTime.InstancePerDependency());
            builder.RegisterAssemblyTypes<ISingleton>(assemblies, setLifeTime => setLifeTime.SingleInstance());
        }

        private static Assembly[] GetCustomAssemblies()
        {
            const string prefix = "KBAW.";
            string[] customAssembliesName = { string.Concat(prefix, "Query"), string.Concat(prefix, "DataAccess"), string.Concat(prefix, "Container") };

            foreach (var name in customAssembliesName)
            {
                Assembly.Load(name);
            }
            
            return AppDomain.CurrentDomain.GetAssemblies()
                .Where(ass => ass.FullName != null && ass.FullName.StartsWith(prefix))
                .ToArray();
        }
    }

    internal static class ContainerBuilderExtensions
    {
        internal static void RegisterAssemblyTypes<T>(
            this ContainerBuilder builder, Assembly[] assemblies,
            Action<IRegistrationBuilder<object, ReflectionActivatorData, DynamicRegistrationStyle>> setLifeTime)
        {
            builder.RegisterAssemblyTypes(assemblies)
                .Where(type => typeof(T).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
                .AsImplementedInterfaces()
                .AsSelf()
                .Apply(setLifeTime);

            IEnumerable<TypeInfo> types = assemblies.SelectMany(ass => ass.DefinedTypes)
                .Where(type => !type.IsInterface && !type.IsAbstract && type.IsGenericTypeDefinition &&
                               typeof(T).GetTypeInfo().IsAssignableFrom(type));

            foreach (TypeInfo genericType in types)
            {
                var genericArgumentsNumber = genericType.GenericTypeParameters.Length;

                Type[] genericInterfaces = genericType.ImplementedInterfaces
                    .Select(gi => gi)
                    .Where(gi => gi.GenericTypeArguments.Length == genericArgumentsNumber)
                    .ToArray();

                builder.RegisterGeneric(genericType.AsType())
                    .AsSelf()
                    .As(genericInterfaces)
                    .Apply(setLifeTime);
            }
        }

        private static T Apply<T>(this T obj, Action<T> action)
        {
            action(obj);
            return obj;
        }
    }
}