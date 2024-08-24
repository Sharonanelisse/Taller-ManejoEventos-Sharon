using EjercicioAgo17.Clases;

namespace EjercicioAgo17
{
    public partial class ControlTarea : Form
    {
        List<Tarea> tareas = new List<Tarea>();

        public ControlTarea()
        {
            InitializeComponent();
            NombreTarea.KeyDown += new KeyEventHandler(NombreTarea_KeyDown);
            flowPanelTareaSinEmpezar.MouseDoubleClick += flowPanelTareaSinEmpezar_MouseDoubleClick;
            flowPanelTareaPendientes.MouseDoubleClick += flowPanelTareaPendientes_MouseDoubleClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaEstado.BeginUpdate();
            ListaEstado.Items.Add("Sin Empezar");
            ListaEstado.Items.Add("En Progreso");
            ListaEstado.Items.Add("Completado");
            ListaEstado.EndUpdate();
        }

        private void AgregarTarea()
        {
            if (NombreTarea.Text.Trim() == "")
            {
                MessageBox.Show("Tienes que agregar un nombre a la tarea");
                return;
            }

            string? estadoSeleccionado = ListaEstado.SelectedItem?.ToString();
            Tarea nuevaTarea = new Tarea(NombreTarea.Text, DateTime.Now, estadoSeleccionado);
            tareas.Add(nuevaTarea);
            this.renderizarTareas();
            NombreTarea.Clear();
            ListaEstado.ResetText();
        }

        private void NombreTarea_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ListaEstado.SelectedIndex != -1)
                {
                    AgregarTarea();
                    e.Handled = true;
                }
                else
                {
                    MessageBox.Show("Tienes que seleccionar el estado de tu tarea");
                }
            }
        }

        private void BotonTarea_Click(object sender, EventArgs e)
        {
            AgregarTarea();
        }

        private void ListaEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void NombreTarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void EliminarTarea_Click(object sender, EventArgs e)
        {
        }

        private void renderizarTareas()
        {
            flowPanelTareaPendientes.Controls.Clear();
            flowPanelTareaCompletadas.Controls.Clear();
            flowPanelTareaSinEmpezar.Controls.Clear();

            foreach (Tarea tarea in tareas)
            {
                Label etiquetaTarea = new Label
                {
                    Text = tarea.nombre,
                    AutoSize = true,
                    Padding = new Padding(5),
                    Margin = new Padding(2),
                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    BorderStyle = BorderStyle.FixedSingle
                };

                etiquetaTarea.MouseEnter += EtiquetaTarea_MouseEnter;
                etiquetaTarea.MouseLeave += EtiquetaTarea_MouseLeave;
                etiquetaTarea.MouseDoubleClick += EtiquetaTarea_MouseDoubleClick;

                if (tarea.estado == "Sin Empezar")
                {
                    flowPanelTareaSinEmpezar.Controls.Add(etiquetaTarea);
                }
                else if (tarea.estado == "En Progreso")
                {
                    flowPanelTareaPendientes.Controls.Add(etiquetaTarea);
                }
                else if (tarea.estado == "Completado")
                {
                    flowPanelTareaCompletadas.Controls.Add(etiquetaTarea);
                }
            }
        }

        private void EtiquetaTarea_MouseEnter(object? sender, EventArgs e)
        {
            Label? etiqueta = sender as Label;
            if (etiqueta != null)
            {
                etiqueta.BackColor = Color.LightGray;
            }
        }

        private void EtiquetaTarea_MouseLeave(object? sender, EventArgs e)
        {
            Label? etiqueta = sender as Label;
            if (etiqueta != null)
            {
                etiqueta.BackColor = Color.White;
            }
        }

        private void EtiquetaTarea_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            if (sender is Label etiqueta)
            {
                Tarea? tareaEliminar = tareas.FirstOrDefault(t => t.nombre == etiqueta.Text);

                if (tareaEliminar != null)
                {
                    if (flowPanelTareaSinEmpezar.Controls.Contains(etiqueta))
                    {
                        tareas.Remove(tareaEliminar);
                        this.renderizarTareas();
                    }
                }
            }
        }

        private void flowPanelTareaPendientes_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            if (sender is FlowLayoutPanel panel)
            {
                var tareaSeleccionada = panel.GetChildAtPoint(e.Location) as Label;

                if (tareaSeleccionada != null)
                {
                    Tarea? tareaMover = tareas.FirstOrDefault(t => t.nombre == tareaSeleccionada.Text);

                    if (tareaMover != null)
                    {
                        tareaMover.estado = "Completado";
                        this.renderizarTareas();
                    }
                }
            }
        }

        private void flowPanelTareaSinEmpezar_MouseDoubleClick(object? sender, MouseEventArgs e)
        {

        }
    }
}