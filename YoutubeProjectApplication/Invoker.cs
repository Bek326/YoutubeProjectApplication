using System.Threading;
using System.Threading.Tasks;
using YoutubeProjectApplication.Commands;

namespace YoutubeProjectApplication
{
    public static class Invoker
    {
        public static Task InvokeAsync(ICommand command, CancellationToken token)
        {
            return command.ExecuteAsync(token);
        }
    }
}