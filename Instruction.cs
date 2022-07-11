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
    // Form zawierający labele z instrukacjami do gry
    
    public partial class Instruction : Form
    {
        public Instruction()
        {
            InitializeComponent();
        }
        // powrót do menu głównego za pomocą przycisku
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Menu gameWindow = new Menu();
            this.Hide();
            gameWindow.ShowDialog();
            this.Close();
        }
    }
}
