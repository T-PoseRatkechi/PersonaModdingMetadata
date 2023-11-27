// See https://aka.ms/new-console-template for more information

using PersonaModdingMetadata.CLI.Encounters;

Console.WriteLine("Hello, World!");
var solutionDir = args[0];
var encountersMetadataDir = Path.Join(solutionDir, "Persona.Encounters.Metadata");
var encountersMetadata = new EncountersMetadata(encountersMetadataDir);
encountersMetadata.Generate();