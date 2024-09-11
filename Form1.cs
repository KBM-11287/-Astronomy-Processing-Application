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
// Version 3
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
        }
        // Array of random integers, global variables
        static int max = 24;
        int[] neutrinoInteractions = new int[max];
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
            listBoxOutput.Items.Clear();
            for (int i = low;i <= high; i++)
            {
                listBoxOutput.Items.Add(neutrinoInteractions[i]);
            }
        }
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

        // Binary search method
        private int BinarySearch(int[] array, int key)
        {
            int min = 0;
            int max = array.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (array[mid] == key)
                {
                    return mid; // Key found
                }
                else if (array[mid] < key)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return -1; // Key not found
        }
        // Search Button Event handler
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Ensure the array is sorted before searching
            BtnSort_Click(sender, e);
            int key;
            if (!int.TryParse(listBoxOutput.Text, out key))
            {
                MessageBox.Show("Please enter an integer value");
                return;
            }
            int result = BinarySearch(neutrinoInteractions, key);
            if ( result != -1)
            {
                MessageBox.Show($"Value found at index{result}");
            }
            else 
            {
                MessageBox.Show("Value not found in the array");
            }
        }
        // Method to display Array
        public void ShowArray (int low, int high)
        {
           listBoxOutput.Items.Clear ();
            for (int i = low; i <= high; i++)
            {
                listBoxOutput.Items.Add(neutrinoInteractions[i]);
            }
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
