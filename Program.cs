using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapHub<SampleHub>("/samplehub", options =>
{
    options.Transports = HttpTransportType.WebSockets;
});

app.Run();

public class SampleHub : Hub
{
}
