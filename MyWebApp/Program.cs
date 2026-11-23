var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Xin chao! Bai 2: Deploy tu dong ASP.NET Core len Somee thanh cong!");

app.Run();
