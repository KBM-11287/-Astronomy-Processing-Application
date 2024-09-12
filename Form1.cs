using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

// Kabo Masimege, (Team Name), Sprint Number 1
// Date: 05/09/2024
// Version 8
// Neutrino Processing Application
// the application processes and stores hourly neutrino interactions
// It records, processes and displays integer data
namespace Neutrino_Astronomy_Processing
{
    public partial class FrmAstroProcessing : Form
    {
        public FrmAstroProcessing()
        {
            InitializeComponent();
            // Call a method to fill Array at start up
            FillArray();
            BtnDelete.Click += new EventHandler(BtnDelete_Click);
            BtnSearch.Click += new EventHandler(BtnSearch_Click);
            BtnEdit.Click += new EventHandler(BtnEdit_Click);

        }
        // Global variables
        static int arraySize = 24;
        int[] integerArray = new int[arraySize];
        Random r = new Random();
        int comparisonCounter = 0;
        // Array of random integers, global variables
        static int max = 24;
        int[] neutrinoInteractions = new int[max];

        // Method to fill Array with random numbers
        public void FillArray()
        {
            // Create a random number
            Random random = new Random();
            for (int i = 0; i < max; i++)
            {
                // Random number 10, 90
                neutrinoInteractions[i] = random.Next(10, 90);
            }
            // Display initial Array
            ShowArray(0, max - 1);
        }
        private void BtnSort_Click(object sender, EventArgs e)
        {
            int data  = neutrinoInteractions.Length;
            for (int i = 0; i < data - 1; i++)
            {
                for (int j = 0; j < data - i - 1; j++)
                {
                    if (neutrinoInteractions[j] > neutrinoInteractions[j + 1])
                    {
                        // Swap elements
                        int temp_data = neutrinoInteractions[j];
                        neutrinoInteractions[j] = neutrinoInteractions[j + 1];
                        neutrinoInteractions[j + 1] = temp_data;
                    }
                }
            }
            // Display sorted array
            ShowArray(0, data - 1);
        }
        // Method to display Array
        public void ShowArray(int low, int high)
        {
            listBoxOutput.Items.Clear(); // Clear the list box before displaying new data
            for (int i = low;i <= high; i++)
            {
                listBoxOutput.Items.Add(neutrinoInteractions[i]); // Add each element to the list box
            }
        }
        

        // Binary search method was here
       
        // Search Button Event handler
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            comparisonCounter = 0;
            int min = 0;
            int max = arraySize - 1;
            if (!(Int32.TryParse(txtBxInput.Text, out int target)))
            {
                TextBoxMessage.Text = "You must enter an integer";
                return;
            }
            while (min <= max)
            {
                comparisonCounter++;
                int mid = (min + max) / 2;
                if (target == integerArray[mid])
                {
                    TextBoxMessage.Text = target + " Found at index " + mid +
                        "\r\n" + "Number of comparisons " + comparisonCounter;
                    txtBxInput.Clear();
                    txtBxInput.Focus();
                    return;
                }
                else if (integerArray[mid] >= target)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            TextBoxMessage.Text = "Not Found, try again." + "\r\n" + "Number of comparisons " + comparisonCounter;
            txtBxInput.Clear();
            txtBxInput.Focus();
        }
        

        // Method to Edit a value in the array
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int Index, newValue;
            if (!Int32.TryParse(txtIndex.Text, out Index) || !Int32.TryParse(txtNewValue.Text, out newValue))
            {
                MessageBox.Show("Please enter valid integer values for the Index and New Value");
                return;
            }
                
             if (Index < 0 || Index >= max)

            {   MessageBox.Show("Index out of bounds");
                return;
            }
            neutrinoInteractions[Index] = newValue;
            ShowArray(0, max - 1);
        }
        
        // Method to delete a value from the array
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int Index;
            if(!Int32.TryParse(txtIndex.Text, out Index))
            {
                MessageBox.Show("Please enter a valid integer value for the Index");
                return;
            }
            if(Index < 0 || Index >= max)
            {
                MessageBox.Show("Index out of bounds");
                return;
            }
            // Shift elements to the left to fill the gap
            for (int i = Index; i < max - 1; i++)
            {
                neutrinoInteractions[i] = neutrinoInteractions[i + 1];
            }
            // Set the last element to 0 (or any default value)
            neutrinoInteractions[max - 1] = 0;
            ShowArray(0, max - 1);
            txtIndex.Clear();
            txtNewValue.Clear();
        }
    }
}
