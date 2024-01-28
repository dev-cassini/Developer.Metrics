using Develop.Metrics.Infrastructure.Atlassian.Bitbucket.Auth.GrantTypes.ClientCredentials;
using Microsoft.Extensions.DependencyInjection;

namespace Developer.Metrics.Infrastructure.Test;

public class Tests
{
    [Test]
    public async Task Test1()
    {
        var serviceCollection = new ServiceCollection()
            .AddBitbucketClientCredentialsHttpClient();

        var serviceProvider = serviceCollection.BuildServiceProvider();

        var httpClient = serviceProvider.GetRequiredService<IHttpClient>();

        var token = await httpClient.RequestTokenAsync(CancellationToken.None);
    }
}