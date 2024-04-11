using System.Xml.Serialization;

namespace Spanzuratoarea
{
    public partial class Form1 : Form
    {
        string cuv;
        string copie;
        string copie2;
        int k = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var n = new Random();
            StreamReader streamReader = new StreamReader(path: "Cuvinte.txt");
            for (int i = 0; i <= n.Next(0, 9); i++)
            {
                cuv = streamReader.ReadLine();
            }
            copie = new string('*', cuv.Length);
            //copie = cuv;
            Console.WriteLine(copie);
            renCuv();
            literaTextBox.MaxLength = 1;
            ChangePhoto();
        }

        void Win()
        {
            MessageBox.Show("YOU WIN!!!", "WIN");
            this.Close();
        }

        void renCuv()
        {
            cuvantLabel.Text = copie;
        }
        void schimbaC(int x, char c)
        {
            char[] c1 = copie.ToCharArray();
            c1[x] = c;
            copie = new string(c1);
        }

        void Lose()
        {
            MessageBox.Show("YOU LOSE!!!", "LOSE");
            this.Close();
        }

        void ChangePhoto()
        {


            switch (k)
            {
                case 1:
                    {
                        desenPictureBox.Image = Image.FromFile("1.jpg");
                        desenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 2:
                    {
                        desenPictureBox.Image = Image.FromFile("2.jpg");
                        desenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 3:
                    {
                        desenPictureBox.Image = Image.FromFile("3.jpg");
                        desenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 4:
                    {
                        desenPictureBox.Image = Image.FromFile("4.jpg");
                        desenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 5:
                    {
                        desenPictureBox.Image = Image.FromFile("5.jpg");
                        desenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 6:
                    {
                        desenPictureBox.Image = Image.FromFile("6.jpg");
                        desenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 7:
                    {
                        desenPictureBox.Image = Image.FromFile("7.jpg");
                        desenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case 8:
                    {
                        desenPictureBox.Image = Image.FromFile("8.jpg");
                        desenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        Lose();
                        break;
                    }
                case 9:
                    {
                        desenPictureBox.Image = Image.FromFile("8.jpg");
                        desenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        Lose();
                        break;
                    }

            }
        }

        void verificareLit(char c)
        {
            int x = cuv.IndexOf(c), f = 0;
            while (x != -1)
            {
                f = 1;
                schimbaC(x, c);
                x = cuv.IndexOf(c, x + 1);
            }
            if (f == 0)
            {
                k++;
                ChangePhoto();
            }
            renCuv();
            if(copie == cuv) { Win(); }
        }

        private void verificareLButton_Click(object sender, EventArgs e)
        {
            char[] c = literaTextBox.Text.ToCharArray();
            verificareLit(c[0]);
        }

        private void verificareCButton_Click(object sender, EventArgs e)
        {
            copie2 = CuvTextBox.Text;
            if (copie2 == cuv) { Win() ; }
            else {
                k += 2;
                ChangePhoto();
            }
        }
    }
}
