using System.Web;

namespace Client;

public class GptWorkflowClient
{
    readonly int port;
    readonly string hostname;

    public GptWorkflowClient(string hostname, int port)
    {
        this.port = port;
        this.hostname = hostname;
    }

    HttpClient CreateClient() => new HttpClient () { BaseAddress = new Uri($"http://{hostname}:{port}") };

    async Task<string> GetResponse(string request)
    {
        using(var webClient = CreateClient())
        {
            var rsp = await webClient.GetAsync(request);
            rsp.EnsureSuccessStatusCode()
                .WriteRequestToConsole();
    
            return await rsp.Content.ReadAsStringAsync();
        }
    }

    string Encode(string text)
        => HttpUtility.UrlPathEncode(text);

    public async Task<string> SendPrompt(string description)
    {
        var rsp = await GetResponse($"?p={Encode(description)}");
        return rsp;
    }
}
