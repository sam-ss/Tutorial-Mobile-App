using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.Views.Master
{

    public class MasterDetailsPageMenuItem
    {
        public MasterDetailsPageMenuItem()
        {
           TargetType = new NavigationPage(new MasterDetailsPageDetail());// typeof(MasterDetailsPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public object TargetType { get; set; }
    }
}