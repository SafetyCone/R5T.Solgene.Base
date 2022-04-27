using System;

using R5T.Cambridge.Types;using R5T.T0064;


namespace R5T.Solgene
{[ServiceDefinitionMarker]
    /// <summary>
    /// A service that generates in-memory <see cref="SolutionFile"/> instances.
    /// </summary>
    public interface IVisualStudioSolutionFileGenerator:IServiceDefinition
    {
        SolutionFile GenerateVisualStudioSolutionFile();
    }
}
