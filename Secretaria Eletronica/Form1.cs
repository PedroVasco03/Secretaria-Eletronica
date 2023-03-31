using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretaria_Eletronica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (pg_Paginas.Page == pg_Home)
            {
                btn_BackHome.Visible = false;
            }
        }
        bool sidebarExpand;
        bool menuColapse;
        bool sobreColapse;
        private void btn_closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizeForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void sidebarTimerAnimation_Tick(object sender, EventArgs e)
        {
            
            //define o minimo e maximo tamanho do sidebar

            if(sidebarExpand){
                //se sidebar está expandido, minimiza
                sidebar.Width -= 40;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimerAnimation.Stop();
                }
            }
            else
            {
                //se sidebar está minimizado, expanda
                sidebar.Width += 40;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimerAnimation.Stop();
                }
            }
            }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimerAnimation.Start();
            menuTimer.Start();
            if(sidebarExpand){
                sobreColapse = true;
                sobreTimer.Start();
            }
        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            if (!menuColapse)
            {
                menuContainer.Height += 40;
                if(menuContainer.Height == menuContainer.MaximumSize.Height)
                {
                    menuColapse = true;
                    menuTimer.Stop();
                }
            }
            else
                {
                    menuContainer.Height -= 40;
                    if(menuContainer.Height == menuContainer.MinimumSize.Height)
                    {
                        menuColapse = false;
                        menuTimer.Stop();
                    }
            }
        }

        private void sobreTimer_Tick(object sender, EventArgs e)
        {
            if (!sobreColapse)
            {
                sobreContainer.Height += 40;
                if (sobreContainer.Height == sobreContainer.MaximumSize.Height)
                {
                    sobreColapse = true;
                    sobreTimer.Stop();
                }
            }
            else
            {
                sobreContainer.Height -= 40;
                if (sobreContainer.Height == sobreContainer.MinimumSize.Height)
                {
                    sobreColapse = false;
                    sobreTimer.Stop();
                }
            }
        }
        public void removerFundo()
        {
            btn_home.BackColor = Color.Transparent;
            btn_galeria.BackColor = Color.Transparent;
            btn_sobre.BackColor = Color.Transparent;
        }
        private void btn_sobre_Click(object sender, EventArgs e)
        {
            sobreTimer.Start();
            
        }
            
        private void btn_home_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Home;

            removerFundo();
            if(pg_Paginas.Page == pg_Home)
            {
                btn_home.BackColor = Color.FromArgb(39, 63, 72);
            }

            if (pg_Paginas.Page == pg_Home)
            {
                btn_BackHome.Visible = false;
            }
        }

        private void btn_galeria_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Galeria;

            removerFundo();
            if (pg_Paginas.Page == pg_Galeria)
            {
                btn_galeria.BackColor = Color.FromArgb(39, 63, 72);
            }
        }

        private void btn_somos_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Somos;

            removerFundo();
            if (pg_Paginas.Page == pg_Somos)
            {
                btn_sobre.BackColor = Color.FromArgb(39, 63, 72);
            }
        }

        private void btn_contacto_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Contacto;

            removerFundo();
            if (pg_Paginas.Page == pg_Contacto)
            {
                btn_sobre.BackColor = Color.FromArgb(39, 63, 72);
            }
        }

        private void areaDeFormacao1_Click(object sender, EventArgs e)
        {
            
        }
        private void cb_AreadeFormacao_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_AreaF;
            if (pg_Paginas.Page == pg_AreaF)
            {
                btn_BackHome.Visible = true;
            }
        }

        private void cb_AreaAdministrativa_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_AreaAdministrativa;

            if (pg_Paginas.Page == pg_AreaAdministrativa)
            {
                btn_BackHome.Visible = true;
            }
        }

        private void cb_Localização_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Localizacao;

            if (pg_Paginas.Page == pg_Localizacao)
            {
                btn_BackHome.Visible = true;
            }
        }

        private void cb_Horario_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Horario;

            if (pg_Paginas.Page == pg_Horario)
            {
                btn_BackHome.Visible = true;
            }
        }

        private void btn_BackHome_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Home;
            if (pg_Paginas.Page == pg_Home)
            {
                btn_BackHome.Visible = false;
            }
        }

        private void eletricidade1_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Eletricidade;
        }

        private void arEletricidade1_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Classe;
        }

        private void arEletricidade21_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Classe;
        }

        private void arEletricidade31_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Classe;
        }

        private void arEletricidade41_Click(object sender, EventArgs e)
        {
            pg_Paginas.Page = pg_Classe;
        }
    }
}
