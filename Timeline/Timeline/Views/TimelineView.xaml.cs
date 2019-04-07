using System.Diagnostics;
using Timeline.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Timeline.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimelineView : ContentPage
    {
        private TimelineViewModel ViewModel;

        public TimelineView()
        {
            InitializeComponent();
            BindingContext = ViewModel = new TimelineViewModel();
        }
    }
}