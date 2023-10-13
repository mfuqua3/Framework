namespace Framework.Utility.NamedServices;

public interface INamedServiceCollection<T> : IReadOnlyDictionary<string, T>
{
}