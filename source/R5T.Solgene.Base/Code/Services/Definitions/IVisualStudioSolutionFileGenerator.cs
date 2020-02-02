using System;

using R5T.Cambridge.Types;


namespace R5T.Solgene
{
    /// <summary>
    /// A service that generates in-memory <see cref="SolutionFile"/> instances.
    /// </summary>
    public interface IVisualStudioSolutionFileGenerator
    {
        SolutionFile GenerateVisualStudioSolutionFile();
    }
}
