using LaunchDarkly.NetCore.Demo.Interfaces;
using LaunchDarkly.NetCore.Demo.LaunchDarkly;
using LaunchDarkly.NetCore.Demo.Services;
using LaunchDarkly.Sdk.Server;

var builder = WebApplication.CreateBuilder(args);

// Add LaunchDarkly Client
builder.Services.AddSingleton<LdClient>(sp =>
    LaunchDarklyClientProvider.CreateClient(sp.GetRequiredService<IConfiguration>()));

// Add services to the container.
builder.Services.AddScoped<IFeatureFlagService, FeatureFlagService>();
builder.Services.AddScoped<ISampleService, SampleService>();
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

app.Run();
