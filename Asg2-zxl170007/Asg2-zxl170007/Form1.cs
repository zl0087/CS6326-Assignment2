/*
    CS6326 Assignment 2
    Zhenghang Liu
    Net Id: zxl170007

    Assignment Introduction:   This program is written for The buyer of a particular product sends in a form with various information and a clerk enters it into a program to be stored
                                in a database. User will fill the required information in form and clerk will modify data.

    Program Introduction: User can use this application with or without mouse, use will fill required information and save their data. All the data will be save to a text file.
                          User can also modify and delete the exisiting data.  
                          
                          Vaidation Rules:  User cannot modify or add data unless all requirements fit.
                                            Same Full name and phone number combined  duplicated data is not allowed.
                                            Required fields are marked with * .
                                            Phone number mush be valid US phone number (10 digits)
                                            Zip Code must be 5 or 9 digits number
                                            State must be correct US state
                                            email mush be corrent email

*/
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Asg2_zxl170007
{
    public partial class rebate_form : Form
    {
        int backspace_number = 0; // to save number of backspace key pressed
        bool modify = false; //if the mode is false, it mean the current user is creating new data, else he is modifying old data
        public rebate_form()
        {
            InitializeComponent();
            this.Load += rebate_form_initialize;
            update_form();
        }

        private void rebate_form_initialize(object sender, EventArgs e) //initialize the rebate form
        {
            dateTimePicker_date_received.Value = DateTime.Today; //set datetime to today by default
            dateTimePicker_date_received.MaxDate = DateTime.Today;
            list_display_initialize(sender,e);  //list initialization call
        }
        private void list_display_initialize(object sender, EventArgs e) //initialize the display list
        {
            listView_info.View = View.Details;
            listView_info.FullRowSelect = true;
            listView_info.Columns.Add("ID", 0);
            listView_info.Columns.Add("Name", 200);
            listView_info.Columns.Add("Phone number", 200);
        }

        private void update_form()   //clear data and variable initialization
        {
            button_save.Enabled = false;
            clear_form();
            modify = false;
            errorProvider.Clear();
            FileIO.user_list.Clear();
            listView_info.Items.Clear();
            backspace_number = 0;
            checkBox_proof_yes.Checked = false;
            checkBox_proof_no.Checked = false;
            FileIO.current_user_number = 0;
            FileIO fileIO= new FileIO();
            fileIO.update_data();
            foreach (User NewUser in FileIO.user_list)//add all file data to list view
            {
                string[] new_user = { NewUser.id, NewUser.get_full_name(), NewUser.phone_number };
                ListViewItem n_user = new ListViewItem(new_user);
                n_user.Tag = NewUser.id;
                listView_info.Items.Add(n_user);
            }

        }
        //Clears form data
        private void clear_form()  //Clear the data in form currently
        {
            modify = false;
            button_save.Enabled = false;
            button_delete.Enabled = false;
            textBox_first_name.Clear();
            textBox_middle_initial.Clear();
            textBox_last_name.Clear();
            textBox_address_line_1.Clear();
            textBox_address_line_2.Clear();
            textBox_city.Clear();
            textBox_state.Clear();
            textBox_zip_code.Clear();
            comboBox_gender.SelectedIndex = -1;
            textBox_phone_number.Clear();
            textBox_email_address.Clear();
            textBox_first_enter_time.Clear();
            textBox_save_time.Clear();
            textBox_backspace_number.Clear();
            listView_info.SelectedItems.Clear();
            errorProvider.Clear();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox_first_enter_time.Text = DateTime.Now.ToString("HH:mm:ss tt");
            form_validation();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void TextBox_zip_code_TextChanged(object sender, EventArgs e)
        {
            form_validation();
            zip_code_validation();
        }
        private bool zip_code_validation()
        {
            if (textBox_zip_code.Text.Length == 5 || textBox_zip_code.Text.Length == 9)
            {
                errorProvider.SetError(textBox_zip_code, null);
                return true;
            }
            else
            {
                errorProvider.SetError(textBox_zip_code, "Zip code should be 5 or 9 digits");
                return false;
            }
        }
        private void TextBox_zip_code_KeyPress(object sender, KeyPressEventArgs e)  //form validation zipcode  
        {
            Char chr = e.KeyChar;
            if (chr == 8) //if its back space
            {
                backspace_number += 1;
            }
            else if (!char.IsDigit(chr)) //check if the input is integer
            {
                e.Handled = true;
            }
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            form_validation();

        }

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void CheckBox_proof_yes_CheckedChanged(object sender, EventArgs e)
        {
            form_validation();
            if(checkBox_proof_yes.Checked)
            {
                checkBox_proof_no.Checked = false;
            }

        }

        private void CheckBox_proof_no_CheckedChanged(object sender, EventArgs e)
        {
            form_validation();

            if (checkBox_proof_no.Checked)
            {
                checkBox_proof_yes.Checked = false;
            }
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            FileIO fileIO = new FileIO();
            string proof_of_purchase_attached;
            //Get all the required entered infomation from form
            if (checkBox_proof_yes.Checked)
                proof_of_purchase_attached = "YES";
            else
                proof_of_purchase_attached = "NO";
            string first_name = textBox_first_name.Text;
            string middle_initial = textBox_middle_initial.Text;
            string last_name = textBox_last_name.Text;
            string address_line_1 = textBox_address_line_1.Text;
            string address_line_2 = textBox_address_line_2.Text;
            string city = textBox_city.Text;
            string state = textBox_state.Text;
            string zip_code = textBox_zip_code.Text;
            string gender = comboBox_gender.Text;
            string phone_number = textBox_phone_number.Text;
            string email_address = textBox_email_address.Text;
            string date_received = dateTimePicker_date_received.Value.ToString();
            string first_enter_time = textBox_first_enter_time.Text;
            string save_time = DateTime.Now.ToString("HH:mm:ss tt");
            if (modify == true) //user is trying to modify existing data
            {
                //if we are try to modify a existing data, we will not change the first enter time, save time and backspace number
                //to do this we will grab the editing user object first and save the three var to temp variable and save them
                User user_temp;
                string full_name = listView_info.SelectedItems[0].SubItems[1].Text;  
                string[] temp_user = full_name.Split(' ');                           
                string first_name_temp = temp_user[0];
                string last_name_temp = temp_user[2];
                string phone_number_temp = listView_info.SelectedItems[0].SubItems[2].Text; //get the basic user info for sorting
                foreach (var user in FileIO.user_list)
                {
                    if (user.first_name == first_name_temp && user.last_name == last_name_temp && user.phone_number == phone_number_temp)//grab the exist data of the select user
                    {
                        //set user info in form
                        user_temp = user;
                        first_enter_time = user_temp.first_enter_time;
                        save_time = user_temp.save_time;
                        backspace_number = Int32.Parse(user_temp.backspace_number);
                        modify = true;
                    }
                }
                int user_temp_index = listView_info.SelectedItems[0].Index;
                string info = String.Join("\t", user_temp_index, first_name, middle_initial, last_name,
                address_line_1, address_line_2, city, state, zip_code, gender, phone_number, email_address,
                proof_of_purchase_attached, date_received, first_enter_time, save_time, backspace_number);

                if (validation(first_name, last_name, phone_number))
                    {
                        fileIO.modify_data(info, user_temp_index);    //filo IO function call _modify data
                        dateTimePicker_date_received.Value = DateTime.Today;
                        update_form();
                    }
                else
                    {
                        //we will do dupulication error here and other form validation uniquely
                        errorProvider.SetError(textBox_phone_number, "full name with phone number entered already exist.");
                    }
            }
            else  //user is tring to create new data
            {
                string info = String.Join("\t", FileIO.current_user_number, first_name, middle_initial, last_name,
                    address_line_1, address_line_2, city, state, zip_code, gender, phone_number, email_address,
                    proof_of_purchase_attached, date_received, first_enter_time, save_time, backspace_number);
                if (validation(first_name, last_name, phone_number))
                {
                    fileIO.add_data(info);   //filo ID functin call add data
                    dateTimePicker_date_received.Value = DateTime.Today;
                    update_form();
                }
                else
                {
                    //we will do dupulication error here and other form validation uniquely
                    errorProvider.SetError(textBox_phone_number, "full name with phone number entered already exist.");
                }
            }     
        }


        private void ListView_info_MouseClick(object sender, MouseEventArgs e)  //whenever click a user obj in list view, display the current data
        {
            //select on list display
            errorProvider.Clear();
            User user_temp;
            string full_name = listView_info.SelectedItems[0].SubItems[1].Text;
            string[] temp_user = full_name.Split(' ');
            string first_name_temp = temp_user[0];
            string last_name_temp = temp_user[2];
            string phone_number_temp = listView_info.SelectedItems[0].SubItems[2].Text; //get the basic user info for sorting
            foreach (var user in FileIO.user_list)
            {
                if (user.first_name == first_name_temp && user.last_name ==last_name_temp&& user.phone_number==phone_number_temp)//grab the exist data of the select user
                {
                    //set user info in form
                    user_temp = user;
                    textBox_first_name.Text = user_temp.first_name;
                    textBox_middle_initial.Text = user_temp.middle_initial;
                    textBox_last_name.Text = user_temp.last_name;
                    textBox_address_line_1.Text = user_temp.address_line_1;
                    textBox_address_line_2.Text = user_temp.address_line_2;
                    textBox_city.Text = user_temp.city;
                    textBox_state.Text = user_temp.state;
                    textBox_zip_code.Text = user_temp.zip_code;
                    comboBox_gender.Text = user_temp.gender;
                    textBox_phone_number.Text = user_temp.phone_number;
                    textBox_email_address.Text = user_temp.email_address;
                    if (user_temp.proof_of_purchase_attached == "YES")
                        checkBox_proof_yes.Checked = true;
                    else
                        checkBox_proof_no.Checked = true;
                    DateTime dt = Convert.ToDateTime(user_temp.date_received); ;
                    dateTimePicker_date_received.Value = dt;
                    textBox_first_enter_time.Text = user_temp.first_enter_time;
                    textBox_save_time.Text = user_temp.save_time;
                    textBox_backspace_number.Text = user_temp.backspace_number;
                    modify = true;
                    button_delete.Enabled = true;

                }
            }

            //
        }


        private void TextBox_last_name_TextChanged(object sender, EventArgs e)
        {
            form_validation();
        }

        private void ListView_info_ItemActivate_1(object sender, EventArgs e)
        {
            //same function with mouse click on the list view, but for they keyboard only users
            errorProvider.Clear();
            User user_temp;
            string full_name = listView_info.SelectedItems[0].SubItems[1].Text;
            string[] temp_user = full_name.Split(' ');
            string first_name_temp = temp_user[0];
            string last_name_temp = temp_user[2];
            string phone_number_temp = listView_info.SelectedItems[0].SubItems[2].Text; //get the basic user info for sorting
            foreach (var user in FileIO.user_list)
            {
                if (user.first_name == first_name_temp && user.last_name == last_name_temp && user.phone_number == phone_number_temp)//grab the exist data of the select user
                {
                    //set user info in form
                    user_temp = user;
                    textBox_first_name.Text = user_temp.first_name;
                    textBox_middle_initial.Text = user_temp.middle_initial;
                    textBox_last_name.Text = user_temp.last_name;
                    textBox_address_line_1.Text = user_temp.address_line_1;
                    textBox_address_line_2.Text = user_temp.address_line_2;
                    textBox_city.Text = user_temp.city;
                    textBox_state.Text = user_temp.state;
                    textBox_zip_code.Text = user_temp.zip_code;
                    comboBox_gender.Text = user_temp.gender;
                    textBox_phone_number.Text = user_temp.phone_number;
                    textBox_email_address.Text = user_temp.email_address;
                    if (user_temp.proof_of_purchase_attached == "YES")
                        checkBox_proof_yes.Checked = true;
                    else
                        checkBox_proof_no.Checked = true;
                    DateTime dt = Convert.ToDateTime(user_temp.date_received); ;
                    dateTimePicker_date_received.Value = dt;
                    textBox_first_enter_time.Text = user_temp.first_enter_time;
                    textBox_save_time.Text = user_temp.save_time;
                    textBox_backspace_number.Text = user_temp.backspace_number;
                    modify = true;
                    button_delete.Enabled = true;
                }
            }
        }

        private bool validation(string first_name, string last_name, string phone_number) //check if the full name and phone number combined already exists in file
        {
            if (listView_info.SelectedItems.Count > 0)
            {

            string full_name = listView_info.SelectedItems[0].SubItems[1].Text;
            string[] temp_user = full_name.Split(' ');
            string first_name_temp = temp_user[0];
            string last_name_temp = temp_user[2];
            string phone_number_temp = listView_info.SelectedItems[0].SubItems[2].Text; //get the basic user info for sorting

                if (first_name == first_name_temp && last_name == last_name_temp && phone_number == phone_number_temp)//grab the exist data of the select user
                {
                    return true;
                }
            }
            foreach (User user in FileIO.user_list)
            {
                if (user.first_name == first_name && user.last_name == last_name && user.phone_number == phone_number)//grab the exist data of the select user
                {
                    return false;
                }
            }
                
            return true;
        }

        private void ListView_info_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            modify = false;
        }

        private void TextBox_first_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 8) //if its back space
            {
                backspace_number += 1;
            }
        }

        private void TextBox_middle_initial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 8) //if its back space
            {
                backspace_number += 1;
            }
        }

        private void TextBox_last_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 8) //if its back space
            {
                backspace_number += 1;
            }
        }

        private void TextBox_address_line_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 8) //if its back space
            {
                backspace_number += 1;
            }
        }

        private void TextBox_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 8) //if its back space
            {
                backspace_number += 1;
            }
        }

        private void TextBox_address_line_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 8) //if its back space
            {
                backspace_number += 1;
            }
        }

        private void TextBox_state_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 8) //if its back space
            {
                backspace_number += 1;
            }
        }

        private void TextBox_phone_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 8) //if its back space
            {
                backspace_number += 1;
            }
            else if (!char.IsDigit(chr)) //check if the input is integer
            {
                e.Handled = true;
            }
        }

        private void TextBox_email_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (chr == 8) //if its back space
            {
                backspace_number += 1;
            }
        }

        // Validates of all required textboxes are entered
        void form_validation()  //call this function whenever any fields have changes, the save button will be enabled only if users reach all the requirements 
        {
            // Check if all the required fields contain proper values
            Regex email_reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Regex states_reg = new Regex("^(?-i:A[LKSZRAEP]|C[AOT]|D[EC]|F[LM]|G[AU]|HI|I[ADLN]|K[SY]|LA|M[ADEHINOPST]|N[CDEHJMVY]|O[HKR]|P[ARW]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY])$");
            if (!string.IsNullOrEmpty(textBox_first_name.Text) && !string.IsNullOrEmpty(textBox_last_name.Text) && !string.IsNullOrEmpty(textBox_address_line_1.Text) &&
                !string.IsNullOrEmpty(textBox_zip_code.Text) && !string.IsNullOrEmpty(textBox_state.Text) && !string.IsNullOrEmpty(comboBox_gender.Text) &&
                !string.IsNullOrEmpty(textBox_phone_number.Text) && !string.IsNullOrEmpty(textBox_email_address.Text) && !string.IsNullOrEmpty(textBox_city.Text)
                &&(checkBox_proof_yes.Checked||checkBox_proof_no.Checked)&& email_reg.IsMatch(textBox_email_address.Text)&& textBox_phone_number.Text.Length == 10
                && states_reg.IsMatch(textBox_state.Text)&&(textBox_zip_code.Text.Length==5|| textBox_zip_code.Text.Length == 9))
            {
                    button_save.Enabled = true;
            }
            else button_save.Enabled = false;


        }

        private bool phone_number_validation()
        {
            if (textBox_phone_number.Text.Length == 10)
            {
                errorProvider.SetError(textBox_phone_number, null);
                return true;
            }
            else
            {
                errorProvider.SetError(textBox_phone_number, "Please enter correct 10 digits US phone number");
                return false;

            }
        }
        private bool city_validation()
        {
            if (textBox_city.Text.Length ==0)
            { 
                errorProvider.SetError(textBox_city, "City is required");
                return false;
            }

            else
            {
                errorProvider.SetError(textBox_city, null);
                return true;
            }
        }
        private bool state_validation() //regualer expression validation for state
        {
            Regex states_reg = new Regex("^(?-i:A[LKSZRAEP]|C[AOT]|D[EC]|F[LM]|G[AU]|HI|I[ADLN]|K[SY]|LA|M[ADEHINOPST]|N[CDEHJMVY]|O[HKR]|P[ARW]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY])$");
            
            if (!states_reg.IsMatch(textBox_state.Text))
            {
                errorProvider.SetError(textBox_state, "Please enter correct state");
                return false;
            }
            else
            {
                errorProvider.SetError(textBox_state, null);
                return true;
            }
        }

        private bool email_validation()  //regual expression validation for email address
        {
            Regex email_reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!email_reg.IsMatch(textBox_email_address.Text))
            {
                errorProvider.SetError(textBox_email_address, "Please enter correct email");
                return false;
            }
            else
            {
                errorProvider.SetError(textBox_email_address, null);
                return true;
            }
        }
        private void TextBox_address_line_1_TextChanged(object sender, EventArgs e)
        {
            form_validation();
        }

        private void TextBox_city_TextChanged(object sender, EventArgs e)
        {
            form_validation();
            city_validation();
        }

        private void TextBox_state_TextChanged_1(object sender, EventArgs e)
        {
            form_validation();
            state_validation();
        }

        private void TextBox_phone_number_TextChanged(object sender, EventArgs e)
        {
            form_validation();
            phone_number_validation();
        }

        private void TextBox_email_address_TextChanged(object sender, EventArgs e)
        {
            form_validation();
            email_validation();
        }

        private void Label_proof_of_purchase_attached_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            clear_form();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FileIO fileIO = new FileIO();
            int user_temp_index = listView_info.SelectedItems[0].Index;
            fileIO.delete_data(user_temp_index);
            dateTimePicker_date_received.Value = DateTime.Today;
            update_form();   
        }

        private void ListView_info_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_info.SelectedItems.Count > 0)
            {
                //select on list display
                errorProvider.Clear();
                User user_temp;
                string full_name = listView_info.SelectedItems[0].SubItems[1].Text;
                string[] temp_user = full_name.Split(' ');
                string first_name_temp = temp_user[0];
                string last_name_temp = temp_user[2];
                string phone_number_temp = listView_info.SelectedItems[0].SubItems[2].Text; //get the basic user info for sorting
                foreach (var user in FileIO.user_list)
                {
                    if (user.first_name == first_name_temp && user.last_name == last_name_temp && user.phone_number == phone_number_temp)//grab the exist data of the select user
                    {
                        //set user info in form
                        user_temp = user;
                        textBox_first_name.Text = user_temp.first_name;
                        textBox_middle_initial.Text = user_temp.middle_initial;
                        textBox_last_name.Text = user_temp.last_name;
                        textBox_address_line_1.Text = user_temp.address_line_1;
                        textBox_address_line_2.Text = user_temp.address_line_2;
                        textBox_city.Text = user_temp.city;
                        textBox_state.Text = user_temp.state;
                        textBox_zip_code.Text = user_temp.zip_code;
                        comboBox_gender.Text = user_temp.gender;
                        textBox_phone_number.Text = user_temp.phone_number;
                        textBox_email_address.Text = user_temp.email_address;
                        if (user_temp.proof_of_purchase_attached == "YES")
                            checkBox_proof_yes.Checked = true;
                        else
                            checkBox_proof_no.Checked = true;
                        DateTime dt = Convert.ToDateTime(user_temp.date_received); ;
                        dateTimePicker_date_received.Value = dt;
                        textBox_first_enter_time.Text = user_temp.first_enter_time;
                        textBox_save_time.Text = user_temp.save_time;
                        textBox_backspace_number.Text = user_temp.backspace_number;
                        modify = true;
                        button_delete.Enabled = true;

                    }
                }
            }
        }
    }
}
