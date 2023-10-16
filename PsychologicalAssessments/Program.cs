using BlazorDownloadFile;
using ElectronNET.API;
using PsychologicalAssessments.Orchestrator.DataOutput;
using PsychologicalAssessments.Orchestrator.DataSeed;
using PsychologicalAssessments.Orchestrator.Dependencies;
using PsychologicalAssessments.Orchestrator.Service;
using PsychologicalAssessments.Orchestrator.Tresult;
using PsychologicalAssessments.Services.Clipboard;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddElectron();
builder.WebHost.UseElectron(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazorDownloadFile();
builder.Services.AddSingleton<IOrchestratorService, OrchestratorService>();
builder.Services.AddSingleton<IDependenciesFactory, DependenciesFactory>();
builder.Services.AddSingleton<IDataSeed, FileDataSeed>();
builder.Services.AddScoped<IClipboardService, ClipboardService>();
builder.Services.AddSingleton<ITresultCalculator, TresultCalculator>();
builder.Services.AddSingleton<IDataOutput, DataOutputExcel>();

if (HybridSupport.IsElectronActive)
{
    // Open the Electron-Window here
    Task.Run(async () => {
        var window = await Electron.WindowManager.CreateWindowAsync();
    });
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();