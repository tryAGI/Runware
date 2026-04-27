namespace Runware.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static RunwareClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("RUNWARE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("RUNWARE_API_KEY environment variable is not found.");

        var client = new RunwareClient(apiKey);
        
        return client;
    }
}
