using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Speech.Recognition;

namespace windows_pet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechRecognitionEngine RecEng = new SpeechRecognitionEngine();
        events Evento = new events();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            actiontimer1.Start();
            movetimer.Start();
            RescSetup();
            RecEng.RecognizeAsync(RecognizeMode.Multiple);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Evento.DistController(500);
            dialog();
        }     // 1 tick por segundo
        private void movetimer_Tick(object sender, EventArgs e)
        {
            movimiento(Evento.MovController(pichu.Location.X, pichu.Location.Y));

        }  //10 tick por segundo
     
        void RescSetup()
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "hola", "como estas", "pete", "re piola", "pene", "bien", "que andas asiendo", "que le digo",
                "que es eso", "pikachu", "pichu"});
            GrammarBuilder grammarB = new GrammarBuilder();
            grammarB.Append(commands);
            Grammar grammar = new Grammar(grammarB);

            RecEng.LoadGrammarAsync(grammar);
            RecEng.SetInputToDefaultAudioDevice();
            RecEng.SpeechRecognized += RecEng_SpeechRecognized;
        }//fraces a reconocer
        private void RecEng_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            binieta.Size = new Size(126, binieta.Height);
            switch (e.Result.Text)
            {
                case "pichu":
                    dialogo = "eso :3";
                    timerdialog = 10;
                    break;
                case "pikachu":
                    dialogo = "pichu..";
                    timerdialog = 10;
                    break;
                case "que es eso":
                    dialogo = "eso es queso";
                    timerdialog = 20;
                    break;
                case "que le digo":
                    dialogo = "algo xd";
                    timerdialog = 10;
                    break;
                case "hola":
                    dialogo = "hola";
                    timerdialog = 10;
                    break;
                case "como estas":
                    dialogo = "bien y vos?";
                    timerdialog = 15;
                    break;
                case "bien":
                    dialogo = "de una";
                    timerdialog = 15;
                    break;
                case "pete":
                    dialogo = "seras vos";
                    timerdialog = 15;
                    break;
                case "pene":
                    dialogo = "para vos";
                    timerdialog = 15;
                    break;
                case "re piola":
                    dialogo = "( ͡° ͜ʖ ͡°)";
                    timerdialog = 15;
                    break;
                case "que andas asiendo":
                    dialogo = "aca, haciendo nada";
                    timerdialog = 20;
                    break;
            }
        }//fraces reconosidas

        int dir = 0;
        void movimiento(int act)
        {
            switch (act)
            {
                case 1: //moveX L
                    if (pichu.Location.X <= 10) pichu.Location = new Point(15, pichu.Location.Y);
                    else
                    {
                        pichu.Location = new Point(pichu.Location.X - 1, pichu.Location.Y);
                        if (dir == 0) pichu.Image = windows_pet.Properties.Resources.Saltando_Ex;
                        dir = -1;
                    }
                    break;

                case 2: //moveX R
                    if (pichu.Location.X >= 654) pichu.Location = new Point(650, pichu.Location.Y);
                    else
                    {
                        pichu.Location = new Point(pichu.Location.X + 1, pichu.Location.Y);
                        if (dir == 0) pichu.Image = windows_pet.Properties.Resources.Saltando_E2x;
                        dir = 1;
                    }
                    break;

                case 3: //sleep
                    pichu.Image = windows_pet.Properties.Resources.z;
                    break;

                case 5: //moveY UP
                    if (pichu.Location.Y <= 10) pichu.Location = new Point(pichu.Location.X, 15);
                    else
                    {
                        pichu.Location = new Point(pichu.Location.X, pichu.Location.Y - 1);
                        if (dir == -1) pichu.Image = windows_pet.Properties.Resources.Exa__Izquierda;
                        else if (dir == 0 || dir == 1) pichu.Image = windows_pet.Properties.Resources.Exa__Derecha;
                    }
                    break;

                case 6: //moveY DW
                    if (pichu.Location.Y >= 386) pichu.Location = new Point(pichu.Location.X, 385);
                    else
                    {
                        pichu.Location = new Point(pichu.Location.X, pichu.Location.Y + 4);
                        if (dir == -1) pichu.Image = windows_pet.Properties.Resources.Exa__Izquierda;
                        else if (dir == 1) pichu.Image = windows_pet.Properties.Resources.Exa__Derecha;
                    }
                    break;

                default: //restart shape
                    if (dir == -1) pichu.Image = windows_pet.Properties.Resources.Exa__Izquierda;
                    else if (dir == 1) pichu.Image = windows_pet.Properties.Resources.Exa__Derecha;
                    dir = 0;
                    break;
            }
        } //movimientos del personaje y margenes de escena

        int timerdialog = 0;
        string dialogo = "";
        bool dialogex = false;
        void dialog()
        {
            if (timerdialog > 0)
            {
                if (dialogo.Length > 8 && dialogex == false)
                {
                    int size = (dialogo.Length - 7)*5;
                    dialogex = true;
                    binieta.Size = new Size(binieta.Width + size, binieta.Height);
                }

                binieta.Location = new Point(pichu.Location.X, pichu.Location.Y -50);
                texobinieta.Location = new Point(pichu.Location.X + 10, pichu.Location.Y - 45);
                texobinieta.Text = dialogo;
                texobinieta.Visible = true;
                binieta.Visible = true;
                timerdialog--;
            }
            else
            {
                dialogex = false;
                binieta.Visible = false;
                texobinieta.Visible = false;
            }
        }//burbuja de dialogo + texto
    }
}