using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BE;
using Newtonsoft.Json;

namespace DAL
{
    public class FoodDAL 
    {
        public class TempData
        {

            public ReportObject.RootObject _root;
            public ReportObject.Desc _food;
            //
        }   
        public class InfoFoodContext: DbContext
        {
           // public DbSet<ReportObject.RootObject> ReportFoodData { get; set;}
            public DbSet<User> Users { get; set;}
         
        }

        public FoodDAL()
        {
            //getFoodDataByName("beer");
            
        }


        public void addUser(User user)
        {
            using (var db = new InfoFoodContext())
            {
                db.Users.Add(user); // adds the user to the DbSet in memory
                db.SaveChanges(); // commits the changes to the database
            }

        }
        public void updateUser(int id)
        {
            using (var db = new InfoFoodContext())
            {
                var user = db.Users.FirstOrDefault(a => a.ID == id);
                //check later
            }
        }

        public User getUser(int id)
        {
            using (var db = new InfoFoodContext())
            {
                var user = db.Users.FirstOrDefault(a => a.ID == id);
                if (user == null)
                {
                    user = new User();
                }
                return user;

            }
        } 

        public void deleteUser(User user)
        {
            using (var db = new InfoFoodContext())
            {
                //var user = db.Users.Find(1);
                db.Users.Remove(user);
                db.SaveChanges();
            }


        }


        public ReportObject.RootObject getFoodDataByName(string name)
        {
            try
            {
                HttpWebRequest SearchFoodWebReq = (HttpWebRequest)WebRequest.Create(string.Format(
               "http://api.nal.usda.gov/ndb/search/?format=JSON&q=" + name + "&sort=n&max=25&offset=0&api_key=W1IAZNHJlfPsg9FL1j1POAqUajeu50fjcicm8skg"));

                SearchFoodWebReq.Method = "GET";

                HttpWebResponse SearchFoodWebResp = (HttpWebResponse)SearchFoodWebReq.GetResponse();

                string SearchFoodjsonString;
                using (Stream stream = SearchFoodWebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
                {
                    StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                    SearchFoodjsonString = reader.ReadToEnd();
                }

                FoodObject.RootObject foodObject = JsonConvert.DeserializeObject<FoodObject.RootObject>(SearchFoodjsonString);//take ndb id from item 
                string ndbno = foodObject.list.item[0].ndbno;

                HttpWebRequest NdbWebReq = (HttpWebRequest)WebRequest.Create(string.Format(
               "https://api.nal.usda.gov/ndb/V2/reports?ndbno=" + ndbno + "&type=b&format=JSON&api_key=W1IAZNHJlfPsg9FL1j1POAqUajeu50fjcicm8skg"));

                NdbWebReq.Method = "GET";

                HttpWebResponse NdbWebResp = (HttpWebResponse)NdbWebReq.GetResponse();

                string NdbjsonString;
                using (Stream stream = NdbWebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
                {
                    StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                    NdbjsonString = reader.ReadToEnd();
                }


                ReportObject.RootObject rootObject = JsonConvert.DeserializeObject<ReportObject.RootObject>(NdbjsonString);
                //rootObject.setKeyValues();

                //        UpdateReportDB(rootObject);

                return rootObject;
            }
            catch (WebException e)
            {
                //using (var db = new InfoFoodContext())
                //{
                //    var result =
                //        (from curr in db.ReportFoodData
                //         where curr.foods[0].food.desc.name.Equals(name)
                //         //lehashlim
                //         select new TempData
                //         {
                //             _root = curr,
                //             //_food = curr.foods[0].food.desc.ndbno,


                //         }).FirstOrDefault();

                //    ReportObject.RootObject rootObject = result._root;
                /*
                 rootObject.report = result._report;
                 var _food = (from curr in db.ReportFoodData
                                 where curr.key_id.Equals(city)
                                 //take care of the key
                                 select (
                                 from i in curr.list
                                 select i.weather
                                 )).FirstOrDefault();
                 rootObject.list[0].weather = _weather.ElementAt(0);
                 */
                //return rootObject;


                // }
                System.Console.WriteLine(e);
                return null;
            }
        }

        //private void UpdateReportDB(ReportObject.Desc rootObject)
        //{
        //    using (var db = new InfoFoodContext())
        //    {
        //        var exist = db.ReportFoodData.SingleOrDefault(info => info.ndbno.Equals(rootObject.ndbno));
                  
        //          // (from info in db.ReportFoodData
        //        //     where info.key_id.Equals(rootObject.key_id)
        //         //    select info).FirstOrDefault();
        //         if (exist != null)
        //        {
        //            db.Entry(exist).CurrentValues.SetValues(rootObject);
        //        }
        //        else
        //        {
        //            db.ReportFoodData.Add(rootObject);
        //        }
        //        db.SaveChanges();
            
        //    }
        //}
    }


}
