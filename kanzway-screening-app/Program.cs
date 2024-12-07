using log4net.Config;
using log4net;
using kanzway_screening_app;

var builder = WebApplication.CreateBuilder(args);

// Configure log4net
var loggerRepository = LogManager.GetRepository(System.Reflection.Assembly.GetEntryAssembly());
XmlConfigurator.Configure(loggerRepository, new FileInfo("log4net.config"));

// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();


log4net.Config.XmlConfigurator.Configure();
logger.log.Info("Application is starting...");
app.Run();