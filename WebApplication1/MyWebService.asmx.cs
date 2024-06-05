using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for MyWebService_asmx
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService_asmx : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello, World!";
        }
        [WebMethod]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

}
