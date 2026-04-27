
#nullable enable

namespace Runware
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunwareError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameter")]
        public string? Parameter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentation")]
        public string? Documentation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskUUID")]
        public global::System.Guid? TaskUUID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskType")]
        public string? TaskType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwareError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="parameter"></param>
        /// <param name="type"></param>
        /// <param name="documentation"></param>
        /// <param name="taskUUID"></param>
        /// <param name="taskType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunwareError(
            string? code,
            string? message,
            string? parameter,
            string? type,
            string? documentation,
            global::System.Guid? taskUUID,
            string? taskType)
        {
            this.Code = code;
            this.Message = message;
            this.Parameter = parameter;
            this.Type = type;
            this.Documentation = documentation;
            this.TaskUUID = taskUUID;
            this.TaskType = taskType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwareError" /> class.
        /// </summary>
        public RunwareError()
        {
        }
    }
}