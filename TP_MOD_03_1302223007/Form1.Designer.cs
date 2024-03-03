namespace TP_MOD_03_1302223007
{
    partial class InputNamaApp
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.inputNama = new System.Windows.Forms.TextBox();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(369, 33);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // inputNama
            // 
            this.inputNama.Location = new System.Drawing.Point(33, 33);
            this.inputNama.Name = "inputNama";
            this.inputNama.Size = new System.Drawing.Size(306, 20);
            this.inputNama.TabIndex = 1;
            // 
            // labelGreeting
            // 
            this.labelGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreeting.Location = new System.Drawing.Point(12, 97);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(460, 23);
            this.labelGreeting.TabIndex = 2;
            this.labelGreeting.Text = "Masukan nama anda!";
            this.labelGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputNamaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.labelGreeting);
            this.Controls.Add(this.inputNama);
            this.Controls.Add(this.btnSubmit);
            this.Name = "InputNamaApp";
            this.Text = "Muhammad Haulul Azkiyaa (1302223007)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox inputNama;
        private System.Windows.Forms.Label labelGreeting;
    }
}

