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
    public partial class Form2 : Form
    {
        PizzaEntities db = new PizzaEntities();
        public CLIENT ClientEdit = new CLIENT();
        public Form2()
        {
            InitializeComponent();
        }

        int numClient = VarGlobal.numEditClient;
        private void Form2_Load(object sender, EventArgs e)
        {
            
            int verif = db.CLIENT.Where(VClient => VClient.N_Client == numClient).Select(VClient=>VClient.N_Client).FirstOrDefault();

            CLIENT Edit =  db.CLIENT.Find(verif);

            ClientName.Text = Edit.NomClient;
            ClientAdresse.Text = Edit.Adresse;
        }
        private void EditClient_Click(object sender, EventArgs e)
        {

            CLIENT Edit = db.CLIENT.SingleOrDefault(VEdit=>VEdit.N_Client==numClient);
                
            if (Edit != null)
            {
                Edit.NomClient = ClientName.Text;
                Edit.Adresse = ClientAdresse.Text;
                db.SaveChanges();
                MessageBox.Show("Modification effectué avec succès");
            }
            else
            {
                MessageBox.Show("Ce client existe déjà");
            }
        }

    }
}
