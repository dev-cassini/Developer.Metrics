using Newtonsoft.Json;

namespace Develop.Metrics.Infrastructure.Atlassian.Bitbucket.Workspaces.GetUsers;

public record UserDto(
    [JsonProperty("uuid")] Guid Id,
    [JsonProperty("display_name")] string DisplayName);