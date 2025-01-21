var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add YARP services
var proxy = builder.Configuration.GetSection("ReverseProxy");
builder.Services.AddReverseProxy()
    .LoadFromConfig(proxy);

// Add additional services like logging, authentication, etc.
builder.Services.AddLogging();
var app = builder.Build();
// Use YARP middleware to handle proxy requests
app.MapReverseProxy();
app.UseHttpsRedirection();

app.MapControllers();
app.Run();
