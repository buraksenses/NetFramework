namespace NetFramework.S19.D5.ModelModelless
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
            this.btnGöstre = new System.Windows.Forms.Button();
            this.btnGöstrePopup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGöstre
            // 
            this.btnGöstre.Location = new System.Drawing.Point(192, 143);
            this.btnGöstre.Name = "btnGöstre";
            this.btnGöstre.Size = new System.Drawing.Size(178, 121);
            this.btnGöstre.TabIndex = 0;
            this.btnGöstre.Text = "Göster";
            this.btnGöstre.UseVisualStyleBackColor = true;
            this.btnGöstre.Click += new System.EventHandler(this.btnGöstre_Click);
            // 
            // btnGöstrePopup
            // 
            this.btnGöstrePopup.Location = new System.Drawing.Point(376, 143);
            this.btnGöstrePopup.Name = "btnGöstrePopup";
            this.btnGöstrePopup.Size = new System.Drawing.Size(178, 121);
            this.btnGöstrePopup.TabIndex = 0;
            this.btnGöstrePopup.Text = "Göster Popup";
            this.btnGöstrePopup.UseVisualStyleBackColor = true;
            this.btnGöstrePopup.Click += new System.EventHandler(this.btnGöstrePopup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGöstrePopup);
            this.Controls.Add(this.btnGöstre);
            this.Name = "Form1";
            this.Text = "Ana Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGöstre;
        private System.Windows.Forms.Button btnGöstrePopup;
    }
}

