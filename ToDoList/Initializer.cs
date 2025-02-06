using ToDoList.DAL.Interfaces;
using ToDoList.DAL.Repositories;
using ToDoList.Domain.Entity;

namespace ToDoList
{
    public static class Initializer
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<TaskEntity>, TaskRepository>();
        }
    }
}
