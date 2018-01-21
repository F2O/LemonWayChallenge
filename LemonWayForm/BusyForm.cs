using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemonWayForm
{
    public partial class BusyForm : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public BusyForm()
        {
            InitializeComponent();
            ControlBox = false;
        }

        /// <summary>
        /// Starts the busyform.
        /// </summary>
        public void Start()
        {
            Task.Run(() =>
            {
                this.ShowDialog();
            });
        }

        /// <summary>
        /// Stops and closes the busyform.
        /// </summary>
        public void Stop()
        {
            BeginInvoke((Action)delegate { Close(); });
        }
    }
}
