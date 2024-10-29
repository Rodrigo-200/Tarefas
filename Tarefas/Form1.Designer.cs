
namespace Tarefas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Employee = new System.Windows.Forms.Label();
            this.txt_TaskName = new System.Windows.Forms.TextBox();
            this.cbb_Employee = new System.Windows.Forms.ComboBox();
            this.lbl_Team = new System.Windows.Forms.Label();
            this.cbb_Team = new System.Windows.Forms.ComboBox();
            this.lbl_TaskName = new System.Windows.Forms.Label();
            this.chb_Cordinator = new System.Windows.Forms.CheckBox();
            this.chb_PersonInCharge = new System.Windows.Forms.CheckBox();
            this.lbl_DateStart = new System.Windows.Forms.Label();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_DateFinish = new System.Windows.Forms.DateTimePicker();
            this.lbl_DateFinish = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.btn_AddEmployee = new System.Windows.Forms.Button();
            this.lbl_tvwTeams = new System.Windows.Forms.Label();
            this.tvw_Teams = new System.Windows.Forms.TreeView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.erp_Errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erp_Errors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarefas";
            // 
            // lbl_Employee
            // 
            this.lbl_Employee.AutoSize = true;
            this.lbl_Employee.Location = new System.Drawing.Point(15, 54);
            this.lbl_Employee.Name = "lbl_Employee";
            this.lbl_Employee.Size = new System.Drawing.Size(82, 17);
            this.lbl_Employee.TabIndex = 1;
            this.lbl_Employee.Text = "Funcionário";
            // 
            // txt_TaskName
            // 
            this.txt_TaskName.Location = new System.Drawing.Point(18, 197);
            this.txt_TaskName.Name = "txt_TaskName";
            this.txt_TaskName.Size = new System.Drawing.Size(190, 22);
            this.txt_TaskName.TabIndex = 2;
            // 
            // cbb_Employee
            // 
            this.cbb_Employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Employee.FormattingEnabled = true;
            this.cbb_Employee.Items.AddRange(new object[] {
            "Rafel Ribeiro",
            "Rodrigo Rodrigues",
            "Guilherme Antunes",
            "Bruno Ribeiro",
            "David Lopes",
            "David Alves",
            "Rodrigo Martins",
            "Miguel Fernandes",
            "Daniel Serra"});
            this.cbb_Employee.Location = new System.Drawing.Point(18, 75);
            this.cbb_Employee.Name = "cbb_Employee";
            this.cbb_Employee.Size = new System.Drawing.Size(190, 24);
            this.cbb_Employee.TabIndex = 3;
            // 
            // lbl_Team
            // 
            this.lbl_Team.AutoSize = true;
            this.lbl_Team.Location = new System.Drawing.Point(15, 115);
            this.lbl_Team.Name = "lbl_Team";
            this.lbl_Team.Size = new System.Drawing.Size(52, 17);
            this.lbl_Team.TabIndex = 4;
            this.lbl_Team.Text = "Equipa";
            // 
            // cbb_Team
            // 
            this.cbb_Team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Team.FormattingEnabled = true;
            this.cbb_Team.Items.AddRange(new object[] {
            "Desenvolvimento",
            "WebDesign",
            "Bases de Dados",
            "Redes",
            "Administração de Sistemas"});
            this.cbb_Team.Location = new System.Drawing.Point(18, 135);
            this.cbb_Team.Name = "cbb_Team";
            this.cbb_Team.Size = new System.Drawing.Size(190, 24);
            this.cbb_Team.TabIndex = 5;
            // 
            // lbl_TaskName
            // 
            this.lbl_TaskName.AutoSize = true;
            this.lbl_TaskName.Location = new System.Drawing.Point(15, 174);
            this.lbl_TaskName.Name = "lbl_TaskName";
            this.lbl_TaskName.Size = new System.Drawing.Size(86, 17);
            this.lbl_TaskName.TabIndex = 6;
            this.lbl_TaskName.Text = "Nome tarefa";
            // 
            // chb_Cordinator
            // 
            this.chb_Cordinator.AutoSize = true;
            this.chb_Cordinator.Location = new System.Drawing.Point(239, 137);
            this.chb_Cordinator.Name = "chb_Cordinator";
            this.chb_Cordinator.Size = new System.Drawing.Size(113, 21);
            this.chb_Cordinator.TabIndex = 7;
            this.chb_Cordinator.Text = "Coordenador";
            this.chb_Cordinator.UseVisualStyleBackColor = true;
            // 
            // chb_PersonInCharge
            // 
            this.chb_PersonInCharge.AutoSize = true;
            this.chb_PersonInCharge.Location = new System.Drawing.Point(239, 197);
            this.chb_PersonInCharge.Name = "chb_PersonInCharge";
            this.chb_PersonInCharge.Size = new System.Drawing.Size(112, 21);
            this.chb_PersonInCharge.TabIndex = 8;
            this.chb_PersonInCharge.Text = "Responsável";
            this.chb_PersonInCharge.UseVisualStyleBackColor = true;
            // 
            // lbl_DateStart
            // 
            this.lbl_DateStart.AutoSize = true;
            this.lbl_DateStart.Location = new System.Drawing.Point(18, 248);
            this.lbl_DateStart.Name = "lbl_DateStart";
            this.lbl_DateStart.Size = new System.Drawing.Size(94, 17);
            this.lbl_DateStart.TabIndex = 9;
            this.lbl_DateStart.Text = "Data de início";
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartDate.Location = new System.Drawing.Point(21, 269);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(95, 22);
            this.dtp_StartDate.TabIndex = 10;
            // 
            // dtp_DateFinish
            // 
            this.dtp_DateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateFinish.Location = new System.Drawing.Point(140, 269);
            this.dtp_DateFinish.Name = "dtp_DateFinish";
            this.dtp_DateFinish.Size = new System.Drawing.Size(95, 22);
            this.dtp_DateFinish.TabIndex = 12;
            // 
            // lbl_DateFinish
            // 
            this.lbl_DateFinish.AutoSize = true;
            this.lbl_DateFinish.Location = new System.Drawing.Point(137, 248);
            this.lbl_DateFinish.Name = "lbl_DateFinish";
            this.lbl_DateFinish.Size = new System.Drawing.Size(126, 17);
            this.lbl_DateFinish.TabIndex = 11;
            this.lbl_DateFinish.Text = "Data de conclusão";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(15, 314);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(71, 17);
            this.lbl_Description.TabIndex = 13;
            this.lbl_Description.Text = "Descrição";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(18, 334);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(354, 196);
            this.txt_Description.TabIndex = 14;
            // 
            // btn_AddEmployee
            // 
            this.btn_AddEmployee.Location = new System.Drawing.Point(19, 546);
            this.btn_AddEmployee.Name = "btn_AddEmployee";
            this.btn_AddEmployee.Size = new System.Drawing.Size(353, 39);
            this.btn_AddEmployee.TabIndex = 15;
            this.btn_AddEmployee.Text = "Adicionar Funcionário";
            this.btn_AddEmployee.UseVisualStyleBackColor = true;
            this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
            // 
            // lbl_tvwTeams
            // 
            this.lbl_tvwTeams.AutoSize = true;
            this.lbl_tvwTeams.Location = new System.Drawing.Point(563, 54);
            this.lbl_tvwTeams.Name = "lbl_tvwTeams";
            this.lbl_tvwTeams.Size = new System.Drawing.Size(59, 17);
            this.lbl_tvwTeams.TabIndex = 16;
            this.lbl_tvwTeams.Text = "Equipas";
            // 
            // tvw_Teams
            // 
            this.tvw_Teams.Location = new System.Drawing.Point(566, 75);
            this.tvw_Teams.Name = "tvw_Teams";
            this.tvw_Teams.Size = new System.Drawing.Size(332, 455);
            this.tvw_Teams.TabIndex = 17;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(566, 546);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(332, 39);
            this.btn_Save.TabIndex = 18;
            this.btn_Save.Text = "Guardar";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // erp_Errors
            // 
            this.erp_Errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp_Errors.ContainerControl = this;
            this.erp_Errors.Icon = ((System.Drawing.Icon)(resources.GetObject("erp_Errors.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 614);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tvw_Teams);
            this.Controls.Add(this.lbl_tvwTeams);
            this.Controls.Add(this.btn_AddEmployee);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.dtp_DateFinish);
            this.Controls.Add(this.lbl_DateFinish);
            this.Controls.Add(this.dtp_StartDate);
            this.Controls.Add(this.lbl_DateStart);
            this.Controls.Add(this.chb_PersonInCharge);
            this.Controls.Add(this.chb_Cordinator);
            this.Controls.Add(this.lbl_TaskName);
            this.Controls.Add(this.cbb_Team);
            this.Controls.Add(this.lbl_Team);
            this.Controls.Add(this.cbb_Employee);
            this.Controls.Add(this.txt_TaskName);
            this.Controls.Add(this.lbl_Employee);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.erp_Errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Employee;
        private System.Windows.Forms.TextBox txt_TaskName;
        private System.Windows.Forms.ComboBox cbb_Employee;
        private System.Windows.Forms.Label lbl_Team;
        private System.Windows.Forms.ComboBox cbb_Team;
        private System.Windows.Forms.Label lbl_TaskName;
        private System.Windows.Forms.CheckBox chb_Cordinator;
        private System.Windows.Forms.CheckBox chb_PersonInCharge;
        private System.Windows.Forms.Label lbl_DateStart;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.DateTimePicker dtp_DateFinish;
        private System.Windows.Forms.Label lbl_DateFinish;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Button btn_AddEmployee;
        private System.Windows.Forms.Label lbl_tvwTeams;
        private System.Windows.Forms.TreeView tvw_Teams;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ErrorProvider erp_Errors;
    }
}

