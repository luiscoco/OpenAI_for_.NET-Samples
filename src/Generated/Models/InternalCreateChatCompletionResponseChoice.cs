// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    internal partial class InternalCreateChatCompletionResponseChoice
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalCreateChatCompletionResponseChoice(ChatFinishReason finishReason, int index, InternalChatCompletionResponseMessage message, InternalCreateChatCompletionResponseChoiceLogprobs logprobs)
        {
            Argument.AssertNotNull(message, nameof(message));

            FinishReason = finishReason;
            Index = index;
            Message = message;
            Logprobs = logprobs;
        }

        internal InternalCreateChatCompletionResponseChoice(ChatFinishReason finishReason, int index, InternalChatCompletionResponseMessage message, InternalCreateChatCompletionResponseChoiceLogprobs logprobs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FinishReason = finishReason;
            Index = index;
            Message = message;
            Logprobs = logprobs;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalCreateChatCompletionResponseChoice()
        {
        }

        public ChatFinishReason FinishReason { get; }
        public int Index { get; }
        public InternalChatCompletionResponseMessage Message { get; }
        public InternalCreateChatCompletionResponseChoiceLogprobs Logprobs { get; }
    }
}