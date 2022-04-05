using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
      
        public void loadDataPizza()
        {
            List<CataloguePizza> ListC = new List<CataloguePizza>();
            ListC.AddRange(db.CataloguePizza.ToList());
            ComboPizza.ValueMember = "N_Pizza";
            ComboPizza.DisplayMember = "NomPizza";
            ComboPizza.DataSource = ListC;

            ComboDeletePizza.ValueMember = "N_Pizza";
            ComboDeletePizza.DisplayMember = "NomPizza";
            ComboDeletePizza.DataSource = ListC;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pizzaDataSet.CataloguePizza'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cataloguePizzaTableAdapter.Fill(this.pizzaDataSet.CataloguePizza);

            DataPizza.DataSource = db.CataloguePizza.ToList();


            loadDataPizza();

        }
       
        private void AddPizzaSubmit_Click(object sender, EventArgs e)
        {
            NouvPizza.NomPizza = NamePizza.Text;
            
            int verif = db.CataloguePizza.Where(vPizza => vPizza.NomPizza == NouvPizza.NomPizza).Count();
            

            if (verif == 0)
            {
                NouvPizza.TaillePizza = Int32.Parse(TaillePizza.Text);
                double prix = Convert.ToDouble(PrixPizza.Text);
                NouvPizza.PrixPizza = (decimal)prix;
                db.CataloguePizza.Add(NouvPizza);
                db.SaveChanges();
                MessageBox.Show("Ajout effectué avec succès");
                loadDataPizza();
            }
            else
            {
                MessageBox.Show("Cette Pizza existe déjà");
            }
        }

        private void DeletePizza_Click(object sender, EventArgs e)
        {
            String numpizz = ComboDeletePizza.SelectedValue.ToString();
            int Index = Convert.ToInt32(numpizz);

            var result = db.CataloguePizza.SingleOrDefault(cl => cl.N_Pizza == Index);

            if (result != null)
            {

                db.CataloguePizza.Remove(result);
                db.SaveChanges();
                MessageBox.Show("Cette pizza a été supprimé ");
                loadDataPizza();
            }
            else
            {
                MessageBox.Show("Cette pizza n'existe pas ");

            }
        }
    }
}
