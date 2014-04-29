using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCommunityApp.Data.Entities
{
    class Playlist : BasePersistedEntity
    {
        IEnumerable<Contributor> Contributors { get; set; }
        string SpotifyURI { get; set; }
    }
}
