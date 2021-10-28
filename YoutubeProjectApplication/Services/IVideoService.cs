using System.Threading;
using System.Threading.Tasks;

namespace YoutubeProjectApplication.Services
{
    public interface IVideoService
    {
        Task DownloadAsync(CancellationToken token);

        Task<string> GetDescriptionAsync(CancellationToken token);
    }
}