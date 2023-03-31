using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W5_Benito
{
    public partial class Form1 : Form
    {
        List<string> benito = new List<string>();
        List<products> productslist = new List<products>();

        public Form1()
        {
            InitializeComponent();
        }
        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();

        int counter = 1;
        
        public class products
        {
            public string productname { get; set; } 
            public string harga { get; set; }   
            public string stock { get; set; }
            public string category { get; set; }
            public string categoryid { get; set; }
            public string productid { get; set; }

            public products (string productname,string harga, string stock, string category)
            {
                this.productname = productname; 
                this.harga = harga;
                this.stock = stock;
                this.category = category;
            }

        
        }
        List<products> produk = new List<products>();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Product");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");
            dataGridView1.DataSource = dtProdukSimpan;  
          
            
            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");
            dataGridView1.DataSource = dtProdukSimpan;

            
            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");
            dataGridView2.DataSource = dtCategory;

            productslist.Add(new products("Jas Hitam", "100000", "10", "Jas"));
            productslist.Add(new products("T-Shirt Black Pink", "70000", "20", "T-Shirt"));
            productslist.Add(new products("T-Shirt Obsessive", "75000", "16", "T-Shirt"));
            productslist.Add(new products("Rok Mini", "82000", "26", "Rok"));
            productslist.Add(new products("Jeans Biru", "90000", "5", "Celana"));
            productslist.Add(new products("Celana Pendek Coklat", "60000", "14", "Celana"));
            productslist.Add(new products("Cawat Blink-Blink", "100000", "1", "Cawat"));
            productslist.Add(new products("Rocca Shirt", "50000", "8", "T-Shirt"));

            foreach (products produk in productslist)
            {
                if (!benito.Contains(produk.category))
                {
                    benito.Add(produk.category);
                    comboBox1.Items.Add(produk.category);
                    comboBox2.Items.Add(produk.category);
                }
            }

            foreach (string kategori in benito)
            {
                dtCategory.Rows.Add("C" + counter, kategori);
                counter++;
            }
            counter = 1;

            foreach (products hili in productslist)
            {
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (hili.category == dtCategory.Rows[i][1].ToString())
                    {
                        hili.categoryid = dtCategory.Rows [i][0].ToString();
                        break;
                    }
                }
            }
            int jumlahbarang = 1;
            for (int i = 65; i<= 90; i++)
            {
                foreach (products produk in productslist)
                {
                    if (Convert.ToChar(i) == produk.productname[0])
                    {
                        produk.productid = Convert.ToChar(i) + jumlahbarang.ToString("000");
                        jumlahbarang++;
                    }
                }
                jumlahbarang = 1;
            }
            foreach(products produk in productslist)
            {
                dtProdukSimpan.Rows.Add(produk.productid, produk.productname, produk.harga, produk.stock, produk.categoryid);
            }
                


        }

        public void updatecategory()
        {
            dtCategory.Clear();
            foreach (string kategori in benito)
            {
                dtCategory.Rows.Add("C"+counter,kategori);
                counter++;
            }
            counter = 1;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void addcategory_button_Click(object sender, EventArgs e)
        {
            bool b = false;

            if (string.IsNullOrEmpty(nama2_textbox.Text))
            {
                MessageBox.Show("Fill in the blank");
            }
            else
            {
                foreach (string jeet in benito)
                {
                    if (jeet.ToUpper().Contains(nama2_textbox.Text.ToUpper()))
                    {
                        b = true;
                        break;
                    }
                }
                if (b == true)
                {
                    MessageBox.Show("Category Already Exist!");
                }
                else
                {
                    benito.Add(nama2_textbox.Text);
                    updatecategory();
                    comboBox1.Items.Add(nama2_textbox.Text);    
                    comboBox2.Items.Add(nama2_textbox.Text);
      
                }
                
            }

        }

        private void nama2_textbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void all_button_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox1.Text = "";
        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }

        private void addproduct_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nama_textbox.Text)&& string.IsNullOrEmpty(comboBox2.Text)&& string.IsNullOrEmpty(harga_textbox.Text)&& string.IsNullOrEmpty(stock_textbox.Text))
            {
                MessageBox.Show("Fill in the blank");
            }
            else
            {
                string productname = nama_textbox.Text;
                string harga = harga_textbox.Text;
                string stock = stock_textbox.Text;
                string category = comboBox2.Text;

                productslist.Add(new products(productname, harga, stock, category));
                foreach (products hili in productslist)
                {
                    for (int i = 0; i < dtCategory.Rows.Count; i++)
                    {
                        if (hili.category == dtCategory.Rows[i][1].ToString())
                        {
                            hili.categoryid = dtCategory.Rows[i][0].ToString();
                            break;
                        }
                    }
                }
                int jumlahbarang = 1;
                for (int i = 65; i <= 90; i++)
                {
                    foreach (products produk in productslist)
                    {
                        if (Convert.ToChar(i) == produk.productname[0])
                        {
                            produk.productid = Convert.ToChar(i) + jumlahbarang.ToString("000");
                            jumlahbarang++;
                        }
                    }
                    jumlahbarang = 1;
                }
                dtProdukSimpan.Rows.Clear();
                foreach (products produk in productslist)
                {
                    dtProdukSimpan.Rows.Add(produk.productid, produk.productname, produk.harga, produk.stock, produk.categoryid);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                nama2_textbox.Text = row.Cells["Nama Category"].Value.ToString();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                nama_textbox.Text = row.Cells["Nama Product"].Value.ToString();
                comboBox2.Text = row.Cells["ID Category"].Value.ToString();
                harga_textbox.Text = row.Cells["Harga"].Value.ToString();
                stock_textbox.Text = row.Cells["Stock"].Value.ToString();

            }
        }

        private void editproduct_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nama_textbox.Text) && string.IsNullOrEmpty(comboBox2.Text) && string.IsNullOrEmpty(harga_textbox.Text) && string.IsNullOrEmpty(stock_textbox.Text))
            {
                MessageBox.Show("Fill in the blank");
            }
            else
            {
                DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                string penampung = row.Cells["Nama Product"].Value.ToString();
                for (int i = 0; i < productslist.Count; i++)
                {
                    if (productslist[i].productname==penampung)
                    {
                        if (Convert.ToInt32(stock_textbox.Text)<=0)
                        {
                            productslist.RemoveAt(i);
                        }
                        else
                        {
                            productslist[i].productname = nama_textbox.Text;
                            productslist[i].harga = harga_textbox.Text;
                            productslist[i].stock = stock_textbox.Text;
                            productslist[i].category = comboBox2.Text;
                        }
                    }
                }
                foreach (products hili in productslist)
                {
                    for (int i = 0; i < dtCategory.Rows.Count; i++)
                    {
                        if (hili.category == dtCategory.Rows[i][1].ToString())
                        {
                            hili.categoryid = dtCategory.Rows[i][0].ToString();
                            break;
                        }
                    }
                }
                int jumlahbarang = 1;
                for (int i = 65; i <= 90; i++)
                {
                    foreach (products produk in productslist)
                    {
                        if (Convert.ToChar(i) == produk.productname[0])
                        {
                            produk.productid = Convert.ToChar(i) + jumlahbarang.ToString("000");
                            jumlahbarang++;
                        }
                    }
                    jumlahbarang = 1;
                }
                dtProdukSimpan.Rows.Clear();
                foreach (products produk in productslist)
                {
                    dtProdukSimpan.Rows.Add(produk.productid, produk.productname, produk.harga, produk.stock, produk.categoryid);
                }
            }
            
        }

        private void removeproduct_button_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            string penampung = row.Cells["Nama Product"].Value.ToString();
            for (int i = 0; i < productslist.Count; i++)
            {
                if (productslist[i].productname.Equals(penampung))
                {
                    productslist.RemoveAt(i);
                    break;
                }
            }
            foreach (products hili in productslist)
            {
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (hili.category == dtCategory.Rows[i][1].ToString())
                    {
                        hili.categoryid = dtCategory.Rows[i][0].ToString();
                        break;
                    }
                }
            }
            int jumlahbarang = 1;
            for (int i = 65; i <= 90; i++)
            {
                foreach (products produk in productslist)
                {
                    if (Convert.ToChar(i) == produk.productname[0])
                    {
                        produk.productid = Convert.ToChar(i) + jumlahbarang.ToString("000");
                        jumlahbarang++;
                    }
                }
                jumlahbarang = 1;
            }
            dtProdukSimpan.Rows.Clear();
            foreach (products produk in productslist)
            {
                dtProdukSimpan.Rows.Add(produk.productid, produk.productname, produk.harga, produk.stock, produk.categoryid);
            }
        }

        private void removecategory_button_Click(object sender, EventArgs e)
        {
            List<products> listproducts = new List<products>();
            DataGridViewRow row = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex];
            string penampung = row.Cells["ID Category"].Value.ToString();
            foreach (products hola in productslist)
            {
                if(hola.categoryid.Contains(penampung))
                {
                    listproducts.Add(hola);
                }
            }
            foreach (products hola in listproducts)
            {
                productslist.Remove(hola);
            }
            foreach (products hili in productslist)
            {
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (hili.category == dtCategory.Rows[i][1].ToString())
                    {
                        hili.categoryid = dtCategory.Rows[i][0].ToString();
                        break;
                    }
                }
            }
            int jumlahbarang = 1;
            for (int i = 65; i <= 90; i++)
            {
                foreach (products produk in productslist)
                {
                    if (Convert.ToChar(i) == produk.productname[0])
                    {
                        produk.productid = Convert.ToChar(i) + jumlahbarang.ToString("000");
                        jumlahbarang++;
                    }
                }
                jumlahbarang = 1;
            }
            dtProdukSimpan.Rows.Clear();
            foreach (products produk in productslist)
            {
                dtProdukSimpan.Rows.Add(produk.productid, produk.productname, produk.harga, produk.stock, produk.categoryid);
            }
            updatecategory();
        }

    }
        
    }
    

