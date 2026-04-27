
#nullable enable

namespace Runware
{
    /// <summary>
    /// Whether to return completed results directly or acknowledge and poll later.<br/>
    /// Default Value: async
    /// </summary>
    public enum RunwareTaskDeliveryMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Async,
        /// <summary>
        /// 
        /// </summary>
        Sync,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunwareTaskDeliveryMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunwareTaskDeliveryMethod value)
        {
            return value switch
            {
                RunwareTaskDeliveryMethod.Async => "async",
                RunwareTaskDeliveryMethod.Sync => "sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunwareTaskDeliveryMethod? ToEnum(string value)
        {
            return value switch
            {
                "async" => RunwareTaskDeliveryMethod.Async,
                "sync" => RunwareTaskDeliveryMethod.Sync,
                _ => null,
            };
        }
    }
}