
namespace Assignment4_InventoryProject
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_number = new System.Windows.Forms.TextBox();
            this.txtBox_inventoryNumber = new System.Windows.Forms.TextBox();
            this.txtBox_objectName = new System.Windows.Forms.TextBox();
            this.txtBox_count = new System.Windows.Forms.TextBox();
            this.txtBox_price = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2_telebirr = new System.Windows.Forms.RadioButton();
            this.radioButton_paypal = new System.Windows.Forms.RadioButton();
            this.label_username = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(669, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inventory Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Object Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(818, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // txtBox_number
            // 
            this.txtBox_number.Location = new System.Drawing.Point(47, 100);
            this.txtBox_number.Name = "txtBox_number";
            this.txtBox_number.Size = new System.Drawing.Size(199, 22);
            this.txtBox_number.TabIndex = 6;
            // 
            // txtBox_inventoryNumber
            // 
            this.txtBox_inventoryNumber.Location = new System.Drawing.Point(674, 100);
            this.txtBox_inventoryNumber.Name = "txtBox_inventoryNumber";
            this.txtBox_inventoryNumber.Size = new System.Drawing.Size(199, 22);
            this.txtBox_inventoryNumber.TabIndex = 7;
            // 
            // txtBox_objectName
            // 
            this.txtBox_objectName.Location = new System.Drawing.Point(47, 204);
            this.txtBox_objectName.Name = "txtBox_objectName";
            this.txtBox_objectName.Size = new System.Drawing.Size(464, 22);
            this.txtBox_objectName.TabIndex = 8;
            // 
            // txtBox_count
            // 
            this.txtBox_count.Location = new System.Drawing.Point(47, 331);
            this.txtBox_count.Name = "txtBox_count";
            this.txtBox_count.Size = new System.Drawing.Size(199, 22);
            this.txtBox_count.TabIndex = 9;
            // 
            // txtBox_price
            // 
            this.txtBox_price.Location = new System.Drawing.Point(823, 331);
            this.txtBox_price.Name = "txtBox_price";
            this.txtBox_price.Size = new System.Drawing.Size(199, 22);
            this.txtBox_price.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(316, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(75, 620);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(122, 40);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(1061, 620);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(122, 40);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2_telebirr);
            this.groupBox1.Controls.Add(this.radioButton_paypal);
            this.groupBox1.Location = new System.Drawing.Point(43, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 101);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            // 
            // radioButton2_telebirr
            // 
            this.radioButton2_telebirr.AutoSize = true;
            this.radioButton2_telebirr.Location = new System.Drawing.Point(7, 59);
            this.radioButton2_telebirr.Name = "radioButton2_telebirr";
            this.radioButton2_telebirr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton2_telebirr.Size = new System.Drawing.Size(83, 21);
            this.radioButton2_telebirr.TabIndex = 1;
            this.radioButton2_telebirr.TabStop = true;
            this.radioButton2_telebirr.Text = "Tele Birr";
            this.radioButton2_telebirr.UseVisualStyleBackColor = true;
            // 
            // radioButton_paypal
            // 
            this.radioButton_paypal.AutoSize = true;
            this.radioButton_paypal.Location = new System.Drawing.Point(7, 18);
            this.radioButton_paypal.Name = "radioButton_paypal";
            this.radioButton_paypal.Size = new System.Drawing.Size(73, 21);
            this.radioButton_paypal.TabIndex = 0;
            this.radioButton_paypal.TabStop = true;
            this.radioButton_paypal.Text = "PayPal";
            this.radioButton_paypal.UseVisualStyleBackColor = true;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(1093, 40);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(103, 38);
            this.label_username.TabIndex = 16;
            this.label_username.Text = "label7";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Amharic",
            "English",
            "Arabic"});
            this.checkedListBox1.Location = new System.Drawing.Point(316, 437);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(156, 72);
            this.checkedListBox1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Preferred Languages";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 749);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBox_price);
            this.Controls.Add(this.txtBox_count);
            this.Controls.Add(this.txtBox_objectName);
            this.Controls.Add(this.txtBox_inventoryNumber);
            this.Controls.Add(this.txtBox_number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_number;
        private System.Windows.Forms.TextBox txtBox_inventoryNumber;
        private System.Windows.Forms.TextBox txtBox_objectName;
        private System.Windows.Forms.TextBox txtBox_count;
        private System.Windows.Forms.TextBox txtBox_price;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2_telebirr;
        private System.Windows.Forms.RadioButton radioButton_paypal;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label7;
    }
}

