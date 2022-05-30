using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalTest
{
	public partial class Form1 : Form
	{
		private SqlConnection Con;

		public Form1()
		{
			InitializeComponent();
		}

		private int EduNum = 0;

		private void Form1_Load(object sender, EventArgs e)
		{
			Con = new SqlConnection();
			Con.ConnectionString = "Server=(local);database=ADOTest;" +
				"Integrated Security=true";
			Con.Open();
		}

		private void select_Click(object sender, EventArgs e)
		{
			PrintTable();
		}

		private void PrintTable()
		{
			string Rec;
			SqlCommand cmd = new SqlCommand("select * from TB_CAR_INFO", Con);
			SqlDataReader R;
			R = cmd.ExecuteReader();
			listView1.Items.Clear();
			while (R.Read())
			{
				Rec = string.Format("{0},  {1},  {2},  {3}, {4}",
					R[0].ToString(), R[1].ToString(), R[2].ToString(), R[3].ToString(),R[4].ToString());
				listView1.Items.Add(Rec);
			}
			R.Close();
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			PrintTable();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string Sql = "update TB_CAR_INFO set carName='" + this.textName.Text  + "'carYear = '" + this.textAge.Text + "'carPrice = '" + this.textPrice.Text + "'carDoor = '" + this.textDoor.Text +"";
		SqlCommand Com = new SqlCommand(Sql, Con);
		Com.Parameters.Add("@carName", SqlDbType.NVarChar, 30);
			Com.Parameters.Add("@carYear", SqlDbType.VarChar, 4);
			Com.Parameters.Add("@carPrice", SqlDbType.Int);
			Com.Parameters.Add("@carDoor", SqlDbType.Int);

			Com.Parameters["@carName"].Value = textName.Text;
			Com.Parameters["@carYear"].Value = textAge.Text;
			Com.Parameters["@carPrice"].Value = textPrice.Text;
			Com.Parameters["@carDoor"].Value = textDoor.Text;

			Com.ExecuteNonQuery();

			PrintTable();
		}
		private bool listView_Secected_Row_Check()
		{
			if (this.listView1.SelectedItems.Count > 0)
				return true;
			else
				MessageBox.Show("선택된 데이터가 없습니다. 데이터를 선택해주세요.", "알림",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);

			return false;
		}

		private bool textBox_DataChk()
		{
			if (this.textName.Text != "" && this.textAge.Text != "" &&
				this.textPrice.Text != "" && this.textDoor.Text != "")
				return true;
			else
			{
				MessageBox.Show("입력 항목의 데이터를 확인해주세요.", "알림",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);

				return false;
			}
		}
		private void Update_Click(object sender, EventArgs e)
		{
			if (!listView_Secected_Row_Check())
			{
				return;
			}

			if (!textBox_DataChk())
			{
				return;
			}
			string Sql = "update TB_CAR_INFO "
					+ "set carName = @carName, carYear = @carYear, "
					+ "carPrice = @carPrice, carDoor = @carDoor "
					+ "where id = @id ";

			SqlCommand Com = new SqlCommand(Sql, Con);
			Com.Parameters.Add("@carName", SqlDbType.NVarChar, 30);
			Com.Parameters.Add("@carYear", SqlDbType.VarChar, 4);
			Com.Parameters.Add("@carPrice", SqlDbType.Int);
			Com.Parameters.Add("@carDoor", SqlDbType.Int);

			Com.Parameters["@carName"].Value = textName.Text;
			Com.Parameters["@carYear"].Value = textAge.Text;
			Com.Parameters["@carPrice"].Value = textPrice.Text;
			Com.Parameters["@carDoor"].Value = textDoor.Text;

			Com.ExecuteNonQuery();

			PrintTable();

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{

			string Sql = "Select * From TB_CAR_INFO "
						+ "where carName = @carName or carYear = @carYear "
						+ "or carPrice = @carPrice or carDoor = @carDoor ";

			var Comm = new SqlCommand(Sql, Con);

			Comm.Parameters.Add("@carName", SqlDbType.NVarChar, 30);
			Comm.Parameters.Add("@carYear", SqlDbType.VarChar, 4);
			Comm.Parameters.Add("@carPrice", SqlDbType.Int);
			Comm.Parameters.Add("@carDoor", SqlDbType.Int);

			Comm.Parameters["@carName"].Value = this.textName.Text;
			Comm.Parameters["@carYear"].Value = this.textAge.Text;
			Comm.Parameters["@carPrice"].Value =
				Convert.ToInt32((this.textPrice.Text == "") ? 0 : Convert.ToInt32(this.textPrice.Text));
			Comm.Parameters["@carDoor"].Value =
				Convert.ToInt32((this.textDoor.Text == "") ? 0 : Convert.ToInt32(this.textDoor.Text));


			var myRead = Comm.ExecuteReader();

			while (myRead.Read())
			{
				var strArray = new String[] { myRead["id"].ToString(),
					myRead["carName"].ToString(), myRead["carYear"].ToString(),
					myRead["carPrice"].ToString(), myRead["carDoor"].ToString() };
				var lvt = new ListViewItem(strArray);
				this.listView1.Items.Add(lvt);
			}
			myRead.Close();
			Con.Close();
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{

		}


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insert2_Click(object sender, EventArgs e)
        {
			string Sql = "INSERT INTO TB_CAR_INFO VALUES (@carName,@carYear,@carPrice,@carDoor)";
			SqlCommand Com = new SqlCommand(Sql, Con);
			Com.Parameters.Add("@carName", SqlDbType.NVarChar, 30);
			Com.Parameters.Add("@carYear", SqlDbType.VarChar, 4);
			Com.Parameters.Add("@carPrice", SqlDbType.Int);
			Com.Parameters.Add("@carDoor", SqlDbType.Int);

			Com.Parameters["@carName"].Value = textName.Text;
			Com.Parameters["@carYear"].Value = textAge.Text;
			Com.Parameters["@carPrice"].Value = textPrice.Text;
			Com.Parameters["@carDoor"].Value = textDoor.Text;

			Com.ExecuteNonQuery();

			PrintTable();

		}


    }
}


