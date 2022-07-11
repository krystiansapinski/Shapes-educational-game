using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes___Krystian_Sapiński
{
    public partial class Menu : Form
    {
        // Menu główne
        
        public Menu()
        {
            InitializeComponent();
        }
        // funkcja aktywująca po przyciśnięciu przycisku rozpocznij grę. przekierowanie do gry
        private void StartButton_Click(object sender, EventArgs e)
        {
            Game gameWindow = new Game();
            this.Hide();
            gameWindow.ShowDialog();
            this.Close();
            Game.score = 0;
        }

        // Funkcja aktywująca się po wciśnięciu przycisku Instrukcja. przekierowanie do Forma z instrukcjami
         
         
        private void OptionButton_Click(object sender, EventArgs e)
        {
            Instruction gameWindow = new Instruction();
            this.Hide();
            gameWindow.ShowDialog();
            this.Close();
        }
        // funkcja wyłączęnia gry. Po przyciśnięciu zamyka aplikację
         
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
