namespace TOP
{
    partial class frmConectareUser
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
            this.lblIdUser = new System.Windows.Forms.Label();
            this.lblParolaUser = new System.Windows.Forms.Label();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.txtParolaUser = new System.Windows.Forms.TextBox();
            this.btnConectare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdUser
            // 
            this.lblIdUser.AutoSize = true;
            this.lblIdUser.Location = new System.Drawing.Point(12, 25);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(47, 13);
            this.lblIdUser.TabIndex = 0;
            this.lblIdUser.Text = "Utilizator";
            // 
            // lblParolaUser
            // 
            this.lblParolaUser.AutoSize = true;
            this.lblParolaUser.Location = new System.Drawing.Point(22, 51);
            this.lblParolaUser.Name = "lblParolaUser";
            this.lblParolaUser.Size = new System.Drawing.Size(37, 13);
            this.lblParolaUser.TabIndex = 1;
            this.lblParolaUser.Text = "Parola";
            // 
            // txtIdUser
            // 
            this.txtIdUser.Location = new System.Drawing.Point(65, 22);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.Size = new System.Drawing.Size(200, 20);
            this.txtIdUser.TabIndex = 0;
            this.txtIdUser.TextChanged += new System.EventHandler(this.txtIdUser_TextChanged);
            // 
            // txtParolaUser
            // 
            this.txtParolaUser.Location = new System.Drawing.Point(65, 48);
            this.txtParolaUser.Name = "txtParolaUser";
            this.txtParolaUser.Size = new System.Drawing.Size(200, 20);
            this.txtParolaUser.TabIndex = 1;
            this.txtParolaUser.UseSystemPasswordChar = true;
            this.txtParolaUser.TextChanged += new System.EventHandler(this.txtParolaUser_TextChanged);
            // 
            // btnConectare
            // 
            this.btnConectare.Location = new System.Drawing.Point(65, 74);
            this.btnConectare.Name = "btnConectare";
            this.btnConectare.Size = new System.Drawing.Size(200, 25);
            this.btnConectare.TabIndex = 2;
            this.btnConectare.Text = "Conectare";
            this.btnConectare.UseVisualStyleBackColor = true;
            // 
            // frmConectareUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 117);
            this.Controls.Add(this.btnConectare);
            this.Controls.Add(this.txtParolaUser);
            this.Controls.Add(this.txtIdUser);
            this.Controls.Add(this.lblParolaUser);
            this.Controls.Add(this.lblIdUser);
            this.Name = "frmConectareUser";
            this.Text = "Conectare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdUser;
        private System.Windows.Forms.Label lblParolaUser;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.TextBox txtParolaUser;
        private System.Windows.Forms.Button btnConectare;
    }
}