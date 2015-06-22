using System;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A a = new A();

            var b = a.Aprop;

            var c = a.Aprop;

        }
    }


    public class A
    {
        public A()
        {
        }
        public string Aprop { get; set; }
    }
}
