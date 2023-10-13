namespace Framework.Testing.TestingComponents.Infrastructure;

/// <summary>
/// Provides methods for creating data access sessions and contexts, tailored for testing purposes.
/// </summary>
public interface ITestingDataAccess<out TRepo, in TOptions> where TRepo:class
{
    /// <summary>
    /// Creates a new session for managing and tracking changes to stored entities.
    /// </summary>
    /// <param name="options">Required options for the session</param>
    /// <returns>An open data access repository.</returns>
    TRepo OpenSession(TOptions options);
}