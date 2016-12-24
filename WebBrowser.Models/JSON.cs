using System.IO;
using System.Web.Script.Serialization;

namespace WebBrowserDemo
{
    public class JSON
    {
        public Profile profile = new Profile();

        public void readJSON()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            StreamReader json = new StreamReader(path + "\\profile.json");
            JavaScriptSerializer jss = new JavaScriptSerializer();
            profile = jss.Deserialize<WebBrowserDemo.Profile>(json.ReadToEnd());
            json.Close();
        }

        public void writeJSON()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            StreamWriter json = new StreamWriter(path + "\\profile.json");
            JavaScriptSerializer jss = new JavaScriptSerializer();
            json.Write(jss.Serialize(profile));
            json.Close();
        }
    }
}
