using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Application.Interfaces;
using Tarker.Booking.Persistence.DataBase;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataBaseService>(options =>
options.UseSqlServer(builder.Configuration["SQLConnectionString"]));

builder.Services.AddScoped<IDataBaseService, DataBaseService>();

var app = builder.Build();

app.MapPost("/createTest", async (IDataBaseService _databaseService) =>
{
    var entity = new Tarker.Booking.Domain.Entities.User.UserEntity
    {
        FirstName = "NameTest",
        LastName = "LastTest",
        UserName = "UserTest",
        Password = "12ii1i11"
    };
    await _databaseService.User.AddAsync(entity);
    await _databaseService.SaveAsync();

    return "Created Ok";
});

app.MapGet("/getTest", async (IDataBaseService _databaseService) =>
{
    var result = await _databaseService.User.ToListAsync();
    return result;
});

app.Run();