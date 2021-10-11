namespace DuBaoGiaLaptop
{
    partial class main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_TinhToan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_chip_brands = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_chip_type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_chip_speed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_graphic_card_model = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_brands = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_monitorSize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_graphic_card_brand = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_SSD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ram = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_HDD = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 398);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_TinhToan
            // 
            this.btn_TinhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TinhToan.ForeColor = System.Drawing.Color.Red;
            this.btn_TinhToan.Location = new System.Drawing.Point(796, 519);
            this.btn_TinhToan.Name = "btn_TinhToan";
            this.btn_TinhToan.Size = new System.Drawing.Size(158, 79);
            this.btn_TinhToan.TabIndex = 1;
            this.btn_TinhToan.Text = "Dự Báo";
            this.btn_TinhToan.UseVisualStyleBackColor = true;
            this.btn_TinhToan.Click += new System.EventHandler(this.btn_TinhToan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sản phẩm:";
            // 
            // txt_product_name
            // 
            this.txt_product_name.BackColor = System.Drawing.Color.White;
            this.txt_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_name.Location = new System.Drawing.Point(116, 470);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.ReadOnly = true;
            this.txt_product_name.Size = new System.Drawing.Size(205, 26);
            this.txt_product_name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hãng Chip:";
            // 
            // txt_chip_brands
            // 
            this.txt_chip_brands.BackColor = System.Drawing.Color.White;
            this.txt_chip_brands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chip_brands.Location = new System.Drawing.Point(116, 510);
            this.txt_chip_brands.Name = "txt_chip_brands";
            this.txt_chip_brands.ReadOnly = true;
            this.txt_chip_brands.Size = new System.Drawing.Size(205, 26);
            this.txt_chip_brands.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dòng Chip:";
            // 
            // txt_chip_type
            // 
            this.txt_chip_type.BackColor = System.Drawing.Color.White;
            this.txt_chip_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chip_type.Location = new System.Drawing.Point(116, 547);
            this.txt_chip_type.Name = "txt_chip_type";
            this.txt_chip_type.ReadOnly = true;
            this.txt_chip_type.Size = new System.Drawing.Size(205, 26);
            this.txt_chip_type.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 587);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tốc độ xử lý:";
            // 
            // txt_chip_speed
            // 
            this.txt_chip_speed.BackColor = System.Drawing.Color.White;
            this.txt_chip_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chip_speed.Location = new System.Drawing.Point(116, 581);
            this.txt_chip_speed.Name = "txt_chip_speed";
            this.txt_chip_speed.ReadOnly = true;
            this.txt_chip_speed.Size = new System.Drawing.Size(205, 26);
            this.txt_chip_speed.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 584);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên Chip Đồ Hoạ:";
            // 
            // txt_graphic_card_model
            // 
            this.txt_graphic_card_model.BackColor = System.Drawing.Color.White;
            this.txt_graphic_card_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_graphic_card_model.Location = new System.Drawing.Point(486, 581);
            this.txt_graphic_card_model.Name = "txt_graphic_card_model";
            this.txt_graphic_card_model.ReadOnly = true;
            this.txt_graphic_card_model.Size = new System.Drawing.Size(206, 26);
            this.txt_graphic_card_model.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Thương hiệu:";
            // 
            // txt_brands
            // 
            this.txt_brands.BackColor = System.Drawing.Color.White;
            this.txt_brands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_brands.Location = new System.Drawing.Point(116, 433);
            this.txt_brands.Name = "txt_brands";
            this.txt_brands.ReadOnly = true;
            this.txt_brands.Size = new System.Drawing.Size(205, 26);
            this.txt_brands.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(646, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Kích thước màn hình:";
            // 
            // txt_monitorSize
            // 
            this.txt_monitorSize.BackColor = System.Drawing.Color.White;
            this.txt_monitorSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monitorSize.Location = new System.Drawing.Point(828, 433);
            this.txt_monitorSize.Name = "txt_monitorSize";
            this.txt_monitorSize.ReadOnly = true;
            this.txt_monitorSize.Size = new System.Drawing.Size(99, 26);
            this.txt_monitorSize.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(317, 550);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Hãng Chip Đồ Hoạ:";
            // 
            // txt_graphic_card_brand
            // 
            this.txt_graphic_card_brand.BackColor = System.Drawing.Color.White;
            this.txt_graphic_card_brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_graphic_card_brand.Location = new System.Drawing.Point(486, 547);
            this.txt_graphic_card_brand.Name = "txt_graphic_card_brand";
            this.txt_graphic_card_brand.ReadOnly = true;
            this.txt_graphic_card_brand.Size = new System.Drawing.Size(206, 26);
            this.txt_graphic_card_brand.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(427, 513);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "SSD:";
            // 
            // txt_SSD
            // 
            this.txt_SSD.BackColor = System.Drawing.Color.White;
            this.txt_SSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SSD.Location = new System.Drawing.Point(486, 510);
            this.txt_SSD.Name = "txt_SSD";
            this.txt_SSD.ReadOnly = true;
            this.txt_SSD.Size = new System.Drawing.Size(144, 26);
            this.txt_SSD.TabIndex = 5;
            this.txt_SSD.TextChanged += new System.EventHandler(this.txt_HDD_BindingContextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(427, 439);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "RAM:";
            // 
            // txt_ram
            // 
            this.txt_ram.BackColor = System.Drawing.Color.White;
            this.txt_ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ram.Location = new System.Drawing.Point(486, 433);
            this.txt_ram.Name = "txt_ram";
            this.txt_ram.ReadOnly = true;
            this.txt_ram.Size = new System.Drawing.Size(144, 26);
            this.txt_ram.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(429, 473);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "HDD:";
            // 
            // txt_HDD
            // 
            this.txt_HDD.BackColor = System.Drawing.Color.White;
            this.txt_HDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HDD.Location = new System.Drawing.Point(486, 470);
            this.txt_HDD.Name = "txt_HDD";
            this.txt_HDD.ReadOnly = true;
            this.txt_HDD.Size = new System.Drawing.Size(144, 26);
            this.txt_HDD.TabIndex = 5;
            this.txt_HDD.TextChanged += new System.EventHandler(this.txt_HDD_BindingContextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(780, 476);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Giá:";
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.White;
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(828, 473);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(99, 26);
            this.txt_price.TabIndex = 5;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 631);
            this.Controls.Add(this.txt_HDD);
            this.Controls.Add(this.txt_ram);
            this.Controls.Add(this.txt_SSD);
            this.Controls.Add(this.txt_graphic_card_brand);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_monitorSize);
            this.Controls.Add(this.txt_brands);
            this.Controls.Add(this.txt_graphic_card_model);
            this.Controls.Add(this.txt_chip_speed);
            this.Controls.Add(this.txt_chip_type);
            this.Controls.Add(this.txt_chip_brands);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_TinhToan);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Du Bao Gia Laptop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_TinhToan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_chip_brands;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_chip_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_chip_speed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_graphic_card_model;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_brands;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_monitorSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_graphic_card_brand;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_SSD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ram;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_HDD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_price;
    }
}

