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
            if (cmbNORDESTE.SelectedIndex != -1)
            {
                cmbTODOS.Items.Add(cmbNORDESTE.SelectedItem);

                cmbNORDESTE.Items.RemoveAt(cmbNORDESTE.SelectedIndex);

                lblNORDESTE.Text = cmbNORDESTE.Items.Count.ToString();

                lblTODOS.Text = cmbTODOS.Items.Count.ToString();

            }
        }

        private void btnCENTRO_Click(object sender, EventArgs e)
        {
            if (cmbCENTRO.SelectedIndex != -1)
            {
                cmbTODOS.Items.Add(cmbCENTRO.SelectedItem);

                cmbCENTRO.Items.RemoveAt(cmbCENTRO.SelectedIndex);

                lblCENTRO.Text = cmbCENTRO.Items.Count.ToString();

                lblTODOS.Text = cmbTODOS.Items.Count.ToString();
            }
        }

        private void btnSUDESTE_Click(object sender, EventArgs e)
        {
            if (cmbSUDESTE.SelectedIndex != -1)
            {
                cmbTODOS.Items.Add(cmbSUDESTE.SelectedItem);

                cmbSUDESTE.Items.RemoveAt(cmbSUDESTE.SelectedIndex);

                lblSUDESTE.Text = cmbSUDESTE.Items.Count.ToString();

                lblTODOS.Text = cmbTODOS.Items.Count.ToString();
            }
        }

        private void btnSUL_Click(object sender, EventArgs e)
        {
            if (cmbSUL.SelectedIndex != -1)
            {
                cmbTODOS.Items.Add(cmbSUL.SelectedItem);

                cmbSUL.Items.RemoveAt(cmbSUL.SelectedIndex);

                lblSUL.Text = cmbSUL.Items.Count.ToString();

                lblTODOS.Text = cmbTODOS.Items.Count.ToString();
            }
        }

        private void btnTODOS_Click(object sender, EventArgs e)
        {
            if (cmbTODOS.SelectedIndex != -1)
            {
                if (cmbTODOS.SelectedItem == "RS" || cmbTODOS.SelectedItem == "SC" || cmbTODOS.SelectedItem == "PR")
                {
                    cmbSUL.Items.Add(cmbTODOS.SelectedItem);

                    cmbTODOS.Items.RemoveAt(cmbTODOS.SelectedIndex);

                    lblSUL.Text = cmbSUL.Items.Count.ToString();

                    lblTODOS.Text = cmbTODOS.Items.Count.ToString();
                }
                else if (cmbTODOS.SelectedItem == "SP" || cmbTODOS.SelectedItem == "RJ" || cmbTODOS.SelectedItem == "MG" || cmbTODOS.SelectedItem == "ES")
                {
                    cmbSUDESTE.Items.Add(cmbTODOS.SelectedItem);

                    cmbTODOS.Items.RemoveAt(cmbTODOS.SelectedIndex);

                    lblSUDESTE.Text = cmbSUDESTE.Items.Count.ToString();

                    lblTODOS.Text = cmbTODOS.Items.Count.ToString();
                }
                else if (cmbTODOS.SelectedItem == "DF" || cmbTODOS.SelectedItem == "MT" || cmbTODOS.SelectedItem == "MS" || cmbTODOS.SelectedItem == "GO")
                {
                    cmbCENTRO.Items.Add(cmbTODOS.SelectedItem);

                    cmbTODOS.Items.RemoveAt(cmbTODOS.SelectedIndex);

                    lblCENTRO.Text = cmbCENTRO.Items.Count.ToString();

                    lblTODOS.Text = cmbTODOS.Items.Count.ToString();
                }
                else if (cmbTODOS.SelectedItem == "SP" || cmbTODOS.SelectedItem == "RJ" || cmbTODOS.SelectedItem == "MG" || cmbTODOS.SelectedItem == "ES")
                {
                    cmbSUDESTE.Items.Add(cmbTODOS.SelectedItem);

                    cmbTODOS.Items.RemoveAt(cmbTODOS.SelectedIndex);

                    lblSUDESTE.Text = cmbSUDESTE.Items.Count.ToString();

                    lblTODOS.Text = cmbTODOS.Items.Count.ToString();
                }
                else if (cmbTODOS.SelectedItem == "AM" || cmbTODOS.SelectedItem == "PA" || cmbTODOS.SelectedItem == "TO" || cmbTODOS.SelectedItem == "RR" || cmbTODOS.SelectedItem == "RO" || cmbTODOS.SelectedItem == "AP" || cmbTODOS.SelectedItem == "AC")
                {
                    cmbNORTE.Items.Add(cmbTODOS.SelectedItem);

                    cmbTODOS.Items.RemoveAt(cmbTODOS.SelectedIndex);

                    lblNORTE.Text = cmbNORTE.Items.Count.ToString();

                    lblTODOS.Text = cmbTODOS.Items.Count.ToString();
                }
                else
                {
                    cmbNORDESTE.Items.Add(cmbTODOS.SelectedItem);

                    cmbTODOS.Items.RemoveAt(cmbTODOS.SelectedIndex);

                    lblNORDESTE.Text = cmbNORDESTE.Items.Count.ToString();

                    lblTODOS.Text = cmbTODOS.Items.Count.ToString();
                }
            }
        }
    }
}
