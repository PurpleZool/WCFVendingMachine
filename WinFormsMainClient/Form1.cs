using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsMainClient.VendingService;

namespace WinFormsMainClient
{

    public partial class MainForm : Form
    {
        private List<string> outputLines = new List<string>();
        private VendingService.MainServiceClient client;


        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsoleWriteLine("Checking drinks...");
            StringBuilder builder = new StringBuilder();
            foreach(Drink drink in client.GetDrinks()) 
            {
                builder.AppendLine("*****************");
                builder.AppendLine(string.Format("  Name : {0}", drink.name));
                builder.AppendLine(string.Format("  Cost : {0}", drink.cost));
                builder.AppendLine(string.Format("  Amount : {0}", drink.count));
            }
            builder.AppendLine("*****************\n       ALL DRINKS SHOWN \n*****************");
            ConsoleWriteLine(builder.ToString());
            RefreshDrinksGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new VendingService.MainServiceClient();
            ConsoleWriteLine("EndPoint Attached at:" + client.Endpoint.Address.ToString());
            RefreshDrinksGrid();
            ConsoleWriteLine("WELCOME TO THE VENDING MACHINE");
        }

        private void ConsoleWriteLine(string text) 
        {
            outputLines.Add(text);
            txtBxOutput.Lines = outputLines.ToArray(); // Actualiza el contenido del TextBox con todas las líneas
            txtBxOutput.SelectionStart = txtBxOutput.Text.Length; // Mueve el cursor al final del texto
            txtBxOutput.ScrollToCaret();
        }

        private void btnDeleteDrinks_Click(object sender, EventArgs e)
        {
            client.DeleteDrinks();
            ConsoleWriteLine("DRINKS DELETED");
            RefreshDrinksGrid();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            ConsoleWriteLine(client.SellDrink(button.Text.ToLower()));
            RefreshDrinksGrid();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            ConsoleWriteLine("Getting Status...");
            PrintStatus(client.GetVendingObj());
        }

        private void PrintStatus(VendingMachine vending) 
        {
            int totalDrinks = vending.drinks.Sum(d => d.count);
            double totalStash = 0;
            foreach(Drink drink in vending.drinks) 
            {
                totalStash += (drink.cost * drink.count);
            }


            StringBuilder builder = new StringBuilder();
            builder.AppendLine("*****************");
            builder.AppendLine(string.Format("  Cash : {0}", vending.totalAmoun));
            builder.AppendLine(string.Format("  Operations Made : {0}", vending.operationsMade));
            builder.AppendLine(string.Format("  Different Drinks : {0}", vending.drinks.Length));
            builder.AppendLine(string.Format("  Total Drinks : {0}", totalDrinks));
            builder.AppendLine(string.Format("  Total Stash : {0} + {1} -> {2}",vending.totalAmoun , totalStash, totalStash + vending.totalAmoun ));
            builder.AppendLine("*****************");
            ConsoleWriteLine(builder.ToString());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            client.ResetMachine();
            RefreshDrinksGrid();
            ConsoleWriteLine("RECORDS DELETED");
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            double cost;
            double.TryParse(txtBxCost.Text, out cost);
            Drink toAdd = new Drink() { name = txtBxDrinkName.Text, cost = cost, count = (int)nmUDAmount.Value };
            ConsoleWriteLine(client.AddDrink(toAdd));
            RefreshDrinksGrid();
        }

        private void RefreshDrinksGrid() 
        {

            dGridVDrinks.DataSource = client.GetDrinks();
            dGridVDrinks.Columns["name"].HeaderText = "Name";
            dGridVDrinks.Columns["name"].DisplayIndex = 0;
            dGridVDrinks.Columns["cost"].HeaderText = "Cost";
            dGridVDrinks.Columns["cost"].DisplayIndex = 1;
            dGridVDrinks.Columns["count"].HeaderText = "Count";
            dGridVDrinks.Columns["count"].DisplayIndex = 2;
        }

        private void btnSellSelected_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dGridVDrinks.SelectedRows[0];
            string drink = selectedRow.Cells["name"].Value.ToString();
            client.SellDrink(drink);
            ConsoleWriteLine(drink + " sold.");
            RefreshDrinksGrid();
        }

        private void btnSetCash_Click(object sender, EventArgs e)
        {
            double.TryParse(txtBxCash.Text, out double newCash);
            ConsoleWriteLine(client.SetCash(newCash));
        }
    }
}
