using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csi_analyzers
{
    class Utilities
    {

        public static void SetDoubleBuffering(Control.ControlCollection controlCollection, bool value)
        {
            foreach(Control control in controlCollection)
            {
                SetDoubleBuffering(control, value);
            }
        }


        private static void SetDoubleBuffering(Control control, bool value)
        {
            System.Reflection.PropertyInfo controlProperty = typeof(Control)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            controlProperty.SetValue(control, value, null);
        }
    }
}
