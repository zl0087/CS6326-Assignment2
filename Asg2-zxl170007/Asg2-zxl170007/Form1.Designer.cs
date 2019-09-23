using System.Reflection.Emit;

namespace Asg2_zxl170007
{
    partial class rebate_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_first_name = new System.Windows.Forms.Label();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.label_last_name = new System.Windows.Forms.Label();
            this.textBox_middle_initial = new System.Windows.Forms.TextBox();
            this.label_middle_initial = new System.Windows.Forms.Label();
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.textBox_address_line_1 = new System.Windows.Forms.TextBox();
            this.label_address_line_1 = new System.Windows.Forms.Label();
            this.textBox_address_line_2 = new System.Windows.Forms.TextBox();
            this.label_address_line_2 = new System.Windows.Forms.Label();
            this.textBox_zip_code = new System.Windows.Forms.TextBox();
            this.textBox_state = new System.Windows.Forms.TextBox();
            this.label_state = new System.Windows.Forms.Label();
            this.label_zip_code = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.label_city = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.textBox_phone_number = new System.Windows.Forms.TextBox();
            this.label_phone_number = new System.Windows.Forms.Label();
            this.textBox_email_address = new System.Windows.Forms.TextBox();
            this.label_email_address = new System.Windows.Forms.Label();
            this.checkBox_proof_yes = new System.Windows.Forms.CheckBox();
            this.label_proof_of_purchase_attached = new System.Windows.Forms.Label();
            this.checkBox_proof_no = new System.Windows.Forms.CheckBox();
            this.label_date_received = new System.Windows.Forms.Label();
            this.dateTimePicker_date_received = new System.Windows.Forms.DateTimePicker();
            this.button_save = new System.Windows.Forms.Button();
            this.listView_info = new System.Windows.Forms.ListView();
            this.textBox_first_enter_time = new System.Windows.Forms.TextBox();
            this.textBox_backspace_number = new System.Windows.Forms.TextBox();
            this.textBox_save_time = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label_first_name
            // 
            this.label_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_first_name.Location = new System.Drawing.Point(76, 100);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(152, 45);
            this.label_first_name.TabIndex = 0;
            this.label_first_name.Text = "First Name";
            this.label_first_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_first_name.Location = new System.Drawing.Point(234, 100);
            this.textBox_first_name.MaxLength = 20;
            this.textBox_first_name.Multiline = true;
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(277, 40);
            this.textBox_first_name.TabIndex = 1;
            this.textBox_first_name.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox_first_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_first_name_KeyPress);
            // 
            // label_last_name
            // 
            this.label_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_last_name.Location = new System.Drawing.Point(780, 100);
            this.label_last_name.Name = "label_last_name";
            this.label_last_name.Size = new System.Drawing.Size(137, 45);
            this.label_last_name.TabIndex = 2;
            this.label_last_name.Text = "Last Name";
            this.label_last_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_middle_initial
            // 
            this.textBox_middle_initial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_middle_initial.Location = new System.Drawing.Point(698, 100);
            this.textBox_middle_initial.MaxLength = 1;
            this.textBox_middle_initial.Multiline = true;
            this.textBox_middle_initial.Name = "textBox_middle_initial";
            this.textBox_middle_initial.Size = new System.Drawing.Size(53, 40);
            this.textBox_middle_initial.TabIndex = 2;
            this.textBox_middle_initial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_middle_initial_KeyPress);
            // 
            // label_middle_initial
            // 
            this.label_middle_initial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_middle_initial.Location = new System.Drawing.Point(540, 100);
            this.label_middle_initial.Name = "label_middle_initial";
            this.label_middle_initial.Size = new System.Drawing.Size(152, 45);
            this.label_middle_initial.TabIndex = 4;
            this.label_middle_initial.Text = "Middle initial ";
            this.label_middle_initial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_last_name.Location = new System.Drawing.Point(923, 100);
            this.textBox_last_name.MaxLength = 20;
            this.textBox_last_name.Multiline = true;
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(277, 40);
            this.textBox_last_name.TabIndex = 3;
            this.textBox_last_name.TextChanged += new System.EventHandler(this.TextBox_last_name_TextChanged);
            this.textBox_last_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_last_name_KeyPress);
            // 
            // textBox_address_line_1
            // 
            this.textBox_address_line_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address_line_1.Location = new System.Drawing.Point(234, 170);
            this.textBox_address_line_1.MaxLength = 35;
            this.textBox_address_line_1.Multiline = true;
            this.textBox_address_line_1.Name = "textBox_address_line_1";
            this.textBox_address_line_1.Size = new System.Drawing.Size(966, 40);
            this.textBox_address_line_1.TabIndex = 4;
            this.textBox_address_line_1.TextChanged += new System.EventHandler(this.TextBox_address_line_1_TextChanged);
            this.textBox_address_line_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_address_line_1_KeyPress);
            // 
            // label_address_line_1
            // 
            this.label_address_line_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address_line_1.Location = new System.Drawing.Point(45, 170);
            this.label_address_line_1.Name = "label_address_line_1";
            this.label_address_line_1.Size = new System.Drawing.Size(183, 45);
            this.label_address_line_1.TabIndex = 9;
            this.label_address_line_1.Text = "Address line 1";
            this.label_address_line_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_address_line_2
            // 
            this.textBox_address_line_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address_line_2.Location = new System.Drawing.Point(234, 240);
            this.textBox_address_line_2.MaxLength = 35;
            this.textBox_address_line_2.Multiline = true;
            this.textBox_address_line_2.Name = "textBox_address_line_2";
            this.textBox_address_line_2.Size = new System.Drawing.Size(966, 40);
            this.textBox_address_line_2.TabIndex = 5;
            this.textBox_address_line_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_address_line_2_KeyPress);
            // 
            // label_address_line_2
            // 
            this.label_address_line_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address_line_2.Location = new System.Drawing.Point(45, 240);
            this.label_address_line_2.Name = "label_address_line_2";
            this.label_address_line_2.Size = new System.Drawing.Size(183, 45);
            this.label_address_line_2.TabIndex = 11;
            this.label_address_line_2.Text = "Address line 2";
            this.label_address_line_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_zip_code
            // 
            this.textBox_zip_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_zip_code.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_zip_code.Location = new System.Drawing.Point(1046, 310);
            this.textBox_zip_code.MaxLength = 9;
            this.textBox_zip_code.Multiline = true;
            this.textBox_zip_code.Name = "textBox_zip_code";
            this.textBox_zip_code.Size = new System.Drawing.Size(155, 40);
            this.textBox_zip_code.TabIndex = 8;
            this.textBox_zip_code.TextChanged += new System.EventHandler(this.TextBox_zip_code_TextChanged);
            this.textBox_zip_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_zip_code_KeyPress);
            // 
            // textBox_state
            // 
            this.textBox_state.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_state.Location = new System.Drawing.Point(733, 310);
            this.textBox_state.MaxLength = 2;
            this.textBox_state.Multiline = true;
            this.textBox_state.Name = "textBox_state";
            this.textBox_state.Size = new System.Drawing.Size(122, 40);
            this.textBox_state.TabIndex = 7;
            this.textBox_state.TextChanged += new System.EventHandler(this.TextBox_state_TextChanged_1);
            this.textBox_state.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_state_KeyPress);
            // 
            // label_state
            // 
            this.label_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_state.Location = new System.Drawing.Point(575, 310);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(152, 40);
            this.label_state.TabIndex = 16;
            this.label_state.Text = "State";
            this.label_state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_zip_code
            // 
            this.label_zip_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_zip_code.Location = new System.Drawing.Point(903, 310);
            this.label_zip_code.Name = "label_zip_code";
            this.label_zip_code.Size = new System.Drawing.Size(137, 40);
            this.label_zip_code.TabIndex = 15;
            this.label_zip_code.Text = "Zip Code";
            this.label_zip_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_city
            // 
            this.textBox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_city.Location = new System.Drawing.Point(234, 310);
            this.textBox_city.MaxLength = 25;
            this.textBox_city.Multiline = true;
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(333, 40);
            this.textBox_city.TabIndex = 6;
            this.textBox_city.TextChanged += new System.EventHandler(this.TextBox_city_TextChanged);
            this.textBox_city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_city_KeyPress);
            // 
            // label_city
            // 
            this.label_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_city.Location = new System.Drawing.Point(76, 310);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(152, 45);
            this.label_city.TabIndex = 13;
            this.label_city.Text = "City";
            this.label_city.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_gender
            // 
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.Location = new System.Drawing.Point(76, 380);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(152, 45);
            this.label_gender.TabIndex = 19;
            this.label_gender.Text = "Gender";
            this.label_gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.AllowDrop = true;
            this.comboBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.ItemHeight = 32;
            this.comboBox_gender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBox_gender.Location = new System.Drawing.Point(234, 380);
            this.comboBox_gender.MaxDropDownItems = 2;
            this.comboBox_gender.MaxLength = 1;
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(202, 40);
            this.comboBox_gender.TabIndex = 9;
            this.comboBox_gender.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // textBox_phone_number
            // 
            this.textBox_phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phone_number.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_phone_number.Location = new System.Drawing.Point(234, 450);
            this.textBox_phone_number.MaxLength = 10;
            this.textBox_phone_number.Multiline = true;
            this.textBox_phone_number.Name = "textBox_phone_number";
            this.textBox_phone_number.Size = new System.Drawing.Size(277, 40);
            this.textBox_phone_number.TabIndex = 10;
            this.textBox_phone_number.TextChanged += new System.EventHandler(this.TextBox_phone_number_TextChanged);
            this.textBox_phone_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_phone_number_KeyPress);
            // 
            // label_phone_number
            // 
            this.label_phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone_number.Location = new System.Drawing.Point(12, 450);
            this.label_phone_number.Name = "label_phone_number";
            this.label_phone_number.Size = new System.Drawing.Size(216, 40);
            this.label_phone_number.TabIndex = 21;
            this.label_phone_number.Text = "Phone number";
            this.label_phone_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_email_address
            // 
            this.textBox_email_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email_address.Location = new System.Drawing.Point(234, 520);
            this.textBox_email_address.MaxLength = 60;
            this.textBox_email_address.Multiline = true;
            this.textBox_email_address.Name = "textBox_email_address";
            this.textBox_email_address.Size = new System.Drawing.Size(333, 40);
            this.textBox_email_address.TabIndex = 11;
            this.textBox_email_address.TextChanged += new System.EventHandler(this.TextBox_email_address_TextChanged);
            this.textBox_email_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_email_address_KeyPress);
            // 
            // label_email_address
            // 
            this.label_email_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email_address.Location = new System.Drawing.Point(76, 520);
            this.label_email_address.Name = "label_email_address";
            this.label_email_address.Size = new System.Drawing.Size(152, 40);
            this.label_email_address.TabIndex = 23;
            this.label_email_address.Text = "E-mail address";
            this.label_email_address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_proof_yes
            // 
            this.checkBox_proof_yes.AutoSize = true;
            this.checkBox_proof_yes.Location = new System.Drawing.Point(234, 612);
            this.checkBox_proof_yes.Name = "checkBox_proof_yes";
            this.checkBox_proof_yes.Size = new System.Drawing.Size(63, 24);
            this.checkBox_proof_yes.TabIndex = 12;
            this.checkBox_proof_yes.Text = "Yes";
            this.checkBox_proof_yes.UseVisualStyleBackColor = true;
            this.checkBox_proof_yes.CheckedChanged += new System.EventHandler(this.CheckBox_proof_yes_CheckedChanged);
            // 
            // label_proof_of_purchase_attached
            // 
            this.label_proof_of_purchase_attached.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_proof_of_purchase_attached.Location = new System.Drawing.Point(12, 584);
            this.label_proof_of_purchase_attached.Name = "label_proof_of_purchase_attached";
            this.label_proof_of_purchase_attached.Size = new System.Drawing.Size(218, 76);
            this.label_proof_of_purchase_attached.TabIndex = 26;
            this.label_proof_of_purchase_attached.Text = "Proof of purchase attached ";
            this.label_proof_of_purchase_attached.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_proof_of_purchase_attached.Click += new System.EventHandler(this.Label_proof_of_purchase_attached_Click);
            // 
            // checkBox_proof_no
            // 
            this.checkBox_proof_no.AutoSize = true;
            this.checkBox_proof_no.Location = new System.Drawing.Point(331, 612);
            this.checkBox_proof_no.Name = "checkBox_proof_no";
            this.checkBox_proof_no.Size = new System.Drawing.Size(55, 24);
            this.checkBox_proof_no.TabIndex = 13;
            this.checkBox_proof_no.Text = "No";
            this.checkBox_proof_no.UseVisualStyleBackColor = true;
            this.checkBox_proof_no.CheckedChanged += new System.EventHandler(this.CheckBox_proof_no_CheckedChanged);
            // 
            // label_date_received
            // 
            this.label_date_received.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date_received.Location = new System.Drawing.Point(10, 660);
            this.label_date_received.Name = "label_date_received";
            this.label_date_received.Size = new System.Drawing.Size(218, 76);
            this.label_date_received.TabIndex = 28;
            this.label_date_received.Text = "Date received";
            this.label_date_received.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_date_received
            // 
            this.dateTimePicker_date_received.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_date_received.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_date_received.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_date_received.Location = new System.Drawing.Point(234, 686);
            this.dateTimePicker_date_received.Name = "dateTimePicker_date_received";
            this.dateTimePicker_date_received.Size = new System.Drawing.Size(465, 35);
            this.dateTimePicker_date_received.TabIndex = 14;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(81, 790);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(141, 56);
            this.button_save.TabIndex = 15;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // listView_info
            // 
            this.listView_info.HideSelection = false;
            this.listView_info.Location = new System.Drawing.Point(1280, 49);
            this.listView_info.Name = "listView_info";
            this.listView_info.Size = new System.Drawing.Size(668, 1031);
            this.listView_info.TabIndex = 18;
            this.listView_info.UseCompatibleStateImageBehavior = false;
            this.listView_info.ItemActivate += new System.EventHandler(this.ListView_info_ItemActivate_1);
            this.listView_info.SelectedIndexChanged += new System.EventHandler(this.ListView_info_SelectedIndexChanged);
            this.listView_info.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_info_MouseClick);
            // 
            // textBox_first_enter_time
            // 
            this.textBox_first_enter_time.Location = new System.Drawing.Point(0, 1142);
            this.textBox_first_enter_time.Name = "textBox_first_enter_time";
            this.textBox_first_enter_time.Size = new System.Drawing.Size(196, 26);
            this.textBox_first_enter_time.TabIndex = 32;
            this.textBox_first_enter_time.Visible = false;
            // 
            // textBox_backspace_number
            // 
            this.textBox_backspace_number.Location = new System.Drawing.Point(0, 1099);
            this.textBox_backspace_number.Name = "textBox_backspace_number";
            this.textBox_backspace_number.Size = new System.Drawing.Size(196, 26);
            this.textBox_backspace_number.TabIndex = 33;
            this.textBox_backspace_number.Visible = false;
            // 
            // textBox_save_time
            // 
            this.textBox_save_time.Location = new System.Drawing.Point(0, 1121);
            this.textBox_save_time.Name = "textBox_save_time";
            this.textBox_save_time.Size = new System.Drawing.Size(196, 26);
            this.textBox_save_time.TabIndex = 34;
            this.textBox_save_time.Visible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(57, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 37);
            this.label1.TabIndex = 35;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(757, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 37);
            this.label2.TabIndex = 36;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(22, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 37);
            this.label3.TabIndex = 37;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(90, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 37);
            this.label4.TabIndex = 38;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(888, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 37);
            this.label5.TabIndex = 39;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(590, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 37);
            this.label6.TabIndex = 40;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(74, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 37);
            this.label7.TabIndex = 41;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(10, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 37);
            this.label8.TabIndex = 42;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(57, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 37);
            this.label9.TabIndex = 43;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(-7, 599);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 37);
            this.label10.TabIndex = 44;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(8, 684);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 37);
            this.label11.TabIndex = 45;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(10, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(218, 25);
            this.label12.TabIndex = 46;
            this.label12.Text = "* indicate required fields";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(534, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(252, 46);
            this.label13.TabIndex = 47;
            this.label13.Text = "Rebate Form";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 790);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 56);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(331, 790);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(141, 56);
            this.button_delete.TabIndex = 16;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.Button2_Click);
            // 
            // rebate_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2006, 1169);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_save_time);
            this.Controls.Add(this.textBox_backspace_number);
            this.Controls.Add(this.textBox_first_enter_time);
            this.Controls.Add(this.listView_info);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dateTimePicker_date_received);
            this.Controls.Add(this.label_date_received);
            this.Controls.Add(this.checkBox_proof_no);
            this.Controls.Add(this.label_proof_of_purchase_attached);
            this.Controls.Add(this.checkBox_proof_yes);
            this.Controls.Add(this.textBox_email_address);
            this.Controls.Add(this.label_email_address);
            this.Controls.Add(this.textBox_phone_number);
            this.Controls.Add(this.label_phone_number);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.textBox_zip_code);
            this.Controls.Add(this.textBox_state);
            this.Controls.Add(this.label_state);
            this.Controls.Add(this.label_zip_code);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.label_city);
            this.Controls.Add(this.textBox_address_line_2);
            this.Controls.Add(this.label_address_line_2);
            this.Controls.Add(this.textBox_address_line_1);
            this.Controls.Add(this.label_address_line_1);
            this.Controls.Add(this.textBox_last_name);
            this.Controls.Add(this.textBox_middle_initial);
            this.Controls.Add(this.label_middle_initial);
            this.Controls.Add(this.label_last_name);
            this.Controls.Add(this.textBox_first_name);
            this.Controls.Add(this.label_first_name);
            this.Name = "rebate_form";
            this.Text = "Rebate Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_first_name;
        
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.Label label_last_name;
        private System.Windows.Forms.TextBox textBox_middle_initial;
        private System.Windows.Forms.Label label_middle_initial;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.TextBox textBox_address_line_1;
        private System.Windows.Forms.Label label_address_line_1;
        private System.Windows.Forms.TextBox textBox_address_line_2;
        private System.Windows.Forms.Label label_address_line_2;
        private System.Windows.Forms.TextBox textBox_zip_code;
        private System.Windows.Forms.TextBox textBox_state;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Label label_zip_code;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.TextBox textBox_phone_number;
        private System.Windows.Forms.Label label_phone_number;
        private System.Windows.Forms.TextBox textBox_email_address;
        private System.Windows.Forms.Label label_email_address;
        private System.Windows.Forms.CheckBox checkBox_proof_yes;
        private System.Windows.Forms.Label label_proof_of_purchase_attached;
        private System.Windows.Forms.CheckBox checkBox_proof_no;
        private System.Windows.Forms.Label label_date_received;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date_received;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ListView listView_info;
        private System.Windows.Forms.TextBox textBox_first_enter_time;
        private System.Windows.Forms.TextBox textBox_backspace_number;
        private System.Windows.Forms.TextBox textBox_save_time;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button1;
    }
}

