using System;
using System.Windows.Forms;

namespace Elephants
{
    internal class Elephant
    {
        public String name;
        public int earSize;

        public void WhoAmI()
        {
            MessageBox.Show("My Ears are " + earSize + " inches tall", name + " says...");
        }
    }
}