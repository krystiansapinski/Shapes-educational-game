
namespace Shapes___Krystian_Sapiński
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.x1 = new System.Windows.Forms.PictureBox();
            this.x2 = new System.Windows.Forms.PictureBox();
            this.x3 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.TimePlayed = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ActualShape = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActualShape)).BeginInit();
            this.SuspendLayout();
            // 
            // x1
            // 
            this.x1.Image = global::Shapes___Krystian_Sapiński.Properties.Resources.trojkat;
            this.x1.Location = new System.Drawing.Point(248, 25);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(118, 119);
            this.x1.TabIndex = 0;
            this.x1.TabStop = false;
            this.x1.Tag = "Triangle";
            // 
            // x2
            // 
            this.x2.Image = global::Shapes___Krystian_Sapiński.Properties.Resources.kwadrat;
            this.x2.Location = new System.Drawing.Point(419, 12);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(126, 133);
            this.x2.TabIndex = 1;
            this.x2.TabStop = false;
            this.x2.Tag = "Rectangle";
            // 
            // x3
            // 
            this.x3.Image = global::Shapes___Krystian_Sapiński.Properties.Resources.kolo;
            this.x3.Location = new System.Drawing.Point(802, 18);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(142, 146);
            this.x3.TabIndex = 2;
            this.x3.TabStop = false;
            this.x3.Tag = "Circle";
            // 
            // Player
            // 
            this.Player.Image = global::Shapes___Krystian_Sapiński.Properties.Resources.koszyk;
            this.Player.Location = new System.Drawing.Point(555, 642);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(114, 86);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 3;
            this.Player.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 15;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // TimePlayed
            // 
            this.TimePlayed.Enabled = true;
            this.TimePlayed.Interval = 1000;
            this.TimePlayed.Tick += new System.EventHandler(this.TimerPlayed);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox4.Location = new System.Drawing.Point(0, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 729);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtScore.Location = new System.Drawing.Point(17, 251);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(162, 41);
            this.txtScore.TabIndex = 5;
            this.txtScore.Text = "Punkty:0";
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTime.Location = new System.Drawing.Point(21, 320);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(158, 41);
            this.txtTime.TabIndex = 6;
            this.txtTime.Text = "Czas: 0s";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shapes___Krystian_Sapiński.Properties.Resources.romb;
            this.pictureBox1.Location = new System.Drawing.Point(607, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 148);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Rhomb";
            // 
            // ActualShape
            // 
            this.ActualShape.Image = global::Shapes___Krystian_Sapiński.Properties.Resources.kwadrat;
            this.ActualShape.Location = new System.Drawing.Point(24, 12);
            this.ActualShape.Name = "ActualShape";
            this.ActualShape.Size = new System.Drawing.Size(151, 152);
            this.ActualShape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ActualShape.TabIndex = 8;
            this.ActualShape.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Aktualny kształt";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActualShape);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shapes - gra edukacyjna";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActualShape)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox x1;
        private System.Windows.Forms.PictureBox x2;
        private System.Windows.Forms.PictureBox x3;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer TimePlayed;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ActualShape;
        private System.Windows.Forms.Label label1;
    }
}

