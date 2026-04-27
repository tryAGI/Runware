
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Runware
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Runware.JsonConverters.RunwareTaskOutputTypeJsonConverter),

            typeof(global::Runware.JsonConverters.RunwareTaskOutputTypeNullableJsonConverter),

            typeof(global::Runware.JsonConverters.RunwareTaskOutputFormatJsonConverter),

            typeof(global::Runware.JsonConverters.RunwareTaskOutputFormatNullableJsonConverter),

            typeof(global::Runware.JsonConverters.RunwareTaskDeliveryMethodJsonConverter),

            typeof(global::Runware.JsonConverters.RunwareTaskDeliveryMethodNullableJsonConverter),

            typeof(global::Runware.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runware.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runware.RunwareTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runware.RunwareTaskOutputType), TypeInfoPropertyName = "RunwareTaskOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runware.RunwareTaskOutputFormat), TypeInfoPropertyName = "RunwareTaskOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runware.RunwareTaskDeliveryMethod), TypeInfoPropertyName = "RunwareTaskDeliveryMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runware.RunwareInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runware.RunwareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runware.RunwareTaskResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runware.RunwareTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runware.RunwareError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runware.RunwareError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runware.RunwareOutputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runware.RunwareTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Runware.RunwareOutputFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Runware.RunwareOutputFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runware.RunwareTaskResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runware.RunwareError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runware.RunwareTask>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Runware.RunwareOutputFile>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}