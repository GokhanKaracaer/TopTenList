using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Demo.Helper.ExternalModel
{
    
        [Serializable]
        [XmlRoot("Products"), XmlType("Products")]
        public class Products
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string ProductCost { get; set; }
        }
   
}
