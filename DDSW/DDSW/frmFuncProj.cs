using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DDSW
{
    public partial class frmFuncProj : Form
    {
        private int codtarefa;
        public frmFuncProj(int cod)
        {
            InitializeComponent();
            this.codtarefa = cod;
            try
            {
                Connection Conn = new Connection();
                Conn.setQuery("select func_proj.cod_proj as func_proj_codproj, func_proj.cod_func as func_proj_codfunc, func.nome as nome, func.cpf from func_proj left join func on func.cod = func_proj.cod left join proj on proj.cod = func_proj.cod where func_proj.cod = " + cod);
                Conn.executeReader();
                MySqlDataReader Reader = Conn.getReader();
                while (Reader.Read())
                {
                    dtgFuncTarefa.Rows.Add(Reader["cod_func"], Reader["nome"], Reader["cpf"]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmFuncTarefa_Load(object sender, EventArgs e)
        {

        }
    }
}
