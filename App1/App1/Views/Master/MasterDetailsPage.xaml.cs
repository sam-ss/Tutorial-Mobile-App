using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailsPage : MasterDetailPage
    {
        public MasterDetailsPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var item = e.SelectedItem as MasterDetailsPageMenuItem;
                if (item == null)
                    return;
                Device.BeginInvokeOnMainThread(() =>
                {
                    // var page =(Page)Activator.CreateInstance(item.TargetType);
                    // page.Title = item.Title;

                    // Detail = new NavigationPage(page);
                    Detail = (Page)item.TargetType;
                    IsPresented = false;
                });
                MasterPage.ListView.SelectedItem = null;
            }
            catch (Exception ex)
            {


            }
        }
    }
}