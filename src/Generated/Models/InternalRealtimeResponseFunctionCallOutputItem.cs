// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeResponseFunctionCallOutputItem : InternalRealtimeResponseItem
    {
        internal InternalRealtimeResponseFunctionCallOutputItem(string id, string callId, string output) : base(id)
        {
            Argument.AssertNotNull(callId, nameof(callId));
            Argument.AssertNotNull(output, nameof(output));

            Type = InternalRealtimeItemType.FunctionCallOutput;
            CallId = callId;
            Output = output;
        }

        internal InternalRealtimeResponseFunctionCallOutputItem(InternalRealtimeResponseItemObject @object, InternalRealtimeItemType type, string id, IDictionary<string, BinaryData> serializedAdditionalRawData, string callId, string output) : base(@object, type, id, serializedAdditionalRawData)
        {
            CallId = callId;
            Output = output;
        }

        internal InternalRealtimeResponseFunctionCallOutputItem()
        {
        }

        public string CallId { get; }
        public string Output { get; }
    }
}