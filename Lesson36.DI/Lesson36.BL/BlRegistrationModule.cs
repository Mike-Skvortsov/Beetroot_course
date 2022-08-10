using Autofac;
using Lesson36.BL.Services;
using Lesson36.DataAccess;

namespace Lesson36.BL
{
    public class BlRegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<DataAccessRegistrationModule>();
            builder.RegisterType<CarService>().As<ICarService>();
        }
    }
}