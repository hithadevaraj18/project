using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingBal
{
    class fundTranfer
    {
        public int transid { get; set; }

        public string branch { get; set; }

        public int account_no { get; set; }

        public string beneficiary_name { get; set; }

        public int benfid { get; set; }

        public string ifsc { get; set; }

        public float amount{ get; set; }

        public string status { get; set; }

        public DateTime date{ get; set; }
    }

}
