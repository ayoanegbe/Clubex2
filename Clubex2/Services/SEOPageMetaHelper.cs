namespace Clubex2.Services
{
    public class SEOPageMetaHelper
    {
        public static IEnumerable<Tuple<string, string, string, string>> Collections
        {
            get
            {
                return new List<Tuple<string, string, string, string>>
                {
                   new Tuple<string, string, string, string>("Home/Index", "Dynamic Index", "Index Description","keyword1,keyword2"),
                   new Tuple<string, string, string, string>("Home/About", "Dynamic About",  "About Description","keyword3,keyword4"),
                   new Tuple<string, string, string, string>("Home/Contact", "Dynamic Contact", "Contact Description","keyword5,keyword6")
                };
            }
        }
    }
}
