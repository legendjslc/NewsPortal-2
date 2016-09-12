//using Microsoft.Owin;
//using NewsPortal.Data.DbContext;
//using NewsPortal.Data.IdentityInfrastructure;
//using Owin;

//[assembly: OwinStartup(typeof(NewsPortal.Data.infrastructure.Startup))]

//namespace NewsPortal.Data.infrastructure
//{
//    public class Startup
//    {
//        public void Configuration(IAppBuilder app)
//        {
//            app.CreatePerOwinContext<NewsPortalContext>(() => new NewsPortalContext());

//            app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);


//            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
//        }
//    }
//}
