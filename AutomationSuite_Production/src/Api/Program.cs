using Core;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IIntentExtractor, OpenAiIntentExtractor>();

var app = builder.Build();

app.MapGet("/health", () => "OK");

app.MapPost("/workflow/run", async (IIntentExtractor ai, string content) =>
{
    var result = await ai.ExtractAsync(content);
    return Results.Ok(result);
});

app.Run();
