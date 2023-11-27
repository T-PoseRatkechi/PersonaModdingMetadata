// See https://aka.ms/new-console-template for more information

using PersonaModdingMetadata.CLI.Encounters;
using Serilog;

Console.WriteLine("Hello, World!");

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .MinimumLevel.Debug()
    .CreateLogger();

if (args.Length < 1)
{
    Log.Error("Missing solution directory arg.");
}

var solutionDir = args[0];
Log.Information("Solution Directory: {dir}", solutionDir);

var encountersMetadataDir = Path.Join(solutionDir, "Persona.Encounters.Metadata");
Log.Information("Encounters Metadata Directory: {dir}", encountersMetadataDir);

var encountersMetadata = new EncountersMetadata(encountersMetadataDir);

Log.Information("Generating Encounters Metadata");
encountersMetadata.Generate();
Log.Information("Completed Encounters Metadata");