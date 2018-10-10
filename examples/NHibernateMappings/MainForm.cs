using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace NHibernateMappings
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void schemaGenBtn_Click(object sender, EventArgs e)
        {
            Configuration cfg = new Configuration();
            cfg.Configure(); //tell NH to configure itself based on the config
            //cfg.AddAssembly(typeof(Person).Assembly); //find mapping info in this assembly

            new SchemaExport(cfg).Execute(true, true, false);

            MessageBox.Show("Schema exported successfully", "Job done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
