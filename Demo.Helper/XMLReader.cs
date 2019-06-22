using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Web;
using System.Data;//Add  
using Demo.Helper.ExternalModel; 

namespace Demo.Helper
{
   public class XMLReader
    {
        public List<Products> RetrunListOfProducts()
        {
            string xmlData = HttpContext.Current.Server.MapPath("~/App_Data/ProductData.xml");//Path of the xml script  
            DataSet ds = new DataSet();//Using dataset to read xml file  
            ds.ReadXml(xmlData);
            var products = new List<Products>();
            products = (from rows in ds.Tables[0].AsEnumerable()
                        select new Products
                        {
                            ProductId = Convert.ToInt32(rows[0].ToString()), //Convert row to int  
                            ProductName = rows[1].ToString(),
                            ProductCost = rows[2].ToString(),
                        }).ToList();
            return products;
        }
    }
}
