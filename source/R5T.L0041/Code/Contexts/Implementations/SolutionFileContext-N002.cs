using System;

using R5T.F0024.T001;
using R5T.T0137;
using R5T.T0172;


namespace R5T.L0041.N002
{
    /// <inheritdoc cref="ISolutionFileContext"/>
    [ContextImplementationMarker]
    public class SolutionFileContext : IContextImplementationMarker,
        ISolutionFileContext
    {
        public SolutionFile SolutionFile { get; set; }
        public ISolutionFilePath SolutionFilePath { get; set; }
    }
}