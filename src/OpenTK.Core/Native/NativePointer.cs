using System;

namespace OpenTK.Core.Native
{
    /// <summary>
    /// Provides a native pointer wrapper struct, to be used where native pointers can't be used(e.g. as type parameters).
    /// </summary>
    /// <typeparam name="T">The element type for the native pointer.</typeparam>
    public readonly unsafe struct NativePointer<T> : IEquatable<NativePointer<T>>
        where T : unmanaged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NativePointer{T}"/> struct.
        /// </summary>
        /// <param name="pointer">The underlying native pointer to wrap in this struct.</param>
        public NativePointer(T* pointer)
        {
            Pointer = pointer;
        }

        /// <summary>
        /// Gets the underlying native pointer.
        /// </summary>
        public T* Pointer { get; }

        /// <summary>
        /// Implicitly converts a <see cref="NativePointer{T}"/> to it's native pointer counterpart.
        /// </summary>
        /// <param name="nativePointer">The <see cref="NativePointer{T}"/> wrapper struct.</param>
        /// <returns>The native pointer counterpart.</returns>
        public static implicit operator T*(NativePointer<T> nativePointer)
        {
            return nativePointer.Pointer;
        }

        /// <summary>
        /// Implicitly converts a nullable <see cref="NativePointer{T}"/> to it's native pointer counterpart.
        /// </summary>
        /// <param name="nativePointer">The <see cref="NativePointer{T}"/> wrapper struct.</param>
        /// <returns>If <paramref name="nativePointer"/> is <c>null</c> a null-pointer is returned; the native pointer counterpart otherwise.</returns>
        public static implicit operator T*(NativePointer<T>? nativePointer)
        {
            return nativePointer.HasValue ? nativePointer.Value.Pointer : null;
        }

        /// <summary>
        /// Implicitly converts a native pointer to a <see cref="NativePointer{T}"/> wrapper struct.
        /// </summary>
        /// <param name="pointer">The native pointer.</param>
        /// <returns>The <see cref="NativePointer{T}"/> wrapper struct.</returns>
        public static implicit operator NativePointer<T>(T* pointer)
        {
            return new NativePointer<T>(pointer);
        }

        /// <inheritdoc />
        public bool Equals(NativePointer<T> other)
        {
            return Pointer == other.Pointer;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return obj is NativePointer<T> other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return unchecked((int)(long)Pointer);
        }
    }
}
