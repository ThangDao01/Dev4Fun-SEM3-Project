using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Dev4Fun_Sem3_eProject.Data;
using Dev4Fun_Sem3_eProject.Models;
using Dev4Fun_Sem3_eProject.Settings;
using Dev4Fun_Sem3_eProject.Services;

var builder = WebApplication.CreateBuilder(args);
var myAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddDbContext<Dev4Fun_Sem3_eProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Dev4Fun_Sem3_eProjectContext")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddTransient<IMailService, MailService>();
builder.Services.AddTransient<DataSeeder>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins,
        builder =>
        {
            builder.WithOrigins("http://localhost:3000")
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});
var app = builder.Build();


if (args.Length == 1 && args[0].ToLower() == "dataseeder")
    {
    DataSeeder(app);
    }
void DataSeeder(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var survice = scope.ServiceProvider.GetService<DataSeeder>();
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(myAllowSpecificOrigins);

app.MapControllers();

app.Run();
