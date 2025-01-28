using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Topicos
{
    /*
    Covarrubias Rosales Luis Humberto 20212393
     */
    public partial class Form1 : Form
    {
        private int tiempo;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo++;
            contador.Text=tiempo.ToString();
            if (contador.Text=="40")
            {
                picPrincipal.ImageLocation = Application.StartupPath + "\\Imagenes\\I1.jpg";
                rdb2.Checked = true;
                rdb1.Checked = false;
                rdb3.Checked = false;
                rdb4.Checked = false;
            }
            if (contador.Text == "80")
            {
                picPrincipal.ImageLocation = Application.StartupPath + "\\Imagenes\\I2.jpg";
                rdb3.Checked = true;
                rdb1.Checked = false;
                rdb2.Checked = false;
                rdb4.Checked = false;
            }
            if (contador.Text == "120")
            {
                picPrincipal.ImageLocation = Application.StartupPath + "\\Imagenes\\I3.jpg";
                rdb4.Checked = true;
                rdb2.Checked = false;
                rdb1.Checked = false;
                rdb3.Checked = false;
            }
            if (contador.Text == "160")
            {
                picPrincipal.ImageLocation = Application.StartupPath + "\\Imagenes\\I4.jpeg";
                rdb1.Checked = true;
                rdb4.Checked = false;
                rdb2.Checked = false;
                rdb3.Checked = false;
            }
            if (contador.Text == "160")
            {
                timer1.Enabled = false;
                tiempo = 0;
                contador.Text = "0";
                timer1.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void picTelefonoNegro_MouseMove(object sender, MouseEventArgs e)
        {
            picTelefonoNegro.Size = new System.Drawing.Size(180, 151);
            picAvatar.Size = new System.Drawing.Size(140, 151);
            picCars.Size = new System.Drawing.Size(140, 151);
            picEndgame.Size = new System.Drawing.Size(140, 151);
            picKungFuPanda.Size = new System.Drawing.Size(140, 151);
            picMiVillanoFavorito.Size = new System.Drawing.Size(140, 151);
        }

        private void picAvatar_MouseMove(object sender, MouseEventArgs e)
        {
            picAvatar.Size = new System.Drawing.Size(180, 151);
            picTelefonoNegro.Size = new System.Drawing.Size(140, 151);
            picCars.Size = new System.Drawing.Size(140, 151);
            picEndgame.Size = new System.Drawing.Size(140, 151);
            picKungFuPanda.Size = new System.Drawing.Size(140, 151);
            picMiVillanoFavorito.Size = new System.Drawing.Size(140, 151);
        }

        private void picCars_MouseMove(object sender, MouseEventArgs e)
        {
            picCars.Size = new System.Drawing.Size(180, 151);
            picTelefonoNegro.Size = new System.Drawing.Size(140, 151);
            picAvatar.Size = new System.Drawing.Size(140, 151);
            picEndgame.Size = new System.Drawing.Size(140, 151);
            picKungFuPanda.Size = new System.Drawing.Size(140, 151);
            picMiVillanoFavorito.Size = new System.Drawing.Size(140, 151);
        }

        private void picEndgame_MouseMove(object sender, MouseEventArgs e)
        {
            picCars.Size = new System.Drawing.Size(140, 151);
            picTelefonoNegro.Size = new System.Drawing.Size(140, 151);
            picAvatar.Size = new System.Drawing.Size(140, 151);
            picEndgame.Size = new System.Drawing.Size(180, 151);
            picKungFuPanda.Size = new System.Drawing.Size(140, 151);
            picMiVillanoFavorito.Size = new System.Drawing.Size(140, 151);
        }

        private void picKungFuPanda_MouseMove(object sender, MouseEventArgs e)
        {
            picCars.Size = new System.Drawing.Size(140, 151);
            picTelefonoNegro.Size = new System.Drawing.Size(140, 151);
            picAvatar.Size = new System.Drawing.Size(140, 151);
            picEndgame.Size = new System.Drawing.Size(140, 151);
            picKungFuPanda.Size = new System.Drawing.Size(180, 151);
            picMiVillanoFavorito.Size = new System.Drawing.Size(140, 151);
        }

        private void picMiVillanoFavorito_MouseMove(object sender, MouseEventArgs e)
        {
            picAvatar.Size = new System.Drawing.Size(140, 151);
            picTelefonoNegro.Size = new System.Drawing.Size(140, 151);
            picCars.Size = new System.Drawing.Size(140, 151);
            picEndgame.Size = new System.Drawing.Size(140, 151);
            picKungFuPanda.Size = new System.Drawing.Size(140, 151);
            picMiVillanoFavorito.Size = new System.Drawing.Size(180, 151);
        }

        private void cmbPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PelSelect = cmbPeliculas.SelectedItem.ToString();
            if (PelSelect == "Telefono Negro")
            {
                InfoTelefonoNegro formTelN = new InfoTelefonoNegro(1);
                formTelN.Show();
                this.Hide();
            }
            else if (PelSelect == "Guardianes de la galaxia Vol.3")
            {
                InfoGuardianesVol3 FormGuardianes = new InfoGuardianesVol3(4);
                FormGuardianes.Show();
                this.Hide();
            }
            else if (PelSelect == "Avatar")
            {
                InfoAvatar2 FormAvatar = new InfoAvatar2(2);
                FormAvatar.Show();
                this.Hide();
            }
            else if (PelSelect == "Avengers: Endgame")
            {
                InfoAvengersEndgame FormEndgame = new InfoAvengersEndgame(3);
                FormEndgame.Show();
                this.Hide();
            }
            else if (PelSelect == "Cars")
            {
                InfoCars FormCars = new InfoCars(5);
                FormCars.Show();
                this.Hide();
            }
            else if (PelSelect == "Kung fu panda")
            {
                InfoKungFuPanda FormKFP = new InfoKungFuPanda(6);
                FormKFP.Show();
                this.Hide();
            }
            else if (PelSelect == "Mi villano favorito 2")
            {
                InfoMiVillanoF2 FormMVF2 = new InfoMiVillanoF2(3);
                FormMVF2.Show();
                this.Hide();
            }
            else if (PelSelect == "Mario bros: La pelicula")
            {
                InfoMarioBros FormMB = new InfoMarioBros(1);
                FormMB.Show();
                this.Hide();
            }
            else if (PelSelect == "Spiderman into the spiderver")
            {
                InfoSpiderITSV FormSITSV = new InfoSpiderITSV(4);
                FormSITSV.Show();
                this.Hide();
            }
            else if (PelSelect == "Suzume")
            {
                InfoSuzume FormSzm = new InfoSuzume(2);
                FormSzm.Show();
                this.Hide();
            }
        }

        private void picTelefonoNegro_DoubleClick(object sender, EventArgs e)
        {
            InfoTelefonoNegro formTelN = new InfoTelefonoNegro(1);
            formTelN.Show();
            this.Hide();
        }
        private void picAvatar_DoubleClick(object sender, EventArgs e)
        {
            InfoAvatar2 FormAvatar = new InfoAvatar2(2);
            FormAvatar.Show();
            this.Hide();
        }
        private void picCars_Click(object sender, EventArgs e)
        {
            InfoCars FormCars = new InfoCars(5);
            FormCars.Show();
            this.Hide();
        }
        private void picEndgame_Click(object sender, EventArgs e)
        {
            InfoAvengersEndgame FormEndgame = new InfoAvengersEndgame(3);
            FormEndgame.Show();
            this.Hide();
        }
        private void picKungFuPanda_Click(object sender, EventArgs e)
        {
            InfoKungFuPanda FormKFP = new InfoKungFuPanda(6);
            FormKFP.Show();
            this.Hide();
        }
        private void picMiVillanoFavorito_Click(object sender, EventArgs e)
        {
            InfoMiVillanoF2 FormMVF2 = new InfoMiVillanoF2(3);
            FormMVF2.Show();
            this.Hide();
        }
    }
}
