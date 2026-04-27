
#nullable enable

namespace Runware
{
    /// <summary>
    /// Generated 3D model file format.<br/>
    /// Default Value: GLB
    /// </summary>
    public enum RunwareTaskOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Glb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunwareTaskOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunwareTaskOutputFormat value)
        {
            return value switch
            {
                RunwareTaskOutputFormat.Glb => "GLB",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunwareTaskOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "GLB" => RunwareTaskOutputFormat.Glb,
                _ => null,
            };
        }
    }
}