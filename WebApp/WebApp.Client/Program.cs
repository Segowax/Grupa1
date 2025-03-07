using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebApp.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("nieWiem", opt => {
    opt.BaseAddress = new Uri("https://my-wonderful-api-acgvdvaaa5d4b9ez.northeurope-01.azurewebsites.net");
});
builder.Services.AddHttpClient("api", opt => {
    opt.BaseAddress = new Uri("https://localhost:7071");
});

await builder.Build().RunAsync();
