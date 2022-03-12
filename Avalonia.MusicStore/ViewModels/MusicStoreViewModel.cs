using System.Collections.ObjectModel;
using System.Reactive;
using ReactiveUI;

namespace Avalonia.MusicStore.ViewModels
{
    public class MusicStoreViewModel : ViewModelBase
    {
        string? _searchText;
        bool _isBusy;
        AlbumViewModel? _selectedAlbum;

        public MusicStoreViewModel()
        {
            SearchResults.Add(new AlbumViewModel());
            SearchResults.Add(new AlbumViewModel());
            SearchResults.Add(new AlbumViewModel());

            BuyMusicCommand = ReactiveCommand.Create(() => SelectedAlbum);
        }

        public string? SearchText
        {
            get => _searchText;
            set => this.RaiseAndSetIfChanged(ref _searchText, value);
        }

        public bool IsBusy
        {
            get => _isBusy;
            set => this.RaiseAndSetIfChanged(ref _isBusy, value);
        }

        public AlbumViewModel? SelectedAlbum
        {
            get => _selectedAlbum;
            set => this.RaiseAndSetIfChanged(ref _selectedAlbum, value);
        }

        public ObservableCollection<AlbumViewModel> SearchResults { get; } = new ObservableCollection<AlbumViewModel>();

        public ReactiveCommand<Unit, AlbumViewModel?> BuyMusicCommand { get; }
    }
}