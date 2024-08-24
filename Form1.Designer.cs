
namespace EjercicioAgo17
{
    partial class ControlTarea
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NombreTarea = new TextBox();
            flowPanelTareaPendientes = new FlowLayoutPanel();
            flowPanelTareaSinEmpezar = new FlowLayoutPanel();
            flowPanelTareaCompletadas = new FlowLayoutPanel();
            LabelTareasSinEmpezar = new Label();
            LabelTareasEnPogreso = new Label();
            label1 = new Label();
            ListaEstado = new ComboBox();
            SuspendLayout();
            // 
            // NombreTarea
            // 
            NombreTarea.Location = new Point(23, 20);
            NombreTarea.Margin = new Padding(2, 1, 2, 1);
            NombreTarea.Name = "NombreTarea";
            NombreTarea.PlaceholderText = "Ingrese su tarea";
            NombreTarea.Size = new Size(371, 23);
            NombreTarea.TabIndex = 0;
            NombreTarea.TextChanged += NombreTarea_TextChanged;
            // 
            // flowPanelTareaPendientes
            // 
            flowPanelTareaPendientes.FlowDirection = FlowDirection.TopDown;
            flowPanelTareaPendientes.Location = new Point(197, 77);
            flowPanelTareaPendientes.Margin = new Padding(2, 1, 2, 1);
            flowPanelTareaPendientes.Name = "flowPanelTareaPendientes";
            flowPanelTareaPendientes.Size = new Size(157, 191);
            flowPanelTareaPendientes.TabIndex = 3;
            // 
            // flowPanelTareaSinEmpezar
            // 
            flowPanelTareaSinEmpezar.FlowDirection = FlowDirection.TopDown;
            flowPanelTareaSinEmpezar.Location = new Point(23, 77);
            flowPanelTareaSinEmpezar.Margin = new Padding(2, 1, 2, 1);
            flowPanelTareaSinEmpezar.Name = "flowPanelTareaSinEmpezar";
            flowPanelTareaSinEmpezar.Size = new Size(157, 191);
            flowPanelTareaSinEmpezar.TabIndex = 4;
            flowPanelTareaSinEmpezar.Paint += flowPanelTareaSinEmpezar_Paint;
            flowPanelTareaSinEmpezar.MouseDoubleClick += flowPanelTareaSinEmpezar_MouseDoubleClick;
            // 
            // flowPanelTareaCompletadas
            // 
            flowPanelTareaCompletadas.FlowDirection = FlowDirection.TopDown;
            flowPanelTareaCompletadas.Location = new Point(371, 77);
            flowPanelTareaCompletadas.Margin = new Padding(2, 1, 2, 1);
            flowPanelTareaCompletadas.Name = "flowPanelTareaCompletadas";
            flowPanelTareaCompletadas.Size = new Size(157, 191);
            flowPanelTareaCompletadas.TabIndex = 4;
            // 
            // LabelTareasSinEmpezar
            // 
            LabelTareasSinEmpezar.AutoSize = true;
            LabelTareasSinEmpezar.Location = new Point(45, 56);
            LabelTareasSinEmpezar.Name = "LabelTareasSinEmpezar";
            LabelTareasSinEmpezar.Size = new Size(105, 15);
            LabelTareasSinEmpezar.TabIndex = 5;
            LabelTareasSinEmpezar.Text = "Tareas sin Empezar";
            // 
            // LabelTareasEnPogreso
            // 
            LabelTareasEnPogreso.AutoSize = true;
            LabelTareasEnPogreso.Location = new Point(223, 56);
            LabelTareasEnPogreso.Name = "LabelTareasEnPogreso";
            LabelTareasEnPogreso.Size = new Size(105, 15);
            LabelTareasEnPogreso.TabIndex = 6;
            LabelTareasEnPogreso.Text = "Tareas en Progreso";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(401, 56);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 7;
            label1.Text = "Tareas Completadas";
            // 
            // ListaEstado
            // 
            ListaEstado.FormattingEnabled = true;
            ListaEstado.Location = new Point(407, 20);
            ListaEstado.Name = "ListaEstado";
            ListaEstado.Size = new Size(121, 23);
            ListaEstado.TabIndex = 9;
            ListaEstado.SelectedIndexChanged += ListaEstado_SelectedIndexChanged_1;
            // 
            // ControlTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 278);
            Controls.Add(ListaEstado);
            Controls.Add(label1);
            Controls.Add(LabelTareasEnPogreso);
            Controls.Add(LabelTareasSinEmpezar);
            Controls.Add(flowPanelTareaCompletadas);
            Controls.Add(flowPanelTareaSinEmpezar);
            Controls.Add(flowPanelTareaPendientes);
            Controls.Add(NombreTarea);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(2, 1, 2, 1);
            Name = "ControlTarea";
            Text = "ControlTarea";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void flowPanelTareaSinEmpezar_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        private TextBox NombreTarea;
        private FlowLayoutPanel flowPanelTareaPendientes;
        private FlowLayoutPanel flowPanelTareaSinEmpezar;
        private FlowLayoutPanel flowPanelTareaCompletadas;
        private Label LabelTareasSinEmpezar;
        private Label LabelTareasEnPogreso;
        private Label label1;
        private ComboBox ListaEstado;
    }
}