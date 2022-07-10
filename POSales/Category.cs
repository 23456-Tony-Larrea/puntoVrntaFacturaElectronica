﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSalesDB;
namespace POSales
{
    public partial class Category : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Category()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadCategory();
        }
        //Data retrieve from tbCategory to dgvCategory on Category form
        public void LoadCategory()
        {
            int i = 0;
            dgvCategory.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM Categorias ORDER BY categoria", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCategory.Rows.Add(i, dr["id"].ToString(), dr["categoria"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryModule module = new CategoryModule(this);
            module.ShowDialog();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("EStas seguro de eliminar esta categoria?", "Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM Categorias WHERE id LIKE '" + dgvCategory[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Categoria eliminado con exito.", "Punto de venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (colName == "Edit")
            {
                CategoryModule module = new CategoryModule(this);
                module.lblId.Text = dgvCategory[1, e.RowIndex].Value.ToString();
                module.txtCategory.Text = dgvCategory[2, e.RowIndex].Value.ToString();
                module.btnGuardar.Enabled = false;
                module.btnActualizar.Enabled = true;
                module.ShowDialog();
            }
            LoadCategory();
        }
    }
}
