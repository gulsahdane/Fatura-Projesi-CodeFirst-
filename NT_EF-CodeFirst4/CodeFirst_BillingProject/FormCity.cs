using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_BillingProject
{
    
    public partial class FormCity : Form
    {
        int selectedID;
        BillingContext ctx = new BillingContext();
        public FormCity()
        {
            InitializeComponent();
        }

        private void FormCity_Load(object sender, EventArgs e)
        {
            FillCity();
        }

        private void FillCity()
        {
           

            var clist = ctx.Cities.ToList();
            dataGVCity.DataSource = clist;
            
        }

        private void btnCityAdd_Click(object sender, EventArgs e)
        {
            

            City city = new City();

            city.Description = txtBoxCity.Text;

            ctx.Cities.Add(city);

            ctx.SaveChanges();

            FillCity();
            
        }

        private void btnCityUpdate_Click(object sender, EventArgs e)
        {
           

            City city = ctx.Cities.Find(selectedID);

            city.Description = txtBoxCity.Text;

           

            ctx.SaveChanges();

            FillCity();

        }

        private void dataGVCity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedID = Convert.ToInt32(dataGVCity.CurrentRow.Cells[0].Value);

           
        }

        private void btnCityDelete_Click(object sender, EventArgs e)
        {
           

            City city = ctx.Cities.Find(selectedID);

            ctx.Cities.Remove(city);

            ctx.SaveChanges();

            FillCity();
        }
    }
}
