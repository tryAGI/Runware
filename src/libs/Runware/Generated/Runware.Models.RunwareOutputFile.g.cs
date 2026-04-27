
#nullable enable

namespace Runware
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunwareOutputFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public global::System.Guid? Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwareOutputFile" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunwareOutputFile(
            global::System.Guid? uuid,
            string? url)
        {
            this.Uuid = uuid;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwareOutputFile" /> class.
        /// </summary>
        public RunwareOutputFile()
        {
        }
    }
}