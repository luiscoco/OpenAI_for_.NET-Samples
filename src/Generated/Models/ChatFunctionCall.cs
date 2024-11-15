// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    public partial class ChatFunctionCall
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        public ChatFunctionCall(string functionName, BinaryData functionArguments)
        {
            Argument.AssertNotNull(functionName, nameof(functionName));
            Argument.AssertNotNull(functionArguments, nameof(functionArguments));

            FunctionName = functionName;
            FunctionArguments = functionArguments;
        }

        internal ChatFunctionCall(string functionName, BinaryData functionArguments, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FunctionName = functionName;
            FunctionArguments = functionArguments;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal ChatFunctionCall()
        {
        }
    }
}