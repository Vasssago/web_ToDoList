using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using web_ToDoList.Areas.Identity.Data;
using web_ToDoList.Models;

namespace web_ToDoList.Data;

public class web_ToDoListDbContext : IdentityDbContext<ApplicationUser>
{
    public web_ToDoListDbContext(DbContextOptions<web_ToDoListDbContext> options)
        : base(options)
    {
        //Database.EnsureCreated();
    }

    public DbSet<ToDoItem> ToDoItems { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
