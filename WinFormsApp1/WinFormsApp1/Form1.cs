namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool up = false;
        bool down = false;
        bool left = false;
        bool right = false;



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            up = down = left = right = false;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    picman.Top -= 5;
                    break;
                case Keys.Down:
                    picman.Top += 5;
                    break;
                case Keys.Left:
                    picman.Left -= 5;
                    break;
                case Keys.Right:
                    picman.Left += 5;
                    break;
            }
        }
        int speed = 1;
        int score = 0;
        bool[] iscoin = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picman.Location.Y > 0 && picman.Location.Y < 410 && picman.Location.X < 25 && picman.Location.X < 525)
            {
                if (up && picman.Location.Y > 0)
                {
                    picman.Top -= 1;
                    if (picman.Location.Y > 0) { up = false; }
                }
                else
                {
                    up = false;
                }
                if (up && picman.Location.Y < 410)
                {
                    picman.Top -= 1;
                }
                else
                {
                    down = false;
                }
                if (up && picman.Location.X > 25)
                {
                    picman.Top -= 1;
                }
                else
                {
                    left = false;
                }
                if (up && picman.Location.X < 525)
                {
                    picman.Top -= 1;
                }
                else
                {
                    right = false;
                }
            }

            if (picman.Bounds.IntersectsWith(coin1.Bounds))
            {
                coin1.Visible = false;
                if (!iscoin[1])
                {
                    score = score + 1;
                    iscoin[1] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(coin2.Bounds))
            {
                coin2.Visible = false;

                if (!iscoin[2])
                {
                    score = score + 1;
                    iscoin[2] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(coin3.Bounds))
            {
                coin3.Visible = false;
                if (!iscoin[3])
                {
                    score = score + 1;
                    iscoin[3] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(coin4.Bounds))
            {
                coin4.Visible = false;
                if (!iscoin[4])
                {
                    score = score + 1;
                    iscoin[4] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(coin5.Bounds))
            {
                coin5.Visible = false;
                if (!iscoin[5])
                {
                    score = score + 1;
                    iscoin[5] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(coin6.Bounds))
            {
                coin6.Visible = false;
                if (!iscoin[6])
                {
                    score = score + 1;
                    iscoin[6] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(coin7.Bounds))
            {
                coin7.Visible = false;
                if (!iscoin[7])
                {
                    score = score + 1;
                    iscoin[7] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(coin8.Bounds))
            {
                coin8.Visible = false;
                if (!iscoin[8])
                {
                    score = score + 1;
                    iscoin[8] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(coin9.Bounds))
            {
                coin9.Visible = false;
                if (!iscoin[9])
                {
                    score = score + 1;
                    iscoin[9] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(coin10.Bounds))
            {
                coin10.Visible = false;
                if (!iscoin[10])
                {
                    score = score + 1;
                    iscoin[10] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(coin11.Bounds))
            {
                coin11.Visible = false;
                if (!iscoin[11])
                {
                    score = score + 1;
                    iscoin[11] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(coin12.Bounds))
            {
                coin12.Visible = false;
                if (!iscoin[12])
                {
                    score = score + 1;
                    iscoin[12] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(coin13.Bounds))
            {
                coin13.Visible = false;
                if (!iscoin[13])
                {
                    score = score + 1;
                    iscoin[13] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(coin14.Bounds))
            {
                coin14.Visible = false;
                if (!iscoin[14])
                {
                    score = score + 1;
                    iscoin[14] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(coin15.Bounds))
            {
                coin15.Visible = false;
                if (!iscoin[15])
                {
                    score = score + 1;
                    iscoin[15] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(coin16.Bounds))
            {
                coin16.Visible = false;
                if (!iscoin[16])
                {
                    score = score + 1;
                    iscoin[16] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(coin17.Bounds))
            {
                coin17.Visible = false;
                if (!iscoin[17])
                {
                    score = score + 1;
                    iscoin[17] = true;
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
    }
}

