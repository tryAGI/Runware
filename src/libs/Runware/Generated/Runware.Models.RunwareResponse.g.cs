
#nullable enable

namespace Runware
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunwareResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Runware.RunwareTaskResponse>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::Runware.RunwareError>? Errors { get; set; }

        /// <summary>
        /// Legacy single-error field used by some responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwareResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="errors"></param>
        /// <param name="error">
        /// Legacy single-error field used by some responses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunwareResponse(
            global::System.Collections.Generic.IList<global::Runware.RunwareTaskResponse>? data,
            global::System.Collections.Generic.IList<global::Runware.RunwareError>? errors,
            string? error)
        {
            this.Data = data;
            this.Errors = errors;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwareResponse" /> class.
        /// </summary>
        public RunwareResponse()
        {
        }
    }
}