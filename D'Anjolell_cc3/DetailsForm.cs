using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Anjolell_cc3
{
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }

        private void medicationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._D_AnjolellMedicalDataSet);

        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_D_AnjolellMedicalDataSet.Medications' table. You can move, or remove it, as needed.
            this.medicationsTableAdapter.Fill(this._D_AnjolellMedicalDataSet.Medications);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
