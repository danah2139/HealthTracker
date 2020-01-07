using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BE;
using Newtonsoft.Json;

namespace DAL
{
    public class FoodDAL 
    {
        public class TempData
        {

            public double weight;
            public string dataOfWeight;
            //
        }   
        public class InfoFoodContext: DbContext
        {
           // public DbSet<ReportObject.RootObject> ReportFoodData { get; set;}
            public DbSet<User> Users { get; set;}
            public DbSet<WeekComleteWeightInfo> WeekComleteWeightInfos { get; set; }
        }

        public FoodDAL()
        {
            //getFoodDataByName("beer");
            
        }

        //public Void addWight()
        public void addUser(User user)
        {
            using (var db = new InfoFoodContext())
            {
                if (getUser(user.UserId) != null)
                {
                    MessageBox.Show("user already exists");
                    return;
                }
                db.Users.Add(user); // adds the user to the DbSet in memory
                db.WeekComleteWeightInfos.Add(new WeekComleteWeightInfo ( user.Id,user.UserId,user.Weight,user.DateOfWeight ));
                db.SaveChanges(); // commits the changes to the database
            }

        }
        public void updateUser(User user)
        {
            using (var db = new InfoFoodContext())
            {
                var updaeUser = db.Users.FirstOrDefault(a => a.UserId == user.UserId);
                if (user.DateOfWeight != updaeUser.DateOfWeight)
                {
                    db.WeekComleteWeightInfos.Add(new WeekComleteWeightInfo ( user.Id, user.UserId, user.Weight, user.DateOfWeight ));
                }
                db.Users.Find(updaeUser.Id).Height = user.Height;
                db.Users.Find(updaeUser.Id).Weight = user.Weight;
                db.Users.Find(updaeUser.Id).Name = user.Name;
                db.Users.Find(updaeUser.Id).DateOfBirth = user.DateOfBirth;
                db.Users.Find(updaeUser.Id).DateOfWeight = user.DateOfWeight;
                db.Users.Find(updaeUser.Id)._gender = user._gender;
                db.Users.Find(updaeUser.Id)._mood = user._mood;
                db.Users.Find(updaeUser.Id)._familyStatus = user._familyStatus;
                db.Users.Find(updaeUser.Id)._activity = user._activity;

                db.SaveChanges();
                
            }
        }

        public User getUser(string id)
        {
            using (var db = new InfoFoodContext())
            {
                var user = db.Users.FirstOrDefault(a => a.UserId == id);
       
                return user;

            }
        } 

        public void deleteUser(User user)
        {
            using (var db = new InfoFoodContext())
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }


        }
        public List<KeyValuePair<string,double>> getGraphData(string id)
        {
            using (var db = new InfoFoodContext())
            {
             
                List<KeyValuePair<string, double>> list = new List<KeyValuePair<string, double>>();
                
                var result = (from c in db.WeekComleteWeightInfos
                              where c.UserId ==id
                              select new TempData
                              {
                                  dataOfWeight = c.CurrentDate,
                                  weight = c.WeightNow
                              }).ToList();
                foreach (TempData i in result)
                {
                    list.Add(new KeyValuePair<string, double>(i.dataOfWeight,i.weight));
                }
                return list;
            }


        }


        public ReportObject.RootObject getFoodDataByName(string name)
        {
            try
            {
                name.Replace(" ","%20");
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
