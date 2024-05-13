using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car
{
    public partial class Form1 : Form
    {
        ICarRepository repository;
        public Form1()
        {
            InitializeComponent();
            repository = new CarRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
