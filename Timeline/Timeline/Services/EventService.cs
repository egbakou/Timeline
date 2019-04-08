using System.Collections.Generic;
using Timeline.Models;

namespace Timeline.Services
{
    public class EventService
    {
        public static List<Event> GetAllEvents()
        {
            return new List<Event>
            {
                new Event
                {
                    AuthorImage ="me.jpg",
                    Title = "Laurent has a new photo",
                    Detail = "Laurent uploaded a more recently pic from him.",
                    DateToString = "APRIL, 08 2019"
                },
                new Event
                {
                    AuthorImage ="ispace.jpg",
                    Title = "Ispace Corporation liked your Tweet",
                    Detail = "Ispace Corporation liked your last Tweet: Ready to share with ...",
                    DateToString = "APRIL, 08 2019"
                },
                new Event
                {
                    AuthorImage ="lfrii.jpg",
                    Title = "L-frii Retweeted",
                    Detail = "L-frii Retweeted your Tweet.",
                    DateToString = "APRIL, 08 2019"
                },
                 new Event
                {
                    AuthorImage ="mvp.jpg",
                    Title = "MVP Award Program Retweeted your Tweet.",
                    Detail = "MVP Award Program Retweeted your Tweet: MVP Gbobal Submmit...",
                    DateToString = "APRIL, 08 2019"
                },
                 new Event
                {
                    AuthorImage ="sani.jpg",
                    Title = "You have a new follower!",
                    Detail = "Sani Koffi is now following you.",
                    DateToString = "APRIL, 08 2019"
                },
                new Event
                {
                    AuthorImage ="leomaris.jpg",
                    Title = "Leomaris Rayes has a new photo",
                    Detail = "Leomaris Rayes uploaded a more recently pic from her.",
                    DateToString = "APRIL, 08 2019"
                },
                new Event
                {
                    AuthorImage ="houssem.jpg",
                    Title = "Houssem Dellai liked your reply.",
                    Detail = "Houssem Dellai liked your reply: Congratulations !!!",
                    DateToString = "MARCH, 10 2019"
                },
                new Event
                {
                    AuthorImage ="nasa.jpg",
                    Title = "NASA started a broadcast",
                    Detail = "NASA started a new broadcast.",
                    DateToString = "MARCH, 14 2019"
                },
                new Event
                {
                    AuthorImage ="googleanalytics.jpg",
                    Title = "Google Ananytics liked your reply.",
                    Detail = "Google Ananytics and 5 others liked your reply.",
                    DateToString = "JANUARY, 08 2019"
                }               
            };
        }
    }
}
