using static PooTA01_2.Producto;

namespace PooTA01_2
{
    public partial class RegistroProducto : Form
    {
        JsonArchivo<Producto> bd = new JsonArchivo<Producto>("Productos.json"); //puede ser de extension .json o .txt

        void mostrar(List<Producto> lista)
        {
            dataGridViewDatos.Rows.Clear();

            foreach (Producto p in lista)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Codigo });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.Nombre });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.cantidad });
                fila.Cells.Add(new DataGridViewTextBoxCell() { Value = p.descripcion });
                dataGridViewDatos.Rows.Add(fila);
            }
            void mostrar(List<Producto> lista) { }

        }
        public RegistroProducto()
        {
            InitializeComponent();
            bd.Cargar();
            mostrar(bd.valores);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto p = bd.Buscar(x => x.Codigo.ToString() == dataGridViewDatos.CurrentRow.Cells[0].Value.ToString())[0];
            textBoxCodigo.Text = p.Codigo.ToString();
            textBoxProducto.Text = p.Nombre;
            textBoxCantidad.Text = p.cantidad.ToString();
            textBoxDescripcion.Text = p.descripcion;
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            bd.Cargar();
            mostrar(bd.valores);
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            int Codigo = int.Parse(textBoxCodigo.Text);
            int Cantidad = int.Parse(textBoxCantidad.Text);
            Producto p = new Producto(Codigo, Cantidad, textBoxProducto.Text, textBoxDescripcion.Text);
            bd.Actualizar(x => x.Codigo == Codigo, p);
            mostrar(bd.valores);
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            int Codigo = int.Parse(textBoxCodigo.Text);
            bd.Eliminar(x => x.Codigo == Codigo);
            mostrar(bd.valores);
        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            var lista = bd.Buscar(x => x.Nombre.Contains(textBoxBusqueda.Text));
            mostrar(lista);
        }
    }
}
