using KUSYS_Demo.Application.Settings;
using KUSYS_Demo.Domain.Authentication;
using KUSYS_Demo.Infrastructure;
using KUSYS_Demo.Infrastructure.Contracts.Repository.Commons;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
// Add services to the container.
#region Settings



services.Configure<JwtSettings>(builder.Configuration.GetSection("JWT"));
var jwt = builder.Configuration.GetSection("JWT").Get<JwtSettings>();
#endregion

builder.Services.AddIdentity<User, Role>(options =>
 {
     options.Password.RequiredLength = 8;
     options.Password.RequireNonAlphanumeric = true;
     options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1d);
     options.Lockout.MaxFailedAccessAttempts = 5;

 }).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
builder.Services.AddInfrastructureService();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
