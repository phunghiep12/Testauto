
namespace Selenium
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
            this.btn_openChome = new System.Windows.Forms.Button();
            this.btn_opnchome2 = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_openChome
            // 
            this.btn_openChome.Location = new System.Drawing.Point(127, 155);
            this.btn_openChome.Name = "btn_openChome";
            this.btn_openChome.Size = new System.Drawing.Size(130, 56);
            this.btn_openChome.TabIndex = 0;
            this.btn_openChome.Text = "Open Chorme";
            this.btn_openChome.UseVisualStyleBackColor = true;
            this.btn_openChome.Click += new System.EventHandler(this.btn_openChome_Click);
            // 
            // btn_opnchome2
            // 
            this.btn_opnchome2.Location = new System.Drawing.Point(348, 153);
            this.btn_opnchome2.Name = "btn_opnchome2";
            this.btn_opnchome2.Size = new System.Drawing.Size(132, 58);
            this.btn_opnchome2.TabIndex = 1;
            this.btn_opnchome2.Text = "Open Chome 2";
            this.btn_opnchome2.UseVisualStyleBackColor = true;
            this.btn_opnchome2.Click += new System.EventHandler(this.btn_opnchome2_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(82, 97);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(477, 20);
            this.txtURL.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(26, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btn_opnchome2);
            this.Controls.Add(this.btn_openChome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_openChome;
        private System.Windows.Forms.Button btn_opnchome2;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
    }
}

