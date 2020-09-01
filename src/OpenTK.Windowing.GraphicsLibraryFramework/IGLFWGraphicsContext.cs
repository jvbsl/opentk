using OpenTK.Core;
using OpenTK.Core.Native;

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Provides methods for interacting with the GLFW graphics context.
    /// </summary>
    public interface IGLFWGraphicsContext : IGraphicsContext<IGLFWGraphicsContextProvider, NativePointer<Window>>
    {
    }
}
