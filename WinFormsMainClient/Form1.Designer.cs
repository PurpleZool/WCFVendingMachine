
namespace WinFormsMainClient
{
    partial class Form1
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDeleteDrinks = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.grpBxSell = new System.Windows.Forms.GroupBox();
            this.btnBeer = new System.Windows.Forms.Button();
            this.txtBxDrinkName = new System.Windows.Forms.TextBox();
            this.txtBxCost = new System.Windows.Forms.TextBox();
            this.nmUDAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.grpBxInfo.SuspendLayout();
            this.grpBxSell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUDAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-2, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txtBxOutput
            // 
            this.txtBxOutput.Location = new System.Drawing.Point(12, 12);
            this.txtBxOutput.Multiline = true;
            this.txtBxOutput.Name = "txtBxOutput";
            this.txtBxOutput.ReadOnly = true;
            this.txtBxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxOutput.Size = new System.Drawing.Size(585, 260);
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
            this.grpBxInfo.Controls.Add(this.btnAddDrink);
            this.grpBxInfo.Controls.Add(this.label1);
            this.grpBxInfo.Controls.Add(this.nmUDAmount);
            this.grpBxInfo.Controls.Add(this.txtBxCost);
            this.grpBxInfo.Controls.Add(this.txtBxDrinkName);
            this.grpBxInfo.Controls.Add(this.btnReset);
            this.grpBxInfo.Controls.Add(this.btnDeleteDrinks);
            this.grpBxInfo.Controls.Add(this.btnStatus);
            this.grpBxInfo.Controls.Add(this.btnCheckDrinks);
            this.grpBxInfo.Location = new System.Drawing.Point(352, 278);
            this.grpBxInfo.Name = "grpBxInfo";
            this.grpBxInfo.Size = new System.Drawing.Size(245, 245);
            this.grpBxInfo.TabIndex = 4;
            this.grpBxInfo.TabStop = false;
            this.grpBxInfo.Text = "Managing";
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
            this.grpBxSell.Controls.Add(this.btnBeer);
            this.grpBxSell.Location = new System.Drawing.Point(84, 384);
            this.grpBxSell.Name = "grpBxSell";
            this.grpBxSell.Size = new System.Drawing.Size(243, 139);
            this.grpBxSell.TabIndex = 5;
            this.grpBxSell.TabStop = false;
            this.grpBxSell.Text = "Vending";
            // 
            // btnBeer
            // 
            this.btnBeer.Location = new System.Drawing.Point(9, 19);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(85, 35);
            this.btnBeer.TabIndex = 0;
            this.btnBeer.Text = "BEER";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // txtBxDrinkName
            // 
            this.txtBxDrinkName.Location = new System.Drawing.Point(102, 73);
            this.txtBxDrinkName.Name = "txtBxDrinkName";
            this.txtBxDrinkName.Size = new System.Drawing.Size(89, 20);
            this.txtBxDrinkName.TabIndex = 3;
            // 
            // txtBxCost
            // 
            this.txtBxCost.Location = new System.Drawing.Point(102, 99);
            this.txtBxCost.Name = "txtBxCost";
            this.txtBxCost.Size = new System.Drawing.Size(89, 20);
            this.txtBxCost.TabIndex = 3;
            // 
            // nmUDAmount
            // 
            this.nmUDAmount.Location = new System.Drawing.Point(102, 125);
            this.nmUDAmount.Name = "nmUDAmount";
            this.nmUDAmount.Size = new System.Drawing.Size(89, 20);
            this.nmUDAmount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Location = new System.Drawing.Point(105, 151);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(87, 27);
            this.btnAddDrink.TabIndex = 6;
            this.btnAddDrink.Text = "Add";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 535);
            this.Controls.Add(this.grpBxSell);
            this.Controls.Add(this.grpBxInfo);
            this.Controls.Add(this.txtBxOutput);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBxInfo.ResumeLayout(false);
            this.grpBxInfo.PerformLayout();
            this.grpBxSell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmUDAmount)).EndInit();
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
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmUDAmount;
        private System.Windows.Forms.TextBox txtBxCost;
        private System.Windows.Forms.TextBox txtBxDrinkName;
    }
}

