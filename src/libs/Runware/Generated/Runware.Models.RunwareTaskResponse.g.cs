
#nullable enable

namespace Runware
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunwareTaskResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskType")]
        public string? TaskType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskUUID")]
        public global::System.Guid? TaskUUID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionSessionUUID")]
        public global::System.Guid? ConnectionSessionUUID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelUUID")]
        public global::System.Guid? ModelUUID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelURL")]
        public string? ModelURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelBase64Data")]
        public string? ModelBase64Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelDataURI")]
        public string? ModelDataURI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::Runware.RunwareOutputs? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::System.Collections.Generic.IList<global::Runware.RunwareTask>? Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public object? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwareTaskResponse" /> class.
        /// </summary>
        /// <param name="taskType"></param>
        /// <param name="taskUUID"></param>
        /// <param name="connectionSessionUUID"></param>
        /// <param name="seed"></param>
        /// <param name="cost"></param>
        /// <param name="modelUUID"></param>
        /// <param name="modelURL"></param>
        /// <param name="modelBase64Data"></param>
        /// <param name="modelDataURI"></param>
        /// <param name="outputs"></param>
        /// <param name="request"></param>
        /// <param name="response"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunwareTaskResponse(
            string? taskType,
            global::System.Guid? taskUUID,
            global::System.Guid? connectionSessionUUID,
            long? seed,
            double? cost,
            global::System.Guid? modelUUID,
            string? modelURL,
            string? modelBase64Data,
            string? modelDataURI,
            global::Runware.RunwareOutputs? outputs,
            global::System.Collections.Generic.IList<global::Runware.RunwareTask>? request,
            object? response)
        {
            this.TaskType = taskType;
            this.TaskUUID = taskUUID;
            this.ConnectionSessionUUID = connectionSessionUUID;
            this.Seed = seed;
            this.Cost = cost;
            this.ModelUUID = modelUUID;
            this.ModelURL = modelURL;
            this.ModelBase64Data = modelBase64Data;
            this.ModelDataURI = modelDataURI;
            this.Outputs = outputs;
            this.Request = request;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwareTaskResponse" /> class.
        /// </summary>
        public RunwareTaskResponse()
        {
        }
    }
}