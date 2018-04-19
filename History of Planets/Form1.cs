using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Login_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelLeft.Height = buttonHome.Height;
            panelLeft.Top = buttonHome.Top;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonHome.Height;
            panelLeft.Top = buttonHome.Top;
        }

        private void buttonSolarSystem_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonSolarSystem.Height;
            panelLeft.Top = buttonSolarSystem.Top;
        }

        private void buttonPlanets_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonPlanets.Height;
            panelLeft.Top = buttonPlanets.Top;
        }

        private void buttonNews_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonNews.Height;
            panelLeft.Top = buttonNews.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
