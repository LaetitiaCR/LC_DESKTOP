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

namespace WinFrmAppEvenAndThreadToutEmbal
{
    public partial class Form1 : Form
    {
        private Thread myThread;
        private Thread myThreadA;
        public delegate void AddListItem();
        public AddListItem myDelegate;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripTextBoxQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItemDemA_Click(object sender, EventArgs e)
        {
           // myDelegate = new AddListItem(AddListItemMethod);
            myThread = new Thread(new ThreadStart(ThreadFunction));
            myThread.Start();
        }

        private void ThreadFunction()
        {
            ClassMyThread myThreadClassObject = new ClassMyThread(this);
            myThreadClassObject.Run();

        }

        private void AddListItemMethod()
        {
           
           
                Thread.Sleep(300);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        /*Les productions horaires sont les suivantes:
        Caisse A:    1000 caisses/heure
        Caisse B:    5000 caisses/heure
        Caisses C: 10000 caisses/heure
        */

        /*
        La progression de la production des caisses de types A, B et C est représentée dans 3 barres de production.
        Le nombre de caisses à produire pour chaque type est le suivant:
        Caisses de type A:   10000
        Caisses de type B:   25000
        Caisses de type C: 120000
        */
    }
}
