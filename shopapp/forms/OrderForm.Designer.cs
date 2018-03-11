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
            this.customerListOrderFormComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerListOrderFormComboBox.FormattingEnabled = true;
            this.customerListOrderFormComboBox.Location = new System.Drawing.Point(118, 53);
            this.customerListOrderFormComboBox.Name = "customerListOrderFormComboBox";
            this.customerListOrderFormComboBox.Size = new System.Drawing.Size(174, 32);
            this.customerListOrderFormComboBox.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(192, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 36;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(19, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 35;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // idtextBox
            // 
            this.idtextBox.Enabled = false;
            this.idtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idtextBox.Location = new System.Drawing.Point(118, 12);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(175, 29);
            this.idtextBox.TabIndex = 34;
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerIdLabel.Location = new System.Drawing.Point(15, 18);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(26, 20);
            this.customerIdLabel.TabIndex = 33;
            this.customerIdLabel.Text = "ID";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(15, 59);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(78, 20);
            this.statusLabel.TabIndex = 32;
            this.statusLabel.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(117, 98);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(175, 29);
            this.dateTimePicker.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Product";
            // 
            // productListOrderFormComboBox
            // 
            this.productListOrderFormComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productListOrderFormComboBox.FormattingEnabled = true;
            this.productListOrderFormComboBox.Location = new System.Drawing.Point(118, 148);
            this.productListOrderFormComboBox.Name = "productListOrderFormComboBox";
            this.productListOrderFormComboBox.Size = new System.Drawing.Size(174, 32);
            this.productListOrderFormComboBox.TabIndex = 42;
            this.productListOrderFormComboBox.SelectedIndexChanged += new System.EventHandler(this.productListOrderFormComboBox_SelectedIndexChanged);
            // 
            // addProductOrderFormButton
            // 
            this.addProductOrderFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProductOrderFormButton.Location = new System.Drawing.Point(118, 186);
            this.addProductOrderFormButton.Name = "addProductOrderFormButton";
            this.addProductOrderFormButton.Size = new System.Drawing.Size(44, 39);
            this.addProductOrderFormButton.TabIndex = 43;
            this.addProductOrderFormButton.Text = ">>";
            this.addProductOrderFormButton.UseVisualStyleBackColor = true;
            this.addProductOrderFormButton.Click += new System.EventHandler(this.addProductOrderFormButton_Click);
            // 
            // produstListOrderFormListBox
            // 
            this.produstListOrderFormListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.produstListOrderFormListBox.FormattingEnabled = true;
            this.produstListOrderFormListBox.ItemHeight = 16;
            this.produstListOrderFormListBox.Location = new System.Drawing.Point(308, 12);
            this.produstListOrderFormListBox.Name = "produstListOrderFormListBox";
            this.produstListOrderFormListBox.Size = new System.Drawing.Size(304, 292);
            this.produstListOrderFormListBox.TabIndex = 44;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
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
            this.Load += new System.EventHandler(this.OrderForm_Load);
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