using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuizMania.Startup))]
namespace QuizMania
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
