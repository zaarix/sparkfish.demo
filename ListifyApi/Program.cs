var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/listify", (int begin, int end, int index) => {
    var list = new ListifyLib.Listify(begin, end);
    return list[index];
});

app.Run();
