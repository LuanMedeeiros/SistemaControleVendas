namespace ProjetoControleVendas.br.com.projeto.view
{
    partial class Frmclientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmclientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabdadospessoais = new System.Windows.Forms.TabPage();
            this.cbuf = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabconsulta = new System.Windows.Forms.TabPage();
            this.dgvclientes = new System.Windows.Forms.DataGridView();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabdadospessoais.SuspendLayout();
            this.tabconsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 123);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(857, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Clientes";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabdadospessoais);
            this.tabControl1.Controls.Add(this.tabconsulta);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(16, 143);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 556);
            this.tabControl1.TabIndex = 1;
            // 
            // tabdadospessoais
            // 
            this.tabdadospessoais.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabdadospessoais.Controls.Add(this.cbuf);
            this.tabdadospessoais.Controls.Add(this.label15);
            this.tabdadospessoais.Controls.Add(this.txtcidade);
            this.tabdadospessoais.Controls.Add(this.label14);
            this.tabdadospessoais.Controls.Add(this.txtcomplemento);
            this.tabdadospessoais.Controls.Add(this.label13);
            this.tabdadospessoais.Controls.Add(this.txtbairro);
            this.tabdadospessoais.Controls.Add(this.label12);
            this.tabdadospessoais.Controls.Add(this.txtnumero);
            this.tabdadospessoais.Controls.Add(this.label11);
            this.tabdadospessoais.Controls.Add(this.txtendereco);
            this.tabdadospessoais.Controls.Add(this.label10);
            this.tabdadospessoais.Controls.Add(this.txtcep);
            this.tabdadospessoais.Controls.Add(this.label9);
            this.tabdadospessoais.Controls.Add(this.txtcelular);
            this.tabdadospessoais.Controls.Add(this.label8);
            this.tabdadospessoais.Controls.Add(this.txttelefone);
            this.tabdadospessoais.Controls.Add(this.label7);
            this.tabdadospessoais.Controls.Add(this.txtcpf);
            this.tabdadospessoais.Controls.Add(this.label6);
            this.tabdadospessoais.Controls.Add(this.txtrg);
            this.tabdadospessoais.Controls.Add(this.label5);
            this.tabdadospessoais.Controls.Add(this.txtemail);
            this.tabdadospessoais.Controls.Add(this.label4);
            this.tabdadospessoais.Controls.Add(this.txtnome);
            this.tabdadospessoais.Controls.Add(this.label3);
            this.tabdadospessoais.Controls.Add(this.txtcodigo);
            this.tabdadospessoais.Controls.Add(this.label2);
            this.tabdadospessoais.Location = new System.Drawing.Point(4, 32);
            this.tabdadospessoais.Margin = new System.Windows.Forms.Padding(4);
            this.tabdadospessoais.Name = "tabdadospessoais";
            this.tabdadospessoais.Padding = new System.Windows.Forms.Padding(4);
            this.tabdadospessoais.Size = new System.Drawing.Size(939, 520);
            this.tabdadospessoais.TabIndex = 0;
            this.tabdadospessoais.Text = "Dados Pessoais";
            this.tabdadospessoais.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cbuf
            // 
            this.cbuf.FormattingEnabled = true;
            this.cbuf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbuf.Location = new System.Drawing.Point(636, 444);
            this.cbuf.Margin = new System.Windows.Forms.Padding(4);
            this.cbuf.Name = "cbuf";
            this.cbuf.Size = new System.Drawing.Size(244, 31);
            this.cbuf.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(584, 450);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "UF:";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(636, 380);
            this.txtcidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(244, 32);
            this.txtcidade.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(531, 384);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 23);
            this.label14.TabIndex = 24;
            this.label14.Text = "Cidade:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(195, 380);
            this.txtcomplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(325, 32);
            this.txtcomplemento.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(16, 380);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 23);
            this.label13.TabIndex = 22;
            this.label13.Text = "Complemento:";
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(195, 447);
            this.txtbairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(324, 32);
            this.txtbairro.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(111, 450);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 23);
            this.label12.TabIndex = 20;
            this.label12.Text = "Bairro:";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(805, 249);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(75, 32);
            this.txtnumero.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(701, 252);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 23);
            this.label11.TabIndex = 18;
            this.label11.Text = "Número:";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(528, 305);
            this.txtendereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(352, 32);
            this.txtendereco.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(401, 309);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Endereço:";
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(528, 249);
            this.txtcep.Margin = new System.Windows.Forms.Padding(4);
            this.txtcep.Mask = "00000-999";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(159, 32);
            this.txtcep.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(456, 252);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Cep:";
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(131, 305);
            this.txtcelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtcelular.Mask = "(99) 00000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(244, 32);
            this.txtcelular.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(16, 309);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Celular:";
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(131, 245);
            this.txttelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txttelefone.Mask = "(99) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(244, 32);
            this.txttelefone.TabIndex = 11;
            this.txttelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(16, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Telefone:";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(636, 181);
            this.txtcpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtcpf.Mask = "###.###.###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(244, 32);
            this.txtcpf.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(557, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "CPF:";
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(636, 105);
            this.txtrg.Margin = new System.Windows.Forms.Padding(4);
            this.txtrg.Mask = "##.###.###-##";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(244, 32);
            this.txtrg.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(565, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "RG:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(131, 177);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(389, 32);
            this.txtemail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(27, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(131, 108);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(389, 32);
            this.txtnome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(27, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(131, 44);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(124, 32);
            this.txtcodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // tabconsulta
            // 
            this.tabconsulta.BackColor = System.Drawing.Color.White;
            this.tabconsulta.Controls.Add(this.dgvclientes);
            this.tabconsulta.Controls.Add(this.btnpesquisar);
            this.tabconsulta.Controls.Add(this.txtpesquisa);
            this.tabconsulta.Controls.Add(this.label16);
            this.tabconsulta.Location = new System.Drawing.Point(4, 32);
            this.tabconsulta.Margin = new System.Windows.Forms.Padding(4);
            this.tabconsulta.Name = "tabconsulta";
            this.tabconsulta.Padding = new System.Windows.Forms.Padding(4);
            this.tabconsulta.Size = new System.Drawing.Size(939, 520);
            this.tabconsulta.TabIndex = 1;
            this.tabconsulta.Text = "Consulta";
            // 
            // dgvclientes
            // 
            this.dgvclientes.AllowUserToAddRows = false;
            this.dgvclientes.AllowUserToDeleteRows = false;
            this.dgvclientes.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientes.Location = new System.Drawing.Point(8, 76);
            this.dgvclientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvclientes.Name = "dgvclientes";
            this.dgvclientes.ReadOnly = true;
            this.dgvclientes.RowHeadersWidth = 51;
            this.dgvclientes.Size = new System.Drawing.Size(920, 431);
            this.dgvclientes.TabIndex = 8;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnpesquisar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.ForeColor = System.Drawing.Color.White;
            this.btnpesquisar.Location = new System.Drawing.Point(517, 25);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(145, 44);
            this.btnpesquisar.TabIndex = 7;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = false;
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(117, 31);
            this.txtpesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(391, 32);
            this.txtpesquisa.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(28, 34);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 23);
            this.label16.TabIndex = 4;
            this.label16.Text = "Nome:";
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnnovo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovo.ForeColor = System.Drawing.Color.White;
            this.btnnovo.Location = new System.Drawing.Point(175, 706);
            this.btnnovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(147, 55);
            this.btnnovo.TabIndex = 2;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsalvar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.ForeColor = System.Drawing.Color.White;
            this.btnsalvar.Location = new System.Drawing.Point(329, 706);
            this.btnsalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(147, 55);
            this.btnsalvar.TabIndex = 3;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnexcluir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.ForeColor = System.Drawing.Color.White;
            this.btnexcluir.Location = new System.Drawing.Point(484, 706);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(147, 55);
            this.btnexcluir.TabIndex = 4;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = false;
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btneditar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.Location = new System.Drawing.Point(639, 706);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(147, 55);
            this.btneditar.TabIndex = 5;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            // 
            // Frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 770);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frmclientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Frmclientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabdadospessoais.ResumeLayout(false);
            this.tabdadospessoais.PerformLayout();
            this.tabconsulta.ResumeLayout(false);
            this.tabconsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabdadospessoais;
        private System.Windows.Forms.TabPage tabconsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbuf;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.DataGridView dgvclientes;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}