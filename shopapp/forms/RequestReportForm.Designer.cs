namespace shopapp.forms
{
    partial class RequestReportForm
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
            this.customerCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.fromAgeTextBox = new System.Windows.Forms.TextBox();
            this.toAgeTextBox = new System.Windows.Forms.TextBox();
            this.statusCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.productCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.dateFromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateToTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allCustomersCheckedButton = new System.Windows.Forms.Button();
            this.allCustomersUncheckedButton = new System.Windows.Forms.Button();
            this.allProductUncheckedButton = new System.Windows.Forms.Button();
            this.allPriductsCheckedButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerCheckedListBox
            // 
            this.customerCheckedListBox.FormattingEnabled = true;
            this.customerCheckedListBox.Location = new System.Drawing.Point(100, 53);
            this.customerCheckedListBox.Name = "customerCheckedListBox";
            this.customerCheckedListBox.Size = new System.Drawing.Size(234, 334);
            this.customerCheckedListBox.TabIndex = 0;
            // 
            // fromAgeTextBox
            // 
            this.fromAgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromAgeTextBox.Location = new System.Drawing.Point(143, 409);
            this.fromAgeTextBox.MaxLength = 3;
            this.fromAgeTextBox.Name = "fromAgeTextBox";
            this.fromAgeTextBox.Size = new System.Drawing.Size(80, 26);
            this.fromAgeTextBox.TabIndex = 1;
            this.fromAgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBox_KeyPress);
            // 
            // toAgeTextBox
            // 
            this.toAgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toAgeTextBox.Location = new System.Drawing.Point(254, 409);
            this.toAgeTextBox.MaxLength = 3;
            this.toAgeTextBox.Name = "toAgeTextBox";
            this.toAgeTextBox.Size = new System.Drawing.Size(80, 26);
            this.toAgeTextBox.TabIndex = 2;
            this.toAgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBox_KeyPress);
            // 
            // statusCheckedListBox
            // 
            this.statusCheckedListBox.FormattingEnabled = true;
            this.statusCheckedListBox.Location = new System.Drawing.Point(100, 450);
            this.statusCheckedListBox.Name = "statusCheckedListBox";
            this.statusCheckedListBox.Size = new System.Drawing.Size(234, 94);
            this.statusCheckedListBox.TabIndex = 3;
            // 
            // productCheckedListBox
            // 
            this.productCheckedListBox.FormattingEnabled = true;
            this.productCheckedListBox.Location = new System.Drawing.Point(426, 53);
            this.productCheckedListBox.Name = "productCheckedListBox";
            this.productCheckedListBox.Size = new System.Drawing.Size(177, 484);
            this.productCheckedListBox.TabIndex = 4;
            // 
            // dateFromTimePicker
            // 
            this.dateFromTimePicker.Enabled = false;
            this.dateFromTimePicker.Location = new System.Drawing.Point(611, 76);
            this.dateFromTimePicker.Name = "dateFromTimePicker";
            this.dateFromTimePicker.Size = new System.Drawing.Size(161, 20);
            this.dateFromTimePicker.TabIndex = 5;
            // 
            // dateToTimePicker
            // 
            this.dateToTimePicker.Enabled = false;
            this.dateToTimePicker.Location = new System.Drawing.Point(611, 102);
            this.dateToTimePicker.Name = "dateToTimePicker";
            this.dateToTimePicker.Size = new System.Drawing.Size(161, 20);
            this.dateToTimePicker.TabIndex = 6;
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Checked = true;
            this.dateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dateCheckBox.Location = new System.Drawing.Point(611, 53);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(76, 17);
            this.dateCheckBox.TabIndex = 7;
            this.dateCheckBox.Text = "For all time";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.dateCheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(654, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 69);
            this.button1.TabIndex = 8;
            this.button1.Text = "REPORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(97, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(229, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "to";
            // 
            // allCustomersCheckedButton
            // 
            this.allCustomersCheckedButton.Location = new System.Drawing.Point(14, 53);
            this.allCustomersCheckedButton.Name = "allCustomersCheckedButton";
            this.allCustomersCheckedButton.Size = new System.Drawing.Size(80, 25);
            this.allCustomersCheckedButton.TabIndex = 11;
            this.allCustomersCheckedButton.Text = "Select ALL";
            this.allCustomersCheckedButton.UseVisualStyleBackColor = true;
            this.allCustomersCheckedButton.Click += new System.EventHandler(this.allCustomersButton_Click);
            // 
            // allCustomersUncheckedButton
            // 
            this.allCustomersUncheckedButton.Location = new System.Drawing.Point(14, 82);
            this.allCustomersUncheckedButton.Name = "allCustomersUncheckedButton";
            this.allCustomersUncheckedButton.Size = new System.Drawing.Size(80, 25);
            this.allCustomersUncheckedButton.TabIndex = 12;
            this.allCustomersUncheckedButton.Text = "Unselect ALL";
            this.allCustomersUncheckedButton.UseVisualStyleBackColor = true;
            this.allCustomersUncheckedButton.Click += new System.EventHandler(this.allCustomersUncheckedButton_Click);
            // 
            // allProductUncheckedButton
            // 
            this.allProductUncheckedButton.Location = new System.Drawing.Point(340, 82);
            this.allProductUncheckedButton.Name = "allProductUncheckedButton";
            this.allProductUncheckedButton.Size = new System.Drawing.Size(80, 25);
            this.allProductUncheckedButton.TabIndex = 14;
            this.allProductUncheckedButton.Text = "Deselect ALL";
            this.allProductUncheckedButton.UseVisualStyleBackColor = true;
            this.allProductUncheckedButton.Click += new System.EventHandler(this.allProductUncheckedButton_Click);
            // 
            // allPriductsCheckedButton
            // 
            this.allPriductsCheckedButton.Location = new System.Drawing.Point(340, 53);
            this.allPriductsCheckedButton.Name = "allPriductsCheckedButton";
            this.allPriductsCheckedButton.Size = new System.Drawing.Size(80, 25);
            this.allPriductsCheckedButton.TabIndex = 13;
            this.allPriductsCheckedButton.Text = "Select All";
            this.allPriductsCheckedButton.UseVisualStyleBackColor = true;
            this.allPriductsCheckedButton.Click += new System.EventHandler(this.allPriductsCheckedButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(112, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Select customers to include in report";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(391, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Select products to include in report";
            // 
            // RequestReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allProductUncheckedButton);
            this.Controls.Add(this.allPriductsCheckedButton);
            this.Controls.Add(this.allCustomersUncheckedButton);
            this.Controls.Add(this.allCustomersCheckedButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateCheckBox);
            this.Controls.Add(this.dateToTimePicker);
            this.Controls.Add(this.dateFromTimePicker);
            this.Controls.Add(this.productCheckedListBox);
            this.Controls.Add(this.statusCheckedListBox);
            this.Controls.Add(this.toAgeTextBox);
            this.Controls.Add(this.fromAgeTextBox);
            this.Controls.Add(this.customerCheckedListBox);
            this.Name = "RequestReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox customerCheckedListBox;
        private System.Windows.Forms.TextBox fromAgeTextBox;
        private System.Windows.Forms.TextBox toAgeTextBox;
        private System.Windows.Forms.CheckedListBox statusCheckedListBox;
        private System.Windows.Forms.CheckedListBox productCheckedListBox;
        private System.Windows.Forms.DateTimePicker dateFromTimePicker;
        private System.Windows.Forms.DateTimePicker dateToTimePicker;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button allCustomersCheckedButton;
        private System.Windows.Forms.Button allCustomersUncheckedButton;
        private System.Windows.Forms.Button allProductUncheckedButton;
        private System.Windows.Forms.Button allPriductsCheckedButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}