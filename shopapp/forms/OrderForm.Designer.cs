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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
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
            resources.ApplyResources(this.customerListOrderFormComboBox, "customerListOrderFormComboBox");
            this.customerListOrderFormComboBox.FormattingEnabled = true;
            this.customerListOrderFormComboBox.Name = "customerListOrderFormComboBox";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // idtextBox
            // 
            resources.ApplyResources(this.idtextBox, "idtextBox");
            this.idtextBox.Name = "idtextBox";
            // 
            // customerIdLabel
            // 
            resources.ApplyResources(this.customerIdLabel, "customerIdLabel");
            this.customerIdLabel.Name = "customerIdLabel";
            // 
            // statusLabel
            // 
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.Name = "statusLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dateTimePicker
            // 
            resources.ApplyResources(this.dateTimePicker, "dateTimePicker");
            this.dateTimePicker.Name = "dateTimePicker";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // productListOrderFormComboBox
            // 
            resources.ApplyResources(this.productListOrderFormComboBox, "productListOrderFormComboBox");
            this.productListOrderFormComboBox.FormattingEnabled = true;
            this.productListOrderFormComboBox.Name = "productListOrderFormComboBox";
            this.productListOrderFormComboBox.SelectedIndexChanged += new System.EventHandler(this.productListOrderFormComboBox_SelectedIndexChanged);
            // 
            // addProductOrderFormButton
            // 
            resources.ApplyResources(this.addProductOrderFormButton, "addProductOrderFormButton");
            this.addProductOrderFormButton.Name = "addProductOrderFormButton";
            this.addProductOrderFormButton.UseVisualStyleBackColor = true;
            this.addProductOrderFormButton.Click += new System.EventHandler(this.addProductOrderFormButton_Click);
            // 
            // produstListOrderFormListBox
            // 
            resources.ApplyResources(this.produstListOrderFormListBox, "produstListOrderFormListBox");
            this.produstListOrderFormListBox.FormattingEnabled = true;
            this.produstListOrderFormListBox.Name = "produstListOrderFormListBox";
            // 
            // OrderForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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