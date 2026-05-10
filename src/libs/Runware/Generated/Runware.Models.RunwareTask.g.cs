
#nullable enable

namespace Runware
{
    /// <summary>
    /// Generic Runware task object. Common platform fields are modeled<br/>
    /// directly, and additional task-specific properties are allowed so newer<br/>
    /// Runware task types can be used before this spec is updated.
    /// </summary>
    public sealed partial class RunwareTask
    {
        /// <summary>
        /// Task identifier, such as authentication, 3dInference, getResponse, or getTaskDetails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskType { get; set; }

        /// <summary>
        /// API key for payload-based authentication tasks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// UUID v4 used to track and match task responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskUUID")]
        public global::System.Guid? TaskUUID { get; set; }

        /// <summary>
        /// Model identifier. Use meta:sam@3d for Meta SAM 3D Objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 3D output type.<br/>
        /// Default Value: URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runware.JsonConverters.RunwareTaskOutputTypeJsonConverter))]
        public global::Runware.RunwareTaskOutputType? OutputType { get; set; }

        /// <summary>
        /// Generated 3D model file format.<br/>
        /// Default Value: GLB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runware.JsonConverters.RunwareTaskOutputFormatJsonConverter))]
        public global::Runware.RunwareTaskOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// URL where completed task responses should be POSTed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookURL")]
        public string? WebhookURL { get; set; }

        /// <summary>
        /// Whether to return completed results directly or acknowledge and poll later.<br/>
        /// Default Value: async
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveryMethod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Runware.JsonConverters.RunwareTaskDeliveryMethodJsonConverter))]
        public global::Runware.RunwareTaskDeliveryMethod? DeliveryMethod { get; set; }

        /// <summary>
        /// Presigned upload URL for generated content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadEndpoint")]
        public string? UploadEndpoint { get; set; }

        /// <summary>
        /// Time-to-live in seconds for generated URL output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public int? Ttl { get; set; }

        /// <summary>
        /// Include task cost in responses.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeCost")]
        public bool? IncludeCost { get; set; }

        /// <summary>
        /// Number of generated results.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberResults")]
        public int? NumberResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::Runware.RunwareInputs? Inputs { get; set; }

        /// <summary>
        /// Text prompt describing elements to include in generated output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positivePrompt")]
        public string? PositivePrompt { get; set; }

        /// <summary>
        /// Random seed for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwareTask" /> class.
        /// </summary>
        /// <param name="taskType">
        /// Task identifier, such as authentication, 3dInference, getResponse, or getTaskDetails.
        /// </param>
        /// <param name="apiKey">
        /// API key for payload-based authentication tasks.
        /// </param>
        /// <param name="taskUUID">
        /// UUID v4 used to track and match task responses.
        /// </param>
        /// <param name="model">
        /// Model identifier. Use meta:sam@3d for Meta SAM 3D Objects.
        /// </param>
        /// <param name="outputType">
        /// 3D output type.<br/>
        /// Default Value: URL
        /// </param>
        /// <param name="outputFormat">
        /// Generated 3D model file format.<br/>
        /// Default Value: GLB
        /// </param>
        /// <param name="webhookURL">
        /// URL where completed task responses should be POSTed.
        /// </param>
        /// <param name="deliveryMethod">
        /// Whether to return completed results directly or acknowledge and poll later.<br/>
        /// Default Value: async
        /// </param>
        /// <param name="uploadEndpoint">
        /// Presigned upload URL for generated content.
        /// </param>
        /// <param name="ttl">
        /// Time-to-live in seconds for generated URL output.
        /// </param>
        /// <param name="includeCost">
        /// Include task cost in responses.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="numberResults">
        /// Number of generated results.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="inputs"></param>
        /// <param name="positivePrompt">
        /// Text prompt describing elements to include in generated output.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducible generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunwareTask(
            string taskType,
            string? apiKey,
            global::System.Guid? taskUUID,
            string? model,
            global::Runware.RunwareTaskOutputType? outputType,
            global::Runware.RunwareTaskOutputFormat? outputFormat,
            string? webhookURL,
            global::Runware.RunwareTaskDeliveryMethod? deliveryMethod,
            string? uploadEndpoint,
            int? ttl,
            bool? includeCost,
            int? numberResults,
            global::Runware.RunwareInputs? inputs,
            string? positivePrompt,
            long? seed)
        {
            this.TaskType = taskType ?? throw new global::System.ArgumentNullException(nameof(taskType));
            this.ApiKey = apiKey;
            this.TaskUUID = taskUUID;
            this.Model = model;
            this.OutputType = outputType;
            this.OutputFormat = outputFormat;
            this.WebhookURL = webhookURL;
            this.DeliveryMethod = deliveryMethod;
            this.UploadEndpoint = uploadEndpoint;
            this.Ttl = ttl;
            this.IncludeCost = includeCost;
            this.NumberResults = numberResults;
            this.Inputs = inputs;
            this.PositivePrompt = positivePrompt;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwareTask" /> class.
        /// </summary>
        public RunwareTask()
        {
        }

    }
}