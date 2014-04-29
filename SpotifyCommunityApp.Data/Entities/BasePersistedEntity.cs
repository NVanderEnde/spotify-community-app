using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCommunityApp.Data.Entities
{
    abstract class BasePersistedEntity
    {
        Guid Id { get; set; }
    }
}
