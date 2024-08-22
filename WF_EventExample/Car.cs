using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_EventExample
{
    class Car
    {
        private Form1 m_form;
        public Car( Form1 form)
        {

            this.m_form = form;
            //this.m_form.RegisterLight(this.reactOnLight);
            this.m_form.lightChange += this.reactOnLight;
        }

        //public Car(ref LightChangeDel lightChange, Form1 form)
        //{           

        //    this.m_form = form;
        //    lightChange += this.reactOnLight;
        //}

        public void reactOnLight(eLight light)
        {
            if (light == eLight.Red)
            {
                Console.WriteLine("Car stop");
                m_form.tbCar.Text = "Stop";
            }
            else if (light == eLight.Yellow)
            {
                Console.WriteLine("Car still stop");
                m_form.tbCar.Text = "We still Stop";
            }
            else if (light == eLight.Green)
            {
                Console.WriteLine("Car go go go");
                m_form.tbCar.Text = "Step on it ";
            }
        }
    }
}
