using System.IO;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.Run(async (HttpContext context) =>
{
    //context.Response.Headers["MyKey"] = "my value";
    //context.Response.Headers["Mykey2"] = "valore key2";
    //context.Response.Headers.Add("Mykey2", "valore key2");

    //context.Response.Headers.Server = "My server";

    //context.Response.ContentType = "application/json";
    //se voglio visualizzare l'html devo impostare un contetnType adatto
    //non application/json ma text/html

    //string path = context.Request.Path;

    context.Response.ContentType = "text/html";
    //if (context.Request.Method == "GET")
    //{
    //    if (context.Request.Query.ContainsKey("id"))
    //    {
    //        string id = context.Request.Query["id"];
    //        await context.Response.WriteAsync($"<h1>{id}</h1>");

    //    }
    //}

    if (context.Request.Headers.ContainsKey("User-Agent"))
    {
        string userAgent = context.Request.Headers["User-Agent"];
        await context.Response.WriteAsync($"<h1>{userAgent}</h1>");
    }

    await context.Response.WriteAsync($"<h1>Hello</h1>");
    await context.Response.WriteAsync(" <h2>Money</h2>");
});

app.Run();
