namespace OpenTK.Core
{
    /// <summary>
    ///  Provides methods for making a graphics context current or non current.
    /// </summary>
    /// <typeparam name="TGraphicsContextProvider">The graphics provider type for this graphics context.</typeparam>
    /// <typeparam name="TGraphicsContext">The native graphics context type for used for this context.</typeparam>
    public interface IGraphicsContext<in TGraphicsContextProvider, TGraphicsContext>
        where TGraphicsContextProvider : IGraphicsContextProvider<TGraphicsContext>
    {
        /// <summary>
        /// Make this graphics context the current context.
        /// </summary>
        void MakeCurrent();

        /// <summary>
        /// Make the graphics context given by the <paramref name="contextProvider"/> the current context.
        /// </summary>
        /// <param name="contextProvider">A graphics provider which provides the context which should be made current.</param>
        /// <remarks>If <c>null</c> is passed the current context gets reset.</remarks>
        void MakeCurrent(TGraphicsContextProvider contextProvider);
    }
}
