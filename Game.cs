using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 *                                      Shapes gra edukacyjna    Windows Form 4.7.2
 *                                      Krystian Sapiński 173078 Tele 4
 * 
 * 
 * 
 */

namespace Shapes___Krystian_Sapiński
{
    public partial class Game : Form
    {
        bool goLeft; // parametry startowe 
        bool goRight;

        int speed = 4;
        public static int score = 0;
        int tick = 0;
        public static int StatTime = 0;
        int Actual = 1;

        Random randX = new Random();
        Random randY = new Random();
        public Game()
        {
            InitializeComponent();
            RestartGame();
        }
        //Główna funkcja programu. Przy użyciu zegara obiekty poruszają się w dół ekranu
         
        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Punkty: " + score;  // zapis punktacji na ekranie

            if (score == 50 && Actual == 1)   // Zwiększanie prędkości po zdobyciu odpowiedniej ilości punktów, oraz zmiana aktualnego kształtu
            {
                Actual = 2;
                speed = 5;
            }

            if (score == 100 && Actual == 2)
            {
                Actual = 3;
                speed = 7;
            }
            if (score == 150 && Actual == 3)
            {
                Actual = 4;
                speed = 9;
            }
            if (score == 250 && Actual == 4)    // Wywołanie zakończenia gry po zdobyciu ilości punktów
            {
                TimePlayed.Stop();
                StatTime += tick;
                tick = 0;
                Actual = 1;

                EndScreen gameWindow = new EndScreen();   // przejście do ekranu końca gry
                this.Hide();
                gameWindow.ShowDialog();
                this.Close();
            }
            // poruszanie się klawiszami lewo
             
            if (goLeft == true && Player.Left > 200)
            {
                Player.Left -= 12;
            }
            
             // poruszanie się klawiszami prawo
             
            if (goRight == true && Player.Left + Player.Width < this.ClientSize.Width)
            {
                Player.Left += 12;
            }
            
            //  Główna pętla programu odpowiadająca za rozgrywkę
             
            foreach (Control x  in this.Controls)
            {
                if (x is PictureBox && ((string)x.Tag == "Triangle" || (string)x.Tag == "Circle" || (string)x.Tag == "Rectangle" || (string)x.Tag == "Rhomb"))
                {
                    x.Top += speed;
                   
                   //  wybór odpowiedniego kształtu
                   
                    switch (Actual)
                    {
                        case 1:
                            ActualShape.Image = Properties.Resources.kwadrat;
                            break;
                        case 2:
                            ActualShape.Image = Properties.Resources.trojkat;
                            break;
                        case 3:
                            ActualShape.Image = Properties.Resources.kolo;
                            break;
                        case 4:
                            ActualShape.Image = Properties.Resources.romb;
                            break;

                    }
                    
                    //  Zabranie punktów gdy aktualnie potrzebny kształt znajdzie się na dole ekranu
                     
                    if (x.Top + x.Height > this.ClientSize.Height)
                    {
                        if (score > 0)
                        {
                            switch (Actual)
                            {
                                case 1:
                                    if ((string)x.Tag == "Rectangle")
                                        score -= 10; 
                                    break;
                                case 2:
                                    if ((string)x.Tag == "Triangle")
                                        score -= 10; 
                                    break;
                                case 3:
                                    if ((string)x.Tag == "Circle")
                                     score -= 10; 
                                    break;
                                case 4:
                                    if ((string)x.Tag == "Rhomb")
                                     score -= 10;
                                    break;


                            }
                        }
                         x.Top = randY.Next(50, 500) * -1;  // wylosowanie pozycji x,y z której PictureBox ma zacząć spadać
                         x.Left = randX.Next(200, this.ClientSize.Width - x.Width);
                    }


                    
                     //  Gdy Kosz zetknie się z danym obrazem zostają dopisane punkty
    
                     if (Player.Bounds.IntersectsWith(x.Bounds))
                     {
                         switch (Actual)
                         {
                             case 1:
                                 if ((string)x.Tag == "Rectangle")
                                     score += 10;
                                 break;
                             case 2:
                                 if ((string)x.Tag == "Triangle")
                                     score += 10;
                                 break;
                             case 3:
                                 if ((string)x.Tag == "Circle")
                                     score += 10;
                                 break;
                             case 4:
                                 if ((string)x.Tag == "Rhomb")
                                     score += 10;
                                 break;
                         }
                        
                         // Odjęcie punktów gdy dotknięty zostanie nieodpowiedni kształt (obraz)
                         
                        if (score > 0)
                        {
                            switch (Actual)
                            {
                                case 1:
                                    if ((string)x.Tag == "Rhomb" | (string)x.Tag == "Triangle" | (string)x.Tag == "Circle")
                                        score -= 10;
                                    break;
                                case 2:
                                    if ((string)x.Tag == "Rhomb" | (string)x.Tag == "Rectangle" | (string)x.Tag == "Circle")
                                        score -= 10;
                                    break;
                                case 3:
                                    if ((string)x.Tag == "Rhomb" | (string)x.Tag == "Triangle" | (string)x.Tag == "Rectangle")
                                        score -= 10;
                                    break;
                                case 4:
                                    if ((string)x.Tag == "Rectangle" | (string)x.Tag == "Triangle" | (string)x.Tag == "Circle")
                                        score -= 10;
                                    break;
                            }
                        }
                        x.Top = randY.Next(50,500) * -1;
                        x.Left = randX.Next(200, this.ClientSize.Width - x.Width);
                    }

                }
            }
        }
        
        // funkcja aktywująca event wciśnięcia klawisza
         
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Escape) // wyjście z rozpoczętej gry za pomocą przycisku Escape
            {
                Menu gameWindow = new Menu();
                this.Hide();
                gameWindow.ShowDialog();
                this.Close();
                score = 0;
                Actual = 1;
            }
        }
        //  Funkcja aktywująca gdy klawisz nie jest wciśnięty
         
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }
        // Funkcja restartu gry
        private void RestartGame()
        {

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && ((string)x.Tag == "Triangle" || (string)x.Tag == "Circle" || (string)x.Tag == "Rectangle" || (string)x.Tag == "Rhomb"))
                {
                    x.Top = randY.Next(50, 500) * -1;
                    x.Left = randX.Next(200, this.ClientSize.Width - x.Width);
                }
            }

            Player.Left = (this.ClientSize.Width) / 2; // wyśrodkowanie koszyka

            tick = 0; // parametry gry
            Actual = 1;
            speed = 4;
            score = 0;

            goLeft = false;
            goRight = false;

            GameTimer.Start();
            TimePlayed.Start();
        }
        //brief funkcja odpowiedzialna za zliczanie cykli zegara, ustawiony aby odliczał sekundy
        
         
        private void TimerPlayed(object sender, EventArgs e)
        {
            tick++;
            txtTime.Text = "Czas: " + tick + "s";
        }


    }
}
