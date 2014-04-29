using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCommunityApp.Data.Entities
{
    /// <summary>
    /// Parent object of the database graph
    /// </summary>
    class Community : BasePersistedEntity
    {
        string Name { get; set; }
        virtual IEnumerable<Playlist> Playlists { get; set; }
    }
}
