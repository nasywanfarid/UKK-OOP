
namespace Farid_Betamart
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
            this.components = new System.ComponentModel.Container();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.betamartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new Farid_Betamart.AppData();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEntryDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.betamartTableAdapter = new Farid_Betamart.AppDataTableAdapters.betamartTableAdapter();
            this.betamartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betamartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.BackColor = System.Drawing.Color.Gold;
            this.btnChoosePicture.Location = new System.Drawing.Point(181, 75);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(140, 36);
            this.btnChoosePicture.TabIndex = 0;
            this.btnChoosePicture.Text = "Choose Picture";
            this.btnChoosePicture.UseVisualStyleBackColor = false;
            this.btnChoosePicture.Click += new System.EventHandler(this.btnChoosePicture_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.entryDateDataGridViewTextBoxColumn,
            this.expiredDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dataGridView.DataSource = this.betamartBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(564, 128);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(743, 461);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.Width = 70;
            // 
            // entryDateDataGridViewTextBoxColumn
            // 
            this.entryDateDataGridViewTextBoxColumn.DataPropertyName = "Entry Date";
            this.entryDateDataGridViewTextBoxColumn.HeaderText = "Entry Date";
            this.entryDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.entryDateDataGridViewTextBoxColumn.Name = "entryDateDataGridViewTextBoxColumn";
            this.entryDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // expiredDataGridViewTextBoxColumn
            // 
            this.expiredDataGridViewTextBoxColumn.DataPropertyName = "Expired";
            this.expiredDataGridViewTextBoxColumn.HeaderText = "Expired";
            this.expiredDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.expiredDataGridViewTextBoxColumn.Name = "expiredDataGridViewTextBoxColumn";
            this.expiredDataGridViewTextBoxColumn.Width = 150;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.MinimumWidth = 8;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Width = 200;
            // 
            // betamartBindingSource
            // 
            this.betamartBindingSource.DataMember = "betamart";
            this.betamartBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name :";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.textBox1);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.txtEntryDate);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.txtStock);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txtProductPrice);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtProductName);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.btnChoosePicture);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(12, 86);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(546, 461);
            this.panel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betamartBindingSource, "Expired", true));
            this.textBox1.Location = new System.Drawing.Point(138, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 26);
            this.textBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Expired :";
            // 
            // txtEntryDate
            // 
            this.txtEntryDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betamartBindingSource, "Entry Date", true));
            this.txtEntryDate.Location = new System.Drawing.Point(138, 350);
            this.txtEntryDate.Name = "txtEntryDate";
            this.txtEntryDate.Size = new System.Drawing.Size(401, 26);
            this.txtEntryDate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Entry Date :";
            // 
            // txtStock
            // 
            this.txtStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betamartBindingSource, "Stock", true));
            this.txtStock.Location = new System.Drawing.Point(138, 300);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(401, 26);
            this.txtStock.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stock :";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betamartBindingSource, "ProductPrice", true));
            this.txtProductPrice.Location = new System.Drawing.Point(138, 249);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(401, 26);
            this.txtProductPrice.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Price :";
            // 
            // txtProductName
            // 
            this.txtProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betamartBindingSource, "ProductName", true));
            this.txtProductName.Location = new System.Drawing.Point(138, 198);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(401, 26);
            this.txtProductName.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.GhostWhite;
            this.btnNew.Location = new System.Drawing.Point(12, 553);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(132, 36);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.GhostWhite;
            this.btnEdit.Location = new System.Drawing.Point(150, 553);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 36);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCancel.Location = new System.Drawing.Point(288, 553);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSave.Location = new System.Drawing.Point(426, 553);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // betamartTableAdapter
            // 
            this.betamartTableAdapter.ClearBeforeFill = true;
            // 
            // betamartBindingSource1
            // 
            this.betamartBindingSource1.DataMember = "betamart";
            this.betamartBindingSource1.DataSource = this.appData;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.betamartBindingSource, "Image", true));
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(172, 172);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Farid_Betamart.Properties.Resources.cooltext397786460232362;
            this.panel1.Location = new System.Drawing.Point(646, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 110);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(1319, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Betamart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betamartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChoosePicture;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEntryDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private AppData appData;
        private System.Windows.Forms.BindingSource betamartBindingSource;
        private AppDataTableAdapters.betamartTableAdapter betamartTableAdapter;
        private System.Windows.Forms.BindingSource betamartBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

