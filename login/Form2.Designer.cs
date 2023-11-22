namespace login
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelUmur = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNama = new System.Windows.Forms.TextBox();
            this.textUmur = new System.Windows.Forms.TextBox();
            this.textAsal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.apertureScience = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(334, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // labelUmur
            // 
            this.labelUmur.AutoSize = true;
            this.labelUmur.BackColor = System.Drawing.Color.White;
            this.labelUmur.Location = new System.Drawing.Point(334, 136);
            this.labelUmur.Name = "labelUmur";
            this.labelUmur.Size = new System.Drawing.Size(64, 30);
            this.labelUmur.TabIndex = 1;
            this.labelUmur.Text = "Umur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(334, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asal";
            // 
            // textNama
            // 
            this.textNama.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textNama.Location = new System.Drawing.Point(442, 88);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(323, 35);
            this.textNama.TabIndex = 3;
            // 
            // textUmur
            // 
            this.textUmur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textUmur.Location = new System.Drawing.Point(442, 136);
            this.textUmur.Name = "textUmur";
            this.textUmur.Size = new System.Drawing.Size(323, 35);
            this.textUmur.TabIndex = 4;
            // 
            // textAsal
            // 
            this.textAsal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textAsal.Location = new System.Drawing.Point(442, 187);
            this.textAsal.Name = "textAsal";
            this.textAsal.Size = new System.Drawing.Size(323, 35);
            this.textAsal.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(266, 305);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(978, 339);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(441, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(805, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selamat Datang, Kerja Lembur!";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Brown;
            this.editButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(606, 240);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(159, 42);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textId.Location = new System.Drawing.Point(442, 41);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(323, 35);
            this.textId.TabIndex = 11;
            // 
            // apertureScience
            // 
            this.apertureScience.AutoSize = true;
            this.apertureScience.BackColor = System.Drawing.Color.White;
            this.apertureScience.Location = new System.Drawing.Point(334, 41);
            this.apertureScience.Name = "apertureScience";
            this.apertureScience.Size = new System.Drawing.Size(31, 30);
            this.apertureScience.TabIndex = 10;
            this.apertureScience.Text = "Id";
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchBox.Location = new System.Drawing.Point(889, 68);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(223, 35);
            this.searchBox.TabIndex = 12;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.BackColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(814, 71);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(49, 30);
            this.search.TabIndex = 13;
            this.search.Text = "Cari";
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.Brown;
            this.delButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delButton.ForeColor = System.Drawing.Color.White;
            this.delButton.Location = new System.Drawing.Point(889, 116);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(159, 40);
            this.delButton.TabIndex = 14;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // Form2
            // 
            this.BackgroundImage = global::login.Properties.Resources.TV___11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1256, 656);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUmur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNama);
            this.Controls.Add(this.textUmur);
            this.Controls.Add(this.textAsal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.apertureScience);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.search);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelUmur;
        private Label label3;
        private TextBox textNama;
        private TextBox textUmur;
        private TextBox textAsal;
        protected DataGridView dataGridView1;
        private Button button1;
        private Label label2;
        private Button editButton;
        private TextBox textId;
        private Label apertureScience;
        private TextBox searchBox;
        private Label search;
        private Button delButton;
    }
}