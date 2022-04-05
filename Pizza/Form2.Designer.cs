namespace Pizza
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientAdresse = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.EditClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse Client";
            // 
            // ClientAdresse
            // 
            this.ClientAdresse.Location = new System.Drawing.Point(199, 205);
            this.ClientAdresse.Name = "ClientAdresse";
            this.ClientAdresse.Size = new System.Drawing.Size(213, 26);
            this.ClientAdresse.TabIndex = 2;
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(199, 38);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(213, 26);
            this.ClientName.TabIndex = 3;
            // 
            // EditClient
            // 
            this.EditClient.Location = new System.Drawing.Point(199, 303);
            this.EditClient.Name = "EditClient";
            this.EditClient.Size = new System.Drawing.Size(338, 74);
            this.EditClient.TabIndex = 4;
            this.EditClient.Text = "Modifier";
            this.EditClient.UseVisualStyleBackColor = true;
            this.EditClient.Click += new System.EventHandler(this.EditClient_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditClient);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.ClientAdresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientAdresse;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.Button EditClient;
    }
}