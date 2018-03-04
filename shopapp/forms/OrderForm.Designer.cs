namespace shopapp.forms
{
    partial class OrderForm
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
            this.customerListOrderFormComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.productListOrderFormComboBox = new System.Windows.Forms.ComboBox();
            this.addProductOrderFormButton = new System.Windows.Forms.Button();
            this.produstListOrderFormListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // customerListOrderFormComboBox
            // 
            this.customerListOrderFormComboBox.FormattingEnabled = true;
            this.customerListOrderFormComboBox.Location = new System.Drawing.Point(94, 59);
            this.customerListOrderFormComboBox.Name = "customerListOrderFormComboBox";
            this.customerListOrderFormComboBox.Size = new System.Drawing.Size(174, 21);
            this.customerListOrderFormComboBox.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(193, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(18, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // idtextBox
            // 
            this.idtextBox.Enabled = false;
            this.idtextBox.Location = new System.Drawing.Point(94, 21);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(175, 20);
            this.idtextBox.TabIndex = 34;
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(15, 21);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(18, 13);
            this.customerIdLabel.TabIndex = 33;
            this.customerIdLabel.Text = "ID";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(15, 59);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(51, 13);
            this.statusLabel.TabIndex = 32;
            this.statusLabel.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(94, 98);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(175, 20);
            this.dateTimePicker.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Product";
            // 
            // productListOrderFormComboBox
            // 
            this.productListOrderFormComboBox.FormattingEnabled = true;
            this.productListOrderFormComboBox.Location = new System.Drawing.Point(94, 148);
            this.productListOrderFormComboBox.Name = "productListOrderFormComboBox";
            this.productListOrderFormComboBox.Size = new System.Drawing.Size(121, 21);
            this.productListOrderFormComboBox.TabIndex = 42;
            this.productListOrderFormComboBox.SelectedIndexChanged += new System.EventHandler(this.productListOrderFormComboBox_SelectedIndexChanged);
            // 
            // addProductOrderFormButton
            // 
            this.addProductOrderFormButton.Location = new System.Drawing.Point(240, 148);
            this.addProductOrderFormButton.Name = "addProductOrderFormButton";
            this.addProductOrderFormButton.Size = new System.Drawing.Size(29, 23);
            this.addProductOrderFormButton.TabIndex = 43;
            this.addProductOrderFormButton.Text = ">>";
            this.addProductOrderFormButton.UseVisualStyleBackColor = true;
            this.addProductOrderFormButton.Click += new System.EventHandler(this.addProductOrderFormButton_Click);
            // 
            // produstListOrderFormListBox
            // 
            this.produstListOrderFormListBox.FormattingEnabled = true;
            this.produstListOrderFormListBox.Location = new System.Drawing.Point(336, 21);
            this.produstListOrderFormListBox.Name = "produstListOrderFormListBox";
            this.produstListOrderFormListBox.Size = new System.Drawing.Size(210, 212);
            this.produstListOrderFormListBox.TabIndex = 44;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 261);
            this.Controls.Add(this.produstListOrderFormListBox);
            this.Controls.Add(this.addProductOrderFormButton);
            this.Controls.Add(this.productListOrderFormComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerListOrderFormComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.customerIdLabel);
            this.Controls.Add(this.statusLabel);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerListOrderFormComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productListOrderFormComboBox;
        private System.Windows.Forms.Button addProductOrderFormButton;
        private System.Windows.Forms.ListBox produstListOrderFormListBox;
    }
}