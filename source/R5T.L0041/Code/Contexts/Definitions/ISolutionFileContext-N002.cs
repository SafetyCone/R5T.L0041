using System;

using R5T.F0024.T001;
using R5T.T0137;
using R5T.T0172;


namespace R5T.L0041.N002
{
    /// <summary>
    /// A context for a <see cref="F0024.T001.SolutionFile"/> object that also contains the expected solution file path.
    /// </summary>
    /// <remarks>
    /// This context is rarely used, since only rarely does a client need to modify the internals of a solution file
    /// (as opposed to just the solution file path, which is all that is needed for adding project references to a solution).
    /// </remarks>
    [ContextDefinitionMarker]
    public interface ISolutionFileContext : IContextDefinitionMarker
    {
        public SolutionFile SolutionFile { get; }
        public ISolutionFilePath SolutionFilePath { get; }
    }
}