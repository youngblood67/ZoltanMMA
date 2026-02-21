using StructureAnalyzer.Cli.Services;

try
{
    // Si aucun argument → on analyse le dossier courant
    var rootPath = args.Length > 0
        ? Path.GetFullPath(args[0])
        : Directory.GetCurrentDirectory();

    var generator = new DirectoryTreeGenerator();
    var tree = generator.Generate(rootPath);

    Console.WriteLine(tree);

    var outputPath = Path.Combine(rootPath, "structure.txt");
    File.WriteAllText(outputPath, tree);

    Console.WriteLine($"Structure exportée vers : {outputPath}");
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Erreur : {ex.Message}");
    Console.ResetColor();
}