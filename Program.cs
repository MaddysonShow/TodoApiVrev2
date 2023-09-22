using Microsoft.EntityFrameworkCore;
using System;
using TitaniumAS.Opc.Client.Common;
using TitaniumAS.Opc.Client.Da;
using TodoApi;
using TodoApi.Models;


var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseHttpsRedirection();
object a = null;
//app.UseAuthorization();
/////////////////////////////////////////////////
app.MapGet("/api/auth" , () => { return Results.Json("AuthPassed"); });
// Путь авторизации на всякий

app.MapGet("/api/todoitems", () => a);

app.MapPost("/api/todoitems", () => {
   a = TodoItem.sql();
   Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyyHH:mm") + "Zapros");
 return a;
});

app.Run();

//////////////////////////////






