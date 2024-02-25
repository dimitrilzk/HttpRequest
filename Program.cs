var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.Run(async (HttpContext context) =>
{
    context.Response.Headers["MyKey"] = "my value";
    context.Response.Headers["Mykey2"] = "valore key2";
    //context.Response.Headers.Add("Mykey2", "valore key2");

    context.Response.Headers.Server = "My server";

    //context.Response.ContentType = "application/json";
    //se voglio visualizzare l'html devo impostare un contetnType adatto
    //non application/json ma text/html
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync("<h1>More</h1>");
    await context.Response.WriteAsync(" <h2>Money</h2>");
});

app.Run();
