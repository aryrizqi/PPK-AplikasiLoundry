namespace AplikasiLoundry
{
    partial class FormOrder
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPaket = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpRs = new System.Windows.Forms.DateTimePicker();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbAlamat = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNohp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdOrder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbBerat = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbKembali = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbDibayar = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbBiaya = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rbDiambil = new System.Windows.Forms.RadioButton();
            this.rbDiantar = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPaket);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 44);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilih Paket";
            // 
            // cbPaket
            // 
            this.cbPaket.FormattingEnabled = true;
            this.cbPaket.Items.AddRange(new object[] {
            "Cuci Kering",
            "Cuci Basah",
            "Cuci Setrika"});
            this.cbPaket.Location = new System.Drawing.Point(99, 14);
            this.cbPaket.Name = "cbPaket";
            this.cbPaket.Size = new System.Drawing.Size(299, 24);
            this.cbPaket.TabIndex = 0;
            this.cbPaket.Text = "Pilih Paket";
            this.cbPaket.SelectedIndexChanged += new System.EventHandler(this.cbPaket_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 191);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Order";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(99, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(163, 42);
            this.richTextBox1.TabIndex = 96;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "ID Order :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(99, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 20);
            this.textBox4.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "Nama";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(99, 97);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(163, 20);
            this.textBox6.TabIndex = 95;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "No HP :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(163, 20);
            this.textBox3.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "Alamat";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpRs);
            this.groupBox3.Controls.Add(this.dtpOrder);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.rtbAlamat);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbNama);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbNohp);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbIdOrder);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 284);
            this.groupBox3.TabIndex = 88;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Order";
            // 
            // dtpRs
            // 
            this.dtpRs.Location = new System.Drawing.Point(198, 240);
            this.dtpRs.Name = "dtpRs";
            this.dtpRs.Size = new System.Drawing.Size(200, 23);
            this.dtpRs.TabIndex = 100;
            // 
            // dtpOrder
            // 
            this.dtpOrder.Location = new System.Drawing.Point(198, 202);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(200, 23);
            this.dtpOrder.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 97;
            this.label5.Text = "Tanggal Order :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 18);
            this.label10.TabIndex = 98;
            this.label10.Text = "Tanggal Rencana Selesai :";
            // 
            // rtbAlamat
            // 
            this.rtbAlamat.Location = new System.Drawing.Point(99, 129);
            this.rtbAlamat.Name = "rtbAlamat";
            this.rtbAlamat.Size = new System.Drawing.Size(299, 55);
            this.rtbAlamat.TabIndex = 96;
            this.rtbAlamat.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 89;
            this.label1.Text = "ID Order :";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(99, 62);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(299, 23);
            this.tbNama.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 90;
            this.label2.Text = "Nama :";
            // 
            // tbNohp
            // 
            this.tbNohp.Location = new System.Drawing.Point(99, 97);
            this.tbNohp.Name = "tbNohp";
            this.tbNohp.Size = new System.Drawing.Size(299, 23);
            this.tbNohp.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 91;
            this.label3.Text = "No HP :";
            // 
            // tbIdOrder
            // 
            this.tbIdOrder.Location = new System.Drawing.Point(99, 24);
            this.tbIdOrder.Name = "tbIdOrder";
            this.tbIdOrder.Size = new System.Drawing.Size(299, 23);
            this.tbIdOrder.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 92;
            this.label4.Text = "Alamat :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbBerat);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.btnSubmit);
            this.groupBox4.Controls.Add(this.tbKembali);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tbDibayar);
            this.groupBox4.Controls.Add(this.tbTotal);
            this.groupBox4.Controls.Add(this.tbBiaya);
            this.groupBox4.Controls.Add(this.tbHarga);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.rbDiambil);
            this.groupBox4.Controls.Add(this.rbDiantar);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(422, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 334);
            this.groupBox4.TabIndex = 89;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total Transaksi";
            // 
            // tbBerat
            // 
            this.tbBerat.Location = new System.Drawing.Point(125, 71);
            this.tbBerat.Name = "tbBerat";
            this.tbBerat.Size = new System.Drawing.Size(169, 23);
            this.tbBerat.TabIndex = 116;
            this.tbBerat.TextChanged += new System.EventHandler(this.tbBerat_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 18);
            this.label20.TabIndex = 115;
            this.label20.Text = "Berat/kg  :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(187, 291);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 34);
            this.btnSubmit.TabIndex = 114;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbKembali
            // 
            this.tbKembali.Location = new System.Drawing.Point(125, 248);
            this.tbKembali.Name = "tbKembali";
            this.tbKembali.ReadOnly = true;
            this.tbKembali.Size = new System.Drawing.Size(169, 23);
            this.tbKembali.TabIndex = 113;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 18);
            this.label13.TabIndex = 112;
            this.label13.Text = "Uang Kembali  :";
            // 
            // tbDibayar
            // 
            this.tbDibayar.Location = new System.Drawing.Point(125, 208);
            this.tbDibayar.Name = "tbDibayar";
            this.tbDibayar.Size = new System.Drawing.Size(169, 23);
            this.tbDibayar.TabIndex = 111;
            this.tbDibayar.TextChanged += new System.EventHandler(this.tbDibayar_TextChanged);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(125, 171);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(169, 23);
            this.tbTotal.TabIndex = 110;
            // 
            // tbBiaya
            // 
            this.tbBiaya.Location = new System.Drawing.Point(125, 138);
            this.tbBiaya.Name = "tbBiaya";
            this.tbBiaya.ReadOnly = true;
            this.tbBiaya.Size = new System.Drawing.Size(169, 23);
            this.tbBiaya.TabIndex = 109;
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(125, 108);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.ReadOnly = true;
            this.tbHarga.Size = new System.Drawing.Size(169, 23);
            this.tbHarga.TabIndex = 101;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 211);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 18);
            this.label17.TabIndex = 108;
            this.label17.Text = "Uang Dibayar  :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 174);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 18);
            this.label19.TabIndex = 106;
            this.label19.Text = "Total dibayar :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 18);
            this.label15.TabIndex = 104;
            this.label15.Text = "Biaya Antar :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 18);
            this.label12.TabIndex = 102;
            this.label12.Text = "Harga/kg :";
            // 
            // rbDiambil
            // 
            this.rbDiambil.AutoSize = true;
            this.rbDiambil.Location = new System.Drawing.Point(204, 30);
            this.rbDiambil.Name = "rbDiambil";
            this.rbDiambil.Size = new System.Drawing.Size(71, 20);
            this.rbDiambil.TabIndex = 33;
            this.rbDiambil.TabStop = true;
            this.rbDiambil.Text = "Diambil";
            this.rbDiambil.UseVisualStyleBackColor = true;
            // 
            // rbDiantar
            // 
            this.rbDiantar.AutoSize = true;
            this.rbDiantar.Location = new System.Drawing.Point(125, 30);
            this.rbDiantar.Name = "rbDiantar";
            this.rbDiantar.Size = new System.Drawing.Size(73, 20);
            this.rbDiantar.TabIndex = 32;
            this.rbDiantar.TabStop = true;
            this.rbDiantar.Text = "Diantar";
            this.rbDiantar.UseVisualStyleBackColor = true;
            this.rbDiantar.CheckedChanged += new System.EventHandler(this.rbDiantar_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 18);
            this.label11.TabIndex = 101;
            this.label11.Text = "Pengiriman :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.logout);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 89);
            this.panel2.TabIndex = 90;
            // 
            // logout
            // 
            this.logout.Image = global::AplikasiLoundry.Properties.Resources.rsz_1off;
            this.logout.Location = new System.Drawing.Point(634, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(69, 75);
            this.logout.TabIndex = 4;
            this.logout.TabStop = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(170, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Telp. 081235060085";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(170, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(323, 18);
            this.label16.TabIndex = 2;
            this.label16.Text = "Jalan Akordeon Utara No 20 Malang";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label18.Location = new System.Drawing.Point(164, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(380, 41);
            this.label18.TabIndex = 1;
            this.label18.Text = "Aplikasi Laundry Gan!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplikasiLoundry.Properties.Resources.rsz_1logan;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(734, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrder";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpRs;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbAlamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNohp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbDiambil;
        private System.Windows.Forms.RadioButton rbDiantar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbBiaya;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbKembali;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbDibayar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logout;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbBerat;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbPaket;
    }
}