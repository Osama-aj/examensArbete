using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examensArbete
{
    public partial class WineTicket : UserControl
    {
        public WineTicket()
        {
            InitializeComponent();
        }

        private long _wineId;
        private string _wineName;
        private string _origin;
        private string _region;
        private string _district;
        private double _alcohol;
        private List<InventoryTicket> _bottlePanel;


        [Category("Custom Props")]
        public string WinePic
        {

            set
            {
                picWinePic.ImageLocation = value;
                picWinePic.SizeMode = PictureBoxSizeMode.CenterImage;
                picWinePic.SizeMode = PictureBoxSizeMode.StretchImage;


                //picWinePic.Size.Height=15;
                //  picWinePic.BorderStyle = BorderStyle.Fixed3D;
            }
        }




        [Category("Custom Props")]
        public List<InventoryTicket> Bottles
        {
            get { return _bottlePanel; }
            set { _bottlePanel = value; BottlesPanel.Controls.AddRange(value.ToArray()); }
        }


        [Category("Custom Props")]
        public long WineId
        {
            get { return _wineId; }
            set { _wineId = value; lblWineId.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public string WineName
        {
            get { return _wineName; }
            set { _wineName = value; lblWineName.Text = value; }
        }

        [Category("Custom Props")]
        public string Origin
        {
            get { return _origin; }
            set { _origin = value; lblOrigin.Text = value; }
        }






        [Category("Custom Props")]
        public double Alcohol
        {
            get { return _alcohol; }
            set { _alcohol = value; lblAlcohol.Text = value.ToString(); }
        }


    }
}
