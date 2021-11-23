using Facture.BLL;
using MC1.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture
{
    public partial class AddUserProduct : Form
    {
        int order = 1;
        double total = 0;
        List<Facture> fac;
        
        public AddUserProduct()
        {
            InitializeComponent();
            fac = new List<Facture>();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            
            
            if(!string.IsNullOrEmpty(txt_Name.Text) && !string.IsNullOrEmpty(txt_Price.Text))
            {
                Facture obj = new Facture() { Id = order++, Name = txt_Name.Text, Price = Convert.ToDouble(txt_Price.Text), Qte = Convert.ToDouble(txt_Qte.Text), Reference = txt_Reference.Text, Tel = txt_Tel.Text, Name_Client = txt_Fullname.Text };
                total += obj.Price * obj.Qte;
                txt_Name.Text = string.Empty;
                txt_Price.Text = string.Empty;
                txt_Total.Text = string.Format("{0}$", total);
                fac.Add(obj);
            }
            MessageBox.Show("produit enregistrer");

            Load();

        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            using(AddUserProduct frm = new AddUserProduct(/*factureBindingSource.DataSource as List<Facture>, string.Format("{0}", total), string.Format("{0:00:00}$", DateTime.Now.ToString("MM/dd/yyyy")*/))
            {
                frm.ShowDialog();
            }
        }

        private void btn_Gener_Click(object sender, EventArgs e)
        {
            FrmPreview _preview;
            _preview = new FrmPreview(fac);
            _preview.Show();

        }
        private void Load()
        {
            listView1.Items.Clear();
            foreach(var f in fac)
            {
                var item = new ListViewItem(new String[] { f.Reference, f.Name, f.Price.ToString(), f.Qte.ToString() });
                listView1.Items.Add(item);
            }
        }
    }
}
