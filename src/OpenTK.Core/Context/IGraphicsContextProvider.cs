namespace OpenTK.Core
{
    /// <summary>
    /// Provides a native graphics context.
    /// </summary>
    /// <typeparam name="TGraphicsContext">The native graphics context type.</typeparam>
    public interface IGraphicsContextProvider<out TGraphicsContext>
    {
        /// <summary>
        /// Gets the native graphics context provided by this <see cref="IGraphicsContextProvider{T}"/>.
        /// </summary>
        TGraphicsContext NativeContext { get; }
    }
}
