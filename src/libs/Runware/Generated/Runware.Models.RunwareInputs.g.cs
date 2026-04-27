
#nullable enable

namespace Runware
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunwareInputs
    {
        /// <summary>
        /// Image input as UUID, URL, Data URI, or Base64.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Mask image as UUID, URL, Data URI, or Base64.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public string? Mask { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwareInputs" /> class.
        /// </summary>
        /// <param name="image">
        /// Image input as UUID, URL, Data URI, or Base64.
        /// </param>
        /// <param name="mask">
        /// Mask image as UUID, URL, Data URI, or Base64.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunwareInputs(
            string? image,
            string? mask)
        {
            this.Image = image;
            this.Mask = mask;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwareInputs" /> class.
        /// </summary>
        public RunwareInputs()
        {
        }
    }
}