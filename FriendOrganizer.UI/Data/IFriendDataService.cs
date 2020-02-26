using System.Collections.Generic;
using Model;

namespace FriendOrganizer.UI.Data
{
    public interface IFriendDataService
    {
        IEnumerable<Friend> GetAll();
    }
}