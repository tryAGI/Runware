
#nullable enable

namespace Runware
{
    /// <summary>
    /// 3D output type.<br/>
    /// Default Value: URL
    /// </summary>
    public enum RunwareTaskOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunwareTaskOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunwareTaskOutputType value)
        {
            return value switch
            {
                RunwareTaskOutputType.Url => "URL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunwareTaskOutputType? ToEnum(string value)
        {
            return value switch
            {
                "URL" => RunwareTaskOutputType.Url,
                _ => null,
            };
        }
    }
}