using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Asg2_zxl170007
{
    class FileIO
    {
        public string data_file = "CS6326Asg2.txt";
        public string modify = "modify";
        public string add = "add";
        public static List<User> user_list = new List<User>(); //save required user info
        public static int current_user_number=0;
        public void update_data()
        {
            if (File.Exists(data_file))
            {
                StreamReader file = new StreamReader(data_file);
                List<String> lines = File.ReadAllLines(data_file).ToList();
                foreach (var line in lines)
                {
                    string[] entries = line.Split('\t');
                    User NewUser = new User();
                    NewUser.id = entries[0];
                    NewUser.first_name = entries[1];
                    NewUser.middle_initial = entries[2];
                    NewUser.last_name = entries[3];
                    NewUser.address_line_1 = entries[4];
                    NewUser.address_line_2 = entries[5];
                    NewUser.city = entries[6];
                    NewUser.state = entries[7];
                    NewUser.zip_code = entries[8];
                    NewUser.gender = entries[9];
                    NewUser.phone_number = entries[10];
                    NewUser.email_address = entries[11];
                    NewUser.proof_of_purchase_attached = entries[12];
                    NewUser.date_received = entries[13];
                    NewUser.first_enter_time = entries[14];
                    NewUser.save_time = entries[15];
                    NewUser.backspace_number = entries[16];
                    user_list.Add(NewUser);
                    current_user_number++;
                }
                file.Close();
            }
        }


        public void modify_data(string info, int user_temp_index)
        {
            string[] new_data = File.ReadAllLines(data_file);
            new_data[user_temp_index] = info;
            File.WriteAllLines(data_file, new_data);
        }
        public void add_data(string info)
        {
                System.IO.StreamWriter file_write = new System.IO.StreamWriter(data_file, true);
                file_write.WriteLine(info);
                file_write.Close();
        }

        public void delete_data(int user_temp_index)
        {
            //StreamReader file = new StreamReader(data_file);
            List<String> lines = File.ReadAllLines(data_file).ToList();
            lines.RemoveAt(user_temp_index);
            File.WriteAllLines(data_file, lines);
        }


    }
}
