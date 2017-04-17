using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;
using System.Runtime.InteropServices;

namespace ARCHIMED
{
    public partial class Form1 : Form
    {
        //Declaration des variable 
        string DBPath;
        SqlCeConnection conn;
        SqlCeDataAdapter adapter;
        DataTable dtMain;
        //variable detection cle usb 
        private const int WM_DEVICECHANGE = 0x0219;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        private const int DBT_DEVTYP_VOLUME = 0x2;
        private string message;
        char[] letters;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_DEVICECHANGE)
            {
                if (m.WParam.ToInt32() == DBT_DEVICEARRIVAL)
                {
                    // la clé à ete branchée
                    DEV_BROADCAST_HDR hdr = (DEV_BROADCAST_HDR)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_HDR));

                    // ok, le device pluggé est un volume (aussi appelé 'périphérique de stockage de masse')...
                    if (hdr.dbch_devicetype == DBT_DEVTYP_VOLUME)
                    {
                        // ... et donc on recréé une structure, a partir du même pointeur de structure "générique",
                        // une structure un poil plus spécifique
                        DEV_BROADCAST_VOLUME vol = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_VOLUME));
                        // le champs dbcv_unitmask contient la ou les lettres de lecteur du ou des devices qui viennent d'etre pluggé
                        // MSDN nous dit que si le bit 0 est à 1 alors le lecteur est a:, si le bit 1 est à 1 alors le lecteur est b:
                        // et ainsi de suite
                        uint mask = vol.dbcv_unitmask;
                        // recupèration des lettres de lecteurs
                        char[] letters = MaskDepioteur(mask);

                        // mise à jour de l'IHM pour notifier nos petits yeux tout content :)
                        //message = string.Format("USB key plugged on drive {0}:", letters[0].ToString().ToUpper());
                        string verif = letters[0].ToString().ToUpper() + ":\\texto.txt";
                        if (File.Exists(verif))
                        {
                            DialogResult dialogResult = MessageBox.Show("Voulez vous creer un nouveau profil archimed ?", "DETECTION D'UNE CLE ARCHIMEDE", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                groupBox1.Visible = true;
                                inserer_svp.Visible = false;
                                lbl_info.Visible = false;
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                // a analyser 
                            }
                        }
                        /*else
                        {
                            MessageBox.Show("Ceci n'est pas un dispositif ARCHIMED");
                        }*/

                    }
                }
                // le device vient d'etre retirer bourrinement ou proprement
                // (ce message intervient même quand on défait la clef softwarement mais qu'elle reste physiquement branché)
                else if (m.WParam.ToInt32() == DBT_DEVICEREMOVECOMPLETE)
                {
                    // device removed

                    // mise à jour de l'IHM
                    message = "USB key unplugged";
                    //MessageBox.Show(message);
                }
            }
            // laissons notre fenêtre faire tout de même son boulot
            base.WndProc(ref m);
        }

        // fonction d'extraction des lettres de lecteur
        public static char[] MaskDepioteur(uint mask)
        {
            int cnt = 0;
            uint temp_mask = mask;

            // on compte le nombre de bits à 1
            for (int i = 0; i < 32; i++)
            {
                if ((temp_mask & 1) == 1)
                    cnt++;
                temp_mask >>= 1;
                if (temp_mask == 0)
                    break;
            }

            // on instancie le bon nombre d'elements
            char[] result = new char[cnt];
            cnt = 0;
            // on refait mais ce coup ci on attribut
            for (int i = 0; i < 32; i++)
            {
                if ((mask & 1) == 1)
                    result[cnt++] = (char)('a' + i);
                mask >>= 1;
                if (mask == 0)
                    break;
            }

            return (result);
        }


        // Foncion pour le detecteur de USB  ///
        // structure générique
        public struct DEV_BROADCAST_HDR
        {
            public uint dbch_size;
            public uint dbch_devicetype;
            public uint dbch_reserved;
        }

        // structure spécifique
        // notez qu'elle a strictement le même tronche que la générique mais
        // avec des trucs en plus
        public struct DEV_BROADCAST_VOLUME
        {
            public uint dbcv_size;
            public uint dbcv_devicetype;
            public uint dbcv_reserved;
            public uint dbcv_unitmask;
            public ushort dbcv_flags;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            groupBox1.Location=new Point(30, 116);
            groupBox2.Location = new Point(30, 116);
            groupBox3.Location = new Point(100, 116);
            groupSynth.Location = new Point(30, 116);
            this.Size = new Size(711, 434);
            // DBPath =  "Z:\\Database\\bd_archimede.sdf";
            DBPath = Application.StartupPath + "\\bd_archimede.sdf";

            // create db if not exists
            if (!File.Exists(DBPath))
            {
                using (SqlCeEngine se = new SqlCeEngine("Data Source=" + DBPath))
                {
                    se.CreateDatabase();
                    connect_db();
                    create_table();
                    se.Dispose();
                }
            }
            else
            {
                connect_db();
                using (SqlCeCommand com = new SqlCeCommand("DELETE FROM patient", conn))
                {

                    com.ExecuteNonQuery();
                    MessageBox.Show("Base de donnée vidée !");

                    
                }
            }

            connect_db();

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupSynth.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_nom.Text == "")
            {
                txt_nom.BackColor = Color.Red;
                MessageBox.Show("Veuillez renseigner le nom de la personne !");
            }
            else if(txt_prenom.Text == "")
            {
                txt_prenom.BackColor = Color.Red;
                MessageBox.Show("Veuillez renseigner au moins un des prenoms de la personne !");
            }
            else if(dat_naiss.Value == null)
            {
                dat_naiss.BackColor = Color.Red;
                MessageBox.Show("Veuillez renseigner date de naissance de la personne !");
            }
            else if(txt_lieu_naiss.Text == "") 
            {
                txt_lieu_naiss.BackColor = Color.Red;
                MessageBox.Show("Veuillez renseigner le lieu de naissance de la personne !");
            }
            else if (txt_nat.Text == "")
            {
                txt_nat.BackColor = Color.Red;
                MessageBox.Show("Veuillez renseigner la nationnalité de la personne !");
            }else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txt_dom.Text == "")
            {
                txt_dom.BackColor = Color.Red;
                MessageBox.Show("Veuillez renseigner l'adresse du domicile de la personne !");
            }
            else if(txt_num1.Text == "")
            {
                txt_num1.BackColor = Color.Red;
                MessageBox.Show("Veuillez renseigner au moins un numero de téléphone de la personne !");
            }
            else
            {
                groupBox3.Visible = true;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {
            txt_nom.BackColor = Color.White;
        }

        private void txt_prenom_TextChanged(object sender, EventArgs e)
        {
            txt_prenom.BackColor = Color.White;
        }

        private void txt_lieu_naiss_TextChanged(object sender, EventArgs e)
        {
            txt_lieu_naiss.BackColor = Color.White;
        }

        private void txt_nat_TextChanged(object sender, EventArgs e)
        {
            txt_nat.BackColor = Color.White;
        }

        private void txt_dom_TextChanged(object sender, EventArgs e)
        {
            txt_dom.BackColor = Color.White;
        }

        private void txt_num1_TextChanged(object sender, EventArgs e)
        {
            txt_num1.BackColor = Color.White;
        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {
            txt_mail.BackColor = Color.White;
        }

        private void bt_term_grp3_Click(object sender, EventArgs e)
        {

            try
            {
                string matricule = "" + mat_generator();
                //MessageBox.Show("'" + matricule + "', '" + txt_nom.Text + "', '" + txt_prenom.Text + "', NULL, '" + dat_naiss.Value.ToShortDateString() + "', '" + txt_num1.Text + "', '" + txt_num2.Text + "', '" + txt_mail.Text + "', '" + txt_dom.Text + "', 'ville', 'pays', NULL");
                using (SqlCeCommand com = new SqlCeCommand("INSERT INTO patient (matricule, nom, prenom, nomMarital, dateNaissance, telephone, telephoneUrgence, mail, domicile, ville, pays) VALUES ('" + matricule + "', '" + txt_nom.Text + "','" + txt_prenom.Text + "',NULL,'" + dat_naiss.Value + "','" + txt_num1.Text + "','" + txt_num2.Text + "','" + txt_mail.Text + "','" + txt_dom.Text + "','" + comboBox1.SelectedValue + "','" + comboBox1.SelectedValue + "');", conn))
                {
                    
                    com.ExecuteNonQuery();
                    MessageBox.Show("les informations ont bien été enregistrées !");
                    groupSynth.Visible = true;
                    infos();
                    disconnect_db();                    
                }
               
                //SqlCeCommand com = new SqlCeCommand("INSERT INTO patient (id, matricule, nom, prenom, nomMarital, dateNaissance, telephone, telephoneUrgence, mail, domicile, ville, pays, antecedentPatient_id) VALUES (NULL, NULL, " + txt_nom.Text + "," + txt_prenom.Text + ",NULL," + dat_naiss.Value + "," + txt_num1.Text + "," + txt_num2.Text + "," + txt_mail.Text + "," + txt_dom.Text + "," + comboBox1.SelectedValue + "," + comboBox1.SelectedValue + "NULL);", conn);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERREUR : "+ex);
            }            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.CheckPathExists = true;
            dlg.CheckFileExists = true;
            //dlg.Filter = "bmp files (*.bmp)|*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // code si l'utilisateur a bien sélectionner un fichier 
                int ind_ants = dlg.FileName.LastIndexOf("\\");
                int ind_pt = dlg.FileName.LastIndexOf(".");        
                int len = ind_pt - ind_ants;
                txt_file.Text = dlg.FileName.Substring(ind_ants+1, len+3);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(dlg.FileName);
                string subPath = "Z:\\Pictures\\"; 
                bool exists = System.IO.Directory.Exists(subPath);
                if (!exists) System.IO.Directory.CreateDirectory(subPath);
                Image b = Image.FromFile(dlg.FileName);
                string name = "" + mat_generator();
                b.Save(subPath + name + ".jpg");
            }
        }

        void connect_db()
        {
            // connect to db
            conn = new SqlCeConnection("Data Source=" + DBPath);
            try
            {
                conn.Open();
                //MessageBox.Show("connecté");
            }
            catch
            {
                MessageBox.Show("base de donée non connecté ");
            }
        }
        void disconnect_db()
        {
            conn = new SqlCeConnection("Data Source=" + DBPath);
            try
            {
                conn.Close();
                //MessageBox.Show("connecté");
            }
            catch
            {
                MessageBox.Show("base de donée toujours connecté ");
            }
        }
        void create_table()
        {
            // create table "Table 1" if not exists
            try
            {
                using (SqlCeCommand create_patient = new SqlCeCommand("CREATE TABLE [patient] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[matricule] NTEXT,[nom] NTEXT,[prenom] NTEXT,[nomMarital] NTEXT, [dateNaissance] NTEXT,[lieuNaissance] NTEXT,[telephone] NTEXT,[telephoneUrgence] NTEXT,[mail] NTEXT,[domicile] NTEXT,[ville] NTEXT,[pays] NTEXT );", conn))
                {
                    create_patient.ExecuteNonQuery();
                }
                using (SqlCeCommand create_cns = new SqlCeCommand("CREATE TABLE [cns] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[numero] NTEXT,[matriculePatient] NTEXT,[version] NTEXT,[dateCreation] NTEXT,[validite] NTEXT);", conn))
                {
                    create_cns.ExecuteNonQuery();
                }
                using (SqlCeCommand create_pays = new SqlCeCommand("CREATE TABLE [pays] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[nom] NTEXT);", conn))
                {
                    create_pays.ExecuteNonQuery();
                }
                using (SqlCeCommand create_ville = new SqlCeCommand("CREATE TABLE [ville] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[nom] NTEXT, [id_pays] NTEXT);", conn))
                {
                    create_ville.ExecuteNonQuery();
                }
                using (SqlCeCommand create_antecedent = new SqlCeCommand("CREATE TABLE [antecedent] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[param_antecedent_id] NTEXT);", conn))
                {
                    create_antecedent.ExecuteNonQuery();
                }
                using (SqlCeCommand create_assurance = new SqlCeCommand("CREATE TABLE [assurance] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[code] NTEXT,[libelle] NTEXT,[description] NTEXT,[param_regimeAssurance_id] NTEXT);", conn)) 
                {
                    create_assurance.ExecuteNonQuery();
                }
                using (SqlCeCommand create_castraites = new SqlCeCommand("CREATE TABLE [castraites] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[casTraitescol] NTEXT,[param_cas_id] NTEXT,[statutPatient_id] NTEXT);", conn))
                {
                    create_castraites.ExecuteNonQuery();
                }
                using (SqlCeCommand create_documentsmedical = new SqlCeCommand("CREATE TABLE [documentsmedical] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[numero] NTEXT,[visite] NTEXT,[libelle] NTEXT,[description] NTEXT);", conn))
                {
                    create_documentsmedical.ExecuteNonQuery();
                }                
                using (SqlCeCommand create_prescription = new SqlCeCommand("CREATE TABLE [prescriptiondecision] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[numero] NTEXT,[visite] NTEXT,[titre] NTEXT,[libelle] NTEXT,[param_decision_id] NTEXT);", conn))
                {
                    create_prescription.ExecuteNonQuery();
                }
                /*using (SqlCeCommand create_constante = new SqlCeCommand("CREATE TABLE [priseconstante] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[id] NTEXT,[taille] NTEXT,[poids] NTEXT,[temperature] NTEXT);", conn))
                {
                    create_constante.ExecuteNonQuery();
                }*/
                using (SqlCeCommand create_medecin = new SqlCeCommand("CREATE TABLE [medecin] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[matricule] NTEXT,[codeServiceMed] NTEXT,[cachet] NTEXT,[nom] NTEXT,[prenom] NTEXT,[telephone] NTEXT,[param_specialite_id] NTEXT);", conn))
                {
                    create_medecin.ExecuteNonQuery();
                }
                using (SqlCeCommand create_specialite = new SqlCeCommand("CREATE TABLE [specialite] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[libelle] nvarchar(4000),[description] nvarchar(4000));", conn))
                {
                    create_specialite.ExecuteNonQuery(); //PARAM
                }
                using (SqlCeCommand create_statutpatient = new SqlCeCommand("CREATE TABLE [statutpatient] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[libelle] nvarchar(4000),[description] nvarchar(4000));", conn))
                {
                    create_statutpatient.ExecuteNonQuery(); //PARAM
                }
                using (SqlCeCommand create_soins = new SqlCeCommand("CREATE TABLE [soin] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[libelle] nvarchar(4000),[description] nvarchar(4000));", conn))
                {
                    create_soins.ExecuteNonQuery(); //PARAM
                }
                using (SqlCeCommand create_typevisite = new SqlCeCommand("CREATE TABLE [typevisite] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[libelle] nvarchar(4000),[description] nvarchar(4000));", conn))
                {
                    create_typevisite.ExecuteNonQuery();
                }
                using (SqlCeCommand create_visite = new SqlCeCommand("CREATE TABLE [visite] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[numero] nvarchar(4000),[date] nvarchar(4000),[param_typevisite_id] nvarchar(4000),[castraites_id] nvarchar(4000),[param_soins_id] nvarchar(4000),[priseconstante_id] nvarchar(4000),[id_patient] nvarchar(4000), [id_medecin] nvarchar(4000));", conn))
                {
                    create_visite.ExecuteNonQuery();
                }
                /* using (SqlCeCommand create_documentmedical = new SqlCeCommand("CREATE TABLE [documentmedical] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[numero] nvarchar(4000),[numero_visite] nvarchar(4000),[libelle] nvarchar(4000),[description] nvarchar(4000));", conn))
                 {
                     create_documentmedical.ExecuteNonQuery();
                 }
                 using (SqlCeCommand create_prescriptiondecision = new SqlCeCommand("CREATE TABLE [prescriptiondecision] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[numero] nvarchar(4000),[numero_visite] nvarchar(4000),[libele] nvarchar(4000),[detail] nvarchar(4000),[id_decision] nvarchar(4000));", conn))
                 {
                     create_prescriptiondecision.ExecuteNonQuery();
                 }*/
                using (SqlCeCommand create_decision = new SqlCeCommand("CREATE TABLE [decision] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[libelle] nvarchar(4000),[description] nvarchar(4000),[id_typedecision] nvarchar(4000));", conn))
                {
                    create_decision.ExecuteNonQuery();//PARAM
                }
                using (SqlCeCommand create_typedecision = new SqlCeCommand("CREATE TABLE [typedecision] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[libelle] nvarchar(4000),[description] nvarchar(4000));", conn))
                {
                    create_typedecision.ExecuteNonQuery();
                }
                using (SqlCeCommand create_constante = new SqlCeCommand("CREATE TABLE [constante] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[freqCard] nvarchar(4000),[pa] nvarchar(4000),[temperature] nvarchar(4000),[SatOx] nvarchar(4000),[evalDoul] nvarchar(4000),[poids] nvarchar(4000),[taille] nvarchar(4000), [id_infirmier] nvarchar(4000), [id_medecin] nvarchar(4000), [id_patient] nvarchar(4000));", conn))
                {
                    create_constante.ExecuteNonQuery();
                }
                using (SqlCeCommand create_centredesante = new SqlCeCommand("CREATE TABLE [centredesante] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[code] nvarchar(4000),[code_service_medical] nvarchar(4000),[nom] nvarchar(4000),[telephone] nvarchar(4000),[sit_geo] nvarchar(4000));", conn))
                {
                    create_centredesante.ExecuteNonQuery();
                }
                using (SqlCeCommand create_service_medical = new SqlCeCommand("CREATE TABLE [servicemedical] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[code] nvarchar(4000),[libelle] nvarchar(4000),[description] nvarchar(4000));", conn))
                {
                    create_service_medical.ExecuteNonQuery(); //PARAM
                }
                using (SqlCeCommand create_antecedent = new SqlCeCommand("CREATE TABLE [antecedent] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[libelle] nvarchar(4000),[description] nvarchar(4000));", conn))
                {
                    create_antecedent.ExecuteNonQuery(); //PARAM
                }
                using (SqlCeCommand create_type_antecedent = new SqlCeCommand("CREATE TABLE [soin] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[libelle] nvarchar(4000),[description] nvarchar(4000));", conn))
                {
                    create_type_antecedent.ExecuteNonQuery(); //PARAM
                }
                using (SqlCeCommand create_cas = new SqlCeCommand("CREATE TABLE [cas] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[libelle] nvarchar(4000),[description] nvarchar(4000),[id_type_cas] nvarchar(4000));", conn))
                {
                    create_cas.ExecuteNonQuery(); //PARAM
                }
                using (SqlCeCommand create_type_cas = new SqlCeCommand("CREATE TABLE [type_cas] (id INTEGER IDENTITY(1,1) PRIMARY KEY,[libelle] nvarchar(4000),[description] nvarchar(4000));", conn))
                {
                    create_type_cas.ExecuteNonQuery(); //PARAM
                }
            }
            catch
            {
                MessageBox.Show("echec de la creation de la BD");
            }
           
        }

        string mat_generator()
        {
            string mat = "AR";
            using (SqlCeConnection conn = new SqlCeConnection("Data Source=" + DBPath))
            {
                string queryString = "SELECT id FROM patient ORDER BY id DESC";
                SqlCeCommand command = new SqlCeCommand(queryString, conn);
                try
                {
                    conn.Open();
                    SqlCeDataReader reader = command.ExecuteReader();
                    reader.Read();
                    mat += reader[0].ToString();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //mat += DateTime.Today.ToShortDateString();
                mat += DateTime.Now.Minute;
                mat += DateTime.Now.Hour;
                mat += DateTime.Now.Day;
                mat += DateTime.Now.Month;
                mat += txt_nom.Text[0];
                mat += txt_prenom.Text[0];
                mat += DateTime.Now.Year;

                return mat;
            }

        }

        void infos()
        {
            string queryString = "SELECT * FROM patient ORDER BY id DESC";
            SqlCeCommand command = new SqlCeCommand(queryString, conn);
            try
            {
                SqlCeDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    label12.Text += reader["nom"].ToString();
                    label13.Text += reader["prenom"].ToString();
                    label14.Text += reader["dateNaissance"].ToString();
                    label15.Text += reader["domicile"].ToString();
                    pictureBox2.Image = Image.FromFile("Z:\\Pictures\\"+ reader["matricule"] +".jpg"); // remplacer pa le matricule de l'occurence 
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        void copie_db()
        {

            string fileName = "bd_archimede.sdf";
            string sourcePath = Application.StartupPath;
            string targetPath = @"Z:\\Database\\";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
        }

        void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        void button1_Click_1(object sender, EventArgs e)
        {
            disconnect_db();
            copie_db();
            Application.Exit();
        }
    }
}
