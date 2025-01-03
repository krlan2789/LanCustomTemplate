using Microsoft.EntityFrameworkCore;

namespace CustomTemplate.API.Data;

public static class DataExtensions
{
    public static async Task MigrateDbAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        await scope.ServiceProvider.GetRequiredService<CustomTemplateDatabaseContext>().Database.MigrateAsync();
    }
}
