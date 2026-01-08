using System.Collections.Generic;
using DiveLogExporter.Model;

namespace DiveLogExporter.Parser
{
    public interface IDiveLogParser
    {
        string Name { get; }

        IReadOnlyList<string> SupportedExtensions { get; }

        bool CanHandle(string inputPath);

        List<GeneralDiveLog> Parse(string inputPath);
    }
}
