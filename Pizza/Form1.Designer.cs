namespace Pizza
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pizzaDataSet = new Pizza.PizzaDataSet();
            this.cataloguePizzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cataloguePizzaTableAdapter = new Pizza.PizzaDataSetTableAdapters.CataloguePizzaTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ListePizza = new System.Windows.Forms.TabPage();
            this.DataPizza = new System.Windows.Forms.DataGridView();
            this.LabelComboPizza = new System.Windows.Forms.Label();
            this.ComboPizza = new System.Windows.Forms.ComboBox();
            this.AddPizza = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboDeletePizza = new System.Windows.Forms.ComboBox();
            this.DeletePizza = new System.Windows.Forms.Button();
            this.PrixPizza = new System.Windows.Forms.TextBox();
            this.TaillePizza = new System.Windows.Forms.TextBox();
            this.NamePizza = new System.Windows.Forms.TextBox();
            this.labelPrixPizza = new System.Windows.Forms.Label();
            this.labelTaillePizza = new System.Windows.Forms.Label();
            this.LabelNomPizza = new System.Windows.Forms.Label();
            this.AddPizzaSubmit = new System.Windows.Forms.Button();
            this.ListeCommandes = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelClient = new System.Windows.Forms.Label();
            this.DateCommande = new System.Windows.Forms.ComboBox();
            this.ComboClients = new System.Windows.Forms.ComboBox();
            this.DataCommande = new System.Windows.Forms.DataGridView();
            this.AddCommande = new System.Windows.Forms.TabPage();
            this.ListeClients = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddClient = new System.Windows.Forms.Button();
            this.DataClient = new System.Windows.Forms.DataGridView();
            this.NameClient = new System.Windows.Forms.TextBox();
            this.AdresseClient = new System.Windows.Forms.TextBox();
            this.EditClient = new System.Windows.Forms.Button();
            this.ComboDeleteClient = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cataloguePizzaBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.ListePizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPizza)).BeginInit();
            this.AddPizza.SuspendLayout();
            this.ListeCommandes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCommande)).BeginInit();
            this.ListeClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataClient)).BeginInit();
            this.SuspendLayout();
            // 
            // pizzaDataSet
            // 
            this.pizzaDataSet.DataSetName = "PizzaDataSet";
            this.pizzaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cataloguePizzaBindingSource
            // 
            this.cataloguePizzaBindingSource.DataMember = "CataloguePizza";
            this.cataloguePizzaBindingSource.DataSource = this.pizzaDataSet;
            // 
            // cataloguePizzaTableAdapter
            // 
            this.cataloguePizzaTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ListePizza);
            this.tabControl1.Controls.Add(this.AddPizza);
            this.tabControl1.Controls.Add(this.ListeCommandes);
            this.tabControl1.Controls.Add(this.AddCommande);
            this.tabControl1.Controls.Add(this.ListeClients);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1111, 627);
            this.tabControl1.TabIndex = 2;
            // 
            // ListePizza
            // 
            this.ListePizza.Controls.Add(this.DataPizza);
            this.ListePizza.Controls.Add(this.LabelComboPizza);
            this.ListePizza.Controls.Add(this.ComboPizza);
            this.ListePizza.Location = new System.Drawing.Point(4, 29);
            this.ListePizza.Name = "ListePizza";
            this.ListePizza.Padding = new System.Windows.Forms.Padding(3);
            this.ListePizza.Size = new System.Drawing.Size(1103, 594);
            this.ListePizza.TabIndex = 2;
            this.ListePizza.Text = "Liste Pizza";
            this.ListePizza.UseVisualStyleBackColor = true;
            // 
            // DataPizza
            // 
            this.DataPizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPizza.Location = new System.Drawing.Point(67, 264);
            this.DataPizza.Name = "DataPizza";
            this.DataPizza.RowHeadersWidth = 62;
            this.DataPizza.RowTemplate.Height = 28;
            this.DataPizza.Size = new System.Drawing.Size(756, 214);
            this.DataPizza.TabIndex = 2;
            // 
            // LabelComboPizza
            // 
            this.LabelComboPizza.AutoSize = true;
            this.LabelComboPizza.Location = new System.Drawing.Point(203, 175);
            this.LabelComboPizza.Name = "LabelComboPizza";
            this.LabelComboPizza.Size = new System.Drawing.Size(122, 20);
            this.LabelComboPizza.TabIndex = 1;
            this.LabelComboPizza.Text = "Liste des pizzas";
            // 
            // ComboPizza
            // 
            this.ComboPizza.FormattingEnabled = true;
            this.ComboPizza.Location = new System.Drawing.Point(363, 175);
            this.ComboPizza.Name = "ComboPizza";
            this.ComboPizza.Size = new System.Drawing.Size(306, 28);
            this.ComboPizza.TabIndex = 0;
            // 
            // AddPizza
            // 
            this.AddPizza.Controls.Add(this.label1);
            this.AddPizza.Controls.Add(this.ComboDeletePizza);
            this.AddPizza.Controls.Add(this.DeletePizza);
            this.AddPizza.Controls.Add(this.PrixPizza);
            this.AddPizza.Controls.Add(this.TaillePizza);
            this.AddPizza.Controls.Add(this.NamePizza);
            this.AddPizza.Controls.Add(this.labelPrixPizza);
            this.AddPizza.Controls.Add(this.labelTaillePizza);
            this.AddPizza.Controls.Add(this.LabelNomPizza);
            this.AddPizza.Controls.Add(this.AddPizzaSubmit);
            this.AddPizza.Location = new System.Drawing.Point(4, 29);
            this.AddPizza.Name = "AddPizza";
            this.AddPizza.Padding = new System.Windows.Forms.Padding(3);
            this.AddPizza.Size = new System.Drawing.Size(1103, 594);
            this.AddPizza.TabIndex = 1;
            this.AddPizza.Text = "Ajouter Pizza";
            this.AddPizza.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selectionnez la pizza a supprimer";
            // 
            // ComboDeletePizza
            // 
            this.ComboDeletePizza.FormattingEnabled = true;
            this.ComboDeletePizza.Location = new System.Drawing.Point(640, 375);
            this.ComboDeletePizza.Name = "ComboDeletePizza";
            this.ComboDeletePizza.Size = new System.Drawing.Size(279, 28);
            this.ComboDeletePizza.TabIndex = 8;
            // 
            // DeletePizza
            // 
            this.DeletePizza.Location = new System.Drawing.Point(640, 457);
            this.DeletePizza.Name = "DeletePizza";
            this.DeletePizza.Size = new System.Drawing.Size(224, 56);
            this.DeletePizza.TabIndex = 7;
            this.DeletePizza.Text = "Supprimer";
            this.DeletePizza.UseVisualStyleBackColor = true;
            this.DeletePizza.Click += new System.EventHandler(this.DeletePizza_Click);
            // 
            // PrixPizza
            // 
            this.PrixPizza.Location = new System.Drawing.Point(185, 275);
            this.PrixPizza.Name = "PrixPizza";
            this.PrixPizza.Size = new System.Drawing.Size(246, 26);
            this.PrixPizza.TabIndex = 6;
            // 
            // TaillePizza
            // 
            this.TaillePizza.Location = new System.Drawing.Point(185, 187);
            this.TaillePizza.Name = "TaillePizza";
            this.TaillePizza.Size = new System.Drawing.Size(246, 26);
            this.TaillePizza.TabIndex = 5;
            // 
            // NamePizza
            // 
            this.NamePizza.Location = new System.Drawing.Point(185, 65);
            this.NamePizza.Name = "NamePizza";
            this.NamePizza.Size = new System.Drawing.Size(246, 26);
            this.NamePizza.TabIndex = 4;
            // 
            // labelPrixPizza
            // 
            this.labelPrixPizza.AutoSize = true;
            this.labelPrixPizza.Location = new System.Drawing.Point(70, 281);
            this.labelPrixPizza.Name = "labelPrixPizza";
            this.labelPrixPizza.Size = new System.Drawing.Size(76, 20);
            this.labelPrixPizza.TabIndex = 3;
            this.labelPrixPizza.Text = "Prix Pizza";
            // 
            // labelTaillePizza
            // 
            this.labelTaillePizza.AutoSize = true;
            this.labelTaillePizza.Location = new System.Drawing.Point(70, 193);
            this.labelTaillePizza.Name = "labelTaillePizza";
            this.labelTaillePizza.Size = new System.Drawing.Size(87, 20);
            this.labelTaillePizza.TabIndex = 2;
            this.labelTaillePizza.Text = "Taille Pizza";
            // 
            // LabelNomPizza
            // 
            this.LabelNomPizza.AutoSize = true;
            this.LabelNomPizza.Location = new System.Drawing.Point(70, 65);
            this.LabelNomPizza.Name = "LabelNomPizza";
            this.LabelNomPizza.Size = new System.Drawing.Size(84, 20);
            this.LabelNomPizza.TabIndex = 1;
            this.LabelNomPizza.Text = "Nom Pizza";
            // 
            // AddPizzaSubmit
            // 
            this.AddPizzaSubmit.Location = new System.Drawing.Point(185, 457);
            this.AddPizzaSubmit.Name = "AddPizzaSubmit";
            this.AddPizzaSubmit.Size = new System.Drawing.Size(224, 56);
            this.AddPizzaSubmit.TabIndex = 0;
            this.AddPizzaSubmit.Text = "Ajouter";
            this.AddPizzaSubmit.UseVisualStyleBackColor = true;
            this.AddPizzaSubmit.Click += new System.EventHandler(this.AddPizzaSubmit_Click);
            // 
            // ListeCommandes
            // 
            this.ListeCommandes.Controls.Add(this.label3);
            this.ListeCommandes.Controls.Add(this.LabelClient);
            this.ListeCommandes.Controls.Add(this.DateCommande);
            this.ListeCommandes.Controls.Add(this.ComboClients);
            this.ListeCommandes.Controls.Add(this.DataCommande);
            this.ListeCommandes.Location = new System.Drawing.Point(4, 29);
            this.ListeCommandes.Name = "ListeCommandes";
            this.ListeCommandes.Padding = new System.Windows.Forms.Padding(3);
            this.ListeCommandes.Size = new System.Drawing.Size(1103, 594);
            this.ListeCommandes.TabIndex = 3;
            this.ListeCommandes.Text = "Liste Commandes";
            this.ListeCommandes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(809, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date commande passée avant : ";
            // 
            // LabelClient
            // 
            this.LabelClient.AutoSize = true;
            this.LabelClient.Location = new System.Drawing.Point(213, 45);
            this.LabelClient.Name = "LabelClient";
            this.LabelClient.Size = new System.Drawing.Size(57, 20);
            this.LabelClient.TabIndex = 3;
            this.LabelClient.Text = "Client :";
            // 
            // DateCommande
            // 
            this.DateCommande.FormattingEnabled = true;
            this.DateCommande.Location = new System.Drawing.Point(748, 94);
            this.DateCommande.Name = "DateCommande";
            this.DateCommande.Size = new System.Drawing.Size(299, 28);
            this.DateCommande.TabIndex = 2;
            // 
            // ComboClients
            // 
            this.ComboClients.FormattingEnabled = true;
            this.ComboClients.Location = new System.Drawing.Point(103, 94);
            this.ComboClients.Name = "ComboClients";
            this.ComboClients.Size = new System.Drawing.Size(348, 28);
            this.ComboClients.TabIndex = 1;
            // 
            // DataCommande
            // 
            this.DataCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCommande.Location = new System.Drawing.Point(128, 250);
            this.DataCommande.Name = "DataCommande";
            this.DataCommande.RowHeadersWidth = 62;
            this.DataCommande.RowTemplate.Height = 28;
            this.DataCommande.Size = new System.Drawing.Size(804, 205);
            this.DataCommande.TabIndex = 0;
            // 
            // AddCommande
            // 
            this.AddCommande.Location = new System.Drawing.Point(4, 29);
            this.AddCommande.Name = "AddCommande";
            this.AddCommande.Padding = new System.Windows.Forms.Padding(3);
            this.AddCommande.Size = new System.Drawing.Size(1103, 594);
            this.AddCommande.TabIndex = 4;
            this.AddCommande.Text = "Ajouter Commande";
            this.AddCommande.UseVisualStyleBackColor = true;
            // 
            // ListeClients
            // 
            this.ListeClients.Controls.Add(this.DeleteClient);
            this.ListeClients.Controls.Add(this.label6);
            this.ListeClients.Controls.Add(this.ComboDeleteClient);
            this.ListeClients.Controls.Add(this.EditClient);
            this.ListeClients.Controls.Add(this.AdresseClient);
            this.ListeClients.Controls.Add(this.NameClient);
            this.ListeClients.Controls.Add(this.label5);
            this.ListeClients.Controls.Add(this.label4);
            this.ListeClients.Controls.Add(this.label2);
            this.ListeClients.Controls.Add(this.AddClient);
            this.ListeClients.Controls.Add(this.DataClient);
            this.ListeClients.Location = new System.Drawing.Point(4, 29);
            this.ListeClients.Name = "ListeClients";
            this.ListeClients.Padding = new System.Windows.Forms.Padding(3);
            this.ListeClients.Size = new System.Drawing.Size(1103, 594);
            this.ListeClients.TabIndex = 5;
            this.ListeClients.Text = "Liste Clients";
            this.ListeClients.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresse: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liste des clients : ";
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(171, 166);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(118, 47);
            this.AddClient.TabIndex = 1;
            this.AddClient.Text = "Ajouter";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // DataClient
            // 
            this.DataClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataClient.Location = new System.Drawing.Point(171, 273);
            this.DataClient.Name = "DataClient";
            this.DataClient.RowHeadersWidth = 62;
            this.DataClient.RowTemplate.Height = 28;
            this.DataClient.Size = new System.Drawing.Size(705, 217);
            this.DataClient.TabIndex = 0;
            // 
            // NameClient
            // 
            this.NameClient.Location = new System.Drawing.Point(171, 38);
            this.NameClient.Name = "NameClient";
            this.NameClient.Size = new System.Drawing.Size(163, 26);
            this.NameClient.TabIndex = 5;
            // 
            // AdresseClient
            // 
            this.AdresseClient.Location = new System.Drawing.Point(171, 113);
            this.AdresseClient.Name = "AdresseClient";
            this.AdresseClient.Size = new System.Drawing.Size(163, 26);
            this.AdresseClient.TabIndex = 6;
            // 
            // EditClient
            // 
            this.EditClient.Location = new System.Drawing.Point(654, 113);
            this.EditClient.Name = "EditClient";
            this.EditClient.Size = new System.Drawing.Size(118, 47);
            this.EditClient.TabIndex = 7;
            this.EditClient.Text = "Modifier";
            this.EditClient.UseVisualStyleBackColor = true;
            this.EditClient.Click += new System.EventHandler(this.EditClient_Click);
            // 
            // ComboDeleteClient
            // 
            this.ComboDeleteClient.FormattingEnabled = true;
            this.ComboDeleteClient.Location = new System.Drawing.Point(654, 70);
            this.ComboDeleteClient.Name = "ComboDeleteClient";
            this.ComboDeleteClient.Size = new System.Drawing.Size(390, 28);
            this.ComboDeleteClient.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(808, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Liste des clients : ";
            // 
            // DeleteClient
            // 
            this.DeleteClient.Location = new System.Drawing.Point(868, 113);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(118, 47);
            this.DeleteClient.TabIndex = 10;
            this.DeleteClient.Text = "Supprimer";
            this.DeleteClient.UseVisualStyleBackColor = true;
            this.DeleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 639);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cataloguePizzaBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ListePizza.ResumeLayout(false);
            this.ListePizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPizza)).EndInit();
            this.AddPizza.ResumeLayout(false);
            this.AddPizza.PerformLayout();
            this.ListeCommandes.ResumeLayout(false);
            this.ListeCommandes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCommande)).EndInit();
            this.ListeClients.ResumeLayout(false);
            this.ListeClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PizzaDataSet pizzaDataSet;
        private System.Windows.Forms.BindingSource cataloguePizzaBindingSource;
        private PizzaDataSetTableAdapters.CataloguePizzaTableAdapter cataloguePizzaTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ListePizza;
        private System.Windows.Forms.TabPage AddPizza;
        private System.Windows.Forms.TextBox PrixPizza;
        private System.Windows.Forms.TextBox TaillePizza;
        private System.Windows.Forms.TextBox NamePizza;
        private System.Windows.Forms.Label labelPrixPizza;
        private System.Windows.Forms.Label labelTaillePizza;
        private System.Windows.Forms.Label LabelNomPizza;
        private System.Windows.Forms.Button AddPizzaSubmit;
        private System.Windows.Forms.ComboBox ComboPizza;
        private System.Windows.Forms.Label LabelComboPizza;
        private System.Windows.Forms.DataGridView DataPizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboDeletePizza;
        private System.Windows.Forms.Button DeletePizza;
        private System.Windows.Forms.TabPage ListeCommandes;
        private System.Windows.Forms.TabPage AddCommande;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelClient;
        private System.Windows.Forms.ComboBox DateCommande;
        private System.Windows.Forms.ComboBox ComboClients;
        private System.Windows.Forms.DataGridView DataCommande;
        private System.Windows.Forms.TabPage ListeClients;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.DataGridView DataClient;
        private System.Windows.Forms.Button EditClient;
        private System.Windows.Forms.TextBox AdresseClient;
        private System.Windows.Forms.TextBox NameClient;
        private System.Windows.Forms.Button DeleteClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboDeleteClient;
    }
}

