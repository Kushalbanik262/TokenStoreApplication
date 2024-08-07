using TokenApp.Configuration;
using static TokenApp.Configuration.LoggingConfig;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.configureSerilog();
builder.Services.AddControllers();
builder.Services.AddSingleton(typeof(ILogger), builder.Services.BuildServiceProvider().GetService<ILogger<Microsoft.AspNetCore.Builder.ApplicationBuilder>>());
builder.configureServices();


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

app.Run();
