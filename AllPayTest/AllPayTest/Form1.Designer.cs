namespace AllPayTest
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Title = new System.Windows.Forms.Label();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.Check4x4 = new System.Windows.Forms.CheckBox();
            this.Check6x6 = new System.Windows.Forms.CheckBox();
            this.Check5x5 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(176, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(248, 56);
            this.Title.TabIndex = 3;
            this.Title.Text = "Lights Out";
            // 
            // ContinueButton
            // 
            this.ContinueButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContinueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ContinueButton.Location = new System.Drawing.Point(263, 178);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(75, 30);
            this.ContinueButton.TabIndex = 4;
            this.ContinueButton.Text = "Ready";
            this.ContinueButton.UseVisualStyleBackColor = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // Check4x4
            // 
            this.Check4x4.AutoSize = true;
            this.Check4x4.Location = new System.Drawing.Point(279, 109);
            this.Check4x4.Name = "Check4x4";
            this.Check4x4.Size = new System.Drawing.Size(43, 17);
            this.Check4x4.TabIndex = 5;
            this.Check4x4.Text = "4x4";
            this.Check4x4.UseVisualStyleBackColor = true;
            // 
            // Check6x6
            // 
            this.Check6x6.AutoSize = true;
            this.Check6x6.Location = new System.Drawing.Point(279, 155);
            this.Check6x6.Name = "Check6x6";
            this.Check6x6.Size = new System.Drawing.Size(43, 17);
            this.Check6x6.TabIndex = 6;
            this.Check6x6.Text = "6x6";
            this.Check6x6.UseVisualStyleBackColor = true;
            // 
            // Check5x5
            // 
            this.Check5x5.AutoSize = true;
            this.Check5x5.Location = new System.Drawing.Point(279, 132);
            this.Check5x5.Name = "Check5x5";
            this.Check5x5.Size = new System.Drawing.Size(43, 17);
            this.Check5x5.TabIndex = 7;
            this.Check5x5.Text = "5x5";
            this.Check5x5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Check5x5);
            this.Controls.Add(this.Check6x6);
            this.Controls.Add(this.Check4x4);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.CheckBox Check4x4;
        private System.Windows.Forms.CheckBox Check6x6;
        private System.Windows.Forms.CheckBox Check5x5;
    }
}

