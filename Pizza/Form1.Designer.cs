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
            this.LabelComboPizza = new System.Windows.Forms.Label();
            this.ComboPizza = new System.Windows.Forms.ComboBox();
            this.AddPizza = new System.Windows.Forms.TabPage();
            this.PrixPizza = new System.Windows.Forms.TextBox();
            this.TaillePizza = new System.Windows.Forms.TextBox();
            this.NamePizza = new System.Windows.Forms.TextBox();
            this.labelPrixPizza = new System.Windows.Forms.Label();
            this.labelTaillePizza = new System.Windows.Forms.Label();
            this.LabelNomPizza = new System.Windows.Forms.Label();
            this.AddPizzaSubmit = new System.Windows.Forms.Button();
            this.DataPizza = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cataloguePizzaBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.ListePizza.SuspendLayout();
            this.AddPizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPizza)).BeginInit();
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
            this.AddPizzaSubmit.Location = new System.Drawing.Point(429, 498);
            this.AddPizzaSubmit.Name = "AddPizzaSubmit";
            this.AddPizzaSubmit.Size = new System.Drawing.Size(224, 56);
            this.AddPizzaSubmit.TabIndex = 0;
            this.AddPizzaSubmit.Text = "Ajouter";
            this.AddPizzaSubmit.UseVisualStyleBackColor = true;
            this.AddPizzaSubmit.Click += new System.EventHandler(this.AddPizzaSubmit_Click);
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
            this.AddPizza.ResumeLayout(false);
            this.AddPizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPizza)).EndInit();
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
    }
}

