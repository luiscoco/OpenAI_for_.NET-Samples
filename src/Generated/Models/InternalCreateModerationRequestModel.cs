// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Moderations
{
    internal readonly partial struct InternalCreateModerationRequestModel : IEquatable<InternalCreateModerationRequestModel>
    {
        private readonly string _value;

        public InternalCreateModerationRequestModel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OmniModerationLatestValue = "omni-moderation-latest";
        private const string OmniModeration20240926Value = "omni-moderation-2024-09-26";
        private const string TextModerationLatestValue = "text-moderation-latest";
        private const string TextModerationStableValue = "text-moderation-stable";

        public static InternalCreateModerationRequestModel OmniModerationLatest { get; } = new InternalCreateModerationRequestModel(OmniModerationLatestValue);
        public static InternalCreateModerationRequestModel OmniModeration20240926 { get; } = new InternalCreateModerationRequestModel(OmniModeration20240926Value);
        public static InternalCreateModerationRequestModel TextModerationLatest { get; } = new InternalCreateModerationRequestModel(TextModerationLatestValue);
        public static InternalCreateModerationRequestModel TextModerationStable { get; } = new InternalCreateModerationRequestModel(TextModerationStableValue);
        public static bool operator ==(InternalCreateModerationRequestModel left, InternalCreateModerationRequestModel right) => left.Equals(right);
        public static bool operator !=(InternalCreateModerationRequestModel left, InternalCreateModerationRequestModel right) => !left.Equals(right);
        public static implicit operator InternalCreateModerationRequestModel(string value) => new InternalCreateModerationRequestModel(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateModerationRequestModel other && Equals(other);
        public bool Equals(InternalCreateModerationRequestModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}