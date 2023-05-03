namespace app_web_backend.Models
{
    public class DbContetx
    {
        private DbContextOptions<ApplicationDBContext> options;

        public DbContetx(DbContextOptions<ApplicationDBContext> options)
        {
            this.options = options;
        }
    }
}