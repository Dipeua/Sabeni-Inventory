namespace Sabeni_Inventory
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listProduit = new System.Windows.Forms.ListBox();
            this.txtQTES = new System.Windows.Forms.TextBox();
            this.txtEMS = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.listViewProduit = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEXCEL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero EMS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantiter:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnADD);
            this.groupBox1.Controls.Add(this.listProduit);
            this.groupBox1.Controls.Add(this.txtQTES);
            this.groupBox1.Controls.Add(this.txtEMS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 347);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrer les informations des produits";
            // 
            // listProduit
            // 
            this.listProduit.FormattingEnabled = true;
            this.listProduit.ItemHeight = 19;
            this.listProduit.Items.AddRange(new object[] {
            "CARDIHIT",
            "ST HEART",
            "DIABETIC",
            "XENOPROST ACTIVE",
            "SLIMUX",
            "PROSTUROS"});
            this.listProduit.Location = new System.Drawing.Point(163, 78);
            this.listProduit.Name = "listProduit";
            this.listProduit.Size = new System.Drawing.Size(215, 137);
            this.listProduit.TabIndex = 5;
            // 
            // txtQTES
            // 
            this.txtQTES.Location = new System.Drawing.Point(163, 239);
            this.txtQTES.Name = "txtQTES";
            this.txtQTES.Size = new System.Drawing.Size(215, 23);
            this.txtQTES.TabIndex = 3;
            // 
            // txtEMS
            // 
            this.txtEMS.Location = new System.Drawing.Point(163, 36);
            this.txtEMS.Name = "txtEMS";
            this.txtEMS.Size = new System.Drawing.Size(215, 23);
            this.txtEMS.TabIndex = 3;
            // 
            // btnADD
            // 
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.Location = new System.Drawing.Point(163, 284);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(215, 29);
            this.btnADD.TabIndex = 6;
            this.btnADD.Text = "Ajouter";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // listViewProduit
            // 
            this.listViewProduit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewProduit.HideSelection = false;
            this.listViewProduit.Location = new System.Drawing.Point(445, 23);
            this.listViewProduit.Name = "listViewProduit";
            this.listViewProduit.Size = new System.Drawing.Size(446, 302);
            this.listViewProduit.TabIndex = 4;
            this.listViewProduit.UseCompatibleStateImageBehavior = false;
            this.listViewProduit.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NUMERO EMS";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PRODUITS";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "QTES";
            // 
            // btnEXCEL
            // 
            this.btnEXCEL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEXCEL.Location = new System.Drawing.Point(739, 331);
            this.btnEXCEL.Name = "btnEXCEL";
            this.btnEXCEL.Size = new System.Drawing.Size(152, 28);
            this.btnEXCEL.TabIndex = 5;
            this.btnEXCEL.Text = "Generer le fichier";
            this.btnEXCEL.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 372);
            this.Controls.Add(this.btnEXCEL);
            this.Controls.Add(this.listViewProduit);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Fira Code", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Sabeni Inventory";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQTES;
        private System.Windows.Forms.TextBox txtEMS;
        private System.Windows.Forms.ListBox listProduit;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.ListView listViewProduit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnEXCEL;
    }
}

