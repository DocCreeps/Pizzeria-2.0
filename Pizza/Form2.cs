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
        private Form1 _form1;
        public CLIENT ClientEdit = new CLIENT();
        public Form2(Form1 form1)
        {
            InitializeComponent();
            
            _form1 = form1;
        }

        int numClient = VarGlobal.numEditClient;
        private void Form2_Load(object sender, EventArgs e)
        {
            
            int verif = VarGlobal.db.CLIENT.Where(VClient => VClient.N_Client == numClient).Select(VClient=>VClient.N_Client).FirstOrDefault();

            CLIENT Edit = VarGlobal.db.CLIENT.Find(verif);

            ClientName.Text = Edit.NomClient;
            ClientAdresse.Text = Edit.Adresse;
        }
        private void EditClient_Click(object sender, EventArgs e)
        {

            CLIENT Edit = VarGlobal.db.CLIENT.SingleOrDefault(VEdit=>VEdit.N_Client==numClient);
                
            if (Edit != null)
            {
                Edit.NomClient = ClientName.Text;
                Edit.Adresse = ClientAdresse.Text;
                VarGlobal.db.SaveChanges();
                _form1.loadDataClient();
                MessageBox.Show("Modification effectué avec succès");

                
                this.Close();

                
            }
            
        }

    }
}
