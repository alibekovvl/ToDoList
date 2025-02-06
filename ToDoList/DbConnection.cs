using Microsoft.EntityFrameworkCore;
using ToDoList.DAL;

namespace ToDoList
{
    public static class DbConnection
    {
        public static void ConfigureDatabase(this IServiceCollection service, string connectionString)
        {
            service.AddDbContext<AppDbContext>(options => {
                options.UseNpgsql(connectionString);
            });
        }
    }
}
