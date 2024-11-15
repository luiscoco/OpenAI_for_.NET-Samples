// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.VectorStores
{
    internal readonly partial struct InternalDeleteVectorStoreResponseObject : IEquatable<InternalDeleteVectorStoreResponseObject>
    {
        private readonly string _value;

        public InternalDeleteVectorStoreResponseObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VectorStoreDeletedValue = "vector_store.deleted";

        public static InternalDeleteVectorStoreResponseObject VectorStoreDeleted { get; } = new InternalDeleteVectorStoreResponseObject(VectorStoreDeletedValue);
        public static bool operator ==(InternalDeleteVectorStoreResponseObject left, InternalDeleteVectorStoreResponseObject right) => left.Equals(right);
        public static bool operator !=(InternalDeleteVectorStoreResponseObject left, InternalDeleteVectorStoreResponseObject right) => !left.Equals(right);
        public static implicit operator InternalDeleteVectorStoreResponseObject(string value) => new InternalDeleteVectorStoreResponseObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalDeleteVectorStoreResponseObject other && Equals(other);
        public bool Equals(InternalDeleteVectorStoreResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}