using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Timeline.Models;

namespace Timeline.ViewModels
{
    public class TimelineViewModel : BaseViewModel
    {
        public TimelineViewModel()
        {
            Title = "Timeline";
            TimelineEvents = new ObservableCollection<Event>
                (Services.EventService.GetAllEventsDes());
        }


        private ObservableCollection<Event> _timelineEvents;
        public ObservableCollection<Event> TimelineEvents
        {
            get { return _timelineEvents; }
            set { SetProperty(ref _timelineEvents, value); }
        }
    }
}