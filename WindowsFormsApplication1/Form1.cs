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
        public int tree_size = 0; //allocate and initiliaze variable of tree size
       
        class record_in_grid //each recors is a node
        {
            public int rec_id, par_rec_id;
            public string val;
        }
        void look_down(int input_node, int action, int action_property)
        {
            int record_in_grid_counter = 0;

            record_in_grid[] record_in_grid_tree_all = new record_in_grid[tree_size];
            for (record_in_grid_counter = 0; record_in_grid_counter < tree_size; record_in_grid_counter = record_in_grid_counter + 1)
            {
                record_in_grid record_in_grid_tmp = new record_in_grid();
                record_in_grid_tmp.rec_id = Convert.ToInt16(dataGridView1.Rows[record_in_grid_counter].Cells[0].Value + "");
                record_in_grid_tmp.par_rec_id = Convert.ToInt16(dataGridView1.Rows[record_in_grid_counter].Cells[1].Value + "");
                record_in_grid_tmp.val = dataGridView1.Rows[record_in_grid_counter].Cells[2].Value + "";
                record_in_grid_tree_all[record_in_grid_counter] = record_in_grid_tmp;
            }

            //MessageBox.Show(Convert.ToString(record_in_grid_tree_all[0].rec_id));
            //MessageBox.Show(Convert.ToString(record_in_grid_tree_all[0].par_rec_id));
                
            for (record_in_grid_counter = 1; record_in_grid_counter < tree_size; record_in_grid_counter = record_in_grid_counter + 1)
            {
                MessageBox.Show("Desc's rec id is " + record_in_grid_tree_all[input_node - 1].rec_id);
                if (record_in_grid_tree_all[input_node-1].rec_id == record_in_grid_tree_all[record_in_grid_counter].par_rec_id)//record_in_grid_counter])
                {
                    MessageBox.Show("Desc's rec id is " + record_in_grid_tree_all[record_in_grid_counter].rec_id + " and Desc's parent rec id is " + record_in_grid_tree_all[record_in_grid_counter].par_rec_id);
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.mainTableAdapter.Fill(this.graf03DataSet.main); //loading data from Database
            
            tree_size = dataGridView1.RowCount; //allocate and initiliaze variable of tree size
            //MessageBox.Show(Convert.ToString(tree_size)); //show size while loading
            int record_in_grid_counter=0;
            /*
            record_in_grid[] record_in_grid_tree_all = new record_in_grid[tree_size];
            for (record_in_grid_counter = 1; record_in_grid_counter < tree_size; record_in_grid_counter=record_in_grid_counter+1)
            {
                record_in_grid record_in_grid_tmp = new record_in_grid();
                record_in_grid_tmp.rec_id = Convert.ToInt16(dataGridView1.Rows[record_in_grid_counter].Cells[0].Value + "");
                record_in_grid_tmp.par_rec_id = Convert.ToInt16(dataGridView1.Rows[record_in_grid_counter].Cells[1].Value + "");
                record_in_grid_tmp.val = dataGridView1.Rows[record_in_grid_counter].Cells[2].Value + "";
                record_in_grid_tree_all[record_in_grid_counter] = record_in_grid_tmp;
            }
            */
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // look_down(Convert.ToInt16(toolStripTextBox1.Text), 1, 1);
            MessageBox.Show(Convert.ToString(Convert.ToInt16(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value)));
            //MessageBox.Show(Convert.ToString(Convert.ToInt16(dataGridView1.Rows[1].Cells[0].Value)-1));
            look_down(Convert.ToInt16(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value), 1, 1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
