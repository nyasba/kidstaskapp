using KidsTaskApp.item;
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

namespace KidsTaskApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KidsTaskMainMaster : ContentPage
    {
        public ListView ListView;

        public KidsTaskMainMaster()
        {
            InitializeComponent();

            BindingContext = new KidsTaskMainMasterViewModel();
            ListView = MenuItemsListView;
        }

        class KidsTaskMainMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<KidsTaskMainMenuItem> MenuItems { get; set; }

            public KidsTaskMainMasterViewModel()
            {
                MenuItems = new ObservableCollection<KidsTaskMainMenuItem>(new[]
                {
                    new KidsTaskMainMenuItem(0, "あさ", typeof(KidsTaskMorning)),
                    new KidsTaskMainMenuItem(0, "よる", typeof(KidsTaskEvening)),
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