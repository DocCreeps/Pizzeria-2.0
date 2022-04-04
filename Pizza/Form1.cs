using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pizza
{
    
    public partial class Form1 : Form
    {
        PizzaEntities db = new PizzaEntities();

        public CataloguePizza NouvPizza = new CataloguePizza();
        public Form1()
        {
            InitializeComponent();
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pizzaDataSet.CataloguePizza'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cataloguePizzaTableAdapter.Fill(this.pizzaDataSet.CataloguePizza);

            DataPizza.DataSource = db.CataloguePizza.ToList();

            List<CataloguePizza> ListC = new List<CataloguePizza>();
            ListC.AddRange(db.CataloguePizza.ToList());
            ComboPizza.ValueMember = "N_Pizza";
            ComboPizza.DisplayMember = "NomPizza";
            ComboPizza.DataSource = ListC;

        }

        private void AddPizzaSubmit_Click(object sender, EventArgs e)
        {
            NouvPizza.NomPizza = NamePizza.Text;
            NouvPizza.TaillePizza = Int32.Parse(TaillePizza.Text);
            double prix = Convert.ToDouble(PrixPizza.Text);
            NouvPizza.PrixPizza = (decimal)prix;
            int verif = db.CataloguePizza.Where(vPizza => vPizza.NomPizza == NouvPizza.NomPizza).Count();
            

            if (verif == 0)
            {
               
                db.CataloguePizza.Add(NouvPizza);
                db.SaveChanges();
                MessageBox.Show("Ajout effectué avec succès");
            }
            else
            {
                MessageBox.Show("Cette Pizza existe déjà");
            }
        }

        
    }
}
