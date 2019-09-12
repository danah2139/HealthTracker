using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BE
{
    public class ReportObject
    {
        public class Desc
        {

            //  [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
            [Key]
            public string ndbno { get; set; }
            public string name { get; set; }
            public string sd { get; set; }
            public string fg { get; set; }
            public string sn { get; set; }
            public string cn { get; set; }
            public string manu { get; set; }
            public double nf { get; set; }
            public double cf { get; set; }
            public double ff { get; set; }
            public double pf { get; set; }
            public string r { get; set; }
            public string rd { get; set; }
            public string ds { get; set; }
            public string ru { get; set; }
        }

        public class Nutrient
        {
            [Key]
            public int nutrient_id { get; set; }
            public string name { get; set; }
            public string group { get; set; }
            public string unit { get; set; }
            public double value { get; set; }
            public string derivation { get; set; }
            public object sourcecode { get; set; }
            public object dp { get; set; }
            public string se { get; set; }
            public List<object> measures { get; set; }
        }

        public class Source
        {   [Key]
            public int id { get; set; }
            public string title { get; set; }
            public string authors { get; set; }
            public string vol { get; set; }
            public string iss { get; set; }
            public string year { get; set; }
        }

        public class Food2
        {
            [Key]
            public string sr { get; set; }
            public string type { get; set; }//Report type
            public Desc desc { get; set; }
            public List<Nutrient> nutrients { get; set; }
            public List<Source> sources { get; set; }
            public List<object> footnotes { get; set; }
            public List<object> langual { get; set; }
        }

        public class Food
        {
            [Key]
            [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
            public Food2 food { get; set; }
            public string error { get; set; }
        }

        public class RootObject
        {
            //public  Food2 type  { get; set; }//report type//i added
            public List<Food> foods { get; set; }
            public int count { get; set; }
            public int notfound { get; set; }
            public double api { get; set; }
            //public Desc desc;
            //public string key_id;
            //public string key_id { get; set; }//i added
            //public Desc desc { get; set; }//i added


            //**************************************//

            //public RootObject()
            //{
            //   setKeyValues(); 
            //}

            //public void setKeyValues()
            //{
            //   if (foods != null)
            //    {
            //        key_id = foods[0].food.desc.ndbno;
            //    }
            //}
        }
    }
}

