using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNORTE_Click(object sender, EventArgs e)
        {
            if (cmbNORTE.SelectedIndex != -1)
            {
                cmbTODOS.Items.Add(cmbNORTE.SelectedItem);

                cmbNORTE.Items.RemoveAt(cmbNORTE.SelectedIndex);

                lblNORTE.Text = cmbNORTE.Items.Count.ToString();

                lblTODOS.Text = cmbTODOS.Items.Count.ToString();
            }
        }

        private void btnNORDESTE_Click(object sender, EventArgs e)
        {
            if (cmbNORTE.SelectedIndex != -1)
            {
                cmbTODOS.Items.Add(cmbNORDESTE.SelectedItem);

                cmbNORDESTE.Items.RemoveAt(cmbNORDESTE.SelectedIndex);

                lblNORDESTE.Text = cmbNORDESTE.Items.Count.ToString();

                lblTODOS.Text = cmbTODOS.Items.Count.ToString();
            }
        }

        private void btnCENTRO_Click(object sender, EventArgs e)
        {
            if (cmbNORTE.SelectedIndex != -1)
            {
                cmbTODOS.Items.Add(cmbCENTRO.SelectedItem);

                cmbCENTRO.Items.RemoveAt(cmbCENTRO.SelectedIndex);

                lblCENTRO.Text = cmbCENTRO.Items.Count.ToString();

                lblTODOS.Text = cmbTODOS.Items.Count.ToString();
            }
        }

        private void btnSUDESTE_Click(object sender, EventArgs e)
        {
            if (cmbNORTE.SelectedIndex != -1)
            {
                cmbTODOS.Items.Add(cmbSUDESTE.SelectedItem);

                cmbSUDESTE.Items.RemoveAt(cmbSUDESTE.SelectedIndex);

                lblSUDESTE.Text = cmbSUDESTE.Items.Count.ToString();

                lblTODOS.Text = cmbTODOS.Items.Count.ToString();
            }
        }

        private void btnSUL_Click(object sender, EventArgs e)
        {
            if (cmbNORTE.SelectedIndex != -1)
            {
                cmbTODOS.Items.Add(cmbSUL.SelectedItem);

                cmbSUL.Items.RemoveAt(cmbSUL.SelectedIndex);

                lblSUL.Text = cmbSUL.Items.Count.ToString();

                lblTODOS.Text = cmbTODOS.Items.Count.ToString();
            }
        }
    }
}
