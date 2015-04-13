using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        class record_in_grid //each recors is a node
        {
            public int rec_id, par_rec_id;
            public string val;
        }
        void look_down(int input_node, int action, int action_property)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.mainTableAdapter.Fill(this.graf03DataSet.main); //loading data from Database
            int tree_size = 0; //allocate and initiliaze variable of tree size
            tree_size = dataGridView1.RowCount; //allocate and initiliaze variable of tree size
            //MessageBox.Show(Convert.ToString(tree_size)); //show size while loading
            int record_in_grid_counter=0;
            for (record_in_grid_counter = 1; record_in_grid_counter < tree_size; record_in_grid_counter=record_in_grid_counter+1)
            {

            }
            look_down(1, 1, 1);
        }
    }
}
