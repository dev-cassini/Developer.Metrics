using Newtonsoft.Json;

namespace Develop.Metrics.Infrastructure.Atlassian.Bitbucket.Auth;

public record Token(
    [JsonProperty("access_token")] string AccessToken,
    [JsonProperty("expires_in")] string ExpiresInSeconds);