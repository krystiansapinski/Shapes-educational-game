
namespace Shapes___Krystian_Sapiński
{
    partial class EndScreen
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
            this.TextTime = new System.Windows.Forms.Label();
            this.TextPoints = new System.Windows.Forms.Label();
            this.TextLevel = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextTime
            // 
            this.TextTime.AutoSize = true;
            this.TextTime.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextTime.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextTime.Location = new System.Drawing.Point(373, 301);
            this.TextTime.Name = "TextTime";
            this.TextTime.Size = new System.Drawing.Size(300, 32);
            this.TextTime.TabIndex = 5;
            this.TextTime.Text = "Czas ukończenia: 10s";
            // 
            // TextPoints
            // 
            this.TextPoints.AutoSize = true;
            this.TextPoints.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextPoints.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextPoints.Location = new System.Drawing.Point(328, 243);
            this.TextPoints.Name = "TextPoints";
            this.TextPoints.Size = new System.Drawing.Size(346, 32);
            this.TextPoints.TabIndex = 4;
            this.TextPoints.Text = "Twoja liczba punktów: 50";
            // 
            // TextLevel
            // 
            this.TextLevel.AutoSize = true;
            this.TextLevel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextLevel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextLevel.Location = new System.Drawing.Point(391, 189);
            this.TextLevel.Name = "TextLevel";
            this.TextLevel.Size = new System.Drawing.Size(217, 32);
            this.TextLevel.TabIndex = 3;
            this.TextLevel.Text = "Ukończyłeś grę";
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Next.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Next.Location = new System.Drawing.Point(397, 370);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(197, 96);
            this.Next.TabIndex = 6;
            this.Next.Text = "Wróc do menu";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.TextTime);
            this.Controls.Add(this.TextPoints);
            this.Controls.Add(this.TextLevel);
            this.Name = "EndScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shapes - gra edukacyjna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextTime;
        private System.Windows.Forms.Label TextPoints;
        private System.Windows.Forms.Label TextLevel;
        private System.Windows.Forms.Button Next;
    }
}