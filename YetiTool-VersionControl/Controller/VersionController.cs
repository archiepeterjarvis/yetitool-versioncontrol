using System.Web.Http;
using System.IO;

namespace YetiTool_VersionControl.Controller
{
    public class VersionController : ApiController
    {
        public string Get()
        {
            string path = File.ReadAllText(@"C:\inetpub\Websites\VersionControl\versions.json");
            return path;
        }

    }
}
