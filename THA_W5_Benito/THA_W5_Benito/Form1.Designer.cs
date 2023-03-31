namespace THA_W5_Benito
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.product = new System.Windows.Forms.Label();
            this.all_button = new System.Windows.Forms.Button();
            this.filter_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.details = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.nama_textbox = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.Label();
            this.harga_textbox = new System.Windows.Forms.TextBox();
            this.harga = new System.Windows.Forms.Label();
            this.stock_textbox = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.Label();
            this.addproduct_button = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.editproduct_button = new System.Windows.Forms.Button();
            this.removeproduct_button = new System.Windows.Forms.Button();
            this.categorylabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nama2 = new System.Windows.Forms.Label();
            this.nama2_textbox = new System.Windows.Forms.TextBox();
            this.addcategory_button = new System.Windows.Forms.Button();
            this.removecategory_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(12, 19);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(119, 32);
            this.product.TabIndex = 0;
            this.product.Text = "Product";
            // 
            // all_button
            // 
            this.all_button.Location = new System.Drawing.Point(201, 45);
            this.all_button.Name = "all_button";
            this.all_button.Size = new System.Drawing.Size(43, 23);
            this.all_button.TabIndex = 2;
            this.all_button.Text = "All";
            this.all_button.UseVisualStyleBackColor = true;
            this.all_button.Click += new System.EventHandler(this.all_button_Click);
            // 
            // filter_button
            // 
            this.filter_button.Location = new System.Drawing.Point(250, 45);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(47, 23);
            this.filter_button.TabIndex = 3;
            this.filter_button.Text = "Filter";
            this.filter_button.UseVisualStyleBackColor = true;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(304, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 326);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.Location = new System.Drawing.Point(11, 415);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(109, 32);
            this.details.TabIndex = 6;
            this.details.Text = "Details";
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Location = new System.Drawing.Point(21, 457);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(50, 16);
            this.nama.TabIndex = 7;
            this.nama.Text = "Nama :";
            // 
            // nama_textbox
            // 
            this.nama_textbox.Location = new System.Drawing.Point(77, 454);
            this.nama_textbox.Name = "nama_textbox";
            this.nama_textbox.Size = new System.Drawing.Size(342, 22);
            this.nama_textbox.TabIndex = 8;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Location = new System.Drawing.Point(3, 486);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(68, 16);
            this.category.TabIndex = 9;
            this.category.Text = "Category :";
            // 
            // harga_textbox
            // 
            this.harga_textbox.Location = new System.Drawing.Point(77, 511);
            this.harga_textbox.Name = "harga_textbox";
            this.harga_textbox.Size = new System.Drawing.Size(121, 22);
            this.harga_textbox.TabIndex = 12;
            // 
            // harga
            // 
            this.harga.AutoSize = true;
            this.harga.Location = new System.Drawing.Point(21, 514);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(51, 16);
            this.harga.TabIndex = 11;
            this.harga.Text = "Harga :";
            // 
            // stock_textbox
            // 
            this.stock_textbox.Location = new System.Drawing.Point(77, 540);
            this.stock_textbox.Name = "stock_textbox";
            this.stock_textbox.Size = new System.Drawing.Size(121, 22);
            this.stock_textbox.TabIndex = 14;
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Location = new System.Drawing.Point(21, 543);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(47, 16);
            this.stock.TabIndex = 13;
            this.stock.Text = "Stock :";
            // 
            // addproduct_button
            // 
            this.addproduct_button.BackColor = System.Drawing.Color.Chartreuse;
            this.addproduct_button.Location = new System.Drawing.Point(213, 496);
            this.addproduct_button.Name = "addproduct_button";
            this.addproduct_button.Size = new System.Drawing.Size(100, 52);
            this.addproduct_button.TabIndex = 15;
            this.addproduct_button.Text = "Add Product";
            this.addproduct_button.UseVisualStyleBackColor = false;
            this.addproduct_button.Click += new System.EventHandler(this.addproduct_button_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(77, 482);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 16;
            // 
            // editproduct_button
            // 
            this.editproduct_button.BackColor = System.Drawing.Color.Yellow;
            this.editproduct_button.Location = new System.Drawing.Point(319, 496);
            this.editproduct_button.Name = "editproduct_button";
            this.editproduct_button.Size = new System.Drawing.Size(100, 52);
            this.editproduct_button.TabIndex = 17;
            this.editproduct_button.Text = "Edit Product";
            this.editproduct_button.UseVisualStyleBackColor = false;
            this.editproduct_button.Click += new System.EventHandler(this.editproduct_button_Click);
            // 
            // removeproduct_button
            // 
            this.removeproduct_button.BackColor = System.Drawing.Color.Red;
            this.removeproduct_button.Location = new System.Drawing.Point(425, 496);
            this.removeproduct_button.Name = "removeproduct_button";
            this.removeproduct_button.Size = new System.Drawing.Size(110, 52);
            this.removeproduct_button.TabIndex = 18;
            this.removeproduct_button.Text = "Remove Product";
            this.removeproduct_button.UseVisualStyleBackColor = false;
            this.removeproduct_button.Click += new System.EventHandler(this.removeproduct_button_Click);
            // 
            // categorylabel
            // 
            this.categorylabel.AutoSize = true;
            this.categorylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorylabel.Location = new System.Drawing.Point(608, 28);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.Size = new System.Drawing.Size(137, 32);
            this.categorylabel.TabIndex = 19;
            this.categorylabel.Text = "Category";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(602, 84);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(360, 257);
            this.dataGridView2.TabIndex = 20;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // nama2
            // 
            this.nama2.AutoSize = true;
            this.nama2.Location = new System.Drawing.Point(606, 363);
            this.nama2.Name = "nama2";
            this.nama2.Size = new System.Drawing.Size(50, 16);
            this.nama2.TabIndex = 21;
            this.nama2.Text = "Nama :";
            // 
            // nama2_textbox
            // 
            this.nama2_textbox.Location = new System.Drawing.Point(662, 360);
            this.nama2_textbox.Name = "nama2_textbox";
            this.nama2_textbox.Size = new System.Drawing.Size(211, 22);
            this.nama2_textbox.TabIndex = 22;
            this.nama2_textbox.TextChanged += new System.EventHandler(this.nama2_textbox_TextChanged);
            // 
            // addcategory_button
            // 
            this.addcategory_button.BackColor = System.Drawing.Color.Chartreuse;
            this.addcategory_button.Location = new System.Drawing.Point(716, 388);
            this.addcategory_button.Name = "addcategory_button";
            this.addcategory_button.Size = new System.Drawing.Size(84, 52);
            this.addcategory_button.TabIndex = 23;
            this.addcategory_button.Text = "Add Category";
            this.addcategory_button.UseVisualStyleBackColor = false;
            this.addcategory_button.Click += new System.EventHandler(this.addcategory_button_Click);
            // 
            // removecategory_button
            // 
            this.removecategory_button.BackColor = System.Drawing.Color.Red;
            this.removecategory_button.Location = new System.Drawing.Point(806, 388);
            this.removecategory_button.Name = "removecategory_button";
            this.removecategory_button.Size = new System.Drawing.Size(77, 52);
            this.removecategory_button.TabIndex = 24;
            this.removecategory_button.Text = "Remove Category";
            this.removecategory_button.UseVisualStyleBackColor = false;
            this.removecategory_button.Click += new System.EventHandler(this.removecategory_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1037, 628);
            this.Controls.Add(this.removecategory_button);
            this.Controls.Add(this.addcategory_button);
            this.Controls.Add(this.nama2_textbox);
            this.Controls.Add(this.nama2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.categorylabel);
            this.Controls.Add(this.removeproduct_button);
            this.Controls.Add(this.editproduct_button);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.addproduct_button);
            this.Controls.Add(this.stock_textbox);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.harga_textbox);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.category);
            this.Controls.Add(this.nama_textbox);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.details);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.filter_button);
            this.Controls.Add(this.all_button);
            this.Controls.Add(this.product);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label product;
        private System.Windows.Forms.Button all_button;
        private System.Windows.Forms.Button filter_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.TextBox nama_textbox;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.TextBox harga_textbox;
        private System.Windows.Forms.Label harga;
        private System.Windows.Forms.TextBox stock_textbox;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.Button addproduct_button;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button editproduct_button;
        private System.Windows.Forms.Button removeproduct_button;
        private System.Windows.Forms.Label categorylabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label nama2;
        private System.Windows.Forms.TextBox nama2_textbox;
        private System.Windows.Forms.Button addcategory_button;
        private System.Windows.Forms.Button removecategory_button;
    }
}

