
namespace WinFormsMainClient
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBxOutput = new System.Windows.Forms.TextBox();
            this.btnCheckDrinks = new System.Windows.Forms.Button();
            this.grpBxInfo = new System.Windows.Forms.GroupBox();
            this.grpBxAddDrinks = new System.Windows.Forms.GroupBox();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.txtBxCost = new System.Windows.Forms.TextBox();
            this.nmUDAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxDrinkName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDeleteDrinks = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.grpBxSell = new System.Windows.Forms.GroupBox();
            this.btnSellSelected = new System.Windows.Forms.Button();
            this.dGridVDrinks = new System.Windows.Forms.DataGridView();
            this.btnSell2 = new System.Windows.Forms.Button();
            this.btnSell1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxCash = new System.Windows.Forms.TextBox();
            this.btnSetCash = new System.Windows.Forms.Button();
            this.grpBxInfo.SuspendLayout();
            this.grpBxAddDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUDAmount)).BeginInit();
            this.grpBxSell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridVDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "In progress...";
            // 
            // txtBxOutput
            // 
            this.txtBxOutput.Location = new System.Drawing.Point(12, 12);
            this.txtBxOutput.Multiline = true;
            this.txtBxOutput.Name = "txtBxOutput";
            this.txtBxOutput.ReadOnly = true;
            this.txtBxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxOutput.Size = new System.Drawing.Size(540, 260);
            this.txtBxOutput.TabIndex = 3;
            // 
            // btnCheckDrinks
            // 
            this.btnCheckDrinks.Location = new System.Drawing.Point(6, 19);
            this.btnCheckDrinks.Name = "btnCheckDrinks";
            this.btnCheckDrinks.Size = new System.Drawing.Size(90, 21);
            this.btnCheckDrinks.TabIndex = 2;
            this.btnCheckDrinks.Text = "Check Drinks";
            this.btnCheckDrinks.UseVisualStyleBackColor = true;
            this.btnCheckDrinks.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpBxInfo
            // 
            this.grpBxInfo.Controls.Add(this.txtBxCash);
            this.grpBxInfo.Controls.Add(this.grpBxAddDrinks);
            this.grpBxInfo.Controls.Add(this.btnSetCash);
            this.grpBxInfo.Controls.Add(this.btnReset);
            this.grpBxInfo.Controls.Add(this.btnDeleteDrinks);
            this.grpBxInfo.Controls.Add(this.btnStatus);
            this.grpBxInfo.Controls.Add(this.btnCheckDrinks);
            this.grpBxInfo.Location = new System.Drawing.Point(352, 278);
            this.grpBxInfo.Name = "grpBxInfo";
            this.grpBxInfo.Size = new System.Drawing.Size(200, 245);
            this.grpBxInfo.TabIndex = 4;
            this.grpBxInfo.TabStop = false;
            this.grpBxInfo.Text = "Managing";
            // 
            // grpBxAddDrinks
            // 
            this.grpBxAddDrinks.Controls.Add(this.btnAddDrink);
            this.grpBxAddDrinks.Controls.Add(this.label3);
            this.grpBxAddDrinks.Controls.Add(this.label2);
            this.grpBxAddDrinks.Controls.Add(this.label1);
            this.grpBxAddDrinks.Controls.Add(this.txtBxCost);
            this.grpBxAddDrinks.Controls.Add(this.txtBxDrinkName);
            this.grpBxAddDrinks.Controls.Add(this.nmUDAmount);
            this.grpBxAddDrinks.Location = new System.Drawing.Point(6, 112);
            this.grpBxAddDrinks.Name = "grpBxAddDrinks";
            this.grpBxAddDrinks.Size = new System.Drawing.Size(186, 127);
            this.grpBxAddDrinks.TabIndex = 7;
            this.grpBxAddDrinks.TabStop = false;
            this.grpBxAddDrinks.Text = "Add Drinks";
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Location = new System.Drawing.Point(10, 97);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(170, 27);
            this.btnAddDrink.TabIndex = 6;
            this.btnAddDrink.Text = "Add";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // txtBxCost
            // 
            this.txtBxCost.Location = new System.Drawing.Point(93, 45);
            this.txtBxCost.Name = "txtBxCost";
            this.txtBxCost.Size = new System.Drawing.Size(87, 20);
            this.txtBxCost.TabIndex = 3;
            // 
            // nmUDAmount
            // 
            this.nmUDAmount.Location = new System.Drawing.Point(93, 71);
            this.nmUDAmount.Name = "nmUDAmount";
            this.nmUDAmount.Size = new System.Drawing.Size(87, 20);
            this.nmUDAmount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Drink Name:";
            // 
            // txtBxDrinkName
            // 
            this.txtBxDrinkName.Location = new System.Drawing.Point(93, 19);
            this.txtBxDrinkName.Name = "txtBxDrinkName";
            this.txtBxDrinkName.Size = new System.Drawing.Size(87, 20);
            this.txtBxDrinkName.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(102, 46);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 21);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset Records";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDeleteDrinks
            // 
            this.btnDeleteDrinks.Location = new System.Drawing.Point(102, 19);
            this.btnDeleteDrinks.Name = "btnDeleteDrinks";
            this.btnDeleteDrinks.Size = new System.Drawing.Size(90, 21);
            this.btnDeleteDrinks.TabIndex = 2;
            this.btnDeleteDrinks.Text = "Delete Drinks";
            this.btnDeleteDrinks.UseVisualStyleBackColor = true;
            this.btnDeleteDrinks.Click += new System.EventHandler(this.btnDeleteDrinks_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(6, 46);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(90, 21);
            this.btnStatus.TabIndex = 2;
            this.btnStatus.Text = "Check Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // grpBxSell
            // 
            this.grpBxSell.Controls.Add(this.btnSellSelected);
            this.grpBxSell.Controls.Add(this.dGridVDrinks);
            this.grpBxSell.Controls.Add(this.btnSell2);
            this.grpBxSell.Controls.Add(this.btnSell1);
            this.grpBxSell.Location = new System.Drawing.Point(12, 324);
            this.grpBxSell.Name = "grpBxSell";
            this.grpBxSell.Size = new System.Drawing.Size(334, 199);
            this.grpBxSell.TabIndex = 5;
            this.grpBxSell.TabStop = false;
            this.grpBxSell.Text = "Vending";
            // 
            // btnSellSelected
            // 
            this.btnSellSelected.Location = new System.Drawing.Point(188, 19);
            this.btnSellSelected.Name = "btnSellSelected";
            this.btnSellSelected.Size = new System.Drawing.Size(140, 35);
            this.btnSellSelected.TabIndex = 2;
            this.btnSellSelected.Text = "Sell Selected";
            this.btnSellSelected.UseVisualStyleBackColor = true;
            this.btnSellSelected.Click += new System.EventHandler(this.btnSellSelected_Click);
            // 
            // dGridVDrinks
            // 
            this.dGridVDrinks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGridVDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridVDrinks.Location = new System.Drawing.Point(6, 60);
            this.dGridVDrinks.MultiSelect = false;
            this.dGridVDrinks.Name = "dGridVDrinks";
            this.dGridVDrinks.ReadOnly = true;
            this.dGridVDrinks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridVDrinks.Size = new System.Drawing.Size(322, 133);
            this.dGridVDrinks.TabIndex = 1;
            // 
            // btnSell2
            // 
            this.btnSell2.Location = new System.Drawing.Point(97, 19);
            this.btnSell2.Name = "btnSell2";
            this.btnSell2.Size = new System.Drawing.Size(85, 35);
            this.btnSell2.TabIndex = 0;
            this.btnSell2.Text = "Water";
            this.btnSell2.UseVisualStyleBackColor = true;
            this.btnSell2.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnSell1
            // 
            this.btnSell1.Location = new System.Drawing.Point(6, 19);
            this.btnSell1.Name = "btnSell1";
            this.btnSell1.Size = new System.Drawing.Size(85, 35);
            this.btnSell1.TabIndex = 0;
            this.btnSell1.Text = "Beer";
            this.btnSell1.UseVisualStyleBackColor = true;
            this.btnSell1.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cost in €:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount to Add:";
            // 
            // txtBxCash
            // 
            this.txtBxCash.Location = new System.Drawing.Point(6, 72);
            this.txtBxCash.Name = "txtBxCash";
            this.txtBxCash.Size = new System.Drawing.Size(90, 20);
            this.txtBxCash.TabIndex = 8;
            // 
            // btnSetCash
            // 
            this.btnSetCash.Location = new System.Drawing.Point(102, 72);
            this.btnSetCash.Name = "btnSetCash";
            this.btnSetCash.Size = new System.Drawing.Size(90, 21);
            this.btnSetCash.TabIndex = 2;
            this.btnSetCash.Text = "Set Cash";
            this.btnSetCash.UseVisualStyleBackColor = true;
            this.btnSetCash.Click += new System.EventHandler(this.btnSetCash_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 529);
            this.Controls.Add(this.grpBxSell);
            this.Controls.Add(this.grpBxInfo);
            this.Controls.Add(this.txtBxOutput);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(580, 568);
            this.MinimumSize = new System.Drawing.Size(580, 568);
            this.Name = "MainForm";
            this.Text = "Vending Machine Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBxInfo.ResumeLayout(false);
            this.grpBxInfo.PerformLayout();
            this.grpBxAddDrinks.ResumeLayout(false);
            this.grpBxAddDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUDAmount)).EndInit();
            this.grpBxSell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridVDrinks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBxOutput;
        private System.Windows.Forms.Button btnCheckDrinks;
        private System.Windows.Forms.GroupBox grpBxInfo;
        private System.Windows.Forms.Button btnDeleteDrinks;
        private System.Windows.Forms.GroupBox grpBxSell;
        private System.Windows.Forms.Button btnSell1;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmUDAmount;
        private System.Windows.Forms.TextBox txtBxCost;
        private System.Windows.Forms.TextBox txtBxDrinkName;
        private System.Windows.Forms.Button btnSell2;
        private System.Windows.Forms.DataGridView dGridVDrinks;
        private System.Windows.Forms.Button btnSellSelected;
        private System.Windows.Forms.GroupBox grpBxAddDrinks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxCash;
        private System.Windows.Forms.Button btnSetCash;
    }
}

