using Autofac;
using Lesson36.DataAccess.Repositories;

namespace Lesson36.DataAccess
{
    public class DataAccessRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LessonDataContext>().AsSelf();
            builder.RegisterType<CarRepository>().As<ICarRepository>();
        }
    }
}