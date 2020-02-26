using System;
using FriendOrganizer.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FriendOrganizer.DataAccess;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<FriendOrganizerDbContext> _contextCreator;

        public FriendDataService(Func<FriendOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<List<Friend>> GetAllAsync()
        {
            using (var context = _contextCreator())
            {
                return await context.Friends.AsNoTracking().ToListAsync();
            }
        }
    }
}
