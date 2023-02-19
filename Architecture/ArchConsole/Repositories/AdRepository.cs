using ArchConsole.Models;
using System;

namespace ArchConsole.Repositories
{
    internal class AdRepository
    {
        public Ad GetAd(int id)
        {
            return new Ad { Id = id, Name = "Ad" };
        }

        internal void Update(Ad ad)
        {
            throw new NotImplementedException();
        }
    }
}
