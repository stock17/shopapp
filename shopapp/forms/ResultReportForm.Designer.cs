namespace shopapp.forms
{
    partial class ResultReportForm
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
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // orderListBox
            // 
            this.orderListBox.Enabled = false;
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.Location = new System.Drawing.Point(13, 13);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(701, 238);
            this.orderListBox.TabIndex = 0;
            // 
            // ResultReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 261);
            this.Controls.Add(this.orderListBox);
            this.Name = "ResultReportForm";
            this.Text = "ResultReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox orderListBox;
    }
}