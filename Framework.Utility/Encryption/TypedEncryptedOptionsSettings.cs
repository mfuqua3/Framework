using System.Reflection;
using System.Text.RegularExpressions;

namespace Framework.Utility.Encryption;

public class TypedEncryptedOptionsSettings
{
    public string Name { get; init; }
    public PropertyInfo PropertyInfo { get; init; }
    public Regex Pattern { get; init; }
}
