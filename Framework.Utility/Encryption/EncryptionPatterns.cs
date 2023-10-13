using System.Text.RegularExpressions;

namespace Framework.Utility.Encryption;

/// <summary>
/// Provides Regex Patterns for extracting encrypted fields within partially encrypted configuration strings
/// </summary>
public static partial class EncryptionPatterns
{
    public static readonly Regex ConnectionStringPassword = ConnectionStringPasswordRegex();

    public static readonly Regex RabbitMqPassword = RabbitMqPasswordRegex();

    [GeneratedRegex("(?<=assword=)[^;]+")]
    private static partial Regex ConnectionStringPasswordRegex();
    [GeneratedRegex("(?<=:)[^:@]+(?=@)")]
    private static partial Regex RabbitMqPasswordRegex();
}
