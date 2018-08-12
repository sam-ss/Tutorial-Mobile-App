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

namespace App1.Views.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailsPageMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailsPageMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailsPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailsPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailsPageMenuItem> MenuItems { get; set; }

            public MasterDetailsPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailsPageMenuItem>(new[]
                {
                    //new MasterDetailsPageMenuItem { Id = 0, Title = "Home",TargetType= new NavigationPage(new MasterDetailsPageDetail())},
                    new MasterDetailsPageMenuItem { Id = 1, Title = Constants.MYSQL_PAGETITLE,TargetType = new NavigationPage(new Tutorial.TutorialPage(Constants.MYSQL_PAGETITLE, Constants.MY_SQL))},
                     new MasterDetailsPageMenuItem { Id = 1, Title = Constants.PHP_PAGETITLE,TargetType = new NavigationPage(new Tutorial.TutorialPage(Constants.PHP_PAGETITLE,Constants.PHP))},
                      new MasterDetailsPageMenuItem { Id = 1, Title = Constants.SQL_SERVER_PAGETITLE,TargetType = new NavigationPage(new Tutorial.TutorialPage(Constants.SQL_SERVER_PAGETITLE,Constants.SQL_SERVER))},

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