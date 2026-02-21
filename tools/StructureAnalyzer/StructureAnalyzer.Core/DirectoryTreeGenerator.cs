using System.Text;

namespace StructureAnalyzer.Cli.Services;

public class DirectoryTreeGenerator
{
    private readonly HashSet<string> _ignoredFolders;

    public DirectoryTreeGenerator(IEnumerable<string>? ignoredFolders = null)
    {
        _ignoredFolders = new HashSet<string>(
            ignoredFolders ?? new[]
            {
                "bin",
                "obj",
                ".git",
                ".vs",
                "node_modules",
                "TestResults"
            },
            StringComparer.OrdinalIgnoreCase
        );
    }

    public string Generate(string rootPath)
    {
        if (!Directory.Exists(rootPath))
            throw new DirectoryNotFoundException($"Path not found: {rootPath}");

        var sb = new StringBuilder();
        var rootDir = new DirectoryInfo(rootPath);

        sb.AppendLine($"📦 {rootDir.Name}");
        ProcessDirectory(rootDir, sb, "");

        return sb.ToString();
    }

    private void ProcessDirectory(DirectoryInfo directory, StringBuilder sb, string indent)
    {
        var directories = directory.GetDirectories()
                                   .Where(d => !_ignoredFolders.Contains(d.Name))
                                   .OrderBy(d => d.Name);

        foreach (var dir in directories)
        {
            sb.AppendLine($"{indent}📁 {dir.Name}");
            ProcessDirectory(dir, sb, indent + "   ");
        }

        var files = directory.GetFiles()
                             .OrderBy(f => f.Name);

        foreach (var file in files)
        {
            sb.AppendLine($"{indent}📄 {file.Name}");
        }
    }
}