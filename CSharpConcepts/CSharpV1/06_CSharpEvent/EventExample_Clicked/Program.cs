using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExample_Clicked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NOTE: event source
            Form form = new Form();

            // NOTE: event response
            Controller controller = new Controller(form);
            form.ShowDialog();
        }
    }


    class Controller
    {
        private Form form;
        public Controller( Form form)
        {
            if (form != null)
            {
                this.form = form;

                // NOTE: event
                // NOTE: subscribe
                this.form.Click += this.FormClicked;
            }
        }

        // NOTE: event handler
        private void FormClicked(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
