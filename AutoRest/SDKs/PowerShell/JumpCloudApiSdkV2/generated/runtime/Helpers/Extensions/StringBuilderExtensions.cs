using System.Text;

namespace JumpCloudApiSdkV2.Runtime.Json
{
    internal static class StringBuilderExtensions
    {
        /// <summary>
        /// Extracts the buffered value and resets the buffer
        /// </summary>
        internal static string Extract(this StringBuilder builder)
        {
            var text = builder.ToString();

            builder.Clear();

            return text;
        }
    }
}