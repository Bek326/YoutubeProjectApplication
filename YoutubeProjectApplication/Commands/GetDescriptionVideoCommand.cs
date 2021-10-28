using System;
using System.Threading;
using System.Threading.Tasks;
using YoutubeProjectApplication.Services;

namespace YoutubeProjectApplication.Commands
{
    public class GetDescriptionVideoCommand : ICommand
    {
        private readonly IVideoService _videoService;

        public GetDescriptionVideoCommand(IVideoService videoService)
        {
            _videoService = videoService;
        }
        public Task ExecuteAsync(CancellationToken token)
        {
            return _videoService.GetDescriptionAsync(token);
        }
    }
}