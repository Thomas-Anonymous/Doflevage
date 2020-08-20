namespace Doflevage {
    partial class Form1 {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.pan_gest = new System.Windows.Forms.Panel();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pseudo = new System.Windows.Forms.TextBox();
            this.list_race = new System.Windows.Forms.ComboBox();
            this.list_sexe = new System.Windows.Forms.ComboBox();
            this.nbr_lvl = new System.Windows.Forms.NumericUpDown();
            this.nbr_reprosMax = new System.Windows.Forms.NumericUpDown();
            this.nbr_reposActu = new System.Windows.Forms.NumericUpDown();
            this.list_amour = new System.Windows.Forms.ComboBox();
            this.list_maturite = new System.Windows.Forms.ComboBox();
            this.list_endurance = new System.Windows.Forms.ComboBox();
            this.chk_sauvage = new System.Windows.Forms.CheckBox();
            this.chk_pure = new System.Windows.Forms.CheckBox();
            this.chk_came = new System.Windows.Forms.CheckBox();
            this.chk_parcho = new System.Windows.Forms.CheckBox();
            this.chk_feconde = new System.Windows.Forms.CheckBox();
            this.chk_enclos = new System.Windows.Forms.CheckBox();
            this.nbr_gesta = new System.Windows.Forms.NumericUpDown();
            this.list_mere = new System.Windows.Forms.ComboBox();
            this.list_pere = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list_capa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label15 = new System.Windows.Forms.Label();
            this.list_enclos = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.pan_gest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_lvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_reprosMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_reposActu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_gesta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(971, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "Gestion";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "Gestion";
            // 
            // pan_gest
            // 
            this.pan_gest.Controls.Add(this.listView1);
            this.pan_gest.Controls.Add(this.button1);
            this.pan_gest.Controls.Add(this.groupBox4);
            this.pan_gest.Controls.Add(this.groupBox2);
            this.pan_gest.Controls.Add(this.groupBox1);
            this.pan_gest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_gest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pan_gest.Location = new System.Drawing.Point(0, 25);
            this.pan_gest.Name = "pan_gest";
            this.pan_gest.Size = new System.Drawing.Size(971, 544);
            this.pan_gest.TabIndex = 1;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(75, 20);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(173, 21);
            this.txt_nom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pseudo";
            // 
            // txt_pseudo
            // 
            this.txt_pseudo.Location = new System.Drawing.Point(75, 47);
            this.txt_pseudo.Name = "txt_pseudo";
            this.txt_pseudo.Size = new System.Drawing.Size(173, 21);
            this.txt_pseudo.TabIndex = 2;
            // 
            // list_race
            // 
            this.list_race.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_race.FormattingEnabled = true;
            this.list_race.Location = new System.Drawing.Point(77, 74);
            this.list_race.Name = "list_race";
            this.list_race.Size = new System.Drawing.Size(171, 23);
            this.list_race.TabIndex = 4;
            // 
            // list_sexe
            // 
            this.list_sexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_sexe.FormattingEnabled = true;
            this.list_sexe.Location = new System.Drawing.Point(77, 103);
            this.list_sexe.Name = "list_sexe";
            this.list_sexe.Size = new System.Drawing.Size(171, 23);
            this.list_sexe.TabIndex = 5;
            // 
            // nbr_lvl
            // 
            this.nbr_lvl.Location = new System.Drawing.Point(77, 132);
            this.nbr_lvl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbr_lvl.Name = "nbr_lvl";
            this.nbr_lvl.Size = new System.Drawing.Size(58, 21);
            this.nbr_lvl.TabIndex = 6;
            this.nbr_lvl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nbr_reprosMax
            // 
            this.nbr_reprosMax.Location = new System.Drawing.Point(165, 51);
            this.nbr_reprosMax.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nbr_reprosMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbr_reprosMax.Name = "nbr_reprosMax";
            this.nbr_reprosMax.Size = new System.Drawing.Size(52, 21);
            this.nbr_reprosMax.TabIndex = 7;
            this.nbr_reprosMax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nbr_reposActu
            // 
            this.nbr_reposActu.Location = new System.Drawing.Point(165, 21);
            this.nbr_reposActu.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nbr_reposActu.Name = "nbr_reposActu";
            this.nbr_reposActu.Size = new System.Drawing.Size(52, 21);
            this.nbr_reposActu.TabIndex = 7;
            // 
            // list_amour
            // 
            this.list_amour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_amour.FormattingEnabled = true;
            this.list_amour.Location = new System.Drawing.Point(135, 79);
            this.list_amour.Name = "list_amour";
            this.list_amour.Size = new System.Drawing.Size(97, 23);
            this.list_amour.TabIndex = 8;
            // 
            // list_maturite
            // 
            this.list_maturite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_maturite.FormattingEnabled = true;
            this.list_maturite.Location = new System.Drawing.Point(135, 108);
            this.list_maturite.Name = "list_maturite";
            this.list_maturite.Size = new System.Drawing.Size(97, 23);
            this.list_maturite.TabIndex = 9;
            // 
            // list_endurance
            // 
            this.list_endurance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_endurance.FormattingEnabled = true;
            this.list_endurance.Location = new System.Drawing.Point(135, 137);
            this.list_endurance.Name = "list_endurance";
            this.list_endurance.Size = new System.Drawing.Size(97, 23);
            this.list_endurance.TabIndex = 10;
            // 
            // chk_sauvage
            // 
            this.chk_sauvage.AutoSize = true;
            this.chk_sauvage.Location = new System.Drawing.Point(13, 27);
            this.chk_sauvage.Name = "chk_sauvage";
            this.chk_sauvage.Size = new System.Drawing.Size(81, 19);
            this.chk_sauvage.TabIndex = 11;
            this.chk_sauvage.Text = "Sauvage";
            this.chk_sauvage.UseVisualStyleBackColor = true;
            // 
            // chk_pure
            // 
            this.chk_pure.AutoSize = true;
            this.chk_pure.Location = new System.Drawing.Point(13, 52);
            this.chk_pure.Name = "chk_pure";
            this.chk_pure.Size = new System.Drawing.Size(56, 19);
            this.chk_pure.TabIndex = 12;
            this.chk_pure.Text = "Pure";
            this.chk_pure.UseVisualStyleBackColor = true;
            // 
            // chk_came
            // 
            this.chk_came.AutoSize = true;
            this.chk_came.Location = new System.Drawing.Point(13, 77);
            this.chk_came.Name = "chk_came";
            this.chk_came.Size = new System.Drawing.Size(91, 19);
            this.chk_came.TabIndex = 13;
            this.chk_came.Text = "Caméléon";
            this.chk_came.UseVisualStyleBackColor = true;
            // 
            // chk_parcho
            // 
            this.chk_parcho.AutoSize = true;
            this.chk_parcho.Location = new System.Drawing.Point(13, 102);
            this.chk_parcho.Name = "chk_parcho";
            this.chk_parcho.Size = new System.Drawing.Size(71, 19);
            this.chk_parcho.TabIndex = 14;
            this.chk_parcho.Text = "Parcho";
            this.chk_parcho.UseVisualStyleBackColor = true;
            // 
            // chk_feconde
            // 
            this.chk_feconde.AutoSize = true;
            this.chk_feconde.Location = new System.Drawing.Point(13, 127);
            this.chk_feconde.Name = "chk_feconde";
            this.chk_feconde.Size = new System.Drawing.Size(81, 19);
            this.chk_feconde.TabIndex = 15;
            this.chk_feconde.Text = "Féconde";
            this.chk_feconde.UseVisualStyleBackColor = true;
            // 
            // chk_enclos
            // 
            this.chk_enclos.AutoSize = true;
            this.chk_enclos.Location = new System.Drawing.Point(13, 152);
            this.chk_enclos.Name = "chk_enclos";
            this.chk_enclos.Size = new System.Drawing.Size(89, 19);
            this.chk_enclos.TabIndex = 16;
            this.chk_enclos.Text = "En enclos";
            this.chk_enclos.UseVisualStyleBackColor = true;
            // 
            // nbr_gesta
            // 
            this.nbr_gesta.Location = new System.Drawing.Point(184, 166);
            this.nbr_gesta.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nbr_gesta.Name = "nbr_gesta";
            this.nbr_gesta.Size = new System.Drawing.Size(61, 21);
            this.nbr_gesta.TabIndex = 17;
            // 
            // list_mere
            // 
            this.list_mere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_mere.FormattingEnabled = true;
            this.list_mere.Location = new System.Drawing.Point(77, 234);
            this.list_mere.Name = "list_mere";
            this.list_mere.Size = new System.Drawing.Size(171, 23);
            this.list_mere.TabIndex = 18;
            // 
            // list_pere
            // 
            this.list_pere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_pere.FormattingEnabled = true;
            this.list_pere.Location = new System.Drawing.Point(77, 263);
            this.list_pere.Name = "list_pere";
            this.list_pere.Size = new System.Drawing.Size(171, 23);
            this.list_pere.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_pseudo);
            this.groupBox1.Controls.Add(this.list_sexe);
            this.groupBox1.Controls.Add(this.nbr_lvl);
            this.groupBox1.Controls.Add(this.list_race);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 172);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infos";
            // 
            // list_capa
            // 
            this.list_capa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_capa.FormattingEnabled = true;
            this.list_capa.Location = new System.Drawing.Point(86, 203);
            this.list_capa.Name = "list_capa";
            this.list_capa.Size = new System.Drawing.Size(162, 23);
            this.list_capa.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Race";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nbr_gesta);
            this.groupBox2.Controls.Add(this.list_amour);
            this.groupBox2.Controls.Add(this.list_maturite);
            this.groupBox2.Controls.Add(this.nbr_reposActu);
            this.groupBox2.Controls.Add(this.list_endurance);
            this.groupBox2.Controls.Add(this.nbr_reprosMax);
            this.groupBox2.Location = new System.Drawing.Point(272, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 198);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.list_enclos);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.list_mere);
            this.groupBox4.Controls.Add(this.list_capa);
            this.groupBox4.Controls.Add(this.list_pere);
            this.groupBox4.Controls.Add(this.chk_sauvage);
            this.groupBox4.Controls.Add(this.chk_came);
            this.groupBox4.Controls.Add(this.chk_pure);
            this.groupBox4.Controls.Add(this.chk_parcho);
            this.groupBox4.Controls.Add(this.chk_feconde);
            this.groupBox4.Controls.Add(this.chk_enclos);
            this.groupBox4.Location = new System.Drawing.Point(12, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 297);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Détails";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sexe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Niveau";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Capacités";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Reproductions actuel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Reproductions max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Niveau amour";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Niveau maturité";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Niveau endurance";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Heures gestation restante";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Parent 1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = "Parent 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 32);
            this.button1.TabIndex = 24;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(542, 8);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(417, 533);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nom";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Race";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sexe";
            this.columnHeader3.Width = 124;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 15);
            this.label15.TabIndex = 23;
            this.label15.Text = "Enclos";
            // 
            // list_enclos
            // 
            this.list_enclos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list_enclos.FormattingEnabled = true;
            this.list_enclos.Location = new System.Drawing.Point(67, 174);
            this.list_enclos.Name = "list_enclos";
            this.list_enclos.Size = new System.Drawing.Size(181, 23);
            this.list_enclos.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(971, 569);
            this.Controls.Add(this.pan_gest);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Doflevage";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pan_gest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbr_lvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_reprosMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_reposActu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_gesta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel pan_gest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox list_pere;
        private System.Windows.Forms.ComboBox list_mere;
        private System.Windows.Forms.NumericUpDown nbr_gesta;
        private System.Windows.Forms.CheckBox chk_enclos;
        private System.Windows.Forms.CheckBox chk_feconde;
        private System.Windows.Forms.CheckBox chk_parcho;
        private System.Windows.Forms.CheckBox chk_came;
        private System.Windows.Forms.CheckBox chk_pure;
        private System.Windows.Forms.CheckBox chk_sauvage;
        private System.Windows.Forms.ComboBox list_endurance;
        private System.Windows.Forms.ComboBox list_maturite;
        private System.Windows.Forms.ComboBox list_amour;
        private System.Windows.Forms.NumericUpDown nbr_reposActu;
        private System.Windows.Forms.NumericUpDown nbr_reprosMax;
        private System.Windows.Forms.NumericUpDown nbr_lvl;
        private System.Windows.Forms.ComboBox list_sexe;
        private System.Windows.Forms.ComboBox list_race;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pseudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox list_capa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox list_enclos;
        private System.Windows.Forms.Label label15;
    }
}

