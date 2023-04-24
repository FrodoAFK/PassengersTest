using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PassengersTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createGrid();
        }

        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PassengersGrid.txt");
        public void createGrid()
        {

            using StreamReader sr = new StreamReader(File.OpenRead(path), System.Text.Encoding.Default);


            DataSet ds = new DataSet();
            ds.Tables.Add("Temp");


            string columnsName = sr.ReadLine();

            string[] arrayNameColumn = System.Text.RegularExpressions.Regex.Split(columnsName, ",");
            for (int i = 0; i < arrayNameColumn.Length; i++)
            {
                ds.Tables[0].Columns.Add(arrayNameColumn[i]);
            }

            string Line = sr.ReadLine();
            while (Line != null)
            {
                string[] arrayCell = System.Text.RegularExpressions.Regex.Split(Line, ",");
                ds.Tables[0].Rows.Add(arrayCell);
                Line = sr.ReadLine();
            }
            passengersGrid.DataSource = ds.Tables[0];
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(passengersGrid.Columns[0].Name.ToString() + "," + passengersGrid.Columns[1].Name.ToString() + "," + passengersGrid.Columns[2].Name.ToString() + "," + passengersGrid.Columns[3].Name.ToString() + "," + passengersGrid.Columns[4].Name.ToString());
                for (int i = 0; i < Convert.ToInt32(passengersGrid.Rows.Count - 1); i++)
                {
                    sw.WriteLine(passengersGrid.Rows[i].Cells[0].Value.ToString() + "," + passengersGrid.Rows[i].Cells[1].Value.ToString() + "," + passengersGrid.Rows[i].Cells[2].Value.ToString() + "," + passengersGrid.Rows[i].Cells[3].Value.ToString() + "," + passengersGrid.Rows[i].Cells[4].Value.ToString());
                }

            }
        }
    }
}