// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeClientEventConversationItemDelete : InternalRealtimeClientEvent
    {
        public InternalRealtimeClientEventConversationItemDelete(string itemId)
        {
            Argument.AssertNotNull(itemId, nameof(itemId));

            Kind = InternalRealtimeClientEventType.ConversationItemDelete;
            ItemId = itemId;
        }

        internal InternalRealtimeClientEventConversationItemDelete(InternalRealtimeClientEventType kind, string eventId, IDictionary<string, BinaryData> serializedAdditionalRawData, string itemId) : base(kind, eventId, serializedAdditionalRawData)
        {
            ItemId = itemId;
        }

        internal InternalRealtimeClientEventConversationItemDelete()
        {
        }

        public string ItemId { get; }
    }
}