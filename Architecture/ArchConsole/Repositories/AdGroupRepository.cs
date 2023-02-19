using ArchConsole.Models;
using System;

namespace ArchConsole.Repositories
{
    internal class AdGroupRepository
    {
        public AdGroup GetAdGroup(int id)
        {
            return new AdGroup { Id = id, Name = "AdGroup" };
        }

        internal void Update(AdGroup adGroup)
        {
            throw new NotImplementedException();
        }
    }
}
