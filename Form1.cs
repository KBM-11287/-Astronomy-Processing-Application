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

namespace Neutrino_Astronomy_Processing
{
    public partial class FrmAstroProcessing : Form
    {
        public FrmAstroProcessing()
        {
            InitializeComponent();
            // Call a method to fill Array at start up
            FillArray();
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
        }
        // Method to display Array
        private void ShowArray()
        {
            listBoxOutput.Items.Clear();
            for (int i = 0;i < max;i++)
            {
                listBoxOutput.Items.Add(neutrinoInteractions[i]);
            }
        }
        // Method to fill Array with random numbers
        public void FillArray()
        {
            // Create a random number
            Random random = new Random();
            for (int i = 0; i <= max; i++)
            {
                // Random number 10, 90
                neutrinoInteractions[i] = random.Next(10, 90);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int mid;
            int lowBound = 0;
            int highBound = max - 1;
            int target;
            if (!(Int32.TryParse(listBoxOutput.Text, out target)))
            {
                MessageBox.Show("Please enter an integer value");
                return;
            }
            {
                while (lowBound <= highBound) //Check "<" or "<="
                {
                    // Display list
                    ShowArray(lowBound, highBound);
                    // Find the midpoint
                    mid = (lowBound + highBound) / 2;
                    // Pause with a messagebox
                    MessageBox.Show("Low:" + lowBound + " Mid:" + mid + " High:" + highBound);
                    if (neutrinoInteractions[mid] == target)
                    {
                        // Target has been found
                        listBoxOutput.Items.Add("Found at index" + mid);
                        return;
                    }
                    else if (neutrinoInteractions[mid] > target)
                    {
                        highBound = mid - 1;
                    }
                    else
                    {
                        lowBound = mid + 1;
                    }
                }
                MessageBox.Show("Query not found, try again");
            }
        }
        // Method to display Array
        public void ShowArray (int low, int high)
        {
            listBoxOutput.Items.Clear();
            for (int i = low; i <= high; i++)
            {
                listBoxOutput.Items.Add(neutrinoInteractions[i]);
            }
        }
    }
}
