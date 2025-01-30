using System;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using BlazorApiEf.Data;

public class UserDbContextFactory : IDesignTimeDbContextFactory<UserDbContext>
{
    public UserDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<UserDbContext>();

        optionsBuilder.UseSqlite("Data Source=BlazorApiEf_Task.db"); // Connection for Database
        return new UserDbContext(optionsBuilder.Options);
    }
}