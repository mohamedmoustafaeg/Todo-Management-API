using System;
using TodoApp.Models;

namespace TodoApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Todos.Any())
            {
                return; // DB has been seeded
            }

            var todos = new Todo[]
            {
                new Todo{Title="Learn ASP.NET Core", Description="Complete the tutorial", Status=TodoStatus.Pending, Priority=PriorityLevel.High, DueDate=DateTime.Now.AddDays(7)},
                new Todo{Title="Build a Todo App", Description="Implement all CRUD operations", Status=TodoStatus.InProgress, Priority=PriorityLevel.High},
                new Todo{Title="Deploy to Azure", Description="Publish the application", Status=TodoStatus.Pending, Priority=PriorityLevel.Medium},
                new Todo{Title="Write documentation", Status=TodoStatus.Completed, Priority=PriorityLevel.Low}
            };

            context.Todos.AddRange(todos);
            context.SaveChanges();
        }
    }
}