namespace Git
{
    using Git.Data;
    using Microsoft.EntityFrameworkCore;
    using MyWebServer;
    using MyWebServer.Controllers;
    using MyWebServer.Results.Views;
    using System.Threading.Tasks;

    public class Startup
    {
        public static async Task Main()
            => await HttpServer
                .WithRoutes(routes => routes
                    .MapStaticFiles()
                    .MapControllers())
                .WithServices(services => services
                    .Add<GitDbContext>()
                    .Add<IViewEngine, CompilationViewEngine>())
                .WithConfiguration<GitDbContext>(context => context
                    .Database.Migrate())
                .Start();
    }
}
