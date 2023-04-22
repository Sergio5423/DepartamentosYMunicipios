using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class DepartamentosYMunicipios : Form
    {
        public DepartamentosYMunicipios()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text == string.Empty)
            {
                
            } else
            {
                if (rbDepartamento.Checked)
                {
                    lstDepartamentos.Items.Add(txtValor.Text);
                }
                else
                {
                    lstMunicipios.Items.Add(txtValor.Text);
                }
                txtValor.Clear();
                txtValor.Focus();
            }            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var item = lstDepartamentos.SelectedItem;
            var item2 = lstMunicipios.SelectedItem;
            lstDepartamentos.Items.Remove(item);
            lstMunicipios.Items.Remove(item2);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (rbDepartamento.Checked)
            {
                lstDepartamentos.Items.Clear();
            } else
            {
                lstMunicipios.Items.Clear();
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.
        }
    }
}
