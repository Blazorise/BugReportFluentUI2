using Blazorise.FluentUI2;
using Blazorise.Icons.FluentUI;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault( args );

AddBlazorise( builder.Services );

await builder.Build().RunAsync();

void AddBlazorise( IServiceCollection services )
{
    services
        .AddBlazorise();
    services
        .AddFluentUI2Providers()
        .AddFluentUIIcons();
}