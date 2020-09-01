using OpenTK.Core;
using OpenTK.Core.Native;

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    /// <summary>
    /// Provides a native GLFW graphics context.
    /// </summary>
    public interface IGLFWGraphicsContextProvider : IGraphicsContextProvider<NativePointer<Window>>
    {
    }
}
