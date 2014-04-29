using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpotifyCommunityApp.Data.Entities
{
    class Contributor : BasePersistedEntity
    {
        string Name { get; set; }
        byte[] ProfileImage { get; set; }
    }
}
