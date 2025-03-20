using System.Net.Quic;
using Microsoft.Extensions.FileProviders;
using WebApplication3.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDirectoryBrowser();
var myPolicy = "CorsPolicy";
builder.Services.AddCors(options =>
{
    var allowedOrigins = new string[] {"*" };
    var allowedMethods = new string[] {"GET","POST" };
options.AddPolicy(myPolicy, builder => builder.WithOrigins(allowedOrigins).WithMethods(allowedMethods));
});

builder.Services.AddSingleton<ProjectRepository>();
builder.Services.AddSingleton<UserRepository>();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseCors(myPolicy);
app.MapControllers();
app.UseStaticFiles();
app.Run();

