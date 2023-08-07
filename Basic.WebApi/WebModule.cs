using Autofac;
using Basic.WebApi.Model;

namespace Basic.WebApi
{
    //  Autofac Dependency Injection
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // builder.RegisterType<CourseModel>.As<ICourseModel>().In
            builder.RegisterType<Course>().As<ICourse>().InstancePerLifetimeScope();
            
            base.Load(builder);
        }
    }
}
