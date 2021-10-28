using System;
using System.Threading;
using System.Threading.Tasks;
using YoutubeProjectApplication.Commands;
using YoutubeProjectApplication.Services;

namespace YoutubeProjectApplication
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            var url = Console.ReadLine();

            var outputFile = Console.ReadLine();

            var commandName = Console.ReadLine();
            
            var service = new YoutubeService(url, outputFile);

            ICommand command = null;

            if (commandName == "Download")
            {
                command = new DownloadVideoCommand(service);
            }
            
            else if (commandName == "GetDescription")
            {
                command = new GetDescriptionVideoCommand(service);
            }

            CancellationTokenSource tcs = new CancellationTokenSource();
            
            await Invoker.InvokeAsync(command, tcs.Token);
        }
    }
}