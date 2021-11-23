namespace Facture
{
    partial class AddUserProduct
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
            this.lbl_Ref = new System.Windows.Forms.Label();
            this.txt_Reference = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Qte = new System.Windows.Forms.TextBox();
            this.lbl_Quantité = new System.Windows.Forms.Label();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.txt_Fullname = new System.Windows.Forms.TextBox();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.btn_Gener = new System.Windows.Forms.Button();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.factureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_reset = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Ref
            // 
            this.lbl_Ref.AutoSize = true;
            this.lbl_Ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ref.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Ref.Location = new System.Drawing.Point(12, 407);
            this.lbl_Ref.Name = "lbl_Ref";
            this.lbl_Ref.Size = new System.Drawing.Size(266, 29);
            this.lbl_Ref.TabIndex = 0;
            this.lbl_Ref.Text = "Reference du produit ";
            // 
            // txt_Reference
            // 
            this.txt_Reference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reference.Location = new System.Drawing.Point(17, 448);
            this.txt_Reference.Name = "txt_Reference";
            this.txt_Reference.Size = new System.Drawing.Size(337, 30);
            this.txt_Reference.TabIndex = 1;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(17, 524);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(337, 30);
            this.txt_Name.TabIndex = 3;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Name.Location = new System.Drawing.Point(12, 487);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(193, 29);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Nom du produit";
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(17, 604);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(337, 30);
            this.txt_Price.TabIndex = 5;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_price.Location = new System.Drawing.Point(12, 567);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(183, 29);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Prix du produit";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Save.Location = new System.Drawing.Point(18, 648);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(263, 33);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Enregistrer";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Qte
            // 
            this.txt_Qte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qte.Location = new System.Drawing.Point(430, 448);
            this.txt_Qte.Name = "txt_Qte";
            this.txt_Qte.Size = new System.Drawing.Size(169, 30);
            this.txt_Qte.TabIndex = 8;
            // 
            // lbl_Quantité
            // 
            this.lbl_Quantité.AutoSize = true;
            this.lbl_Quantité.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantité.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Quantité.Location = new System.Drawing.Point(425, 407);
            this.lbl_Quantité.Name = "lbl_Quantité";
            this.lbl_Quantité.Size = new System.Drawing.Size(111, 29);
            this.lbl_Quantité.TabIndex = 7;
            this.lbl_Quantité.Text = "Quantité";
            // 
            // txt_Tel
            // 
            this.txt_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tel.Location = new System.Drawing.Point(430, 604);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(337, 30);
            this.txt_Tel.TabIndex = 12;
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Tel.Location = new System.Drawing.Point(425, 567);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(246, 29);
            this.lbl_Tel.TabIndex = 11;
            this.lbl_Tel.Text = "Telephone du client";
            // 
            // txt_Fullname
            // 
            this.txt_Fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fullname.Location = new System.Drawing.Point(430, 524);
            this.txt_Fullname.Name = "txt_Fullname";
            this.txt_Fullname.Size = new System.Drawing.Size(337, 30);
            this.txt_Fullname.TabIndex = 10;
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Nom.Location = new System.Drawing.Point(425, 487);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(174, 29);
            this.lbl_Nom.TabIndex = 9;
            this.lbl_Nom.Text = "Nom du client";
            // 
            // btn_Gener
            // 
            this.btn_Gener.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gener.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Gener.Location = new System.Drawing.Point(487, 648);
            this.btn_Gener.Name = "btn_Gener";
            this.btn_Gener.Size = new System.Drawing.Size(263, 33);
            this.btn_Gener.TabIndex = 13;
            this.btn_Gener.Text = "Generer Facture";
            this.btn_Gener.UseVisualStyleBackColor = true;
            this.btn_Gener.Click += new System.EventHandler(this.btn_Gener_Click);
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(628, 448);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(169, 30);
            this.txt_Total.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(623, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total :";
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_reset.Location = new System.Drawing.Point(318, 648);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(141, 33);
            this.btn_reset.TabIndex = 18;
            this.btn_reset.Text = "Annuler";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(784, 376);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Reference";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom produit";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prix";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantité";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            // 
            // AddUserProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 696);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Gener);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.lbl_Tel);
            this.Controls.Add(this.txt_Fullname);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.txt_Qte);
            this.Controls.Add(this.lbl_Quantité);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txt_Reference);
            this.Controls.Add(this.lbl_Ref);
            this.Name = "AddUserProduct";
            this.Text = "Produit";
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ref;
        private System.Windows.Forms.TextBox txt_Reference;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Qte;
        private System.Windows.Forms.Label lbl_Quantité;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.Label lbl_Tel;
        private System.Windows.Forms.TextBox txt_Fullname;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.Button btn_Gener;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.BindingSource factureBindingSource;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

