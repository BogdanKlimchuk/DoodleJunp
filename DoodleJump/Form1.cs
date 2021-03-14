using DoodleJump.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//vsego_chasov_potracheno_zdes_18
//vsego_udarov_po_stolu_93
//vsego_matov_skazano_382

//Это есть гланое окно тут только менюшка и ещё немного будет дописано

namespace DoodleJump
{
    public partial class MainWindow : Form
    {
        public bool isGameStart = false;
        public MainWindow()
        {
            InitializeComponent();
        }


        public async void playButton_Click(object sender, EventArgs e)
        {

            playButton.BackgroundImage = Properties.Resources.start_button_on;
            await Task.Delay(75);
            playButton.BackgroundImage = Properties.Resources.starn_button;

            FormForGame formForGame = new FormForGame();

            formForGame.Show();

            //this.Visible = false;

        }
    }
}
