using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.Text;
using Services_Lab6Model;

namespace Services_Lab7
{
    public class Service1 : IService1
    {
        public SyndicationFeedFormatter GetStudentNotes(string Id_student)
        {
            SyndicationFeed feed = new SyndicationFeed("Subjects & Notes", "Get list of notes by all subjects for this student", null);

            feed.Generator = "C# RSS Sample";
            feed.Language = "ru-ru";
            feed.LastUpdatedTime = new DateTimeOffset(DateTime.Now);
            feed.Title = SyndicationContent.CreatePlaintextContent("Лабораторная работа 7");
            feed.Categories.Add(new SyndicationCategory("Lab7"));
            feed.Authors.Add(new SyndicationPerson("pochikovskaja@gmail.com",
                "Yulia P", "http://www.professorweb.ru"));
            feed.Description = SyndicationContent.CreatePlaintextContent(
                "Результат выполнения лабораторной работы 7");

            List<SyndicationItem> items = new List<SyndicationItem>();
            Console.WriteLine(Id_student);
            Services_Lab6Entities2 wds = new Services_Lab6Entities2(new Uri("http://localhost:51906/WcfDataService1.svc"));
            foreach (var note in wds.Notes.AsEnumerable().Where(i => i.Id_student == int.Parse(Id_student)))
            {
                items.Add(new SyndicationItem(note.Subj, note.Note1.ToString(), null));
            }
            feed.Items = items;

            string query = WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters["format"];
            SyndicationFeedFormatter formatter = null;
            if (query == "atom") 
                formatter = new Atom10FeedFormatter(feed);
            else 
                formatter = new Rss20FeedFormatter(feed);
            return formatter;
        }
    }
}
