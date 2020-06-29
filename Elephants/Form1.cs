using System;
using System.Windows.Forms;


namespace Elephants
{
    public partial class Form1 : Form
    {
        Elephant lloyd = new Elephant() { name = "Lloyd", earSize = 40 };
        Elephant lucinda = new Elephant() { name = "Lucinda", earSize = 33 };

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLloyd_Click(object sender, EventArgs e) => lloyd.WhoAmI();


        private void ButtonLucinda_Click(object sender, EventArgs e) => lucinda.WhoAmI();
    }
}
