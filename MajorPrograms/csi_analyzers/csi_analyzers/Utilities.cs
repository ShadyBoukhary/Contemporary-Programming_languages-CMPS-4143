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
        private static readonly Random rand = new Random(DateTime.Now.Millisecond);

        public static void SetDoubleBuffering(Control.ControlCollection controlCollection, bool value)
        {
            foreach(Control control in controlCollection)
            {
                SetDoubleBuffering(control, value);
            }
        }

        public static OpenFileDialog GetTextFileDialog()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt"; 
            dialog.Multiselect = false;
            return dialog;
        }

        /// <summary>
        /// Gets a random integer
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int GetRandomInt(int min, int max)
        {
            return rand.Next(min, max);
        }


        private static void SetDoubleBuffering(Control control, bool value)
        {
            System.Reflection.PropertyInfo controlProperty = typeof(Control)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            controlProperty.SetValue(control, value, null);
        }
    }
}
