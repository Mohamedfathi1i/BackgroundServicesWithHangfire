using BackgroundServicesWithHangfire;
using DALHangfire;
using PLHangfire;
using Hangfire;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDALServices(builder.Configuration);
builder.Services.AddPLServices(builder.Configuration);
builder.Services.AddHangfire((sp,config) =>
{
    var connectionString = sp.GetRequiredService<IConfiguration>().GetConnectionString("DbConnection");
    config.UseSqlServerStorage(connectionString);
});
builder.Services.AddHangfireServer();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHangfireDashboard("/Dashboard");
app.MapHangfireDashboard();
app.UseAuthorization();

app.MapControllers();
HangFireRecurring.hangFireConfigJobs();
app.Run();
