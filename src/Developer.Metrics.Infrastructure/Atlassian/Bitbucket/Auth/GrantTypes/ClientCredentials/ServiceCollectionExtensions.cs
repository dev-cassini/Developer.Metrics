using IdentityModel.Client;
using Microsoft.Extensions.DependencyInjection;

namespace Develop.Metrics.Infrastructure.Atlassian.Bitbucket.Auth.GrantTypes.ClientCredentials;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBitbucketClientCredentialsHttpClient(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddHttpClient<IHttpClient, HttpClient>(client =>
        {
            client.BaseAddress = new Uri("https://bitbucket.org/site/oauth2/");
            client.SetBasicAuthentication("CLIENT_ID_HERE", "CLIENT_SECRET_HERE");
        });

        return serviceCollection;
    }
}