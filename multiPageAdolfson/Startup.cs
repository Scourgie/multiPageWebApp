using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using multiPageAdolfson.Models;

namespace multiPageAdolfson
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ContactContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ContactContext")));
        }
    }
}
