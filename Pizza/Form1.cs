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
        
       


        public CataloguePizza NouvPizza = new CataloguePizza();
        public CLIENT NouvClient = new CLIENT();
        public Form1()
        {
            VarGlobal.db = new PizzaEntities();
            InitializeComponent();
        }
      
        public void loadDataPizza()
        {
            DataPizza.DataSource = VarGlobal.db.CataloguePizza.ToList(); 

            List<CataloguePizza> ListC = new List<CataloguePizza>();
            ListC.AddRange(VarGlobal.db.CataloguePizza.ToList());
            ComboPizza.ValueMember = "N_Pizza";
            ComboPizza.DisplayMember = "NomPizza";
            ComboPizza.DataSource = ListC;

            ComboDeletePizza.ValueMember = "N_Pizza";
            ComboDeletePizza.DisplayMember = "NomPizza";
            ComboDeletePizza.DataSource = ListC;
        }
        public void loadDataClient()
        {
            DataClient.DataSource = VarGlobal.db.CLIENT.ToList();

            List<CLIENT> ListClient = new List<CLIENT>();
            ListClient.AddRange(VarGlobal.db.CLIENT.ToList());
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
            
            int verif = VarGlobal.db.CataloguePizza.Where(vPizza => vPizza.NomPizza == NouvPizza.NomPizza).Count();
            

            if (verif == 0)
            {
                NouvPizza.TaillePizza = Int32.Parse(TaillePizza.Text);
                double prix = Convert.ToDouble(PrixPizza.Text);
                NouvPizza.PrixPizza = (decimal)prix;
                VarGlobal.db.CataloguePizza.Add(NouvPizza);
                VarGlobal.db.SaveChanges();
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

            var result = VarGlobal.db.CataloguePizza.SingleOrDefault(cl => cl.N_Pizza == Index);

            if (result != null)
            {

                VarGlobal.db.CataloguePizza.Remove(result);
                VarGlobal.db.SaveChanges();
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
            int verif = VarGlobal.db.CLIENT.Where(VClient => VClient.NomClient == NouvClient.NomClient).Count();


            if (verif == 0)
            {
                NouvClient.Adresse = AdresseClient.Text;
                VarGlobal.db.CLIENT.Add(NouvClient);
                VarGlobal.db.SaveChanges();
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

            var result = VarGlobal.db.CLIENT.SingleOrDefault(client => client.N_Client == Index);

            if (result != null)
            {

                VarGlobal.db.CLIENT.Remove(result);
                VarGlobal.db.SaveChanges();
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

            Form2 form2 = new Form2(this);
            form2.Show();
           
            
        }
    }
}
