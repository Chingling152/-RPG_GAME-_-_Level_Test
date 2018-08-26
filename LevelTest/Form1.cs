using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LevelTest.Scripts;

namespace LevelTest
{
    public partial class Form1 : Form
    {

        public Player player = new Player();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintIt();
        }

        public void PrintIt() {
            lbl_PNV.Text = player.nivel.ToString();
            lbl_P_XP.Text = player.xp.ToString();

            lbl_PF_.Text = player.forca.ToString();
            lbl_PD_.Text = player.destreza.ToString();
            lbl_PR_.Text = player.resistencia.ToString();
            lbl_PV_.Text = player.vigor.ToString();
            lbl_PM_.Text = player.magia.ToString();

            lbl_PHP_.Text = player.hp.ToString();
            lbl_PSTA_.Text = player.stamina.ToString();
            lbl_PP_.Text = player.pesomax.ToString();
            lbl_PSLT_.Text = player.slotsmagia.ToString();

            lbl_P_DMG_F.Text = player.danofisico.ToString();
            lbl_P_DMG_FG.Text = player.danofogo.ToString();
            lbl_P_DMG_R.Text = player.danoraio.ToString();
            lbl_P_DMG_V.Text = player.danoveneno.ToString();
            lbl_P_DMG_M.Text = player.danomagico.ToString();

            lbl_P_DEF_F.Text = player.defesafisica.ToString();
            lbl_P_DEF_FG.Text = player.defesafogo.ToString();
            lbl_P_DEF_R.Text = player.defesaraio.ToString();
            lbl_P_DEF_V.Text = player.defesaveneno.ToString();
            lbl_P_DEF_M.Text = player.defesamagica.ToString();
        } 
    }
}
