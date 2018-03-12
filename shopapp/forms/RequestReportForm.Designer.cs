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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestReportForm));
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
            resources.ApplyResources(this.customerCheckedListBox, "customerCheckedListBox");
            this.customerCheckedListBox.FormattingEnabled = true;
            this.customerCheckedListBox.Name = "customerCheckedListBox";
            // 
            // fromAgeTextBox
            // 
            resources.ApplyResources(this.fromAgeTextBox, "fromAgeTextBox");
            this.fromAgeTextBox.Name = "fromAgeTextBox";
            this.fromAgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBox_KeyPress);
            // 
            // toAgeTextBox
            // 
            resources.ApplyResources(this.toAgeTextBox, "toAgeTextBox");
            this.toAgeTextBox.Name = "toAgeTextBox";
            this.toAgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBox_KeyPress);
            // 
            // statusCheckedListBox
            // 
            resources.ApplyResources(this.statusCheckedListBox, "statusCheckedListBox");
            this.statusCheckedListBox.FormattingEnabled = true;
            this.statusCheckedListBox.Name = "statusCheckedListBox";
            // 
            // productCheckedListBox
            // 
            resources.ApplyResources(this.productCheckedListBox, "productCheckedListBox");
            this.productCheckedListBox.FormattingEnabled = true;
            this.productCheckedListBox.Name = "productCheckedListBox";
            // 
            // dateFromTimePicker
            // 
            resources.ApplyResources(this.dateFromTimePicker, "dateFromTimePicker");
            this.dateFromTimePicker.Name = "dateFromTimePicker";
            // 
            // dateToTimePicker
            // 
            resources.ApplyResources(this.dateToTimePicker, "dateToTimePicker");
            this.dateToTimePicker.Name = "dateToTimePicker";
            // 
            // dateCheckBox
            // 
            resources.ApplyResources(this.dateCheckBox, "dateCheckBox");
            this.dateCheckBox.Checked = true;
            this.dateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.dateCheckBox_CheckedChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // allCustomersCheckedButton
            // 
            resources.ApplyResources(this.allCustomersCheckedButton, "allCustomersCheckedButton");
            this.allCustomersCheckedButton.Name = "allCustomersCheckedButton";
            this.allCustomersCheckedButton.UseVisualStyleBackColor = true;
            this.allCustomersCheckedButton.Click += new System.EventHandler(this.allCustomersButton_Click);
            // 
            // allCustomersUncheckedButton
            // 
            resources.ApplyResources(this.allCustomersUncheckedButton, "allCustomersUncheckedButton");
            this.allCustomersUncheckedButton.Name = "allCustomersUncheckedButton";
            this.allCustomersUncheckedButton.UseVisualStyleBackColor = true;
            this.allCustomersUncheckedButton.Click += new System.EventHandler(this.allCustomersUncheckedButton_Click);
            // 
            // allProductUncheckedButton
            // 
            resources.ApplyResources(this.allProductUncheckedButton, "allProductUncheckedButton");
            this.allProductUncheckedButton.Name = "allProductUncheckedButton";
            this.allProductUncheckedButton.UseVisualStyleBackColor = true;
            this.allProductUncheckedButton.Click += new System.EventHandler(this.allProductUncheckedButton_Click);
            // 
            // allPriductsCheckedButton
            // 
            resources.ApplyResources(this.allPriductsCheckedButton, "allPriductsCheckedButton");
            this.allPriductsCheckedButton.Name = "allPriductsCheckedButton";
            this.allPriductsCheckedButton.UseVisualStyleBackColor = true;
            this.allPriductsCheckedButton.Click += new System.EventHandler(this.allPriductsCheckedButton_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // RequestReportForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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