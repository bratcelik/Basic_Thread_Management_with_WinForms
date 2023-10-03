namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random rnd;
        Thread th1;
        Thread th2;
        Thread th3;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

            btnBlue.Click += BtnBlue_Click;
            btnRed.Click += BtnRed_Click;
            btnYellow.Click += BtnYellow_Click;
        }

        private void BtnYellow_Click(object? sender, EventArgs e)
        {
            //metod1();

            th1 = new Thread(metod1);
            th1.Start();
        }

        private void BtnRed_Click(object? sender, EventArgs e)
        {
            //metod3();

            th3 = new Thread(metod3);
            th3.Start();
        }

        private void BtnBlue_Click(object? sender, EventArgs e)
        {
            //metod2();

            th2 = new Thread(metod2);
            th2.Start();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            rnd = new Random();
        }

        public void metod1() // yellow
        {
            for(int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(
                    new Pen(Brushes.Yellow, 4),
                    new Rectangle(
                        rnd.Next(0, this.Width),
                        rnd.Next(0, this.Height),
                        30,
                        30)
                    );

                Thread.Sleep(100);
            }
        }

        public void metod2() // blue
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(
                    new Pen(Brushes.Blue, 4),
                    new Rectangle(
                        rnd.Next(0, this.Width),
                        rnd.Next(0, this.Height),
                        30,
                        30)
                    );

                Thread.Sleep(100);
            }
        }

        public void metod3() // red
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(
                    new Pen(Brushes.Red, 4),
                    new Rectangle(
                        rnd.Next(0, this.Width),
                        rnd.Next(0, this.Height),
                        30,
                        30)
                    );

                Thread.Sleep(100);
            }
        }
    }
}