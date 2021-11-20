using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farid_Betamart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    betamartBindingSource.RemoveCurrent();
            }
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtProductName.Focus();
                this.appData.betamart.AddbetamartRow(this.appData.betamart.NewbetamartRow());
                betamartBindingSource.MoveLast();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                betamartBindingSource.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtProductName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            betamartBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                betamartBindingSource.EndEdit();
                betamartTableAdapter.Update(this.appData.betamart);
                panel.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                betamartBindingSource.ResetBindings(false);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.betamart' table. You can move, or remove it, as needed.
            this.betamartTableAdapter.Fill(this.appData.betamart);
            betamartBindingSource.DataSource = this.appData.betamart;
        }
    }
}
