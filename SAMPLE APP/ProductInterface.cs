using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMPLE_APP
{
    public interface ProductInterface
    {
        public int ProductID { get; set; }
        public string ProdName { get; set; }
        public int Quantity { get; set; }

    }

}
