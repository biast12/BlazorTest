using BlazorTest.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient("DefaultClient", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["BaseURL"] ?? "https://localhost:5002/");
});

builder.Services.AddHttpClient("ApexSkinsTranslatorClient", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ApexSkinsTranslator"] ?? "https://api.biast12.site/");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();