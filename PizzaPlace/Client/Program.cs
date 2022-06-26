using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PizzaPlace.Client;
using PizzaPlace.Client.Services;
using PizzaPlace.Shared;
using Syncfusion.Blazor;
using BlazorStyled;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
builder.Services.AddSyncfusionBlazor();
builder.Services.AddBlazorStyled();
builder.Services
    .AddTransient<IMenuService, MenuService>();
builder.Services
    .AddTransient<IOrderService,OrderService>();
await builder.Build().RunAsync();
