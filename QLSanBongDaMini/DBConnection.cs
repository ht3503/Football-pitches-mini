using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBongDaMini
{
    public class DBConnection
    {
        SqlConnection connect;
        SqlDataAdapter da;
        DataSet dataSet;

        public string StrServerName, StrDatabaseName;
        public DataSet DataSet
        {
            get { return dataSet; }
            set { dataSet = value; }
        }
        public DBConnection()
        {
            StrServerName = @"CHAUCUTEVL\CHAUDZHOST";
            StrDatabaseName = "QLSanBongDaMini";
            string StrConnect = @"Data Source=" + StrServerName + ";Initial Catalog=" + StrDatabaseName + ";Integrated Security=True";
            try
            {
                connect = new SqlConnection(StrConnect);
                dataSet = new DataSet(StrDatabaseName);
        
            }
            catch (SqlException ex)
            {
              
            }
        }
        public DataTable layDuLieu(string sql)
        {
            da = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int themXoaSua(string sql)
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            return cmd.ExecuteNonQuery();
            connect.Close();
        }
        public int Update(string sql, DataTable name)
        {
            da = new SqlDataAdapter(sql, connect);
            SqlCommandBuilder cmdd = new SqlCommandBuilder(da);
            return da.Update(name);
        }

        public void openConnection()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
        }

        public void closeConnection()
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
        }
        public void disposeConnection()
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
            connect.Dispose();
        }

        public void updateToDataBase(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = strSQL;
            cmd.ExecuteNonQuery();
            closeConnection();
        }

        public int getCount(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = strSQL;
            int count = (int)cmd.ExecuteScalar();
            closeConnection();
            return count;
        }

        public SqlDataReader getDataReader(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(strSQL, connect);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }

        public SqlDataAdapter getADA(string strSQL, string table)
        {
            openConnection();
            SqlDataAdapter ada = new SqlDataAdapter(strSQL, connect);
            ada.Fill(dataSet, table);
            closeConnection();
            return ada;
        }

        public DataTable getDataTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);
            return dt;
        }
    }
}
