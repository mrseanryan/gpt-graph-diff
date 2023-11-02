using System.Diagnostics;

args = args.Where(a => !string.IsNullOrEmpty(a)).ToArray();

switch (args.Length)
{
    case 1:
    {
        var cmd = args[0];
        if (cmd == "test")
        {
            var testPrompt = "AI is going to";
            var rsp = await SendUserPrompt(testPrompt);
            Console.WriteLine($"-- RESPONSE --");
            Console.WriteLine(rsp);
            return 0;
        }
        else ShowUsage();
        return 6661;
    }
    case 2:
    {
        var cmd = args[0];
        if (cmd == "prompt")
        {
            var rsp = await SendUserPrompt(args[1]);
            Console.WriteLine($"-- RESPONSE --");
            Console.WriteLine(rsp);
            return 0;
        }
        else ShowUsage();
        return 6662;
    }
    default:
    {
        ShowUsage();
        return 666;
    }
}

async Task<string> SendUserPrompt(string prompt)
{
    var gptWorkflowClient = new Client.GptWorkflowClient(Config.Host, Config.Port);
    var rsp = await gptWorkflowClient.SendPrompt(prompt);
    return rsp;
}

void ShowUsage()
{
    var processName = Process.GetCurrentProcess().ProcessName;
    Console.WriteLine($"USAGE: {processName} prompt <user prompt>");
    Console.WriteLine($"USAGE: {processName} test");
}
