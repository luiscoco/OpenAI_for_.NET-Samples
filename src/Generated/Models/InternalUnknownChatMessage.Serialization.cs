// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Chat
{
    internal partial class InternalUnknownChatMessage : IJsonModel<ChatMessage>
    {
        ChatMessage IJsonModel<ChatMessage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatMessage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatMessage(document.RootElement, options);
        }

        internal static InternalUnknownChatMessage DeserializeInternalUnknownChatMessage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ChatMessageRole role = default;
            ChatMessageContent content = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("role"u8))
                {
                    role = property.Value.GetString().ToChatMessageRole();
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    DeserializeContentValue(property, ref content);
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            // CUSTOM: Initialize Content collection property.
            return new InternalUnknownChatMessage(role, content ?? new ChatMessageContent(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChatMessage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatMessage)} does not support writing '{options.Format}' format.");
            }
        }

        ChatMessage IPersistableModel<ChatMessage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChatMessage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatMessage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatMessage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static new InternalUnknownChatMessage FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalUnknownChatMessage(document.RootElement);
        }

        internal override BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create<ChatMessage>(this, ModelSerializationExtensions.WireOptions);
        }
    }
}