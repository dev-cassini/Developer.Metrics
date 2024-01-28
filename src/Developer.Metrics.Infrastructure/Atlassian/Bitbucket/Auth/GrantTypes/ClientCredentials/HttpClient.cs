using Newtonsoft.Json;

namespace Develop.Metrics.Infrastructure.Atlassian.Bitbucket.Auth.GrantTypes.ClientCredentials;

public class HttpClient : IHttpClient
{
    private readonly System.Net.Http.HttpClient _httpClient;

    public HttpClient(System.Net.Http.HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<Token> RequestTokenAsync(CancellationToken cancellationToken)
    {
        var requestContent = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>
        {
            new("grant_type", "client_credentials")
        });
        
        var response = await _httpClient.PostAsync(
            "access_token",
            requestContent,
            cancellationToken);

        var responseContent = await response.Content.ReadAsStringAsync(cancellationToken);
        var token = JsonConvert.DeserializeObject<Token>(responseContent);
        if (token is null)
        {
            throw new Exception();
        }

        return token;
    }
}