// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.FineTuning
{
    internal partial class InternalListFineTuningJobEventsResponse
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalListFineTuningJobEventsResponse(bool hasMore, IEnumerable<FineTuningJobEvent> data)
        {
            Argument.AssertNotNull(data, nameof(data));

            HasMore = hasMore;
            Data = data.ToList();
        }

        internal InternalListFineTuningJobEventsResponse(bool hasMore, IReadOnlyList<FineTuningJobEvent> data, InternalListFineTuningJobEventsResponseObject @object, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HasMore = hasMore;
            Data = data;
            Object = @object;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalListFineTuningJobEventsResponse()
        {
        }

        public bool HasMore { get; }
        public IReadOnlyList<FineTuningJobEvent> Data { get; }
        public InternalListFineTuningJobEventsResponseObject Object { get; } = InternalListFineTuningJobEventsResponseObject.List;
    }
}