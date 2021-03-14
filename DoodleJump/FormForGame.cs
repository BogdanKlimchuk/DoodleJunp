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

//Форма для игры откроется сама после нажатии кнопки


namespace DoodleJump
{
    public partial class FormForGame : Form
    {
        Player player;
        Timer timer1;

        public FormForGame()
        {
            InitializeComponent();
        }

       
        public void Init()
        {
            PlateGenerator.plates = new System.Collections.Generic.List<Plate>();
            PlateGenerator.AddPlate(new System.Drawing.PointF(100, 450));
            PlateGenerator.startPlatePosY = 400;
            Physic.score = 0;
            PlateGenerator.GenerateStartPlatform();
            player = new Player();
        }

        private void OnKeyboardUp(object sender, KeyEventArgs e)
        {
            player.physic.dx = 0;
        }

        private void OnKeyboardPressed(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    player.physic.dx = 6;
                    Player.AddPlayer(Properties.ResourceGameSpace.man_spaceright);
                    break;
                case "Left":
                    player.physic.dx = -6;
                    Player.AddPlayer(Properties.ResourceGameSpace.man_spaceleft);
                    break;
            }
        }

        private void Update(object sender, EventArgs e)
        {
            this.Text = "Doodle Jump: Score - " + Physic.score;

            if (player.physic.obj.position.Y >= PlateGenerator.plates[0].obj.position.Y + 200)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.isGameStart = false;
                timer1.Stop();
                //mainWindow.Visible = true;
                this.Close();

            }
            player.physic.ApplyPhysics();
            FollowPlayer();
            Invalidate();
        }
        public void FollowPlayer()
        {
            int offset = 400 - (int)player.physic.obj.position.Y;
            player.physic.obj.position.Y += offset;
            for (int i = 0; i < PlateGenerator.plates.Count; i++)
            {
                var platform = PlateGenerator.plates[i];
                platform.obj.position.Y += offset;
            }
        }

        private void OnRepaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (PlateGenerator.plates.Count > 0)
            {
                for (int i = 0; i < PlateGenerator.plates.Count; i++)
                    PlateGenerator.plates[i].DrawPlate(g);
            }
            player.DrawPict(g);
        }

        private void FormForGame_Load(object sender, EventArgs e)
        {
            Init();
            Plate.AdImage(Properties.ResourceGameSpace.platform);
            Player.AddPlayer(Properties.ResourceGameSpace.man_spaceleft);
            timer1 = new Timer();
            timer1.Interval = 15;
            timer1.Tick += new EventHandler(Update);
            timer1.Start();
            this.KeyDown += new KeyEventHandler(OnKeyboardPressed);
            this.KeyUp += new KeyEventHandler(OnKeyboardUp);
            this.BackgroundImage = Properties.ResourceGameSpace.space_back;
            this.Height = 600;
            this.Width = 330;
            this.Paint += new PaintEventHandler(OnRepaint);

        }
    }
}
