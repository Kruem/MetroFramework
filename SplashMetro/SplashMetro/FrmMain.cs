using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashMetro
{
    public partial class FrmMain : MetroFramework.Forms.MetroForm
    {
        public FrmMain()
        {
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start();
            for (int i = 0; i <= 1000; i++)
                Thread.Sleep(10);
            t.Abort();

            {

            }
            InitializeComponent();


        }
        public void Loading()
        {
            Frmspl frm = new Frmspl();
            Application.Run(frm);
        }
    }
}
