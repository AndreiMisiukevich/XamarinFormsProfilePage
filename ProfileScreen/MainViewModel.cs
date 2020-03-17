using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ProfileScreen
{
    public sealed class MainViewModel
    {
        public string Title => "Andrik Just4Fun";
        public string Name => "Andrei Misiukevich";
        public string Role => "Software Engineer at ISsoft";
        public string Picture => "https://sun9-28.userapi.com/c834301/v834301470/87cfc/iwaiivS6ek0.jpg";

        public string Twitter => "https://twitter.com/Andrik_Just4Fun";
        public string LinkedIn => "https://www.linkedin.com/in/andrei-misiukevich-416589aa/";
        public string Instagram => "https://www.instagram.com/andrik_just4fun/";


        private Item _selectedItem;
        public Item SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem != null)
                {
                    _selectedItem.FontAttributes = FontAttributes.None;
                    _selectedItem.FontFamily = "AvenirNext-DemiBold";
                }
                value.FontAttributes = FontAttributes.Bold;
                value.FontFamily = "AvenirNext-Bold";
                _selectedItem = value;
            }
        }

        public Item[] Items { get; } =
        {
            new Item
            {
                Title = "OWNED",
                Repos = new Repo[]
                {
                    new Repo
                    {
                        Title = "CardsView",
                        Url = "https://github.com/AndreiMisiukevich/CardView",
                        Description = "CardsView | CarouselView | CoverflowView | CubeView for Xamarin.Forms 🇧🇾",
                        Issues = "1",
                        PRs = "0",
                        Forks = "86",
                        Stars = "483",
                        Contributors = new Contributor[]
                        {
                            new Contributor
                            {
                                Name = "AndreiMisiukevich",
                                Commits = "645 commits",
                                Plus = "131,243 ++",
                                Minus = "101,029 --",
                                Number = "#1"
                            },
                            new Contributor
                            {
                                Name = "Phenek",
                                Commits = "14 commits",
                                Plus = "4,050 ++",    
                                Minus = "877 --",
                                Number = "#2"
                            },
                            new Contributor
                            {
                                Name = "JTOne123",
                                Commits = "11 commits",    
                                Plus = "3,171 ++",
                                Minus = "1880 --",
                                Number = "#3"
                            }
                        }
                    },
                    new Repo
                    {
                        Title = "ExpandableView",
                        Url = "https://github.com/AndreiMisiukevich/ExpandableView",
                        Description = "Expandable view for Xamarin.Forms 🇧🇾",
                        Issues = "0",
                        PRs = "0",
                        Forks = "13",
                        Stars = "167",
                        Contributors = new Contributor[]
                        {
                            new Contributor
                            {
                                Name = "AndreiMisiukevich",
                                Commits = "45 commits",
                                Plus = "20,847 ++",
                                Minus = "8,672 --",
                                Number = "#1"
                            },
                            new Contributor
                            {
                                Name = "MartinOpde",
                                Commits = "4 commits",
                                Plus = "421 ++",
                                Minus = "219 --",
                                Number = "#2"
                            },
                            new Contributor
                            {
                                Name = "jlovely",
                                Commits = "33 commits",
                                Plus = "20 ++",
                                Minus = "2 --",
                                Number = "#3"
                            }
                        }
                    },
                    new Repo
                    {
                        Title = "HotReload",
                        Url = "https://github.com/AndreiMisiukevich/HotReload",
                        Description = "Xamarin.Forms XAML hot reload, live reload, live xaml 🇧🇾",
                        Issues = "5",
                        PRs = "1",
                        Forks = "42",
                        Stars = "382",
                        Contributors = new Contributor[]
                        {
                            new Contributor
                            {
                                Name = "AndreiMisiukevich",
                                Commits = "213 commits",
                                Plus = "23,847 ++",
                                Minus = "9,835 --",
                                Number = "#1"    
                            },
                            new Contributor
                            {
                                Name = "stanbav",
                                Commits = "16 commits",
                                Plus = "6,470 ++",
                                Minus = "355 --",
                                Number = "#2"
                            },
                            new Contributor
                            {
                                Name = "iBavtovich",
                                Commits = "10 commits",
                                Plus = "1,893 ++",
                                Minus = "139 --",
                                Number = "#3"
                            }
                        }
                    },
                    new Repo
                    {
                        Title = "ContextMenu",
                        Url = "https://github.com/AndreiMisiukevich/ContextMenu",
                        Description = "ContextView for Xamarin.Forms 🇧🇾",
                        Issues = "0",
                        PRs = "0",
                        Forks = "41",
                        Stars = "233",
                        Contributors = new Contributor[]
                        {
                            new Contributor
                            {
                                Name = "AndreiMisiukevich",
                                Commits = "70 commits",
                                Plus = "56,035 ++",
                                Minus = "29,131 --",
                                Number = "#1"
                            },
                            new Contributor
                            {
                                Name = "pkozak2",
                                Commits = "1 commit",
                                Plus = "2 ++",
                                Minus = "0 --",
                                Number = "#2"
                            },
                            new Contributor
                            {
                                Name = "JTOne123",
                                Commits = "1 commits",
                                Plus = "18 ++",
                                Minus = "2 --",
                                Number = "#3"
                            }
                        }
                    },
                    new Repo
                    {
                        Title = "TouchEffect",
                        Url = "https://github.com/AndreiMisiukevich/TouchEffect",
                        Description = "UI-responsive touch effects for Xamarin.Forms 🇧🇾",
                        Issues = "0",
                        PRs = "4",
                        Forks = "15",
                        Stars = "113",
                        Contributors = new Contributor[]
                        {
                            new Contributor
                            {
                                Name = "AndreiMisiukevich",
                                Commits = "100 commits",
                                Plus = "54,922 ++",
                                Minus = "36,315 --",
                                Number = "#1"
                            },
                            new Contributor
                            {
                                Name = "piersdeseilligny",
                                Commits = "4 commits",
                                Plus = "12,753 ++",
                                Minus = "7,682 --",
                                Number = "#2"
                            },
                            new Contributor
                            {
    
                                Name = "stanbav",
                                Commits = "1 commit",
                                Plus = "1,220 ++",
                                Minus = "76 --",
                                Number = "#3"
                            }
                        }
                    },
                    new Repo
                    {
                        Title = "OpenTok-Xamarin.Forms",
                        Url = "https://github.com/AndreiMisiukevich/OpenTok-Xamarin.Forms",
                        Description = "OpenTok: Video/Audio Chat library for Xamarin.Forms 🇧🇾",
                        Issues = "0",
                        PRs = "0",
                        Forks = "12",
                        Stars = "48",
                        Contributors = new Contributor[]
                        {
                            new Contributor
                            {
                                Name = "AndreiMisiukevich",
                                Commits = "43 commits",
                                Plus = "71,976 ++",
                                Minus = "44,026 --",
                                Number = "#1"
                            }    
                        }
                    }
                }
            },
            new Item
            {
                Title = "FORKED",
                Repos = new Repo[]
                {
                    new Repo
                    {
                        Title = "Xamarin/Xamarin.Forms",
                        Url = "https://github.com/xamarin/Xamarin.Forms",
                        Description = "Xamarin.Forms Official Home https://xamarin.com/forms",
                        Issues = "2,147",
                        PRs = "155",
                        Forks = "1.7k",
                        Stars = "4.2k",
                        Contributors = new Contributor[]
                        {
                            new Contributor
                            {
                                Name = "hartez",
                                Commits = "544 commits",
                                Plus = "83,388 ++",
                                Minus = "142,748 --",
                                Number = "#1"
                            },
                            new Contributor
                            {
                                Name = "StephaneDelcroix",
                                Commits = "544 commits",
                                Plus = "64,568 ++",
                                Minus = "55,780 --",
                                Number = "#2"
                            },
                            new Contributor
                            {
                                Name = "rmarinho",
                                Commits = "544 commits",
                                Plus = "59,563 ++",
                                Minus = "57,235 --",
                                Number = "#3"
                            }
                        }
                    }
                }
            }
        };
    }   

    public sealed class Item: BindableObject
    {
        public string Title { get; set; }
        public Repo[] Repos { get; set; }

        private FontAttributes _fontAttributes;
        public FontAttributes FontAttributes
        {
            get => _fontAttributes;
            set
            {
                _fontAttributes = value;
                OnPropertyChanged();
            }
        }

        private string _fontFamily = "AvenirNext-DemiBold";
        public string FontFamily
        {
            get => _fontFamily;
            set
            {
                _fontFamily = value;
                OnPropertyChanged();
            }
        }
    }

    public sealed class Repo : BindableObject
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Issues { get; set; }
        public string PRs { get; set; }
        public string Forks { get; set; }
        public string Stars { get; set; }
        public Contributor[] Contributors { get; set; }

        private bool _isExpanded;
        public bool IsExpanded
        {
            get => _isExpanded;
            set
            {
                _isExpanded = value;
                OnPropertyChanged();
            }
        }

        public Repo()
        {
            TapCommand = new Command(() =>
            {
                IsExpanded = !IsExpanded;
            });

            OpenGitHubCommand = new Command(() =>
            {
                Launcher.OpenAsync(Url);
            });
        }

        public ICommand TapCommand { get; }
        public ICommand OpenGitHubCommand { get; }
    }

    public sealed class Contributor
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Commits { get; set; }
        public string Plus { get; set; }
        public string Minus { get; set; }
    }
}
