namespace LPProject
{
    partial class LivePerformance
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
            this.components = new System.ComponentModel.Container();
            this.MSMenu = new System.Windows.Forms.MenuStrip();
            this.verkiezingsuitslagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fetchDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporteerCoalitieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGVUitslagen = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uitslagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tcHoofd = new System.Windows.Forms.TabControl();
            this.Verkiezingsuitslagen = new System.Windows.Forms.TabPage();
            this.Partijen = new System.Windows.Forms.TabPage();
            this.btnVerwijderPartij = new System.Windows.Forms.Button();
            this.btnCoalitieVormen = new System.Windows.Forms.Button();
            this.DGVPartijen = new System.Windows.Forms.DataGridView();
            this.Coalities = new System.Windows.Forms.TabPage();
            this.DGVCoalities = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeselecteerdeUitslag = new System.Windows.Forms.TabPage();
            this.lblSoort = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toevoegen = new System.Windows.Forms.TabPage();
            this.dtpDatumUitslag = new System.Windows.Forms.DateTimePicker();
            this.lblDatumUitslag = new System.Windows.Forms.Label();
            this.lblNaamUitslag = new System.Windows.Forms.Label();
            this.tbNaamUitslag = new System.Windows.Forms.TextBox();
            this.btnUitslagAfronden = new System.Windows.Forms.Button();
            this.lbPartijenInUitslag = new System.Windows.Forms.ListBox();
            this.btnToevoegenAanUitslag = new System.Windows.Forms.Button();
            this.lblAantalStemmen = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LBAllePartijen = new System.Windows.Forms.ListBox();
            this.lblUitslagToevoegen = new System.Windows.Forms.Label();
            this.lblPartij = new System.Windows.Forms.Label();
            this.tbLijsttrekker = new System.Windows.Forms.TextBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.lblPartijLijsttrekker = new System.Windows.Forms.Label();
            this.lblPartijNaam = new System.Windows.Forms.Label();
            this.btnPartijToevoegen = new System.Windows.Forms.Button();
            this.uitslagBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stemmenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partijBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naamDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijsttrekkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stemmen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUitslagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitslagBindingSource)).BeginInit();
            this.tcHoofd.SuspendLayout();
            this.Verkiezingsuitslagen.SuspendLayout();
            this.Partijen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPartijen)).BeginInit();
            this.Coalities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCoalities)).BeginInit();
            this.GeselecteerdeUitslag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Toevoegen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uitslagBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stemmenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partijBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MSMenu
            // 
            this.MSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verkiezingsuitslagenToolStripMenuItem});
            this.MSMenu.Location = new System.Drawing.Point(0, 0);
            this.MSMenu.Name = "MSMenu";
            this.MSMenu.Size = new System.Drawing.Size(784, 24);
            this.MSMenu.TabIndex = 0;
            this.MSMenu.Text = "menuStrip1";
            // 
            // verkiezingsuitslagenToolStripMenuItem
            // 
            this.verkiezingsuitslagenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fetchDatabaseToolStripMenuItem,
            this.exporteerCoalitieToolStripMenuItem});
            this.verkiezingsuitslagenToolStripMenuItem.Name = "verkiezingsuitslagenToolStripMenuItem";
            this.verkiezingsuitslagenToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.verkiezingsuitslagenToolStripMenuItem.Text = "Menu";
            // 
            // fetchDatabaseToolStripMenuItem
            // 
            this.fetchDatabaseToolStripMenuItem.Name = "fetchDatabaseToolStripMenuItem";
            this.fetchDatabaseToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fetchDatabaseToolStripMenuItem.Text = "Ophalen Database";
            this.fetchDatabaseToolStripMenuItem.Click += new System.EventHandler(this.fetchDatabaseToolStripMenuItem_Click);
            // 
            // exporteerCoalitieToolStripMenuItem
            // 
            this.exporteerCoalitieToolStripMenuItem.Name = "exporteerCoalitieToolStripMenuItem";
            this.exporteerCoalitieToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exporteerCoalitieToolStripMenuItem.Text = "Exporteer Coalitie";
            // 
            // DGVUitslagen
            // 
            this.DGVUitslagen.AllowUserToAddRows = false;
            this.DGVUitslagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVUitslagen.AutoGenerateColumns = false;
            this.DGVUitslagen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUitslagen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.naamDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.soortDataGridViewTextBoxColumn});
            this.DGVUitslagen.DataSource = this.uitslagBindingSource;
            this.DGVUitslagen.Location = new System.Drawing.Point(6, 6);
            this.DGVUitslagen.Name = "DGVUitslagen";
            this.DGVUitslagen.Size = new System.Drawing.Size(740, 444);
            this.DGVUitslagen.TabIndex = 1;
            this.DGVUitslagen.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUitslagen_CellValueChanged);
            this.DGVUitslagen.DoubleClick += new System.EventHandler(this.DGVUitslagen_DoubleClick);
            this.DGVUitslagen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGVUitslagen_KeyDown);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // naamDataGridViewTextBoxColumn
            // 
            this.naamDataGridViewTextBoxColumn.DataPropertyName = "Naam";
            this.naamDataGridViewTextBoxColumn.HeaderText = "Naam";
            this.naamDataGridViewTextBoxColumn.Name = "naamDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // soortDataGridViewTextBoxColumn
            // 
            this.soortDataGridViewTextBoxColumn.DataPropertyName = "Soort";
            this.soortDataGridViewTextBoxColumn.HeaderText = "Soort";
            this.soortDataGridViewTextBoxColumn.Name = "soortDataGridViewTextBoxColumn";
            // 
            // uitslagBindingSource
            // 
            this.uitslagBindingSource.DataSource = typeof(LPProject.Models.Uitslag);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tcHoofd
            // 
            this.tcHoofd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcHoofd.Controls.Add(this.Verkiezingsuitslagen);
            this.tcHoofd.Controls.Add(this.Partijen);
            this.tcHoofd.Controls.Add(this.Coalities);
            this.tcHoofd.Controls.Add(this.GeselecteerdeUitslag);
            this.tcHoofd.Controls.Add(this.Toevoegen);
            this.tcHoofd.Location = new System.Drawing.Point(12, 27);
            this.tcHoofd.Name = "tcHoofd";
            this.tcHoofd.SelectedIndex = 0;
            this.tcHoofd.Size = new System.Drawing.Size(760, 482);
            this.tcHoofd.TabIndex = 3;
            // 
            // Verkiezingsuitslagen
            // 
            this.Verkiezingsuitslagen.Controls.Add(this.DGVUitslagen);
            this.Verkiezingsuitslagen.Location = new System.Drawing.Point(4, 22);
            this.Verkiezingsuitslagen.Name = "Verkiezingsuitslagen";
            this.Verkiezingsuitslagen.Padding = new System.Windows.Forms.Padding(3);
            this.Verkiezingsuitslagen.Size = new System.Drawing.Size(752, 456);
            this.Verkiezingsuitslagen.TabIndex = 0;
            this.Verkiezingsuitslagen.Text = "Verkiezingsuitslagen";
            this.Verkiezingsuitslagen.UseVisualStyleBackColor = true;
            // 
            // Partijen
            // 
            this.Partijen.Controls.Add(this.btnVerwijderPartij);
            this.Partijen.Controls.Add(this.btnCoalitieVormen);
            this.Partijen.Controls.Add(this.DGVPartijen);
            this.Partijen.Location = new System.Drawing.Point(4, 22);
            this.Partijen.Name = "Partijen";
            this.Partijen.Padding = new System.Windows.Forms.Padding(3);
            this.Partijen.Size = new System.Drawing.Size(752, 456);
            this.Partijen.TabIndex = 1;
            this.Partijen.Text = "Partijen";
            this.Partijen.UseVisualStyleBackColor = true;
            // 
            // btnVerwijderPartij
            // 
            this.btnVerwijderPartij.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerwijderPartij.Location = new System.Drawing.Point(518, 427);
            this.btnVerwijderPartij.Name = "btnVerwijderPartij";
            this.btnVerwijderPartij.Size = new System.Drawing.Size(111, 23);
            this.btnVerwijderPartij.TabIndex = 4;
            this.btnVerwijderPartij.Text = "Partij Verwijderen";
            this.btnVerwijderPartij.UseVisualStyleBackColor = true;
            // 
            // btnCoalitieVormen
            // 
            this.btnCoalitieVormen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCoalitieVormen.Location = new System.Drawing.Point(635, 427);
            this.btnCoalitieVormen.Name = "btnCoalitieVormen";
            this.btnCoalitieVormen.Size = new System.Drawing.Size(111, 23);
            this.btnCoalitieVormen.TabIndex = 3;
            this.btnCoalitieVormen.Text = "Coalitie Vormen";
            this.btnCoalitieVormen.UseVisualStyleBackColor = true;
            // 
            // DGVPartijen
            // 
            this.DGVPartijen.AllowUserToAddRows = false;
            this.DGVPartijen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVPartijen.AutoGenerateColumns = false;
            this.DGVPartijen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPartijen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.naamDataGridViewTextBoxColumn1,
            this.lijsttrekkerDataGridViewTextBoxColumn,
            this.Stemmen});
            this.DGVPartijen.DataSource = this.partijBindingSource;
            this.DGVPartijen.Location = new System.Drawing.Point(6, 6);
            this.DGVPartijen.Name = "DGVPartijen";
            this.DGVPartijen.Size = new System.Drawing.Size(740, 415);
            this.DGVPartijen.TabIndex = 2;
            // 
            // Coalities
            // 
            this.Coalities.Controls.Add(this.DGVCoalities);
            this.Coalities.Location = new System.Drawing.Point(4, 22);
            this.Coalities.Name = "Coalities";
            this.Coalities.Padding = new System.Windows.Forms.Padding(3);
            this.Coalities.Size = new System.Drawing.Size(752, 456);
            this.Coalities.TabIndex = 2;
            this.Coalities.Text = "Coalities";
            this.Coalities.UseVisualStyleBackColor = true;
            // 
            // DGVCoalities
            // 
            this.DGVCoalities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCoalities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCoalities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DGVCoalities.Location = new System.Drawing.Point(6, 6);
            this.DGVCoalities.Name = "DGVCoalities";
            this.DGVCoalities.Size = new System.Drawing.Size(740, 444);
            this.DGVCoalities.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 200F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Naam";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 200F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // GeselecteerdeUitslag
            // 
            this.GeselecteerdeUitslag.Controls.Add(this.lblSoort);
            this.GeselecteerdeUitslag.Controls.Add(this.lblNaam);
            this.GeselecteerdeUitslag.Controls.Add(this.lblDatum);
            this.GeselecteerdeUitslag.Controls.Add(this.dataGridView1);
            this.GeselecteerdeUitslag.Location = new System.Drawing.Point(4, 22);
            this.GeselecteerdeUitslag.Name = "GeselecteerdeUitslag";
            this.GeselecteerdeUitslag.Padding = new System.Windows.Forms.Padding(3);
            this.GeselecteerdeUitslag.Size = new System.Drawing.Size(752, 456);
            this.GeselecteerdeUitslag.TabIndex = 3;
            this.GeselecteerdeUitslag.Text = "Geselecteerde Uitslag";
            this.GeselecteerdeUitslag.UseVisualStyleBackColor = true;
            // 
            // lblSoort
            // 
            this.lblSoort.AutoSize = true;
            this.lblSoort.Location = new System.Drawing.Point(6, 29);
            this.lblSoort.Name = "lblSoort";
            this.lblSoort.Size = new System.Drawing.Size(38, 13);
            this.lblSoort.TabIndex = 7;
            this.lblSoort.Text = "Soort: ";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(6, 16);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(41, 13);
            this.lblNaam.TabIndex = 6;
            this.lblNaam.Text = "Naam: ";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(6, 3);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(44, 13);
            this.lblDatum.TabIndex = 5;
            this.lblDatum.Text = "Datum: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.Location = new System.Drawing.Point(6, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 405);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.FillWeight = 200F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Partij";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 200F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Aantal Stemmen";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // Toevoegen
            // 
            this.Toevoegen.Controls.Add(this.dtpDatumUitslag);
            this.Toevoegen.Controls.Add(this.lblDatumUitslag);
            this.Toevoegen.Controls.Add(this.lblNaamUitslag);
            this.Toevoegen.Controls.Add(this.tbNaamUitslag);
            this.Toevoegen.Controls.Add(this.btnUitslagAfronden);
            this.Toevoegen.Controls.Add(this.lbPartijenInUitslag);
            this.Toevoegen.Controls.Add(this.btnToevoegenAanUitslag);
            this.Toevoegen.Controls.Add(this.lblAantalStemmen);
            this.Toevoegen.Controls.Add(this.textBox1);
            this.Toevoegen.Controls.Add(this.LBAllePartijen);
            this.Toevoegen.Controls.Add(this.lblUitslagToevoegen);
            this.Toevoegen.Controls.Add(this.lblPartij);
            this.Toevoegen.Controls.Add(this.tbLijsttrekker);
            this.Toevoegen.Controls.Add(this.tbNaam);
            this.Toevoegen.Controls.Add(this.lblPartijLijsttrekker);
            this.Toevoegen.Controls.Add(this.lblPartijNaam);
            this.Toevoegen.Controls.Add(this.btnPartijToevoegen);
            this.Toevoegen.Location = new System.Drawing.Point(4, 22);
            this.Toevoegen.Name = "Toevoegen";
            this.Toevoegen.Padding = new System.Windows.Forms.Padding(3);
            this.Toevoegen.Size = new System.Drawing.Size(752, 456);
            this.Toevoegen.TabIndex = 4;
            this.Toevoegen.Text = "Toevoegen";
            this.Toevoegen.UseVisualStyleBackColor = true;
            // 
            // dtpDatumUitslag
            // 
            this.dtpDatumUitslag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDatumUitslag.Location = new System.Drawing.Point(216, 389);
            this.dtpDatumUitslag.Name = "dtpDatumUitslag";
            this.dtpDatumUitslag.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumUitslag.TabIndex = 17;
            // 
            // lblDatumUitslag
            // 
            this.lblDatumUitslag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDatumUitslag.AutoSize = true;
            this.lblDatumUitslag.Location = new System.Drawing.Point(278, 373);
            this.lblDatumUitslag.Name = "lblDatumUitslag";
            this.lblDatumUitslag.Size = new System.Drawing.Size(76, 13);
            this.lblDatumUitslag.TabIndex = 16;
            this.lblDatumUitslag.Text = "Datum Uitslag:";
            // 
            // lblNaamUitslag
            // 
            this.lblNaamUitslag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNaamUitslag.AutoSize = true;
            this.lblNaamUitslag.Location = new System.Drawing.Point(280, 334);
            this.lblNaamUitslag.Name = "lblNaamUitslag";
            this.lblNaamUitslag.Size = new System.Drawing.Size(73, 13);
            this.lblNaamUitslag.TabIndex = 14;
            this.lblNaamUitslag.Text = "Naam Uitslag:";
            // 
            // tbNaamUitslag
            // 
            this.tbNaamUitslag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbNaamUitslag.Location = new System.Drawing.Point(240, 350);
            this.tbNaamUitslag.Name = "tbNaamUitslag";
            this.tbNaamUitslag.Size = new System.Drawing.Size(153, 20);
            this.tbNaamUitslag.TabIndex = 13;
            // 
            // btnUitslagAfronden
            // 
            this.btnUitslagAfronden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUitslagAfronden.Location = new System.Drawing.Point(240, 415);
            this.btnUitslagAfronden.Name = "btnUitslagAfronden";
            this.btnUitslagAfronden.Size = new System.Drawing.Size(153, 23);
            this.btnUitslagAfronden.TabIndex = 12;
            this.btnUitslagAfronden.Text = "Uitslag Afronden";
            this.btnUitslagAfronden.UseVisualStyleBackColor = true;
            // 
            // lbPartijenInUitslag
            // 
            this.lbPartijenInUitslag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPartijenInUitslag.FormattingEnabled = true;
            this.lbPartijenInUitslag.Location = new System.Drawing.Point(202, 30);
            this.lbPartijenInUitslag.Name = "lbPartijenInUitslag";
            this.lbPartijenInUitslag.Size = new System.Drawing.Size(228, 290);
            this.lbPartijenInUitslag.TabIndex = 11;
            // 
            // btnToevoegenAanUitslag
            // 
            this.btnToevoegenAanUitslag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnToevoegenAanUitslag.Location = new System.Drawing.Point(25, 418);
            this.btnToevoegenAanUitslag.Name = "btnToevoegenAanUitslag";
            this.btnToevoegenAanUitslag.Size = new System.Drawing.Size(153, 23);
            this.btnToevoegenAanUitslag.TabIndex = 10;
            this.btnToevoegenAanUitslag.Text = "Toevoegen aan uitslag";
            this.btnToevoegenAanUitslag.UseVisualStyleBackColor = true;
            // 
            // lblAantalStemmen
            // 
            this.lblAantalStemmen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAantalStemmen.AutoSize = true;
            this.lblAantalStemmen.Location = new System.Drawing.Point(58, 376);
            this.lblAantalStemmen.Name = "lblAantalStemmen";
            this.lblAantalStemmen.Size = new System.Drawing.Size(87, 13);
            this.lblAantalStemmen.TabIndex = 9;
            this.lblAantalStemmen.Text = "Aantal Stemmen:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(25, 392);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 8;
            // 
            // LBAllePartijen
            // 
            this.LBAllePartijen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBAllePartijen.FormattingEnabled = true;
            this.LBAllePartijen.Location = new System.Drawing.Point(6, 30);
            this.LBAllePartijen.Name = "LBAllePartijen";
            this.LBAllePartijen.Size = new System.Drawing.Size(190, 316);
            this.LBAllePartijen.TabIndex = 7;
            this.LBAllePartijen.SelectedIndexChanged += new System.EventHandler(this.LBAllePartijen_SelectedIndexChanged);
            // 
            // lblUitslagToevoegen
            // 
            this.lblUitslagToevoegen.AutoSize = true;
            this.lblUitslagToevoegen.Location = new System.Drawing.Point(53, 14);
            this.lblUitslagToevoegen.Name = "lblUitslagToevoegen";
            this.lblUitslagToevoegen.Size = new System.Drawing.Size(97, 13);
            this.lblUitslagToevoegen.TabIndex = 6;
            this.lblUitslagToevoegen.Text = "Uitslag Toevoegen";
            // 
            // lblPartij
            // 
            this.lblPartij.AutoSize = true;
            this.lblPartij.Location = new System.Drawing.Point(552, 11);
            this.lblPartij.Name = "lblPartij";
            this.lblPartij.Size = new System.Drawing.Size(88, 13);
            this.lblPartij.TabIndex = 5;
            this.lblPartij.Text = "Partij Toevoegen";
            // 
            // tbLijsttrekker
            // 
            this.tbLijsttrekker.Location = new System.Drawing.Point(510, 59);
            this.tbLijsttrekker.Name = "tbLijsttrekker";
            this.tbLijsttrekker.Size = new System.Drawing.Size(187, 20);
            this.tbLijsttrekker.TabIndex = 4;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(510, 33);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(187, 20);
            this.tbNaam.TabIndex = 3;
            // 
            // lblPartijLijsttrekker
            // 
            this.lblPartijLijsttrekker.AutoSize = true;
            this.lblPartijLijsttrekker.Location = new System.Drawing.Point(443, 62);
            this.lblPartijLijsttrekker.Name = "lblPartijLijsttrekker";
            this.lblPartijLijsttrekker.Size = new System.Drawing.Size(61, 13);
            this.lblPartijLijsttrekker.TabIndex = 2;
            this.lblPartijLijsttrekker.Text = "Lijsttrekker:";
            // 
            // lblPartijNaam
            // 
            this.lblPartijNaam.AutoSize = true;
            this.lblPartijNaam.Location = new System.Drawing.Point(466, 36);
            this.lblPartijNaam.Name = "lblPartijNaam";
            this.lblPartijNaam.Size = new System.Drawing.Size(38, 13);
            this.lblPartijNaam.TabIndex = 1;
            this.lblPartijNaam.Text = "Naam:";
            // 
            // btnPartijToevoegen
            // 
            this.btnPartijToevoegen.Location = new System.Drawing.Point(570, 85);
            this.btnPartijToevoegen.Name = "btnPartijToevoegen";
            this.btnPartijToevoegen.Size = new System.Drawing.Size(127, 23);
            this.btnPartijToevoegen.TabIndex = 0;
            this.btnPartijToevoegen.Text = "Partij Toevoegen";
            this.btnPartijToevoegen.UseVisualStyleBackColor = true;
            // 
            // uitslagBindingSource1
            // 
            this.uitslagBindingSource1.DataSource = typeof(LPProject.Models.Uitslag);
            // 
            // stemmenBindingSource
            // 
            this.stemmenBindingSource.DataMember = "Stemmen";
            this.stemmenBindingSource.DataSource = this.uitslagBindingSource1;
            // 
            // partijBindingSource
            // 
            this.partijBindingSource.DataSource = typeof(LPProject.Models.Partij);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // naamDataGridViewTextBoxColumn1
            // 
            this.naamDataGridViewTextBoxColumn1.DataPropertyName = "Naam";
            this.naamDataGridViewTextBoxColumn1.HeaderText = "Naam";
            this.naamDataGridViewTextBoxColumn1.Name = "naamDataGridViewTextBoxColumn1";
            // 
            // lijsttrekkerDataGridViewTextBoxColumn
            // 
            this.lijsttrekkerDataGridViewTextBoxColumn.DataPropertyName = "Lijsttrekker";
            this.lijsttrekkerDataGridViewTextBoxColumn.HeaderText = "Lijsttrekker";
            this.lijsttrekkerDataGridViewTextBoxColumn.Name = "lijsttrekkerDataGridViewTextBoxColumn";
            // 
            // Stemmen
            // 
            this.Stemmen.HeaderText = "Stemmen";
            this.Stemmen.Name = "Stemmen";
            // 
            // LivePerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.tcHoofd);
            this.Controls.Add(this.MSMenu);
            this.MainMenuStrip = this.MSMenu;
            this.MinimumSize = new System.Drawing.Size(800, 560);
            this.Name = "LivePerformance";
            this.Text = "Live Performance";
            this.MSMenu.ResumeLayout(false);
            this.MSMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUitslagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uitslagBindingSource)).EndInit();
            this.tcHoofd.ResumeLayout(false);
            this.Verkiezingsuitslagen.ResumeLayout(false);
            this.Partijen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPartijen)).EndInit();
            this.Coalities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCoalities)).EndInit();
            this.GeselecteerdeUitslag.ResumeLayout(false);
            this.GeselecteerdeUitslag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Toevoegen.ResumeLayout(false);
            this.Toevoegen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uitslagBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stemmenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partijBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSMenu;
        private System.Windows.Forms.ToolStripMenuItem verkiezingsuitslagenToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGVUitslagen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tcHoofd;
        private System.Windows.Forms.TabPage Verkiezingsuitslagen;
        private System.Windows.Forms.TabPage Partijen;
        private System.Windows.Forms.DataGridView DGVPartijen;
        private System.Windows.Forms.TabPage Coalities;
        private System.Windows.Forms.DataGridView DGVCoalities;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripMenuItem fetchDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporteerCoalitieToolStripMenuItem;
        private System.Windows.Forms.TabPage GeselecteerdeUitslag;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblSoort;
        private System.Windows.Forms.Button btnVerwijderPartij;
        private System.Windows.Forms.Button btnCoalitieVormen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabPage Toevoegen;
        private System.Windows.Forms.TextBox tbLijsttrekker;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Label lblPartijLijsttrekker;
        private System.Windows.Forms.Label lblPartijNaam;
        private System.Windows.Forms.Button btnPartijToevoegen;
        private System.Windows.Forms.Label lblUitslagToevoegen;
        private System.Windows.Forms.Label lblPartij;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox LBAllePartijen;
        private System.Windows.Forms.Button btnUitslagAfronden;
        private System.Windows.Forms.ListBox lbPartijenInUitslag;
        private System.Windows.Forms.Button btnToevoegenAanUitslag;
        private System.Windows.Forms.Label lblAantalStemmen;
        private System.Windows.Forms.DateTimePicker dtpDatumUitslag;
        private System.Windows.Forms.Label lblDatumUitslag;
        private System.Windows.Forms.Label lblNaamUitslag;
        private System.Windows.Forms.TextBox tbNaamUitslag;
        private System.Windows.Forms.BindingSource uitslagBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soortDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uitslagBindingSource1;
        private System.Windows.Forms.BindingSource stemmenBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naamDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lijsttrekkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stemmen;
        private System.Windows.Forms.BindingSource partijBindingSource;
    }
}

