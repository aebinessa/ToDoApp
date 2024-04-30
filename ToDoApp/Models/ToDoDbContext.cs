using Microsoft.EntityFrameworkCore;
namespace ToDoApp.Models
{
    public class ToDoDbContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        { 
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>().HasData(new List<ToDoItem>{
             new ToDoItem{ Description = "Complete all Coded Assignments", Id = 4, DueDate = new DateTime(2024,04,30), IsCompleted = false},
             new ToDoItem{ Description = "Appartment Rent", IsCompleted = true, Id = 5, DueDate = new DateTime(2024,04,30)},
             new ToDoItem{ Description = "Clean My Room", IsCompleted = false, Id = 6,DueDate = new DateTime(2024,04,30) }
             });
            base.OnModelCreating(modelBuilder);


        }

    }
}
