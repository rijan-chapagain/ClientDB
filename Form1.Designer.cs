namespace ClientDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.AddClient = new System.Windows.Forms.Button();
            this.RemoveClient = new System.Windows.Forms.Button();
            this.IsAClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Location = new System.Drawing.Point(263, 49);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(304, 27);
            this.ClientNameTextBox.TabIndex = 1;
            this.ClientNameTextBox.TextChanged += new System.EventHandler(this.ClientDB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-2419, -29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(645, 32691);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 27);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.ClientDB_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(-2383, -15);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(336, 27);
            this.textBox4.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(-2279, 96);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(244, 27);
            this.textBox6.TabIndex = 1;
            // 
            // AddClient
            // 
            this.AddClient.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddClient.Location = new System.Drawing.Point(105, 147);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(102, 29);
            this.AddClient.TabIndex = 6;
            this.AddClient.Text = "Add Client";
            this.AddClient.UseVisualStyleBackColor = false;
            this.AddClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveClient
            // 
            this.RemoveClient.Location = new System.Drawing.Point(272, 147);
            this.RemoveClient.Name = "RemoveClient";
            this.RemoveClient.Size = new System.Drawing.Size(142, 29);
            this.RemoveClient.TabIndex = 7;
            this.RemoveClient.Text = "Remove Client";
            this.RemoveClient.UseVisualStyleBackColor = true;
            this.RemoveClient.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // IsAClient
            // 
            this.IsAClient.BackColor = System.Drawing.SystemColors.Info;
            this.IsAClient.Location = new System.Drawing.Point(491, 147);
            this.IsAClient.Name = "IsAClient";
            this.IsAClient.Size = new System.Drawing.Size(94, 29);
            this.IsAClient.TabIndex = 8;
            this.IsAClient.Text = "Is A CLient?";
            this.IsAClient.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 790);
            this.Controls.Add(this.IsAClient);
            this.Controls.Add(this.RemoveClient);
            this.Controls.Add(this.AddClient);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientNameTextBox);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Button RemoveClient;
        private System.Windows.Forms.Button IsAClient;
    }
}

