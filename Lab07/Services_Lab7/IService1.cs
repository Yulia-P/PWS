using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;

namespace Services_Lab7
{
    [ServiceContract]
    [ServiceKnownType(typeof(Atom10FeedFormatter))]
    [ServiceKnownType(typeof(Rss20FeedFormatter))]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "/{Id_student}")]
        SyndicationFeedFormatter GetStudentNotes(string Id_student);
    }
}
