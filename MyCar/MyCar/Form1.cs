using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        void Form1_Shown(object sender, EventArgs e)
        {
            CarService.Service1Client service = new CarService.Service1Client();
            var myCar = service.getMyCar();

            lblModel.Text = myCar.model;
            lblMake.Text = myCar.make;
            lblYear.Text = myCar.year;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
