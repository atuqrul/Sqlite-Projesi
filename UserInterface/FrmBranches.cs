using Business;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmBranches : Form
    {
        StudentManager studentManager;
        public FrmBranches()
        {
            InitializeComponent();
            studentManager = StudentManager.GetInstance();
        }

        private void FrmBranches_Load(object sender, EventArgs e)
        {
            DtgBranches.DataSource = studentManager.GetBranchList();
        }
    }
}
