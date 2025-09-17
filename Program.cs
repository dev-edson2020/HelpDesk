using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using HelpDesk;
using HelpDesk.Data;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Componentes raiz
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient padrão (futuro uso com API real)
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

// Banco de dados em memória (AppDb)
builder.Services.AddSingleton<AppDb>();

builder.Services.AddMudServices(); // ✅ registra os serviços do MudBlazor

await builder.Build().RunAsync();