using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllinOne.BLL
{
    class trnsactionBLL
    {
        public int bill_id { get; set; }
        public decimal grandtotal { get; set; }
       
        public decimal Discounnt_amount { get; set; }
        public DateTime date { get; set; }
        public DataTable transactionDetails { get; set; }

    }
}
