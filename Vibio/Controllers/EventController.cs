using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Vibio.Models;
using System.Data.SqlClient;

namespace Vibio.Controllers
{
    public class EventController : Controller
    {
        //const string _connection = "Server = tcp:ivqgu1eln8.database.windows.net,1433; Database = korgie_db; User ID = frankiel@ivqgu1eln8; Password = Helloworld123; Trusted_Connection = False; Encrypt = True; Connection Timeout = 30";
        // GET: Event
        public ActionResult Index()
        {
            string[] allcookies = Request.Cookies.AllKeys;
            bool result = true;
            foreach (string x in allcookies)
            {
                if (x == "Preferences")
                {
                    result = false;
                }
            }

            if (result)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Email = Request.Cookies["Preferences"]["Email"];
            return View(); // don't return anything
        }

        //        public string GetContacts() //Accepted
        //        {
        //            List<User> contacts = new List<User>();
        //            using (var conn = new SqlConnection(_connection))
        //            {
        //                var cmd = new SqlCommand(@"SELECT * FROM Users U, 
        //UserContacts UC WHERE (UC.PrimaryEmailUser=@Email AND UC.PrimaryEmailContact=U.PrimaryEmail AND State='Accepted') OR (UC.PrimaryEmailUser=U.PrimaryEmail AND UC.PrimaryEmailContact=@Email AND State='Accepted')", conn);
        //                conn.Open();
        //                cmd.Parameters.AddWithValue("@Email", Request.Cookies["Preferences"]["Email"]);
        //                using (SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
        //                {
        //                    while (dr.Read())
        //                    {
        //                        contacts.Add(new User(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6).Split(' ').ToList<string>(), dr.GetString(7).Split(' ').ToList<string>(), dr.GetString(8).Split(' ').ToList<string>(),
        //                            dr.GetString(9).Split(' ').ToList<string>(), dr.GetString(10).Split(' ').ToList<string>()));
        //                    }
        //                }
        //            }
        //            return new JavaScriptSerializer().Serialize(contacts);
        //        }
        //        public string GetRequest() //Rejected and Send
        //        {
        //            return new JavaScriptSerializer().Serialize(GetRequestsUni(@"SELECT UC.PrimaryEmailUser, UC.PrimaryEmailContact, U.Name, UC.State FROM Users U, UserContacts UC 
        //WHERE UC.PrimaryEmailUser=@Email AND UC.PrimaryEmailContact=U.PrimaryEmail AND (State='Sent' OR State='Rejected')"));
        //        }


        //private Contact[] GetRequestsUni(string sqlcom)
        //{
        //    List<Contact> contacts = new List<Contact>();
        //    using (var conn = new SqlConnection(_connection))
        //    {
        //        var cmd = new SqlCommand(sqlcom, conn);
        //        conn.Open();
        //        cmd.Parameters.AddWithValue("@Email", Request.Cookies["Preferences"]["Email"]);
        //        using (SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
        //        {
        //            while (dr.Read())
        //            {
        //                contacts.Add(new Contact(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3)));
        //            }
        //        }
        //    }
        //    return contacts.ToArray();
        //}
    }
}