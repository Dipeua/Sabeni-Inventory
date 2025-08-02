using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel; // Assurez-vous d'avoir installé ClosedXML via NuGet

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
                MessageBox.Show("Veuillez remplir tous les champs.","Erreur detecter.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("La quantité de produit invalide. Elle doit être comprise entre 1 et 20.",
                                "Erreur de quantité", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Add the product to the inventory
                string product = listProduit.Text;
                string ems = $"EMS00{txtEMS.Text}";
                string qtes = txtQTES.Text;


                // Here you would typically add the product to a database or a list
                new_item = new ListViewItem();
                new_item.Text = itemCount.ToString();
                new_item.SubItems.Add(product);
                new_item.SubItems.Add(ems);
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

        //private void GenerateExcelFile()
        //{
        //    using (var workbook = new XLWorkbook())
        //    {
        //        var worksheet = workbook.Worksheets.Add("ETAT DES PRODUITS");

        //        // Titre fusionné et centré
        //        worksheet.Range("A1:D1").Merge();
        //        worksheet.Cell("A1").Value = "ETAT DES RETOURS PAR EMS";
        //        worksheet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
        //        worksheet.Cell("A1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
        //        worksheet.Cell("A1").Style.Font.Bold = true;
        //        worksheet.Cell("A1").Style.Font.FontSize = 14;

        //        // En-têtes
        //        worksheet.Cell("A2").Value = "N'ORDRE";
        //        worksheet.Cell("B2").Value = "NUMERO EMS";
        //        worksheet.Cell("C2").Value = "PRODUITS";
        //        worksheet.Cell("D2").Value = "QTES";

        //        // Données
        //        worksheet.Cell("A3").Value = 1;
        //        worksheet.Cell("B3").Value = "EMS006092";
        //        worksheet.Cell("C3").Value = "CARDIHIT";
        //        worksheet.Cell("D3").Value = 3;

        //        // Bordures tableau (de A2 à D3)
        //        var tableRange = worksheet.Range("A2:D3");
        //        tableRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
        //        tableRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

        //        // Sauvegarder
        //        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "test.xlsx");
        //        workbook.SaveAs(filePath);

        //        MessageBox.Show("Fichier enregistré sur le Bureau :\n" + filePath, "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void GenerateExcelFile()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("ETAT DES PRODUITS");

                // Titre fusionné et centré
                worksheet.Range("A1:D1").Merge();
                worksheet.Cell("A1").Value = "ETAT DES RETOURS PAR EMS";
                worksheet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                worksheet.Cell("A1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                worksheet.Cell("A1").Style.Font.Bold = true;
                worksheet.Cell("A1").Style.Font.FontSize = 14;

                // En-têtes
                worksheet.Cell("A2").Value = "N'ORDRE";
                worksheet.Cell("B2").Value = "NUMERO EMS";
                worksheet.Cell("C2").Value = "PRODUITS";
                worksheet.Cell("D2").Value = "QTES";
                worksheet.Range("A2:D2").Style.Font.Bold = true;

                // Données à partir de la ligne 3
                int startRow = 3;
                foreach (ListViewItem item in listViewProduit.Items)
                {
                    worksheet.Cell(startRow, 1).Value = item.Text;                          // N° Ordre (col A)
                    worksheet.Cell(startRow, 2).Value = item.SubItems[2].Text;             // Numéro EMS (col B)
                    worksheet.Cell(startRow, 3).Value = item.SubItems[1].Text;             // Produits (col C)
                    worksheet.Cell(startRow, 4).Value = item.SubItems[3].Text;             // QTES (col D)

                    startRow++; // passer à la ligne suivante
                }

                // Déterminer la dernière ligne utilisée pour encadrer le tableau
                int lastRow = startRow - 1;
                var tableRange = worksheet.Range($"A2:D{lastRow}");
                tableRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                tableRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                // Ajuster automatiquement la largeur des colonnes
                worksheet.Columns("A:D").AdjustToContents();

                // Sauvegarder sur le bureau
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ETAT_RETROU_EMS.xlsx");
                workbook.SaveAs(filePath);

                MessageBox.Show("Fichier enregistré sur le Bureau :\n" + filePath, "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            // Demande de confirmation à l'utilisateur
            var ask = MessageBox.Show(
                "Avez-vous terminé la saisie de toutes les informations ?",
                "Téléchargement du fichier Excel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ask == DialogResult.Yes)
            {
                // 👉 À remplacer par ta logique de génération de fichier Excel (si pas encore faite)
                // Exemple fictif : GenerateExcelFile();
                GenerateExcelFile();
                MessageBox.Show(
                    "Votre fichier Excel a été généré et est disponible sur votre disque.",
                    "Téléchargement terminé",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
