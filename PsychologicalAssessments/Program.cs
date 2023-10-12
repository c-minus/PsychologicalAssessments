using PsychologicalAssessments.Services.Clipboard;
using PsychologicalAssessments.Services.ConnersSelfEvaluation;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.DataSeed;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Adhd;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.AdhdConners3;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Disorder;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.Inconsistency;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Indexes.PiAndNi;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Profiles;
using PsychologicalAssessments.Services.ConnersSelfEvaluation.Result;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<IDataSeed, FileDataSeed>();
builder.Services.AddSingleton<IConnersSelfEvaluationService, ConnersSelfEvaluationService>();
builder.Services.AddSingleton<ICategoryTypeFactory, CategoryTypeFactory>();
builder.Services.AddSingleton<IScoringTypeFactory, ScoringTypeFactory>();
builder.Services.AddSingleton<IInconsistencyIndexCalculator, InconsistencyIndexCalculator>();
builder.Services.AddSingleton<IPiAndNiIndexCalculator, PiAndNiIndexCalculator>();
builder.Services.AddScoped<IClipboardService, ClipboardService>();
builder.Services.AddSingleton<IAdhdHyperActiveIndex, AdhdHyperActiveCalculator>();
builder.Services.AddSingleton<IAdhdInattentiveIndex, AdhdInattentiveCalculator>();
builder.Services.AddSingleton<IBehaviorDisorderIndex, BehaviorDisorderIndex>();
builder.Services.AddSingleton<IOppositionDisorderIndex, OppositionDisorderIndex>();
builder.Services.AddSingleton<IAdhdConners3Calculator, AdhdConners3Calculator>();
builder.Services.AddSingleton<IProfileFactory, ProfileFactory>();
builder.Services.AddSingleton<IResultCalculator, ResultCalculator>();

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