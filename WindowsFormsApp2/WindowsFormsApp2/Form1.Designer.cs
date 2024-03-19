namespace WindowsFormsApp2
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
            this.CarFormShowButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CarFormShowButton
            // 
            this.CarFormShowButton.Location = new System.Drawing.Point(50, 37);
            this.CarFormShowButton.Name = "CarFormShowButton";
            this.CarFormShowButton.Size = new System.Drawing.Size(156, 99);
            this.CarFormShowButton.TabIndex = 0;
            this.CarFormShowButton.Text = "View Car Data";
            this.CarFormShowButton.UseVisualStyleBackColor = true;
            this.CarFormShowButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show min/max car repair price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(50, 319);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.Size = new System.Drawing.Size(214, 59);
            this.textBoxResults.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 579);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CarFormShowButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CarFormShowButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxResults;
    }
}

