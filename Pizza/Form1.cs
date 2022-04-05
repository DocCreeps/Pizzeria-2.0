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
        public CLIENT NouvClient = new CLIENT();
        public Form1()
        {
            InitializeComponent();
        }
      
        public void loadDataPizza()
        {
            DataPizza.DataSource = db.CataloguePizza.ToList(); 

            List<CataloguePizza> ListC = new List<CataloguePizza>();
            ListC.AddRange(db.CataloguePizza.ToList());
            ComboPizza.ValueMember = "N_Pizza";
            ComboPizza.DisplayMember = "NomPizza";
            ComboPizza.DataSource = ListC;

            ComboDeletePizza.ValueMember = "N_Pizza";
            ComboDeletePizza.DisplayMember = "NomPizza";
            ComboDeletePizza.DataSource = ListC;
        }
        public void loadDataClient()
        {
            DataClient.DataSource = db.CLIENT.ToList();

            List<CLIENT> ListClient = new List<CLIENT>();
            ListClient.AddRange(db.CLIENT.ToList());
            ComboDeleteClient.ValueMember = "N_Client";
            ComboDeleteClient.DisplayMember = "NomClient";
            ComboDeleteClient.DataSource = ListClient;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pizzaDataSet.CataloguePizza'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cataloguePizzaTableAdapter.Fill(this.pizzaDataSet.CataloguePizza);


            loadDataPizza();
            loadDataClient();

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

        private void AddClient_Click(object sender, EventArgs e)
        {
            NouvClient.NomClient = NameClient.Text;
            int verif = db.CLIENT.Where(VClient => VClient.NomClient == NouvClient.NomClient).Count();


            if (verif == 0)
            {
                NouvClient.Adresse = AdresseClient.Text;
                db.CLIENT.Add(NouvClient);
                db.SaveChanges();
                MessageBox.Show("Ajout effectué avec succès");
                loadDataClient();
            }
            else
            {
                MessageBox.Show("Ce client existe déjà");
            }
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            String numClients = ComboDeleteClient.SelectedValue.ToString();
            int Index = Convert.ToInt32(numClients);

            var result = db.CLIENT.SingleOrDefault(client => client.N_Client == Index);

            if (result != null)
            {

                db.CLIENT.Remove(result);
                db.SaveChanges();
                MessageBox.Show("Ce client a été supprimé ");
                loadDataClient();
            }
            else
            {
                MessageBox.Show("Ce client n'existe pas ");

            }
        }

        private void EditClient_Click(object sender, EventArgs e)
        {
            String numClients = ComboDeleteClient.SelectedValue.ToString();
            VarGlobal.numEditClient = Convert.ToInt32(numClients);

            Form2 form2 = new Form2();
            form2.ShowDialog();
            
        }
    }
}
