namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            kodyPocztoweGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kodPocztowyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            miejscowoscDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            wojewodztwoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            powiatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uwagiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            localizationsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kodyPocztoweBindingSource = new BindingSource(components);
            localizationsGridView = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kodyPocztoweIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kodyPocztoweDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            localizationBindingSource = new BindingSource(components);
            searchGroupBox = new GroupBox();
            powiatLabel = new Label();
            wojewodztwoLabel = new Label();
            miejscowoscLabel = new Label();
            adresLabel = new Label();
            searchButton = new Button();
            powiatTextBox = new TextBox();
            wojewodztwoTextBox = new TextBox();
            miejscowoscTextBox = new TextBox();
            adresTextBox = new TextBox();
            kodPocztowyLabel = new Label();
            kodPocztowyTextBox = new TextBox();
            idTextBox = new TextBox();
            idLabel = new Label();
            kodPocztowyChangeGroupBox = new GroupBox();
            changeKodPocztowyPowiatLabel = new Label();
            changeKodPocztowyWojewodtwoLabel = new Label();
            changeKodPocztowyMiejscowoscLabel = new Label();
            changeKodPocztowyAdresLabel = new Label();
            changeKodPocztowyLabel = new Label();
            changeKodPocztowyIdLabel = new Label();
            changesKodPocztowyButton = new Button();
            changeKodPocztowyPowiatTextBox = new TextBox();
            changeKodPocztowyWojewodztwoTextBox = new TextBox();
            changeKodPocztowyMiejscowoscTextBox = new TextBox();
            changeKodPocztowyAdresTextBox = new TextBox();
            changeKodPocztowyTextBox = new TextBox();
            changeKodPocztowyIdTextBox = new TextBox();
            localizationChangeGroupBox = new GroupBox();
            changeLocalizationKodPocztowyIdLabel = new Label();
            changeLocalizationIdLabel = new Label();
            changeLocalizationDescriptionLabel = new Label();
            changeLocalizationNameLabel = new Label();
            changesLocalizationButton = new Button();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            kodPocztowyDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            adresDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            miejscowoscDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            wojewodztwoDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            powiatDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            uwagiDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            localizationsDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            kodyPocztoweSearchedBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            kodyPocztoweIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            kodyPocztoweDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            localizationSearchedBindingSource = new BindingSource(components);
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)kodyPocztoweGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kodyPocztoweBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)localizationsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)localizationBindingSource).BeginInit();
            searchGroupBox.SuspendLayout();
            kodPocztowyChangeGroupBox.SuspendLayout();
            localizationChangeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kodyPocztoweSearchedBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)localizationSearchedBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Data from Database";
            // 
            // kodyPocztoweGridView
            // 
            kodyPocztoweGridView.AllowUserToAddRows = false;
            kodyPocztoweGridView.AllowUserToDeleteRows = false;
            kodyPocztoweGridView.AutoGenerateColumns = false;
            kodyPocztoweGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kodyPocztoweGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, kodPocztowyDataGridViewTextBoxColumn, adresDataGridViewTextBoxColumn, miejscowoscDataGridViewTextBoxColumn, wojewodztwoDataGridViewTextBoxColumn, powiatDataGridViewTextBoxColumn, uwagiDataGridViewTextBoxColumn, localizationsDataGridViewTextBoxColumn });
            kodyPocztoweGridView.DataSource = kodyPocztoweBindingSource;
            kodyPocztoweGridView.Location = new Point(12, 27);
            kodyPocztoweGridView.Name = "kodyPocztoweGridView";
            kodyPocztoweGridView.ReadOnly = true;
            kodyPocztoweGridView.RowTemplate.Height = 25;
            kodyPocztoweGridView.Size = new Size(744, 193);
            kodyPocztoweGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodPocztowyDataGridViewTextBoxColumn
            // 
            kodPocztowyDataGridViewTextBoxColumn.DataPropertyName = "KodPocztowy";
            kodPocztowyDataGridViewTextBoxColumn.HeaderText = "KodPocztowy";
            kodPocztowyDataGridViewTextBoxColumn.Name = "kodPocztowyDataGridViewTextBoxColumn";
            kodPocztowyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            adresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // miejscowoscDataGridViewTextBoxColumn
            // 
            miejscowoscDataGridViewTextBoxColumn.DataPropertyName = "Miejscowosc";
            miejscowoscDataGridViewTextBoxColumn.HeaderText = "Miejscowosc";
            miejscowoscDataGridViewTextBoxColumn.Name = "miejscowoscDataGridViewTextBoxColumn";
            miejscowoscDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wojewodztwoDataGridViewTextBoxColumn
            // 
            wojewodztwoDataGridViewTextBoxColumn.DataPropertyName = "Wojewodztwo";
            wojewodztwoDataGridViewTextBoxColumn.HeaderText = "Wojewodztwo";
            wojewodztwoDataGridViewTextBoxColumn.Name = "wojewodztwoDataGridViewTextBoxColumn";
            wojewodztwoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // powiatDataGridViewTextBoxColumn
            // 
            powiatDataGridViewTextBoxColumn.DataPropertyName = "Powiat";
            powiatDataGridViewTextBoxColumn.HeaderText = "Powiat";
            powiatDataGridViewTextBoxColumn.Name = "powiatDataGridViewTextBoxColumn";
            powiatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uwagiDataGridViewTextBoxColumn
            // 
            uwagiDataGridViewTextBoxColumn.DataPropertyName = "Uwagi";
            uwagiDataGridViewTextBoxColumn.HeaderText = "Uwagi";
            uwagiDataGridViewTextBoxColumn.Name = "uwagiDataGridViewTextBoxColumn";
            uwagiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localizationsDataGridViewTextBoxColumn
            // 
            localizationsDataGridViewTextBoxColumn.DataPropertyName = "Localizations";
            localizationsDataGridViewTextBoxColumn.HeaderText = "Localizations";
            localizationsDataGridViewTextBoxColumn.Name = "localizationsDataGridViewTextBoxColumn";
            localizationsDataGridViewTextBoxColumn.ReadOnly = true;
            localizationsDataGridViewTextBoxColumn.Visible = false;
            // 
            // kodyPocztoweBindingSource
            // 
            kodyPocztoweBindingSource.DataSource = typeof(Models.KodyPocztowe);
            // 
            // localizationsGridView
            // 
            localizationsGridView.AllowUserToAddRows = false;
            localizationsGridView.AllowUserToDeleteRows = false;
            localizationsGridView.AutoGenerateColumns = false;
            localizationsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            localizationsGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, kodyPocztoweIdDataGridViewTextBoxColumn, kodyPocztoweDataGridViewTextBoxColumn });
            localizationsGridView.DataSource = localizationBindingSource;
            localizationsGridView.Location = new Point(773, 27);
            localizationsGridView.Name = "localizationsGridView";
            localizationsGridView.ReadOnly = true;
            localizationsGridView.RowTemplate.Height = 25;
            localizationsGridView.Size = new Size(445, 193);
            localizationsGridView.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodyPocztoweIdDataGridViewTextBoxColumn
            // 
            kodyPocztoweIdDataGridViewTextBoxColumn.DataPropertyName = "KodyPocztoweId";
            kodyPocztoweIdDataGridViewTextBoxColumn.HeaderText = "KodyPocztoweId";
            kodyPocztoweIdDataGridViewTextBoxColumn.Name = "kodyPocztoweIdDataGridViewTextBoxColumn";
            kodyPocztoweIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodyPocztoweDataGridViewTextBoxColumn
            // 
            kodyPocztoweDataGridViewTextBoxColumn.DataPropertyName = "KodyPocztowe";
            kodyPocztoweDataGridViewTextBoxColumn.HeaderText = "KodyPocztowe";
            kodyPocztoweDataGridViewTextBoxColumn.Name = "kodyPocztoweDataGridViewTextBoxColumn";
            kodyPocztoweDataGridViewTextBoxColumn.ReadOnly = true;
            kodyPocztoweDataGridViewTextBoxColumn.Visible = false;
            // 
            // localizationBindingSource
            // 
            localizationBindingSource.DataSource = typeof(Models.Localization);
            // 
            // searchGroupBox
            // 
            searchGroupBox.Controls.Add(powiatLabel);
            searchGroupBox.Controls.Add(wojewodztwoLabel);
            searchGroupBox.Controls.Add(miejscowoscLabel);
            searchGroupBox.Controls.Add(adresLabel);
            searchGroupBox.Controls.Add(searchButton);
            searchGroupBox.Controls.Add(powiatTextBox);
            searchGroupBox.Controls.Add(wojewodztwoTextBox);
            searchGroupBox.Controls.Add(miejscowoscTextBox);
            searchGroupBox.Controls.Add(adresTextBox);
            searchGroupBox.Controls.Add(kodPocztowyLabel);
            searchGroupBox.Controls.Add(kodPocztowyTextBox);
            searchGroupBox.Controls.Add(idTextBox);
            searchGroupBox.Controls.Add(idLabel);
            searchGroupBox.Location = new Point(12, 226);
            searchGroupBox.Name = "searchGroupBox";
            searchGroupBox.Size = new Size(372, 250);
            searchGroupBox.TabIndex = 3;
            searchGroupBox.TabStop = false;
            searchGroupBox.Text = "Search Box";
            // 
            // powiatLabel
            // 
            powiatLabel.AutoSize = true;
            powiatLabel.Location = new Point(197, 147);
            powiatLabel.Name = "powiatLabel";
            powiatLabel.Size = new Size(43, 15);
            powiatLabel.TabIndex = 12;
            powiatLabel.Text = "Powiat";
            // 
            // wojewodztwoLabel
            // 
            wojewodztwoLabel.AutoSize = true;
            wojewodztwoLabel.Location = new Point(197, 91);
            wojewodztwoLabel.Name = "wojewodztwoLabel";
            wojewodztwoLabel.Size = new Size(82, 15);
            wojewodztwoLabel.TabIndex = 11;
            wojewodztwoLabel.Text = "Wojewodztwo";
            // 
            // miejscowoscLabel
            // 
            miejscowoscLabel.AutoSize = true;
            miejscowoscLabel.Location = new Point(197, 28);
            miejscowoscLabel.Name = "miejscowoscLabel";
            miejscowoscLabel.Size = new Size(75, 15);
            miejscowoscLabel.TabIndex = 10;
            miejscowoscLabel.Text = "Miejscowosc";
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Location = new Point(6, 147);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new Size(37, 15);
            adresLabel.TabIndex = 9;
            adresLabel.Text = "Adres";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(125, 215);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(117, 23);
            searchButton.TabIndex = 8;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // powiatTextBox
            // 
            powiatTextBox.Location = new Point(197, 165);
            powiatTextBox.Name = "powiatTextBox";
            powiatTextBox.Size = new Size(163, 23);
            powiatTextBox.TabIndex = 7;
            // 
            // wojewodztwoTextBox
            // 
            wojewodztwoTextBox.Location = new Point(197, 109);
            wojewodztwoTextBox.Name = "wojewodztwoTextBox";
            wojewodztwoTextBox.Size = new Size(163, 23);
            wojewodztwoTextBox.TabIndex = 6;
            // 
            // miejscowoscTextBox
            // 
            miejscowoscTextBox.Location = new Point(197, 46);
            miejscowoscTextBox.Name = "miejscowoscTextBox";
            miejscowoscTextBox.Size = new Size(163, 23);
            miejscowoscTextBox.TabIndex = 5;
            // 
            // adresTextBox
            // 
            adresTextBox.Location = new Point(6, 165);
            adresTextBox.Name = "adresTextBox";
            adresTextBox.Size = new Size(163, 23);
            adresTextBox.TabIndex = 4;
            // 
            // kodPocztowyLabel
            // 
            kodPocztowyLabel.AutoSize = true;
            kodPocztowyLabel.Location = new Point(6, 91);
            kodPocztowyLabel.Name = "kodPocztowyLabel";
            kodPocztowyLabel.Size = new Size(82, 15);
            kodPocztowyLabel.TabIndex = 3;
            kodPocztowyLabel.Text = "Kod pocztowy";
            // 
            // kodPocztowyTextBox
            // 
            kodPocztowyTextBox.Location = new Point(6, 109);
            kodPocztowyTextBox.Name = "kodPocztowyTextBox";
            kodPocztowyTextBox.Size = new Size(163, 23);
            kodPocztowyTextBox.TabIndex = 2;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(6, 46);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(163, 23);
            idTextBox.TabIndex = 1;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(6, 28);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id";
            // 
            // kodPocztowyChangeGroupBox
            // 
            kodPocztowyChangeGroupBox.Controls.Add(changeKodPocztowyPowiatLabel);
            kodPocztowyChangeGroupBox.Controls.Add(changeKodPocztowyWojewodtwoLabel);
            kodPocztowyChangeGroupBox.Controls.Add(changeKodPocztowyMiejscowoscLabel);
            kodPocztowyChangeGroupBox.Controls.Add(changeKodPocztowyAdresLabel);
            kodPocztowyChangeGroupBox.Controls.Add(changeKodPocztowyLabel);
            kodPocztowyChangeGroupBox.Controls.Add(changeKodPocztowyIdLabel);
            kodPocztowyChangeGroupBox.Controls.Add(changesKodPocztowyButton);
            kodPocztowyChangeGroupBox.Controls.Add(changeKodPocztowyPowiatTextBox);
            kodPocztowyChangeGroupBox.Controls.Add(changeKodPocztowyWojewodztwoTextBox);
            kodPocztowyChangeGroupBox.Controls.Add(changeKodPocztowyMiejscowoscTextBox);
            kodPocztowyChangeGroupBox.Controls.Add(changeKodPocztowyAdresTextBox);
            kodPocztowyChangeGroupBox.Controls.Add(changeKodPocztowyTextBox);
            kodPocztowyChangeGroupBox.Controls.Add(changeKodPocztowyIdTextBox);
            kodPocztowyChangeGroupBox.Location = new Point(419, 232);
            kodPocztowyChangeGroupBox.Name = "kodPocztowyChangeGroupBox";
            kodPocztowyChangeGroupBox.Size = new Size(383, 244);
            kodPocztowyChangeGroupBox.TabIndex = 4;
            kodPocztowyChangeGroupBox.TabStop = false;
            kodPocztowyChangeGroupBox.Text = "Kod Pocztowy Change Box";
            // 
            // changeKodPocztowyPowiatLabel
            // 
            changeKodPocztowyPowiatLabel.AutoSize = true;
            changeKodPocztowyPowiatLabel.Location = new Point(207, 141);
            changeKodPocztowyPowiatLabel.Name = "changeKodPocztowyPowiatLabel";
            changeKodPocztowyPowiatLabel.Size = new Size(43, 15);
            changeKodPocztowyPowiatLabel.TabIndex = 12;
            changeKodPocztowyPowiatLabel.Text = "Powiat";
            // 
            // changeKodPocztowyWojewodtwoLabel
            // 
            changeKodPocztowyWojewodtwoLabel.AutoSize = true;
            changeKodPocztowyWojewodtwoLabel.Location = new Point(207, 85);
            changeKodPocztowyWojewodtwoLabel.Name = "changeKodPocztowyWojewodtwoLabel";
            changeKodPocztowyWojewodtwoLabel.Size = new Size(82, 15);
            changeKodPocztowyWojewodtwoLabel.TabIndex = 11;
            changeKodPocztowyWojewodtwoLabel.Text = "Wojewodztwo";
            // 
            // changeKodPocztowyMiejscowoscLabel
            // 
            changeKodPocztowyMiejscowoscLabel.AutoSize = true;
            changeKodPocztowyMiejscowoscLabel.Location = new Point(207, 22);
            changeKodPocztowyMiejscowoscLabel.Name = "changeKodPocztowyMiejscowoscLabel";
            changeKodPocztowyMiejscowoscLabel.Size = new Size(75, 15);
            changeKodPocztowyMiejscowoscLabel.TabIndex = 10;
            changeKodPocztowyMiejscowoscLabel.Text = "Miejscowosc";
            // 
            // changeKodPocztowyAdresLabel
            // 
            changeKodPocztowyAdresLabel.AutoSize = true;
            changeKodPocztowyAdresLabel.Location = new Point(6, 141);
            changeKodPocztowyAdresLabel.Name = "changeKodPocztowyAdresLabel";
            changeKodPocztowyAdresLabel.Size = new Size(37, 15);
            changeKodPocztowyAdresLabel.TabIndex = 9;
            changeKodPocztowyAdresLabel.Text = "Adres";
            // 
            // changeKodPocztowyLabel
            // 
            changeKodPocztowyLabel.AutoSize = true;
            changeKodPocztowyLabel.Location = new Point(6, 85);
            changeKodPocztowyLabel.Name = "changeKodPocztowyLabel";
            changeKodPocztowyLabel.Size = new Size(82, 15);
            changeKodPocztowyLabel.TabIndex = 8;
            changeKodPocztowyLabel.Text = "Kod Pocztowy";
            // 
            // changeKodPocztowyIdLabel
            // 
            changeKodPocztowyIdLabel.AutoSize = true;
            changeKodPocztowyIdLabel.Location = new Point(6, 22);
            changeKodPocztowyIdLabel.Name = "changeKodPocztowyIdLabel";
            changeKodPocztowyIdLabel.Size = new Size(17, 15);
            changeKodPocztowyIdLabel.TabIndex = 7;
            changeKodPocztowyIdLabel.Text = "Id";
            // 
            // changesKodPocztowyButton
            // 
            changesKodPocztowyButton.Location = new Point(129, 209);
            changesKodPocztowyButton.Name = "changesKodPocztowyButton";
            changesKodPocztowyButton.Size = new Size(132, 23);
            changesKodPocztowyButton.TabIndex = 6;
            changesKodPocztowyButton.Text = "Apply Changes";
            changesKodPocztowyButton.UseVisualStyleBackColor = true;
            // 
            // changeKodPocztowyPowiatTextBox
            // 
            changeKodPocztowyPowiatTextBox.Location = new Point(207, 159);
            changeKodPocztowyPowiatTextBox.Name = "changeKodPocztowyPowiatTextBox";
            changeKodPocztowyPowiatTextBox.Size = new Size(170, 23);
            changeKodPocztowyPowiatTextBox.TabIndex = 5;
            // 
            // changeKodPocztowyWojewodztwoTextBox
            // 
            changeKodPocztowyWojewodztwoTextBox.Location = new Point(207, 103);
            changeKodPocztowyWojewodztwoTextBox.Name = "changeKodPocztowyWojewodztwoTextBox";
            changeKodPocztowyWojewodztwoTextBox.Size = new Size(170, 23);
            changeKodPocztowyWojewodztwoTextBox.TabIndex = 4;
            // 
            // changeKodPocztowyMiejscowoscTextBox
            // 
            changeKodPocztowyMiejscowoscTextBox.Location = new Point(207, 40);
            changeKodPocztowyMiejscowoscTextBox.Name = "changeKodPocztowyMiejscowoscTextBox";
            changeKodPocztowyMiejscowoscTextBox.Size = new Size(170, 23);
            changeKodPocztowyMiejscowoscTextBox.TabIndex = 3;
            // 
            // changeKodPocztowyAdresTextBox
            // 
            changeKodPocztowyAdresTextBox.Location = new Point(6, 159);
            changeKodPocztowyAdresTextBox.Name = "changeKodPocztowyAdresTextBox";
            changeKodPocztowyAdresTextBox.Size = new Size(170, 23);
            changeKodPocztowyAdresTextBox.TabIndex = 2;
            // 
            // changeKodPocztowyTextBox
            // 
            changeKodPocztowyTextBox.Location = new Point(6, 103);
            changeKodPocztowyTextBox.Name = "changeKodPocztowyTextBox";
            changeKodPocztowyTextBox.Size = new Size(170, 23);
            changeKodPocztowyTextBox.TabIndex = 1;
            // 
            // changeKodPocztowyIdTextBox
            // 
            changeKodPocztowyIdTextBox.Enabled = false;
            changeKodPocztowyIdTextBox.Location = new Point(6, 40);
            changeKodPocztowyIdTextBox.Name = "changeKodPocztowyIdTextBox";
            changeKodPocztowyIdTextBox.Size = new Size(170, 23);
            changeKodPocztowyIdTextBox.TabIndex = 0;
            // 
            // localizationChangeGroupBox
            // 
            localizationChangeGroupBox.Controls.Add(changeLocalizationKodPocztowyIdLabel);
            localizationChangeGroupBox.Controls.Add(changeLocalizationIdLabel);
            localizationChangeGroupBox.Controls.Add(changeLocalizationDescriptionLabel);
            localizationChangeGroupBox.Controls.Add(changeLocalizationNameLabel);
            localizationChangeGroupBox.Controls.Add(changesLocalizationButton);
            localizationChangeGroupBox.Controls.Add(textBox10);
            localizationChangeGroupBox.Controls.Add(textBox9);
            localizationChangeGroupBox.Controls.Add(textBox8);
            localizationChangeGroupBox.Controls.Add(textBox7);
            localizationChangeGroupBox.Location = new Point(829, 232);
            localizationChangeGroupBox.Name = "localizationChangeGroupBox";
            localizationChangeGroupBox.Size = new Size(387, 244);
            localizationChangeGroupBox.TabIndex = 5;
            localizationChangeGroupBox.TabStop = false;
            localizationChangeGroupBox.Text = "Localization Change Box";
            // 
            // changeLocalizationKodPocztowyIdLabel
            // 
            changeLocalizationKodPocztowyIdLabel.AutoSize = true;
            changeLocalizationKodPocztowyIdLabel.Location = new Point(194, 19);
            changeLocalizationKodPocztowyIdLabel.Name = "changeLocalizationKodPocztowyIdLabel";
            changeLocalizationKodPocztowyIdLabel.Size = new Size(95, 15);
            changeLocalizationKodPocztowyIdLabel.TabIndex = 8;
            changeLocalizationKodPocztowyIdLabel.Text = "Kod pocztowy Id";
            // 
            // changeLocalizationIdLabel
            // 
            changeLocalizationIdLabel.AutoSize = true;
            changeLocalizationIdLabel.Location = new Point(6, 22);
            changeLocalizationIdLabel.Name = "changeLocalizationIdLabel";
            changeLocalizationIdLabel.Size = new Size(17, 15);
            changeLocalizationIdLabel.TabIndex = 7;
            changeLocalizationIdLabel.Text = "Id";
            // 
            // changeLocalizationDescriptionLabel
            // 
            changeLocalizationDescriptionLabel.AutoSize = true;
            changeLocalizationDescriptionLabel.Location = new Point(6, 141);
            changeLocalizationDescriptionLabel.Name = "changeLocalizationDescriptionLabel";
            changeLocalizationDescriptionLabel.Size = new Size(67, 15);
            changeLocalizationDescriptionLabel.TabIndex = 6;
            changeLocalizationDescriptionLabel.Text = "Description";
            // 
            // changeLocalizationNameLabel
            // 
            changeLocalizationNameLabel.AutoSize = true;
            changeLocalizationNameLabel.Location = new Point(6, 85);
            changeLocalizationNameLabel.Name = "changeLocalizationNameLabel";
            changeLocalizationNameLabel.Size = new Size(39, 15);
            changeLocalizationNameLabel.TabIndex = 5;
            changeLocalizationNameLabel.Text = "Name";
            // 
            // changesLocalizationButton
            // 
            changesLocalizationButton.Location = new Point(123, 209);
            changesLocalizationButton.Name = "changesLocalizationButton";
            changesLocalizationButton.Size = new Size(135, 23);
            changesLocalizationButton.TabIndex = 4;
            changesLocalizationButton.Text = "Apply Changes";
            changesLocalizationButton.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(194, 40);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(187, 23);
            textBox10.TabIndex = 3;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(6, 159);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(375, 23);
            textBox9.TabIndex = 2;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(6, 103);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(375, 23);
            textBox8.TabIndex = 1;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(6, 40);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(155, 23);
            textBox7.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, kodPocztowyDataGridViewTextBoxColumn1, adresDataGridViewTextBoxColumn1, miejscowoscDataGridViewTextBoxColumn1, wojewodztwoDataGridViewTextBoxColumn1, powiatDataGridViewTextBoxColumn1, uwagiDataGridViewTextBoxColumn1, localizationsDataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = kodyPocztoweSearchedBindingSource;
            dataGridView1.Location = new Point(12, 508);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(744, 274);
            dataGridView1.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn2.HeaderText = "Id";
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // kodPocztowyDataGridViewTextBoxColumn1
            // 
            kodPocztowyDataGridViewTextBoxColumn1.DataPropertyName = "KodPocztowy";
            kodPocztowyDataGridViewTextBoxColumn1.HeaderText = "KodPocztowy";
            kodPocztowyDataGridViewTextBoxColumn1.Name = "kodPocztowyDataGridViewTextBoxColumn1";
            kodPocztowyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn1
            // 
            adresDataGridViewTextBoxColumn1.DataPropertyName = "Adres";
            adresDataGridViewTextBoxColumn1.HeaderText = "Adres";
            adresDataGridViewTextBoxColumn1.Name = "adresDataGridViewTextBoxColumn1";
            adresDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // miejscowoscDataGridViewTextBoxColumn1
            // 
            miejscowoscDataGridViewTextBoxColumn1.DataPropertyName = "Miejscowosc";
            miejscowoscDataGridViewTextBoxColumn1.HeaderText = "Miejscowosc";
            miejscowoscDataGridViewTextBoxColumn1.Name = "miejscowoscDataGridViewTextBoxColumn1";
            miejscowoscDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // wojewodztwoDataGridViewTextBoxColumn1
            // 
            wojewodztwoDataGridViewTextBoxColumn1.DataPropertyName = "Wojewodztwo";
            wojewodztwoDataGridViewTextBoxColumn1.HeaderText = "Wojewodztwo";
            wojewodztwoDataGridViewTextBoxColumn1.Name = "wojewodztwoDataGridViewTextBoxColumn1";
            wojewodztwoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // powiatDataGridViewTextBoxColumn1
            // 
            powiatDataGridViewTextBoxColumn1.DataPropertyName = "Powiat";
            powiatDataGridViewTextBoxColumn1.HeaderText = "Powiat";
            powiatDataGridViewTextBoxColumn1.Name = "powiatDataGridViewTextBoxColumn1";
            powiatDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // uwagiDataGridViewTextBoxColumn1
            // 
            uwagiDataGridViewTextBoxColumn1.DataPropertyName = "Uwagi";
            uwagiDataGridViewTextBoxColumn1.HeaderText = "Uwagi";
            uwagiDataGridViewTextBoxColumn1.Name = "uwagiDataGridViewTextBoxColumn1";
            uwagiDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // localizationsDataGridViewTextBoxColumn1
            // 
            localizationsDataGridViewTextBoxColumn1.DataPropertyName = "Localizations";
            localizationsDataGridViewTextBoxColumn1.HeaderText = "Localizations";
            localizationsDataGridViewTextBoxColumn1.Name = "localizationsDataGridViewTextBoxColumn1";
            localizationsDataGridViewTextBoxColumn1.ReadOnly = true;
            localizationsDataGridViewTextBoxColumn1.Visible = false;
            // 
            // kodyPocztoweSearchedBindingSource
            // 
            kodyPocztoweSearchedBindingSource.DataSource = typeof(Models.KodyPocztowe);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 490);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 7;
            label2.Text = "Search Result";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(773, 9);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 8;
            label3.Text = "Data from Database";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn3, nameDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn1, kodyPocztoweIdDataGridViewTextBoxColumn1, kodyPocztoweDataGridViewTextBoxColumn1 });
            dataGridView2.DataSource = localizationSearchedBindingSource;
            dataGridView2.Location = new Point(773, 508);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(443, 274);
            dataGridView2.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn3.HeaderText = "Id";
            idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            idDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kodyPocztoweIdDataGridViewTextBoxColumn1
            // 
            kodyPocztoweIdDataGridViewTextBoxColumn1.DataPropertyName = "KodyPocztoweId";
            kodyPocztoweIdDataGridViewTextBoxColumn1.HeaderText = "KodyPocztoweId";
            kodyPocztoweIdDataGridViewTextBoxColumn1.Name = "kodyPocztoweIdDataGridViewTextBoxColumn1";
            kodyPocztoweIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kodyPocztoweDataGridViewTextBoxColumn1
            // 
            kodyPocztoweDataGridViewTextBoxColumn1.DataPropertyName = "KodyPocztowe";
            kodyPocztoweDataGridViewTextBoxColumn1.HeaderText = "KodyPocztowe";
            kodyPocztoweDataGridViewTextBoxColumn1.Name = "kodyPocztoweDataGridViewTextBoxColumn1";
            kodyPocztoweDataGridViewTextBoxColumn1.ReadOnly = true;
            kodyPocztoweDataGridViewTextBoxColumn1.Visible = false;
            // 
            // localizationSearchedBindingSource
            // 
            localizationSearchedBindingSource.DataSource = typeof(Models.Localization);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(773, 490);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 10;
            label4.Text = "Search Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 794);
            Controls.Add(label4);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(localizationChangeGroupBox);
            Controls.Add(kodPocztowyChangeGroupBox);
            Controls.Add(searchGroupBox);
            Controls.Add(localizationsGridView);
            Controls.Add(kodyPocztoweGridView);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)kodyPocztoweGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)kodyPocztoweBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)localizationsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)localizationBindingSource).EndInit();
            searchGroupBox.ResumeLayout(false);
            searchGroupBox.PerformLayout();
            kodPocztowyChangeGroupBox.ResumeLayout(false);
            kodPocztowyChangeGroupBox.PerformLayout();
            localizationChangeGroupBox.ResumeLayout(false);
            localizationChangeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kodyPocztoweSearchedBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)localizationSearchedBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView kodyPocztoweGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kodPocztowyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wojewodztwoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn powiatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uwagiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn localizationsDataGridViewTextBoxColumn;
        private BindingSource kodyPocztoweBindingSource;
        private DataGridView localizationsGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kodyPocztoweIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kodyPocztoweDataGridViewTextBoxColumn;
        private BindingSource localizationBindingSource;
        private GroupBox searchGroupBox;
        private Label powiatLabel;
        private Label wojewodztwoLabel;
        private Label miejscowoscLabel;
        private Label adresLabel;
        private Button searchButton;
        private TextBox powiatTextBox;
        private TextBox wojewodztwoTextBox;
        private TextBox miejscowoscTextBox;
        private TextBox adresTextBox;
        private Label kodPocztowyLabel;
        private TextBox kodPocztowyTextBox;
        private TextBox idTextBox;
        private Label idLabel;
        private GroupBox kodPocztowyChangeGroupBox;
        private Button changesKodPocztowyButton;
        private TextBox changeKodPocztowyPowiatTextBox;
        private TextBox changeKodPocztowyWojewodztwoTextBox;
        private TextBox changeKodPocztowyMiejscowoscTextBox;
        private TextBox changeKodPocztowyAdresTextBox;
        private TextBox changeKodPocztowyTextBox;
        private TextBox changeKodPocztowyIdTextBox;
        private GroupBox localizationChangeGroupBox;
        private Button changesLocalizationButton;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label changeKodPocztowyPowiatLabel;
        private Label changeKodPocztowyWojewodtwoLabel;
        private Label changeKodPocztowyMiejscowoscLabel;
        private Label changeKodPocztowyAdresLabel;
        private Label changeKodPocztowyLabel;
        private Label changeKodPocztowyIdLabel;
        private Label changeLocalizationKodPocztowyIdLabel;
        private Label changeLocalizationIdLabel;
        private Label changeLocalizationDescriptionLabel;
        private Label changeLocalizationNameLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn kodPocztowyDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn miejscowoscDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn wojewodztwoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn powiatDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn uwagiDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn localizationsDataGridViewTextBoxColumn1;
        private BindingSource kodyPocztoweSearchedBindingSource;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn kodyPocztoweIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn kodyPocztoweDataGridViewTextBoxColumn1;
        private BindingSource localizationSearchedBindingSource;
        private Label label4;
    }
}