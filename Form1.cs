using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac_SAC_Task_3
{
    public partial class Form1 : Form
    {
        string filter;
        List<Sale> sales = new List<Sale>();
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            //OpenCSV();
            //bs.DataSource = sales;
            dgvTask3Shop.DataSource = bs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SortByRating(List<Sale> _sales)
        {
            int min;
            string temp;
            for (int i = 0; i < _sales.Count - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < _sales.Count; j++)
                {
                   if (int.TryParse(_sales[j].Rating, out int ratingJ))
                    {
                        if (int.TryParse(_sales[min].Rating, out int ratingMin))
                        {
                            if (ratingJ < ratingMin) min = j;
                        }
                        else
                        {
                            min = j;
                        }
                    }
                }
                temp = sales[min].Rating;
                _sales[min].Rating = _sales[i].Rating;
                _sales[i].Rating = temp;
            }

        }

        private void cmboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = comSubject.Text;
            if (filter == "Rating")
            {
                SortByRating(sales);
            }
            dgvTask3Shop.DataSource = bs;
            bs.ResetBindings(false);

        }
        private List<Sale> Search(string target, string filter)
        {
            List<Sale> results = new List<Sale>();
            foreach(Sale s in sales)
            {
                if (filter == "Rating")
                {
                    if (s.Rating.ToLower() == target.ToLower()) 
                    {
                        results.Add(s);
                    }
                    


                }
                if (filter == "Subject")
                {
                    if (s.Subject.ToLower().Contains(target.ToString().ToLower()))
                    {
                        results.Add(s); Console.WriteLine(target);
                    }
                   


                }
                if (filter == "Textbook")
                {
                    if (s.Textbook.ToLower().Contains(target.ToString().ToLower()))
                    {
                        results.Add(s); Console.WriteLine(target);
                    }
                    
                }
                
            }
            return results;
        }


        private void OpenCSV()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {


                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                    List<string> lines = new List<string>();
                    lines = File.ReadAllLines(filePath).ToList();
                    foreach (string line in lines)
                    {
                        List<string> items = line.Split(',').ToList();
                        Sale sale = new Sale();
                        sale.Textbook = items[0];
                        sale.Subject = items[1];
                        sale.Seller = items[2];
                        sale.Buyer = items[3];
                        sale.purchasedPrice = float.Parse(items[4]);
                        sale.SalePrice = items[5];
                        sale.Rating = items[6];
                        sales.Add(sale);
                    }
                    bs.DataSource = sales;
                    bs.ResetBindings(false);
                }
                else if (ofd.ShowDialog() == DialogResult.Cancel)
                {
                    MessageBox.Show("No File Was Selected");
                }
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("File Cannot Be Opened");
            }
            catch
            {
                MessageBox.Show("Not a Valid File");
            }
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenCSV();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Sale> r = Search(txtSearch.Text, filter);
            bs.DataSource = r;
            dgvTask3Shop.DataSource = r;
            bs.ResetBindings(false);
        }
    }
}
