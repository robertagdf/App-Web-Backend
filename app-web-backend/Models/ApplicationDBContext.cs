namespace app_web_backend.Models
{
    public class ApplicationDBContext : DbContetx
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options) 
        
        { 
        }   
    }
}
