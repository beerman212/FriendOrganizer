using System.Collections.ObjectModel;
using System.Windows.Navigation;
using FriendOrganizer.UI.Data;
using Model;

namespace FriendOrganizer.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IFriendDataService _friendDataService;
        private Friend _selectedFriend;

        public ObservableCollection<Friend> Friends { get; set; }

        public Friend SelectedFriend
        {
            get { return _selectedFriend; }
            set
            {
                _selectedFriend = value; 
                OnPropertyChanged();
            }
        }

        public MainViewModel(IFriendDataService friendDataService)
        {
            Friends = new ObservableCollection<Friend>();
            _friendDataService = friendDataService;

        }

        public void Load()
        {
            var friends = _friendDataService.GetAll();

            Friends.Clear();

            foreach (var friend in friends)
            {
                Friends.Add(friend);
            }
        }
    }
}
