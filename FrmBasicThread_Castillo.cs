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

namespace CastilloAsh
{
    public partial class FrmBasicThread : Form
    {
        private Thread ThreadX, ThreadY;
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine("--------");
            Console.WriteLine("-Before starting thread-");
            ThreadStart delObjThread = new ThreadStart(MyThreadClass.Thread1);

            ThreadX = new Thread(delObjThread);
            ThreadX.Name = "Child Thread A";
            ThreadY = new Thread(delObjThread);
            ThreadY.Name = "Child Thread B";
            ThreadX.Start();
            ThreadY.Start();
            ThreadX.Join();
            ThreadY.Join();
            label1.Text = ("-End of Thread-");
        }
    }
}
