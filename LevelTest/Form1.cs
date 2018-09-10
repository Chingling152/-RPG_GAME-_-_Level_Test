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
            player.Influencias();
    
            lbl_N_P_XP.Text = player.XpCap.ToString();
            lbl_PPTS.Text = player.pts.ToString();
            lbl_P_XP.Text = player.xp.ToString();         

            lbl_PNV.Text = player.nivel.ToString();

            lbl_PF_.Text = player.forca.ToString();
            lbl_PD_.Text = player.destreza.ToString();
            lbl_PR_.Text = player.resistencia.ToString();
            lbl_PV_.Text = player.vigor.ToString();
            lbl_PM_.Text = player.magia.ToString();

            lbl_PHP_.Text = player.hp.ToString();
            lbl_PSTA_.Text = player.stamina.ToString();
            lbl_PP_.Text = player.pesomax.ToString();
            lbl_PSLT_.Text = player.slotsmagia.ToString();

            lbl_P_DMG_F.Text = player.danofisico.ToString("N2");
            lbl_P_DMG_FG.Text = player.danofogo.ToString("N2");
            lbl_P_DMG_R.Text = player.danoraio.ToString("N2");
            lbl_P_DMG_V.Text = player.danoveneno.ToString("N2");
            lbl_P_DMG_M.Text = player.danomagico.ToString("N2");

            lbl_P_DEF_F.Text = player.defesafisica.ToString("N2");
            lbl_P_DEF_FG.Text = player.defesafogo.ToString("N2");
            lbl_P_DEF_R.Text = player.defesaraio.ToString("N2");
            lbl_P_DEF_V.Text = player.defesaveneno.ToString("N2");
            lbl_P_DEF_M.Text = player.defesamagica.ToString("N2");
        }

        //ABSTRAÇÃO NIVEIS
        public void Level(bool mais , int t) {
            if (mais) {
                switch (t)
                {
                    case 1:
                        if(player.forca < 100 && player.pts > 0) {
                            player.forca++;
                            player.nivel++;
                            player.pts --;
                        }
                        break;
                    case 2:
                        if (player.destreza < 100 && player.pts > 0){
                            player.destreza++;
                            player.nivel++;
                            player.pts--;
                        }
                        break;
                    case 3:
                        if (player.resistencia < 100 && player.pts > 0){
                            player.resistencia++;
                            player.nivel++;
                            player.pts--;
                        }
                        break;
                    case 4:
                        if (player.vigor < 100 && player.pts > 0){
                            player.vigor++;
                            player.nivel++;
                            player.pts--;
                        }
                        break;
                    case 5:
                        if (player.magia < 100 && player.pts > 0){
                            player.magia++;
                            player.nivel++;
                            player.pts--;
                        }
                        break;
                    default:
                        break;
                }
            }
            else {
                switch (t){
                    case 1:
                        if(player.forca > 1) {
                            player.forca--;
                            player.nivel--;
                            player.pts++;
                        }
                        break;
                    case 2:
                        if (player.destreza > 1){
                            player.destreza--;
                            player.nivel--;
                            player.pts++;
                        }
                        break;
                    case 3:
                        if (player.resistencia > 1){
                            player.resistencia--;
                            player.nivel--;
                            player.pts++;
                        }
                        break;
                    case 4:
                        if (player.vigor > 1){
                            player.vigor--;
                            player.nivel--;
                            player.pts++;
                        }
                        break;
                    case 5:
                        if (player.magia > 1){
                            player.magia--;
                            player.nivel--;
                            player.pts++;
                        }
                        break;
                    default:
                        break;
                }
            }
            PrintIt();
        }
        
        //XP
        private void Btn_mais_xp_Click(object sender, EventArgs e)
        {
            int.TryParse(txt_xp_inc.Text, out int xp);
            player.xp += xp;

            PrintIt();
        }

        private void Btn_menos_xp_Click(object sender, EventArgs e)
        {
            int.TryParse(txt_xp_inc.Text, out int xp);
            if (player.xp > xp) {
                player.xp -= xp;
            }

            PrintIt();
        }

        //NIVEIS
        private void Btn_mais_for_Click(object sender, EventArgs e)
        {
            Level(true , 1);
        }

        private void Btn_menos_for_Click(object sender, EventArgs e)
        {
            Level(false , 1);
        }

        private void Btn_menos_dex_Click(object sender, EventArgs e)
        {
            Level(false , 2);
        }

        private void Btn_mais_dex_Click(object sender, EventArgs e)
        {
            Level(true, 2);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Level(false , 3);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Level(true, 3);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Level(false, 4);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Level(true, 4);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Level(false, 5);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Level(true, 5);
        }
    }
}
