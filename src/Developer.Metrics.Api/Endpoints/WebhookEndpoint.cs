namespace Developer.Metrics.Api.Endpoints;

public static class WebhookEndpoint
{
    public static WebApplication MapWebhookEndpoint(this WebApplication webApplication)
    {
        webApplication.MapPost(
                "/webhook",
                ProcessWebhook)
            .AllowAnonymous()
            .Produces(StatusCodes.Status401Unauthorized)
            .Produces(StatusCodes.Status403Forbidden)
            .ProducesValidationProblem();

        return webApplication;
    }
    
    private static async Task<IResult> ProcessWebhook(dynamic request, CancellationToken cancellationToken)
    {
        return Results.NoContent();
    }
}