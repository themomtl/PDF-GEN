using GenPDF.Data;
using GenPDF.DropBox;
using GenPDF.Exceptions;
using GenPDF.Notes;
using Microsoft.AspNetCore.Mvc;
using PdfGenAPI;
using PdfGenAPI.Data;
using PdfGenAPI.Exceptions;
using PdfGenAPI.Factories;
using PdfGenAPI.Notes;
using PdfGenAPI.Views;
using QuestPDF.Infrastructure;

var builder = WebApplication.CreateBuilder(args);


var allOriginsPolicy = "_allOriginsPolicy";
var HubOnlyPolicy = "_HubOnlyPolicy";

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: allOriginsPolicy,
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        }
    );

    options.AddPolicy(
        name: HubOnlyPolicy,
        policy =>
        {
            policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("...");
        }
    );
});

builder.Services.AddDbContexts(builder.Configuration);
builder.Services.AddScoped<ContextFactory>();
builder.Services.AddScoped<GenMemStream>();
builder.Services.AddScoped<IDropBoxService, DropBoxService>();
builder.Services.AddScoped<IPhqData, PhqData>();
builder.Services.AddScoped<IBimsData, BimsData>();
builder.Services.AddScoped<IEvalProgData, EvalProgData>();
builder.Services.AddScoped<IEvalMemStream, EvalMemStream>();
builder.Services.AddScoped<IProgressNoteMemStream, ProgressNoteMemStream>();
builder.Services.AddScoped<IPhqMemStream, PhqMemStream>();
builder.Services.AddScoped<IBimsMemStream, BimsMemStream>();
builder.Services.AddScoped<IAbsMemStream, AbsMemStream>();
builder.Services.AddScoped<IAimsData, AimsData>();
builder.Services.AddScoped<IAimsMemStream, AimsMemStream>();
builder.Services.AddScoped<IPsychiatryEvalData, PsychiatryEvalData>();
builder.Services.AddScoped<IPsychiatryEvalMemStream, PsychiatryEvalMemStream>();
builder.Services.AddScoped<INoteFactory, NoteFactory>();

var app = builder.Build();

app.UseCors(allOriginsPolicy);

app.MapGet(
        "/api/pdf-gen/{state}/{noteType}/{noteId}",
        async (
            [FromRoute] string state,
            [FromRoute] string noteType,
            [FromRoute] string noteId,
            GenMemStream GenMem
        ) =>
        {
            state = state.ToLower();
            QuestPDF.Settings.License = //Add Licence

            try
            {
                var pdf =
                    await GenMem.Get(state, noteId, noteType)
                    ?? throw new NoteNotFoundExeption("Note not found");
                return Results.File(pdf, "application/pdf");
            }
            catch (NoSignatureException e)
            {
                return Results.Problem($"No Signature - {e}", statusCode: 424);
            }
            catch (NoteNotFoundExeption e)
            {
                return Results.Problem($"note not found - {e}", statusCode: 404);
            }
            catch (Exception e)
            {
                return Results.Problem(e.Message);
            }
        }
    )
    .WithOpenApi();

app.MapGet(
        "/test",
        (HttpContext req) =>
        {
            return StatusCodes.Status200OK;
        }
    )
    .WithOpenApi();

app.Run();
