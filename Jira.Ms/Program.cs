using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var env = builder.Environment;

var config = builder.Configuration;
var services = builder.Services;

config.SetBasePath(AppDomain.CurrentDomain.BaseDirectory);
config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

/// register services
services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
});



/// set db context
//var dbconnectionstring = config.GetConnectionString("DefaultConnection");
//services.AddDbContextPool<JiraContext>(options =>
//{
//    options.UseMySql(dbconnectionstring, ServerVersion.AutoDetect(dbconnectionstring));
//});

//IServiceProvider serviceProvider = services.BuildServiceProvider();

//var jiracontext = serviceProvider.GetRequiredService<JiraContext>();
//jiracontext.Database.Migrate();



var app = builder.Build();


/// add middlewares
if (app.Environment.IsDevelopment())
{
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
