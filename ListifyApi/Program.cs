var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/listify", (int begin, int end, int index) =>
{
    if (begin >= end)
        return Results.BadRequest(new { message = "end must be greater than begin" });

    if (index < 0 || index > (end - begin))
        return Results.BadRequest(new { message = "index out of range"});

    var list = new ListifyLib.Listify(begin, end);
    return Results.Ok(new { value = list[index] });
});

app.Run();
