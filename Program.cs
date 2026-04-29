using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var html = @"
    <!DOCTYPE html>
    <html>
    <head>
        <title>Meu Primeiro Site em C#</title>
        <style>
            body {
                background-color: #0f172a;
                color: white;
                display: flex;
                justify-content: center;
                align-items: center;
                height: 100vh;
                font-family: Arial;
            }
            h1 {
                font-size: 40px;
                color: #38bdf8;
            }
        </style>
    </head>
    <body>
        <h1>Esse é o meu primeiro site em C# 🚀</h1>
    </body>
    </html>";

    return Results.Content(html, "text/html");
});

app.Run();
