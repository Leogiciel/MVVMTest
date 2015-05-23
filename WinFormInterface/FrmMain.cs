using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels;

namespace WinFormInterface
{
    public partial class FrmMain : Form
    {
        private ViewModel _ViewModel { get; set; }

        public FrmMain()
        {
            InitializeComponent();
            //Instanciate model
            _ViewModel = new ViewModel();
            //Bind datasource
            var binding = new Binding("Text", _ViewModel, "Name");
            this.textBox1.DataBindings.Add(binding);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _ViewModel.Validate();
            }
            catch (Exception ex)
            {
                //High-level exception handling
                MessageBox.Show(ex.Message, "Exception");
            }
        }
    }
}
