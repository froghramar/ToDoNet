using Microsoft.EntityFrameworkCore;

namespace ToDoNet;

public class ToDoContext : DbContext
{
    public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
    {
    }

    public DbSet<ToDoItem> ToDoItems { get; set; }
}