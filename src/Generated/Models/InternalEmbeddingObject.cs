// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Embeddings
{
    internal readonly partial struct InternalEmbeddingObject : IEquatable<InternalEmbeddingObject>
    {
        private readonly string _value;

        public InternalEmbeddingObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EmbeddingValue = "embedding";

        public static InternalEmbeddingObject Embedding { get; } = new InternalEmbeddingObject(EmbeddingValue);
        public static bool operator ==(InternalEmbeddingObject left, InternalEmbeddingObject right) => left.Equals(right);
        public static bool operator !=(InternalEmbeddingObject left, InternalEmbeddingObject right) => !left.Equals(right);
        public static implicit operator InternalEmbeddingObject(string value) => new InternalEmbeddingObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalEmbeddingObject other && Equals(other);
        public bool Equals(InternalEmbeddingObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}