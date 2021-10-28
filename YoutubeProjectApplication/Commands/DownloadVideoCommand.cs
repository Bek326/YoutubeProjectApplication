using System.Threading;
using System.Threading.Tasks;
using YoutubeProjectApplication.Services;

namespace YoutubeProjectApplication.Commands
{
    public class DownloadVideoCommand : ICommand
    {
        private readonly IVideoService _videoService;

        public DownloadVideoCommand(IVideoService videoService)
        {
            _videoService = videoService;
        }
        
        public Task ExecuteAsync(CancellationToken token)
        {
            return _videoService.DownloadAsync(token);
        }
    }
}