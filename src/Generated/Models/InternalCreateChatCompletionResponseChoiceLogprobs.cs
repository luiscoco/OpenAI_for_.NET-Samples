// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Chat
{
    internal partial class InternalCreateChatCompletionResponseChoiceLogprobs
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalCreateChatCompletionResponseChoiceLogprobs(IEnumerable<ChatTokenLogProbabilityDetails> content, IEnumerable<ChatTokenLogProbabilityDetails> refusal)
        {
            Content = content?.ToList();
            Refusal = refusal?.ToList();
        }

        internal InternalCreateChatCompletionResponseChoiceLogprobs(IReadOnlyList<ChatTokenLogProbabilityDetails> content, IReadOnlyList<ChatTokenLogProbabilityDetails> refusal, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Content = content;
            Refusal = refusal;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalCreateChatCompletionResponseChoiceLogprobs()
        {
        }

        public IReadOnlyList<ChatTokenLogProbabilityDetails> Content { get; }
        public IReadOnlyList<ChatTokenLogProbabilityDetails> Refusal { get; }
    }
}