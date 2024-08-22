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

    public delegate void LightChangeDel(eLight color);

    public enum eLight {
        Green,
        Yellow,
        Red
    }

    public partial class Form1 : Form
    {
        public event LightChangeDel lightChange = null;

        public Form1()
        {
            InitializeComponent();

            //Car car1 = new Car(ref lightChange, this);
            Car car1 = new Car( this);

            Rascal rascal = new Rascal();
            rascal.Form1Ref = this;
            rascal.Show();

        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("" + (int)eLight.Red);
            lightChange?.Invoke(eLight.Red);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lightChange?.Invoke(eLight.Yellow);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lightChange?.Invoke(eLight.Green);
        }

        
        //public void RegisterLight(LightChangeDel lc)
        //{
        //    lightChange += lc;
            
        //}

        //public void UnRegisterLight(LightChangeDel lc)
        //{
        //    lightChange -= lc;
            
        //}
        
    }
}
