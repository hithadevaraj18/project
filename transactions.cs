using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingBal
{
    class transactions
    {
        public int transactionid { get; set; }

        public DateTime transactiondate { get; set; }

        public string branch { get; set; }

        public string ifsc{ get; set; }

        public float amount { get; set; }

        public string transactiontype{ get; set; }

       
    }
}
