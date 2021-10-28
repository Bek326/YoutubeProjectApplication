using System;
using System.Threading;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YoutubeProjectApplication.Services
{
    public class YoutubeService : IVideoService
    {
        private readonly string  _videoUrl;

        private readonly string _outputFile;

        private readonly YoutubeClient _client;
        
        public YoutubeService(string videoUrl, string outputFile)
        {
            _videoUrl = videoUrl;
            _outputFile = outputFile;
            _client = new YoutubeClient();
        }
        
        public async Task DownloadAsync(CancellationToken token)
        {
            try
            {
                await _client.Videos.DownloadAsync(_videoUrl, _outputFile, builder => builder.SetPreset(ConversionPreset.UltraFast),  cancellationToken: token);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public async Task<string> GetDescriptionAsync(CancellationToken token)
        {
            try
            {
                var video = await _client.Videos.GetAsync(_videoUrl, token);

                Console.WriteLine(video.Title);
            
                Console.WriteLine(video.Description);

                return video.Description;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}