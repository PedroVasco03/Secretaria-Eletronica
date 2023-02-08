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
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimerAnimation.Stop();
                }
            }
            else
            {
                //se sidebar está minimizado, expanda
                sidebar.Width += 10;
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
                menuContainer.Height += 10;
                if(menuContainer.Height == menuContainer.MaximumSize.Height)
                {
                    menuColapse = true;
                    menuTimer.Stop();
                }
            }
            else
                {
                    menuContainer.Height -= 10;
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
                sobreContainer.Height += 10;
                if (sobreContainer.Height == sobreContainer.MaximumSize.Height)
                {
                    sobreColapse = true;
                    sobreTimer.Stop();
                }
            }
            else
            {
                sobreContainer.Height -= 10;
                if (sobreContainer.Height == sobreContainer.MinimumSize.Height)
                {
                    sobreColapse = false;
                    sobreTimer.Stop();
                }
            }
        }

        private void btn_sobre_Click(object sender, EventArgs e)
        {
            sobreTimer.Start();
        }
    }
}
