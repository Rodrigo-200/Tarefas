using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            if (cbb_Employee.SelectedItem != null && cbb_Team.SelectedItem != null &&
                txt_TaskName.Text.Trim() != "" && txt_Description.Text.Trim() != "")
            {
                try
                {
                    Generic._ListOfEmployees.Add(new Employee(cbb_Employee.SelectedItem.ToString(), cbb_Team.SelectedItem.ToString(), txt_TaskName.Text, chb_Cordinator.Checked, chb_PersonInCharge.Checked, dtp_StartDate.Value, dtp_DateFinish.Value, txt_Description.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string erro = "Campo obrigatório";
                if (cbb_Employee.SelectedItem == null)
                {
                    erp_Errors.SetError(cbb_Employee, erro);
                }
                if(cbb_Team.SelectedItem == null)
                {
                    erp_Errors.SetError(cbb_Team, erro);
                }
                if(txt_TaskName.Text.Trim() == "")
                {
                    erp_Errors.SetError(txt_TaskName, erro);
                }
                if(txt_Description.Text.Trim() == "")
                {
                    erp_Errors.SetError(txt_Description, erro);
                }
            }
        }
    }
}
