//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace examensArbete
//{
//    public partial class frmWaitForm : Form
//    {
//        public Action Worker { set; get; }
//        public frmWaitForm(Action woker)
//        {
//            InitializeComponent();
//            if (woker == null)
//                throw new ArgumentNullException();

//            Worker = woker;
//        }
//        protected override void OnLoad(EventArgs e)
//        {
//            base.OnLoad(e);
//            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
//        }
//    }
//}
