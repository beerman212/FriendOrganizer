using System.Collections.ObjectModel;
using System.Windows.Navigation;
using FriendOrganizer.UI.Data;
using FriendOrganizer.Model;
using System.Threading.Tasks;

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

        public async Task LoadAsync()
        {
            var friends = await _friendDataService.GetAllAsync();

            Friends.Clear();

            foreach (var friend in friends)
            {
                Friends.Add(friend);
            }
        }
    }
}
