using System;

using System.Windows.Forms;

namespace MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "This a pop-up similar to JOptionPane";
            string title = "JOptionPane Example";
            System.Windows.Forms.MessageBox.Show(msg, title);


        }
    }
}
