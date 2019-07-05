using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App31
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RooterMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public RooterMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new RooterMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class RooterMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<RooterMasterDetailPageMenuItem> MenuItems { get; set; }
            
            public RooterMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<RooterMasterDetailPageMenuItem>(new[]
                {
                    new RooterMasterDetailPageMenuItem { Id = 0, Title = "Page 1" },
                    new RooterMasterDetailPageMenuItem { Id = 1, Title = "Page 2" },
                    new RooterMasterDetailPageMenuItem { Id = 2, Title = "Page 3" },
                    new RooterMasterDetailPageMenuItem { Id = 3, Title = "Page 4" },
                    new RooterMasterDetailPageMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}