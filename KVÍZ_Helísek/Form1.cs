using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KVÍZ_Helísek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Otazky(object sender, EventArgs e)
        {
       
 
        }

        private void btn_Videohry_Click(object sender, EventArgs e)
        {
            int spravnyVysledky = 0;
            string[] otazkyVideohry1 = { "1", "2", "3", "4", "5" };
            string[] otazkyVideohry2 = { "1", "2", "3", "4", "5" };
            string[] otazkyVideohry3 = { "1", "2", "3", "4", "5" };
            int nahodnyOtazky = rnd.Next(1, 4);
            switch (nahodnyOtazky)
            {
                case 1:
                    for (int i = 0; i < nup_Videohry.Value; i++)
                    {
                        if (otazkyVideohry1[i] == "1")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Zaklínač;
                            DialogResult result = MessageBox.Show("Je Zaklínač Divoký hon RPG hra?","Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyVideohry1[i] == "2")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.God_of_War;
                            DialogResult result = MessageBox.Show("Je Thor hlavní postavou hry God of War?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyVideohry1[i] == "3")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Sekiro;
                            DialogResult result = MessageBox.Show("Bylo Sekiro Shadow Die Twice hra roku?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyVideohry1[i] == "4")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Mario;
                            DialogResult result = MessageBox.Show("Je Mario Mexičan?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyVideohry1[i] == "5")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.TF2;
                            DialogResult result = MessageBox.Show("TF2 jsou jen dva týmy rozděleny na červený a modrý?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }

                    }
                    MessageBox.Show(spravnyVysledky + "/" + nup_Videohry.Value, "Výsledek");
                    if (spravnyVysledky == nup_Videohry.Value)
                    {
                        MessageBox.Show("Výborně");
                    }
                    break;
                case 2:
                    for (int i = 0; i < nup_Videohry.Value; i++)
                    {
                        if (otazkyVideohry2[i] == "1")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.The_last;
                            DialogResult result = MessageBox.Show("Je Joe hlavní postava The last of us II?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyVideohry2[i] == "2")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.WOW;
                            DialogResult result = MessageBox.Show("Je WOW MMORPG hra?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyVideohry2[i] == "3")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.WOW;
                            DialogResult result = MessageBox.Show("Je Shadowlands expanze do WOW?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyVideohry2[i] == "4")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Detroit_become_human;
                            DialogResult result = MessageBox.Show("Ve hře Detroit: become human hrajete za lidi?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyVideohry2[i] == "5")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Far_Cry;
                            DialogResult result = MessageBox.Show("Odehrává se Far cry 4 v Americe?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }

                    }
                    MessageBox.Show(spravnyVysledky + "/" + nup_Videohry.Value, "Výsledek");
                    if (spravnyVysledky == nup_Videohry.Value)
                    {
                        MessageBox.Show("Výborně");
                    }
                    break;
                case 3:
                    for (int i = 0; i < nup_Videohry.Value; i++)
                    {
                        if (otazkyVideohry3[i] == "1")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Eternal_DOOM;
                            DialogResult result = MessageBox.Show("Je Doomsday hlavní postavou hry Doom?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyVideohry3[i] == "2")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.GTA;
                            DialogResult result = MessageBox.Show("Je GTA 5?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyVideohry3[i] == "3")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.NFS;
                            DialogResult result = MessageBox.Show("Jsou Need for speedy arkádový hry?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyVideohry3[i] == "4")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.LOL;
                            DialogResult result = MessageBox.Show("Je League of Legends FPS hra?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyVideohry3[i] == "5")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Batman;
                            DialogResult result = MessageBox.Show("Byl dřív vydaný Batman Arkham Origins než Batman Arkham City?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                    }
                    MessageBox.Show(spravnyVysledky + "/" + nup_Videohry.Value,"Výsledek");
                    if (spravnyVysledky == nup_Videohry.Value)
                    {
                        MessageBox.Show("Výborně");
                    }
                    break;
                default:
                    break;
            }
        }

        private void btn_Filmy_Click(object sender, EventArgs e)
        {
            int spravnyVysledky = 0;
            string[] otazkyFilmy1 = { "1", "2", "3", "4", "5" };
            string[] otazkyFilmy2 = { "1", "2", "3", "4", "5" };
            string[] otazkyFilmy3 = { "1", "2", "3", "4", "5" };
            int nahodnyOtazky = rnd.Next(1, 4);
            switch (nahodnyOtazky)
            {
                case 1:
                    for (int i = 0; i < nup_Filmy.Value; i++)
                    {
                        if (otazkyFilmy1[i] == "1")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Django;
                            DialogResult result = MessageBox.Show("Ztvární Leonardo Di Caprio nesputanýho Djanga?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyFilmy1[i] == "2")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Sini;
                            DialogResult result = MessageBox.Show("Je Sinister horror?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyFilmy1[i] == "3")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Avangers;
                            DialogResult result = MessageBox.Show("Vystupuje Spider-man ve filmu Avangers?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyFilmy1[i] == "4")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Počátek;
                            DialogResult result = MessageBox.Show("Je Počátek o snech?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyFilmy1[i] == "5")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.sedm;
                            DialogResult result = MessageBox.Show("Je film Sedm životopis?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }

                    }
                    MessageBox.Show(spravnyVysledky + "/" + nup_Filmy.Value, "Výsledek");
                    if (spravnyVysledky == nup_Filmy.Value)
                    {
                        MessageBox.Show("Výborně");
                    }
                    break;
                case 2:
                    for (int i = 0; i < nup_Filmy.Value; i++)
                    {
                        if (otazkyFilmy2[i] == "1")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Chalupari;
                            DialogResult result = MessageBox.Show("Patří Sovák mezi hlavní postavy seriálu Chalupáři?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyFilmy2[i] == "2")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Na_samotě;
                            DialogResult result = MessageBox.Show("Režíroval Svěrák film Na samotě u lesa?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyFilmy2[i] == "3")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.kulový;
                            DialogResult result = MessageBox.Show("Odehrává se Kulový blesk na vesnici?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyFilmy2[i] == "4")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Ecce;
                            DialogResult result = MessageBox.Show("Je film Ecce homo Homolka černobílý?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyFilmy2[i] == "5")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Pane;
                            DialogResult result = MessageBox.Show("Je film Pane vy jste vdova o cestování v čase?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }

                    }
                    MessageBox.Show(spravnyVysledky + "/" + nup_Filmy.Value, "Výsledek");
                    if (spravnyVysledky == nup_Filmy.Value)
                    {
                        MessageBox.Show("Výborně");
                    }
                    break;
                case 3:
                    for (int i = 0; i < nup_Filmy.Value; i++)
                    {
                        if (otazkyFilmy3[i] == "1")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Kill_bill;
                            DialogResult result = MessageBox.Show("Je hláška (Pavouk chytil dvě mouchy) z filmu Kill Bill?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyFilmy3[i] == "2")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.big;
                            DialogResult result = MessageBox.Show("Žije Dude Lebowski v Polsku?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyFilmy3[i] == "3")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.vezeni;
                            DialogResult result = MessageBox.Show("Je film Vykoupení z věznice Shawshank o bankéři?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyFilmy3[i] == "4")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.chyt_me_kdyz;
                            DialogResult result = MessageBox.Show("Je film Chyť mě, když to dokážeš podle skutěčných událostí?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyFilmy3[i] == "5")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Batman;
                            DialogResult result = MessageBox.Show("Je Joker hlavní záporák filmu Temný rytíř povstal?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                    }
                    MessageBox.Show(spravnyVysledky + "/" + nup_Filmy.Value, "Výsledek");
                    if (spravnyVysledky == nup_Filmy.Value)
                    {
                        MessageBox.Show("Výborně");
                    }
                    break;
                default:
                    break;
            }
        }

        private void btn_Anime_Click(object sender, EventArgs e)
        {

            int spravnyVysledky = 0;
            string[] otazkyAnime1 = { "1", "2", "3", "4", "5" };
            string[] otazkyAnime2 = { "1", "2", "3", "4", "5" };
            string[] otazkyAnime3 = { "1", "2", "3", "4", "5" };
            int nahodnyOtazky = rnd.Next(1, 4);
            switch (nahodnyOtazky)
            {
                case 1:
                    for (int i = 0; i < nup_Anime.Value; i++)
                    {
                        if (otazkyAnime1[i] == "1")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.JJBA;
                            DialogResult result = MessageBox.Show("Má JJBA jen 5 partu?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyAnime1[i] == "2")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Naruto;
                            DialogResult result = MessageBox.Show("Je Naruto o obřích robotech?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyAnime1[i] == "3")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Hunter_x_hunter;
                            DialogResult result = MessageBox.Show("Hunter x hunter je shounen?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyAnime1[i] == "4")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Death_note;
                            DialogResult result = MessageBox.Show("Umře Kira v Death Note?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyAnime1[i] == "5")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Cowboy_Bebop;
                            DialogResult result = MessageBox.Show("Cowboy Bebop je o vesmírných lovcí odměn?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }

                    }
                    MessageBox.Show(spravnyVysledky + "/" + nup_Anime.Value, "Výsledek");
                    if (spravnyVysledky == nup_Anime.Value)
                    {
                        MessageBox.Show("Výborně");
                    }
                    break;
                case 2:
                    for (int i = 0; i < nup_Anime.Value; i++)
                    {
                        if (otazkyAnime2[i] == "1")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.My_hero_academia;
                            DialogResult result = MessageBox.Show("My hero academia je v Japonštině Boku no hero academia?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyAnime2[i] == "2")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.One_punch_man;
                            DialogResult result = MessageBox.Show("Je hlavní protagonista seriálu One Punch Man plešatý?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyAnime2[i] == "3")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Attack_on_titan;
                            DialogResult result = MessageBox.Show("V sriálu Attack on titan žijou lidi jen za zdmi?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyAnime2[i] == "4")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Fullmetal_Alechemist;
                            DialogResult result = MessageBox.Show("Fullmetal alchemist je seriál o bratrancích?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyAnime2[i] == "5")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Demon_Slayer;
                            DialogResult result = MessageBox.Show("Je Demon Slayer o sestře a bratrovi?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }

                    }
                    MessageBox.Show(spravnyVysledky + "/" + nup_Anime.Value, "Výsledek");
                    if (spravnyVysledky == nup_Anime.Value)
                    {
                        MessageBox.Show("Výborně");
                    }
                    break;
                case 3:
                    for (int i = 0; i < nup_Anime.Value; i++)
                    {
                        if (otazkyAnime3[i] == "1")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Goblin_slayer;
                            DialogResult result = MessageBox.Show("Je Goblin Slayer o budoucnosti?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyAnime3[i] == "2")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Naruto;
                            DialogResult result = MessageBox.Show("Je Naruto o liščím démonovi?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyAnime3[i] == "3?")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Tokyo_Ghoul;
                            DialogResult result = MessageBox.Show("Tokyo ghoul je seriál o vzniku města Tokyo?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyAnime3[i] == "4")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.JJBA;
                            DialogResult result = MessageBox.Show("Jsou v JJBA upíři?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                        else if (otazkyAnime3[i] == "5")
                        {
                            pic_obrazky.Image = KVÍZ_Helísek.Properties.Resources.Sedm_Smrtelných_hříchu;
                            DialogResult result = MessageBox.Show("Je seriál Sedm smrtelných hříchu o velkým blonďákovi?", "Kvíz", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.No)
                            {
                                spravnyVysledky++;
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                        }
                    }
                    MessageBox.Show(spravnyVysledky + "/" + nup_Anime.Value, "Výsledek");
                    if (spravnyVysledky == nup_Anime.Value)
                    {
                        MessageBox.Show("Výborně");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
