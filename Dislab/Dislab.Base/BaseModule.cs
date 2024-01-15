using Autofac;
using Dislab.Base.Data;
using Dislab.Base.DbContexts;
using Dislab.Base.Features.Questions.Domain;
using Dislab.Base.Services;

namespace Dislab.Base
{
    public class BaseModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public BaseModule(string connectionString,
            string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<DapperContext>().As<IDapperContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AskQuestionRepository>().As<IAskQuestionRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AskQuestionService>().As<IAskQuestionService>()
              .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
