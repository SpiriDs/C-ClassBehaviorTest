using System;
using System.Windows.Forms;

namespace Elephants
{
    class Elephant
    {
        public String name;
        public int earSize;

        public void WhoAmI()
        {
            MessageBox.Show("My Ears are " + earSize + " inches tall", name + " says...");
        }
    }
}
