using System;

using R5T.T0137;
using R5T.T0172;


namespace R5T.L0041
{
    /// <summary>
    /// Context for a solution file path.
    /// </summary>
    /// <remarks>
    /// This context, which includes only the solution file path, is placed in the root namespace since only the solution file path is commonly needed during code generation.
    /// For example, after creating a solution file, you only need to add project references to the solution file (as opposed to update any properties via complicated logic).
    /// </remarks>
    [ContextDefinitionMarker]
    public interface ISolutionFileContext : IContextDefinitionMarker
    {
        public ISolutionFilePath SolutionFilePath { get; }
    }
}