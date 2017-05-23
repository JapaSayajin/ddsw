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
    public partial class frmFuncTarefa : Form
    {
        private int codtarefa;
        public frmFuncTarefa(int cod)
        {
            InitializeComponent();
            this.codtarefa = cod;
            try
            {
                Connection Conn = new Connection();
                Conn.setQuery("select func_tarefas.cod_func as cod_func, func_tarefas.cod_tarefas as cod_tarefa, func.nome as nome, func.cpf as cpf from func_tarefas left join func on func.cod = func_tarefas.cod_func where func_tarefas.cod_tarefas = " + codtarefa);
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
