using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Registro nuevoregistro;

        bool goup;
        bool godown;
        bool goleft;
        bool goright;
        int speed = 5;
        int ghost1x = 6;
        int ghost2x = 6;
        int ghost1y = 6;
        int ghost2y = 6;
        int score = 0;
        public Form1(Registro miregistro)
        {
            InitializeComponent();
            nuevoregistro = miregistro;
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.BringToFront();
            labelGameO.Visible = false;
            listBoxPuntajes.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void labelNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNombreUsuario.Text != null)
                {
                    panel1.Visible = false;
                }
            }
            catch
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPacman_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxPink_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxFruit_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxRed_Click(object sender, EventArgs e)
        {

        }

        private void keyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                pictureBoxPacman.Image = Properties.Resources.pacman_left;

            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                pictureBoxPacman.Image = Properties.Resources.pacman_right;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                pictureBoxPacman.Image = Properties.Resources.pacman_up;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                pictureBoxPacman.Image = Properties.Resources.pacman_down;
            }
        }

        private void keyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }

        private void labelScore_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelScore.Text = "Score: " + score.ToString();

            if (goleft == true)
            {
                pictureBoxPacman.Left -= speed;
            }
            if (goright == true)
            {
                pictureBoxPacman.Left += speed;
            }
            if (goup == true)
            {
                pictureBoxPacman.Top -= speed;
            }
            if (godown == true)
            {
                pictureBoxPacman.Top += speed;
            }
            //Random r = new Random();
            //int x2 = r.Next(0, 502);
            //int y = r.Next(0, 474);
            //int x1 = r.Next(0, 502);
            //int y2 = r.Next(0, 474);
            //pictureBoxPink.Left = x2;
            //pictureBoxPink.Top = y;
            //pictureBoxRed.Left = x1;
            //pictureBoxRed.Top = y2;
            pictureBoxPink.Top -= ghost1y;
            pictureBoxRed.Top -= ghost2y;
            pictureBoxPink.Left -= ghost1x;
            pictureBoxRed.Left -= ghost2x;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag.ToString() == "ghost")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pictureBoxPacman.Bounds) || score == 30)
                    {
                        pictureBoxPacman.Left = 0;
                        pictureBoxPacman.Top = 25;
                        labelGameO.Visible = true;
                        string nombre = textBoxNombreUsuario.Text;
                        Usuario user = new Usuario(nombre, score);
                        nuevoregistro.AgregarUsuario(user);
                        timer1.Stop();
                    }
                }
                if (x is PictureBox && x.Tag.ToString() == "fruit")
                {
                    //checking if the player hits the points picturebox then we can add to the score
                    if (((PictureBox)x).Bounds.IntersectsWith(pictureBoxPacman.Bounds))
                    {
                        this.Controls.Remove(x);
                        score += 15;
                    }
                }
            }
            if (pictureBoxPink.Left < 1 || pictureBoxPink.Left + pictureBoxPink.Width > ClientSize.Width - 2)
            {
                ghost1x = -ghost1x;
            }
            if (pictureBoxPink.Top < 1 || pictureBoxPink.Top + pictureBoxPink.Height > ClientSize.Height - 2)
            {
                ghost1y = -ghost1y;
            }
            if (pictureBoxRed.Left < 1 || pictureBoxRed.Left + pictureBoxRed.Width > ClientSize.Width - 2)
            {
                ghost2x = -ghost2x;
            }
            if (pictureBoxRed.Top < 1 || pictureBoxRed.Top + pictureBoxRed.Height > ClientSize.Height - 2)
            {
                ghost2y = -ghost2y;
            }

        }

        private void labelGameO_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            BinaryFormatter bin = new BinaryFormatter();
            if (File.Exists("../../Serialized.txt"))
            {
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Open, FileAccess.Write);
                bin.Serialize(stream, nuevoregistro);
                stream.Close();
            }
            else
            {
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Create, FileAccess.Write);
                bin.Serialize(stream, nuevoregistro);
                stream.Close();
            }
            base.OnFormClosing(e);
        }

        private void buttonPuntajes_Click(object sender, EventArgs e)
        {
            listBoxPuntajes.Show();
            List<Usuario> listaUsuario = nuevoregistro.GetListaUsuarios();
            foreach (Usuario u in listaUsuario)
            {
                string str = u.GetNombre() + " " + u.GetPuntaje();
                if (listBoxPuntajes.Items.Contains(str))
                {
                    continue;
                }
                else
                {
                    this.listBoxPuntajes.Items.Add(str);
                }
            }
        }

        private void listBoxPuntajes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
