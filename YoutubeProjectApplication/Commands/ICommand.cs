using System.Threading;
using System.Threading.Tasks;

namespace YoutubeProjectApplication.Commands
{
    public interface ICommand
    {
        Task ExecuteAsync(CancellationToken token);
    }
}