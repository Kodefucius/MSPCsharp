using System;
using System.Windows.Forms;
using PythonInteroperatingDemo;

namespace Test
{
    public partial class Form1 : Form
    {
        private InteropDemo _python;

        public Form1()
        {
            InitializeComponent();
            _python = new InteropDemo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                string executeMethod = _python.ExecuteMethod(methodName.Text);
                MessageBox.Show(executeMethod);
            }
            catch (Exception)
            {

                MessageBox.Show("Nu exista bla");
            }
          
        }
    }
}