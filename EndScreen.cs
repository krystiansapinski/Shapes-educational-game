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
    // Form aktywujący się po zakończeniu gry.
    
    public partial class EndScreen : Form
    {   
        // wypisanie wyniku czasowego oraz punktowego jak i komunikat o ukończeniu gry.
         
        public EndScreen()
        {
            InitializeComponent();
            TextLevel.Text = "Ukończyłeś grę";
            TextPoints.Text = "Końcowa liczba punktów: " + Game.score;
            TextTime.Text = "Końcowy czas: " + Game.StatTime;
        }
       
        //powrót do menu głównego.
         
        private void Next_Click(object sender, EventArgs e)
        {
            Menu gameWindow = new Menu();
            this.Hide();
            gameWindow.ShowDialog();
            this.Close();
        }
    }
}
