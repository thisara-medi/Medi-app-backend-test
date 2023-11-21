using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using PMS.Endpoints.Mappings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Text;
using UnitOfWorkDemo.Infrastructure.ServiceExtension;
using UnitOfWorkDemo.Services;
using UnitOfWorkDemo.Services.Interfaces;
using PMS.Services.AuthenticationService;
using PMS.Services;
using UnitOfWorkDemo.Core.Interfaces;
using PMS.Endpoints.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Configuration
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();
var jwtSettings = configuration.GetSection("jwtSettings");

// Services
builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));

builder.Services.AddDIServices(builder.Configuration);

builder.Services.AddScoped<IPatientService, PatientService>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IPatientRecordService, PatientRecordService>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<TokenService>(provider =>
{
    var unitOfWork = provider.GetRequiredService<IUnitOfWork>();
    var defaultIssuer = jwtSettings["Issuer"];
    var defaultAudience = jwtSettings["Audience"];

    return new TokenService(unitOfWork, defaultIssuer, defaultAudience);
});
builder.Services.AddControllers();
// Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings["Issuer"],
            ValidAudience = jwtSettings["Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["SecretKey"]))
        };
    });
builder.Services.AddAuthorization();
builder.Services.AddSwaggerGen();
// Application
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyPolicy");
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
