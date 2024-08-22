using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_EventExample
{
    public partial class Rascal : Form
    {

        private Form1 form1Ref = null;

        public Form1 Form1Ref
        {
            get { return form1Ref = null; }
            set { form1Ref = value; }
        }

        public Rascal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //form1Ref.lightChange = null;

            form1Ref.lightChange += this.reactOnLight;
            //if (form1Ref != null)
            //{
            //    form1Ref.lightChange(eLight.Red);
            //}

            //Add a metode reference to the delegate instance
            //form1Ref?.RegisterLight(this.reactOnLight);
        }

        public void reactOnLight(eLight light)
        {
            form1Ref.tbCar.Text = "Rascal issue ";
            Console.WriteLine("Ill do nothing the rascal says");
        }
    }
}
