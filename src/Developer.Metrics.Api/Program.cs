using Developer.Metrics.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapWebhookEndpoint();
app.MapGet("/", () => "Hello World!");

app.Run();

public partial class Program { }