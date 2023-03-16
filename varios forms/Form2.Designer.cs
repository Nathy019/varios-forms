namespace varios_forms
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
            this.textBoxMultitexto = new System.Windows.Forms.TextBox();
            this.buttonsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMultitexto
            // 
            this.textBoxMultitexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxMultitexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMultitexto.Location = new System.Drawing.Point(12, 12);
            this.textBoxMultitexto.Multiline = true;
            this.textBoxMultitexto.Name = "textBoxMultitexto";
            this.textBoxMultitexto.Size = new System.Drawing.Size(420, 323);
            this.textBoxMultitexto.TabIndex = 0;
            // 
            // buttonsair
            // 
            this.buttonsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonsair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonsair.Location = new System.Drawing.Point(357, 341);
            this.buttonsair.Name = "buttonsair";
            this.buttonsair.Size = new System.Drawing.Size(75, 23);
            this.buttonsair.TabIndex = 1;
            this.buttonsair.Text = "Sair";
            this.buttonsair.UseVisualStyleBackColor = false;
            this.buttonsair.Click += new System.EventHandler(this.buttonsair_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(467, 390);
            this.Controls.Add(this.buttonsair);
            this.Controls.Add(this.textBoxMultitexto);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMultitexto;
        private System.Windows.Forms.Button buttonsair;
    }
}