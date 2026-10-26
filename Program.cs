
using Microsoft.EntityFrameworkCore;
using PolyLearnAI.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Đăng ký các dịch vụ
builder.Services.AddRazorPages();
builder.Services.AddControllers();

// Kết nối database PolyLearnAI
builder.Services.AddDbContext<PolyLearnDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

builder.Services.AddCors(options =>
{
    options.AddPolicy("PolyLearnDev", policy =>
    {
        policy.WithOrigins("http://127.0.0.1:5500")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Cấu hình HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// Kích hoạt Razor Pages và Web API
app.MapRazorPages();

app.UseCors("PolyLearnDev");

app.MapControllers();

app.Run();
