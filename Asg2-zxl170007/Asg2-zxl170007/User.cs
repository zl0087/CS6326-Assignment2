using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg2_zxl170007
{
    class User
    {
        public string id { get; set; }
        public string first_name { get; set; }
        public string middle_initial { get; set; }
        public string last_name { get; set; }
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }
        public string gender { get; set; }
        public string phone_number { get; set; }
        public string email_address { get; set; }
        public string proof_of_purchase_attached { get; set; }
        public string date_received { get; set; }
        public string first_enter_time { get; set; }
        public string save_time { get; set; }
        public string backspace_number { get; set; }

        public string get_full_name()
        {
            return first_name +" " + middle_initial+ " " +last_name;
        }
    }



}
