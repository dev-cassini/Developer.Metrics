using IdentityModel;
using IdentityModel.Client;

namespace Develop.Metrics.Infrastructure.Atlassian.Bitbucket.Auth.GrantTypes.ClientCredentials;

public interface IHttpClient
{
    /// <summary>
    /// Request a token using <see cref="OidcConstants.GrantTypes.ClientCredentials"/> flow.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The <see cref="TokenResponse"/> from auth server.</returns>
    Task<Token> RequestTokenAsync(CancellationToken cancellationToken);
}