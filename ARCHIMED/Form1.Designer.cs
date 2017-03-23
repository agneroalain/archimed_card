using System;

namespace ARCHIMED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_suiv_grp1 = new System.Windows.Forms.Button();
            this.txt_nat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dat_naiss = new System.Windows.Forms.DateTimePicker();
            this.txt_lieu_naiss = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_prec_grp2 = new System.Windows.Forms.Button();
            this.bt_suiv_grp2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_pre_grp3 = new System.Windows.Forms.Button();
            this.bt_term_grp3 = new System.Windows.Forms.Button();
            this.inserer_svp = new System.Windows.Forms.Label();
            this.groupSynth = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupSynth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.bt_suiv_grp1);
            this.groupBox1.Controls.Add(this.txt_nat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dat_naiss);
            this.groupBox1.Controls.Add(this.txt_lieu_naiss);
            this.groupBox1.Controls.Add(this.txt_prenom);
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(9, 269);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(291, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IDENTITE";
            // 
            // bt_suiv_grp1
            // 
            this.bt_suiv_grp1.BackColor = System.Drawing.Color.DimGray;
            this.bt_suiv_grp1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_suiv_grp1.Location = new System.Drawing.Point(193, 206);
            this.bt_suiv_grp1.Name = "bt_suiv_grp1";
            this.bt_suiv_grp1.Size = new System.Drawing.Size(75, 23);
            this.bt_suiv_grp1.TabIndex = 5;
            this.bt_suiv_grp1.Text = "Suivant";
            this.bt_suiv_grp1.UseVisualStyleBackColor = false;
            this.bt_suiv_grp1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nat
            // 
            this.txt_nat.Location = new System.Drawing.Point(123, 131);
            this.txt_nat.Name = "txt_nat";
            this.txt_nat.Size = new System.Drawing.Size(145, 20);
            this.txt_nat.TabIndex = 4;
            this.txt_nat.TextChanged += new System.EventHandler(this.txt_nat_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightYellow;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(36, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nationnalité :";
            // 
            // dat_naiss
            // 
            this.dat_naiss.Location = new System.Drawing.Point(123, 78);
            this.dat_naiss.Name = "dat_naiss";
            this.dat_naiss.Size = new System.Drawing.Size(145, 20);
            this.dat_naiss.TabIndex = 2;
            // 
            // txt_lieu_naiss
            // 
            this.txt_lieu_naiss.Location = new System.Drawing.Point(123, 104);
            this.txt_lieu_naiss.Name = "txt_lieu_naiss";
            this.txt_lieu_naiss.Size = new System.Drawing.Size(145, 20);
            this.txt_lieu_naiss.TabIndex = 3;
            this.txt_lieu_naiss.TextChanged += new System.EventHandler(this.txt_lieu_naiss_TextChanged);
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(123, 52);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(145, 20);
            this.txt_prenom.TabIndex = 1;
            this.txt_prenom.TextChanged += new System.EventHandler(this.txt_prenom_TextChanged);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(123, 27);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(145, 20);
            this.txt_nom.TabIndex = 0;
            this.txt_nom.TextChanged += new System.EventHandler(this.txt_nom_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightYellow;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(6, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lieu de naissance :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightYellow;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de naissance :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightYellow;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(56, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightYellow;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(70, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.bt_prec_grp2);
            this.groupBox2.Controls.Add(this.bt_suiv_grp2);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txt_num1);
            this.groupBox2.Controls.Add(this.txt_num2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_mail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_dom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(744, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 249);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTACTS - ADRESSE";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // bt_prec_grp2
            // 
            this.bt_prec_grp2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bt_prec_grp2.BackColor = System.Drawing.Color.DimGray;
            this.bt_prec_grp2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_prec_grp2.Location = new System.Drawing.Point(126, 206);
            this.bt_prec_grp2.Name = "bt_prec_grp2";
            this.bt_prec_grp2.Size = new System.Drawing.Size(75, 23);
            this.bt_prec_grp2.TabIndex = 13;
            this.bt_prec_grp2.Text = "Precedent";
            this.bt_prec_grp2.UseVisualStyleBackColor = false;
            this.bt_prec_grp2.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_suiv_grp2
            // 
            this.bt_suiv_grp2.BackColor = System.Drawing.Color.DimGray;
            this.bt_suiv_grp2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_suiv_grp2.Location = new System.Drawing.Point(207, 206);
            this.bt_suiv_grp2.Name = "bt_suiv_grp2";
            this.bt_suiv_grp2.Size = new System.Drawing.Size(75, 23);
            this.bt_suiv_grp2.TabIndex = 12;
            this.bt_suiv_grp2.Text = "Suivant";
            this.bt_suiv_grp2.UseVisualStyleBackColor = false;
            this.bt_suiv_grp2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(137, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(137, 104);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(145, 20);
            this.txt_num1.TabIndex = 9;
            this.txt_num1.TextChanged += new System.EventHandler(this.txt_num1_TextChanged);
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(137, 131);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(145, 20);
            this.txt_num2.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightYellow;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(14, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Numéro téléphone 2 :";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(137, 157);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(145, 20);
            this.txt_mail.TabIndex = 11;
            this.txt_mail.TextChanged += new System.EventHandler(this.txt_mail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightYellow;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(51, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adresse mail :";
            // 
            // txt_dom
            // 
            this.txt_dom.Location = new System.Drawing.Point(137, 78);
            this.txt_dom.Name = "txt_dom";
            this.txt_dom.Size = new System.Drawing.Size(145, 20);
            this.txt_dom.TabIndex = 8;
            this.txt_dom.TextChanged += new System.EventHandler(this.txt_dom_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightYellow;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(14, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Numéro téléphone 1 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightYellow;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(31, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Adresse domicile :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightYellow;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(91, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ville :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightYellow;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(87, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pays :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.txt_file);
            this.groupBox3.Controls.Add(this.lbl_info);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.bt_pre_grp3);
            this.groupBox3.Controls.Add(this.bt_term_grp3);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(398, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 236);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PHOTO";
            // 
            // txt_file
            // 
            this.txt_file.Location = new System.Drawing.Point(35, 153);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(101, 20);
            this.txt_file.TabIndex = 24;
            // 
            // button6
            // 
            this.button6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(22, 176);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "Importer une photo";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 110);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // bt_pre_grp3
            // 
            this.bt_pre_grp3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bt_pre_grp3.BackColor = System.Drawing.Color.DimGray;
            this.bt_pre_grp3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_pre_grp3.Location = new System.Drawing.Point(10, 206);
            this.bt_pre_grp3.Name = "bt_pre_grp3";
            this.bt_pre_grp3.Size = new System.Drawing.Size(75, 23);
            this.bt_pre_grp3.TabIndex = 21;
            this.bt_pre_grp3.Text = "Precedent";
            this.bt_pre_grp3.UseVisualStyleBackColor = false;
            this.bt_pre_grp3.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_term_grp3
            // 
            this.bt_term_grp3.BackColor = System.Drawing.Color.DimGray;
            this.bt_term_grp3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_term_grp3.Location = new System.Drawing.Point(91, 206);
            this.bt_term_grp3.Name = "bt_term_grp3";
            this.bt_term_grp3.Size = new System.Drawing.Size(75, 23);
            this.bt_term_grp3.TabIndex = 20;
            this.bt_term_grp3.Text = "Terminé";
            this.bt_term_grp3.UseVisualStyleBackColor = false;
            this.bt_term_grp3.Click += new System.EventHandler(this.bt_term_grp3_Click);
            // 
            // inserer_svp
            // 
            this.inserer_svp.AutoSize = true;
            this.inserer_svp.BackColor = System.Drawing.Color.Transparent;
            this.inserer_svp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inserer_svp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inserer_svp.Location = new System.Drawing.Point(44, 180);
            this.inserer_svp.Name = "inserer_svp";
            this.inserer_svp.Size = new System.Drawing.Size(337, 22);
            this.inserer_svp.TabIndex = 23;
            this.inserer_svp.Text = "Veuillez inserer une clé ARCHIMED svp !";
            // 
            // groupSynth
            // 
            this.groupSynth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupSynth.BackgroundImage")));
            this.groupSynth.Controls.Add(this.button1);
            this.groupSynth.Controls.Add(this.label15);
            this.groupSynth.Controls.Add(this.label14);
            this.groupSynth.Controls.Add(this.label13);
            this.groupSynth.Controls.Add(this.label12);
            this.groupSynth.Controls.Add(this.pictureBox2);
            this.groupSynth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupSynth.Location = new System.Drawing.Point(788, 6);
            this.groupSynth.Name = "groupSynth";
            this.groupSynth.Size = new System.Drawing.Size(306, 246);
            this.groupSynth.TabIndex = 24;
            this.groupSynth.TabStop = false;
            this.groupSynth.Text = "NFORMATION";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(221, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Confirmer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Ivory;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(7, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Domicile : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Ivory;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(7, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Date de naissance :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Ivory;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(7, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Prenom : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Ivory;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(7, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nom : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(25, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 116);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_info.Location = new System.Drawing.Point(151, 3);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(366, 264);
            this.lbl_info.TabIndex = 23;
            this.lbl_info.Text = resources.GetString("lbl_info.Text");
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(445, 81);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(242, 253);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1088, 569);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupSynth);
            this.Controls.Add(this.inserer_svp);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupSynth.ResumeLayout(false);
            this.groupSynth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dat_naiss;
        private System.Windows.Forms.TextBox txt_lieu_naiss;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_dom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_suiv_grp1;
        private System.Windows.Forms.Button bt_prec_grp2;
        private System.Windows.Forms.Button bt_suiv_grp2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_pre_grp3;
        private System.Windows.Forms.Button bt_term_grp3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private EventHandler groupBox1_Enter;
        private EventHandler groupBox2_Enter;
        private EventHandler textBox5_TextChanged;
        private EventHandler label5_Click;
        private EventHandler label9_Click;
        private EventHandler groupBox3_Enter;
        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.Label inserer_svp;
        private System.Windows.Forms.GroupBox groupSynth;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.PictureBox pictureBox3;
        //public EventHandler Form1_Load { get; private set; }
    }
}

