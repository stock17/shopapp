using System.Collections.Generic;

namespace shopapp
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.productQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 265);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.IdTextBox);
            this.tabPage1.Controls.Add(this.customerIdLabel);
            this.tabPage1.Controls.Add(this.customersListBox);
            this.tabPage1.Controls.Add(this.statusTextBox);
            this.tabPage1.Controls.Add(this.statusLabel);
            this.tabPage1.Controls.Add(this.ageTextBox);
            this.tabPage1.Controls.Add(this.ageLabel);
            this.tabPage1.Controls.Add(this.sexTextBox);
            this.tabPage1.Controls.Add(this.sexLabel);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Controls.Add(this.nameLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(550, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(94, 30);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(175, 20);
            this.IdTextBox.TabIndex = 10;
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(15, 30);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(18, 13);
            this.customerIdLabel.TabIndex = 9;
            this.customerIdLabel.Text = "ID";
            // 
            // customersListBox
            // 
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.Location = new System.Drawing.Point(329, 30);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(178, 160);
            this.customersListBox.TabIndex = 8;
            this.customersListBox.SelectedIndexChanged += new System.EventHandler(this.customersListBox_SelectedIndexChanged);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Enabled = false;
            this.statusTextBox.Location = new System.Drawing.Point(94, 168);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(175, 20);
            this.statusTextBox.TabIndex = 7;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(15, 168);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(67, 13);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Social status";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Enabled = false;
            this.ageTextBox.Location = new System.Drawing.Point(94, 134);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.ReadOnly = true;
            this.ageTextBox.Size = new System.Drawing.Size(175, 20);
            this.ageTextBox.TabIndex = 5;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(15, 134);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Age";
            // 
            // sexTextBox
            // 
            this.sexTextBox.Enabled = false;
            this.sexTextBox.Location = new System.Drawing.Point(94, 100);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.ReadOnly = true;
            this.sexTextBox.Size = new System.Drawing.Size(175, 20);
            this.sexTextBox.TabIndex = 3;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(15, 103);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(25, 13);
            this.sexLabel.TabIndex = 2;
            this.sexLabel.Text = "Sex";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(94, 68);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(175, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(15, 71);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.productIdTextBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.productsListBox);
            this.tabPage2.Controls.Add(this.productQuantityTextBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.productPriceTextBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.productNameTextBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Enabled = false;
            this.productIdTextBox.Location = new System.Drawing.Point(108, 39);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.ReadOnly = true;
            this.productIdTextBox.Size = new System.Drawing.Size(175, 20);
            this.productIdTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // productsListBox
            // 
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.Location = new System.Drawing.Point(343, 39);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(178, 160);
            this.productsListBox.TabIndex = 19;
            this.productsListBox.SelectedIndexChanged += new System.EventHandler(this.productsListBox_SelectedIndexChanged);
            // 
            // productQuantityTextBox
            // 
            this.productQuantityTextBox.Enabled = false;
            this.productQuantityTextBox.Location = new System.Drawing.Point(108, 143);
            this.productQuantityTextBox.Name = "productQuantityTextBox";
            this.productQuantityTextBox.ReadOnly = true;
            this.productQuantityTextBox.Size = new System.Drawing.Size(175, 20);
            this.productQuantityTextBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantity";
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Enabled = false;
            this.productPriceTextBox.Location = new System.Drawing.Point(108, 109);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.ReadOnly = true;
            this.productPriceTextBox.Size = new System.Drawing.Size(175, 20);
            this.productPriceTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Price";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Enabled = false;
            this.productNameTextBox.Location = new System.Drawing.Point(108, 77);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ReadOnly = true;
            this.productNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.productNameTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(550, 239);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(550, 239);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeButton);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.newButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 40);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(212, 11);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(114, 11);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(18, 11);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(468, 329);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(97, 38);
            this.reportButton.TabIndex = 2;
            this.reportButton.Text = "Make report";
            this.reportButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.AutoEllipsis = true;
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveButton.Enabled = false;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.SystemColors.Window;
            this.saveButton.Image = global::shopapp.Properties.Resources.save_disabled;
            this.saveButton.Location = new System.Drawing.Point(12, 1);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(37, 40);
            this.saveButton.TabIndex = 3;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 375);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ListBox customersListBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox productsListBox;
        private System.Windows.Forms.TextBox productQuantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label label5;
    }
}

