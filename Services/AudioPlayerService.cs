using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radioo.Services
{
    public class AudioPlayerService
    {
        private MediaElement _mediaElement;
        private bool _isPlaying;

        public AudioPlayerService()
        {
            _mediaElement = new MediaElement();
        }

        public async Task PlayAsync(string url)
        {
            if (_isPlaying)
            {
                _mediaElement.Stop();
            }

            _mediaElement.Source = MediaSource.FromUri(url);
            _mediaElement.Play();
            _isPlaying = true;
        }

        public void Stop()
        {
            if (_isPlaying)
            {
                _mediaElement.Stop();
                _isPlaying = false;
            }
        }

        public bool IsPlaying => _isPlaying;
    }
}
