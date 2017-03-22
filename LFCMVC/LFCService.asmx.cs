using LFCMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LFCMVC
{
    /// <summary>
    /// Summary description for LFCService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class LFCService : System.Web.Services.WebService
    {

        private LFCContext db = new LFCContext();

        [WebMethod]
        public string[] GetFixturesByName(string namePart)
        {
            List<string> fixtures = new List<string>();

            if (namePart != "")
            {
                foreach (var fix in db.Fixtures
                                        .Where(a => a.Stadium.Contains(namePart))
                                        .ToList())
                {
                    fixtures.Add(fix.HomeTeam);
                }
            }

            return fixtures.ToArray();
        }

        [WebMethod]
        public string[] GetFixturesByNameAuto(string namePart)
        {
            List<string> fixtures = new List<string>();

            if (namePart != "")
            {
                foreach (var fix in db.Fixtures
                                        .Where(a => a.Stadium.StartsWith(namePart))
                                        .ToList())
                {
                    fixtures.Add(fix.Stadium);
                }
            }

            return fixtures.ToArray();
        }

        [WebMethod]
        public object[] GetFixturesByPlayer(string namePart)
        {
            List<object> fixtures = new List<object>();

            if (namePart != "")
            {
                foreach (var fix in db.Players
                                        .Where(a => a.LastName.Equals(namePart))
                                        .ToList())
                {
                    fixtures.Add(fix.Nationality);
                    fixtures.Add(fix.SquadNumber);
                }
            }

            return fixtures.ToArray();
        }

        [WebMethod]
        public object[] GetManagerByName(string namePart)
        {
            List<object> managers = new List<object>();

            if (namePart != "")
            {
                foreach (var fix in db.Managers
                                        .Where(a => a.LastName.Equals(namePart))
                                        .ToList())
                {
                    managers.Add(fix.Nationality);
                    managers.Add(fix.Period);
                }
            }

            return managers.ToArray();
        }

    }
}
