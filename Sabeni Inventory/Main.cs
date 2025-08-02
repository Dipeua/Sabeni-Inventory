using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sabeni_Inventory
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Autorise uniquement les chiffres et la touche backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            ListViewItem new_item = new ListViewItem();
            int itemCount = listViewProduit.Items.Count + 1;
            if (String.IsNullOrEmpty(txtEMS.Text) || String.IsNullOrEmpty(txtQTES.Text) || String.IsNullOrEmpty(listProduit.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }
            else if (!Regex.IsMatch(txtEMS.Text, @"^\d{4}$") || txtEMS.Text == "0000")
            {
                MessageBox.Show("Le Numéro EMS est invalide. Il doit être composé de 4 chiffres et différent de 0000.",
                                "Erreur EMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!int.TryParse(txtQTES.Text, out int quantite) || quantite < 1 || quantite > 20)
            {
                MessageBox.Show("Quantité de produit invalide. Elle doit être comprise entre 1 et 20.",
                                "Erreur de quantité", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Add the product to the inventory
                string product = listProduit.Text;
                string ems = txtEMS.Text;
                string qtes = txtQTES.Text;


                // Here you would typically add the product to a database or a list
                new_item = new ListViewItem();
                new_item.Text = itemCount.ToString();
                new_item.SubItems.Add(product);
                new_item.SubItems.Add($"EMS00{ems}");
                new_item.SubItems.Add(qtes);
                listViewProduit.Items.Add(new_item);

                // Clear the input fields after adding
                txtEMS.Clear();
                txtQTES.Clear();
                listProduit.SelectedIndex = -1;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtEMS.KeyPress += txt_KeyPress;
            txtQTES.KeyPress += txt_KeyPress;
            listProduit.SelectedIndex = 1;
        }
    }
}
