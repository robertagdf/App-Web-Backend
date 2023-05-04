namespace app_web_backend
{
    public class StartupBase
    {

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services, sevices.AddDbContext<ApplicationDbContext> options)
        {
            sevices.AddDbContext<ApplicationDbContext> options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")
                );

            services.AddControllersWithViews();
        }
    }
}