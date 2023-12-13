using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Squirrel_Distributor.Customization
{
    public static class CustomFormConfiguration
    {
        public static void toDefaultForm(this Form form)
        {
            form.MaximumSize = new Size(form.Width, form.Height);
            form.MinimumSize = new Size(form.Width, form.Height);
        }
    }
}
