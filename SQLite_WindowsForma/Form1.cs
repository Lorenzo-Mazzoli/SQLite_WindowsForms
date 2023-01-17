using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace SQLite_WindowsForma
{
    public partial class Form1 : Form
    {
        List<Query> queryList = new List<Query>();  //inizializzo una lista in cui contenere le query

        public Form1()
        {
            InitializeComponent();

        }
        private void btnFile_Click(object sender, EventArgs e)
        {
            //al clic del bottone seleziono il file e controllo che la risposta sia valida
            OpenFileDialog ofd = new OpenFileDialog();

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDB.Text = ofd.FileName;
            }
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            // https://www.connectionstrings.com/  //lo tengo per comodità :)

            strConnessione = "Data Source=" + txtDB.Text + ";Version=3;";

            DataTable dtTable = new DataTable();

            query = txtQuery.Text;

            //connessione e query
            SQLiteDataAdapter dtAdapter = new SQLiteDataAdapter(query, strConnessione);

            try //riempio il DataTable
            {
                dtAdapter.Fill(dtTable);

                dgvTabella.DataSource = dtTable;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void btnFileQuery_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileQuery.Text = ofd.FileName;
            }

            string line;
            int c = 0;
            try
            {
                StreamReader sr = new StreamReader(txtFileQuery.Text);

                line = sr.ReadLine();

                while (line != null)
                {
                    if (line.Contains("#"))
                    {
                        Query q = new Query();
                        queryList.Add(q);
                        q.Titolo = line;
                        c++;
                        cmbQuery.Items.Add(q.getTitolo());
                    }
                    else
                    {
                        queryList[c-1].Contenuto = queryList[c-1].Contenuto + line;
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception: " + exc.Message);
            }
        }

        private void cmbQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = 0;
            foreach (Query q in queryList)
            {
                if (queryList[k].getTitolo() == cmbQuery.SelectedItem.ToString())
                {
                    txtQuery.Text = queryList[k].getContenuto();
                }
                k++;
            }
        }
    }
}
