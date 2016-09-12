//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.AspNet.Identity.Owin;
//using NewsPortal.Data.DbContext;
//using NewsPortal.Model.Models;

//namespace NewsPortal.Data.IdentityInfrastructure
//{
//    class AppUserManager : UserManager<ApplicationUser>
//    {
//        public AppUserManager(IUserStore<ApplicationUser> store) : base(store)
//        {
//        }

//        public static AppUserManager Create(IdentityFactoryOptions<AppUserManager> identityFactoryOptions, Microsoft.Owin.IOwinContext owinContext)
//        {
//            NewsPortalContext context = owinContext.Get<NewsPortalContext>();

//            AppUserManager appUserManager = new AppUserManager(new UserStore<ApplicationUser>(context));

//            return appUserManager;
//        }
//    }
//}
