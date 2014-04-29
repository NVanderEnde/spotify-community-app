using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCommunityApp.Spotify.Models
{
    class Playlist
    {
        string Name { get; set; }
        string ImageURI { get; set; }
        User Owner { get; set; }
        IEnumerable<Track> Tracks { get; set; }
    }
}
