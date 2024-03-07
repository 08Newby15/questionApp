using Microsoft.AspNetCore.SignalR;

namespace QuestionsApp.Web.Hubs;

public static class QuestionsHubExtensions
{
    public static async Task SendRefreshAsync(this IHubContext<QuestionsHub>? hub)
    {
        if (hub != null)
            await hub.Clients.All.SendAsync("refresh");
    }
}