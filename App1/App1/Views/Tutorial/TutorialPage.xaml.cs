using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.Tutorial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TutorialPage : ContentPage
    { 
        public TutorialPage(string pagetitle, string htmlSource)
        {
            InitializeComponent();
            Title = pagetitle;
            activitybusy.IsVisible = true;
            activitybusy.IsRunning = true;
           
            TutorialWebview.Source = LoadHTMLFileFromResource(htmlSource);
            activitybusy.IsRunning = false;
            activitybusy.IsVisible = false;
        }

        HtmlWebViewSource LoadHTMLFileFromResource(string htmlSource)
        {
            try
            { 
                var source = new HtmlWebViewSource(); 
                var assembly = typeof(TutorialPage).GetTypeInfo().Assembly;
                var stream = assembly.GetManifestResourceStream(htmlSource);//(@"App1.HtmlPages.mysql.html");
                if (stream == null) throw new ArgumentNullException(nameof(stream));
                using (var reader = new StreamReader(stream))
                {
                    source.Html = reader.ReadToEnd();
                }
                return source;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}