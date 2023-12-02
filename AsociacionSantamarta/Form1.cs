using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsociacionSantamarta.Modelo;
using AsociacionSantamarta.Logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AsociacionSantamarta
{
    public partial class Form1 : Form
    {
        string dato = "";
      
        public Form1()
        {
            InitializeComponent();
        }

    
        

        public bool ValidarDNI(string dni)
        {
            const string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
            bool esValido = false;

            if (!string.IsNullOrEmpty(dni) && dni.Length == 9)
            {
                var letra = dni[dni.Length - 1]; // Último carácter del DNI
                var numero = dni.Substring(0, dni.Length - 1); // Todos los caracteres menos el último

                if (int.TryParse(numero, out int num) && char.IsLetter(letra))
                {
                    var letraCalculada = letras[num % 23];

                    if (char.ToUpper(letra) == letraCalculada)
                    {
                        esValido = true;
                    }
                }
            }

            return esValido;
        }

        private void ActualizaStatustri()
        {
            toolStripStatusLabel1.Text = "Componentes Creados: " + dgvpersonas.Rows.Count.ToString();
            // Comprueba si hay filas en el DataGridView
            if (dgvpersonas.Rows.Count > 0)
            {
                // Obtiene la última fila
                DataGridViewRow ultimaFila = dgvpersonas.Rows[dgvpersonas.Rows.Count - 1];

                // Muestra los datos de la última fila en el StatusStrip
                // Asegúrate de cambiar "NombreColumna" por el nombre de la columna que quieres mostrar
                toolStripLabel1.Text = "Último Registro: " +
            
            "Nombre: " + ultimaFila.Cells["Nombre"].Value.ToString() + ", " +
            "Apellidos: " + ultimaFila.Cells["Apellido"].Value.ToString() + ", " +
            "DNI: " + ultimaFila.Cells["Dni"].Value.ToString();
            }

        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Verifica si los TextBoxes están vacíos
            if (string.IsNullOrWhiteSpace(txtidpersona.Text) ||
                string.IsNullOrWhiteSpace(txtnombre.Text) ||
                string.IsNullOrWhiteSpace(txtapellido.Text) ||
                string.IsNullOrWhiteSpace(txtdni.Text))
            {
                MessageBox.Show("Por favor, rellena todos los campos antes de Guardar.");
                return;
            }
            Persona objeto = new Persona()
            {
                Id = Int32.Parse(txtidpersona.Text.Trim()),
                Nombre = txtnombre.Text.Trim(),
                Apellido = txtapellido.Text.Trim(),
                Dni = txtdni.Text.Trim(), // Se ha cambiado el telefono por Dni
            };

            bool respuesta = PersonaLogica.Instancia.Guardar(objeto);

            if (respuesta)
            {
                limpiar();
                mostrar_persona();
                ActualizaStatustri();
            }
            
            // Luego actualiza el StatusStrip
            ActualizaStatustri();

        }
        public void mostrar_persona()
        {
            dgvpersonas.DataSource = null;
            dgvpersonas.DataSource = PersonaLogica.Instancia.Listar();
            dgvpersonas.Columns["Id"].HeaderText = "Identificación";
            dgvpersonas.Columns["Nombre"].HeaderText = "Nombre";
            dgvpersonas.Columns["Apellido"].HeaderText = "Apellidos";
            dgvpersonas.Columns["Dni"].HeaderText = "DNI";
            // Cambia el ancho de la columna
            dgvpersonas.Columns["Nombre"].Width = 100;
            dgvpersonas.Columns["Apellido"].Width = 150;
            // Cambia el ancho de la columna
            dgvpersonas.Columns["Dni"].Width = 100;
        }

        public void limpiar()
        {
            txtidpersona.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtdni.Text = "";
            txtidpersona.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrar_persona();
            ActualizaStatustri();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // Verifica si los TextBoxes están vacíos
            if (string.IsNullOrWhiteSpace(txtidpersona.Text) ||
                string.IsNullOrWhiteSpace(txtnombre.Text) ||
                string.IsNullOrWhiteSpace(txtapellido.Text) ||
                string.IsNullOrWhiteSpace(txtdni.Text))
            {
                MessageBox.Show("Por favor, rellena todos los campos antes de editar.");
                return;
            }
            Persona objeto = new Persona()
            {
                Id = Int32.Parse(txtidpersona.Text.Trim()),
                Nombre = txtnombre.Text.Trim(),
                Apellido = txtapellido.Text.Trim(),
                Dni = txtdni.Text.Trim(),
            };
            bool respuesta = PersonaLogica.Instancia.editar(objeto);
            string dni = txtdni.Text; // Asume que txtDNI es tu TextBox para el DNI
            bool esValido = ValidarDNI(dni);

            if (esValido)
            {
                MessageBox.Show("El DNI es válido.");
            }
            else
            {
                // Si el DNI no es válido, muestra un mensaje al usuario
                MessageBox.Show("El DNI ingresado no es válido. Por favor, inténtalo de nuevo.");
            }


            if (respuesta)
            {
                limpiar();
                mostrar_persona();
                ActualizaStatustri();
            }

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            // Verifica si los TextBoxes están vacíos
            if (string.IsNullOrWhiteSpace(txtidpersona.Text) ||
                string.IsNullOrWhiteSpace(txtnombre.Text) ||
                string.IsNullOrWhiteSpace(txtapellido.Text) ||
                string.IsNullOrWhiteSpace(txtdni.Text))
            {
                MessageBox.Show("Por favor, rellena todos los campos antes de Eliminar.");
                return;
            }
            // Muestra un cuadro de diálogo de confirmación
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres eliminar este elemento?", "Confirmación de eliminación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // El usuario ha confirmado la eliminación, procede a eliminar
                Persona objeto = new Persona()
                {
                    Id = Int32.Parse(txtidpersona.Text)
                };
                bool respuesta = PersonaLogica.Instancia.eliminar(objeto);

                if (respuesta)
                {
                    limpiar();
                    mostrar_persona();
                    ActualizaStatustri();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                // El usuario ha cancelado la eliminación
            }
        }

        private void dgvpersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegúrate de que se ha seleccionado una fila
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvpersonas.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los TextBoxes
                txtidpersona.Text = row.Cells["Id"].Value.ToString();
                txtnombre.Text = row.Cells["Nombre"].Value.ToString();
                txtapellido.Text = row.Cells["Apellido"].Value.ToString();
                txtdni.Text = row.Cells["Dni"].Value.ToString();
                
                // Continúa para el resto de las celdas...
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmación de salida", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCompDni_Click(object sender, EventArgs e)
        {
            string dni = txtdni.Text; // Asume que txtDNI es tu TextBox para el DNI
            bool esValido = ValidarDNI(dni);

            if (esValido)
            {
                MessageBox.Show("DNI  válido.");
            }
            else
            {
                // Si el DNI no es válido, muestra un mensaje al usuario
                MessageBox.Show("El DNI ingresado no es válido. Por favor, inténtalo de nuevo.");
            }

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                if(radioButton1.Checked ==false && radioButton2.Checked == false)
                {
                    MessageBox.Show("SELECIONA TIPO DE BUSQUEDA ID O NOMBRE");
                }
                else
                {
                    if(radioButton1.Checked == true) 
                    {
                        Busqueda_en_Grid(dgvpersonas, 0);
                    } else if(radioButton2.Checked == true)
                    {
                        Busqueda_en_Grid(dgvpersonas, 1);
                    }
                    txtbuscar.Clear();
                }
            }
            else
            {
                MessageBox.Show("RELLENAR CASILLA DE BUSQUEDA");
            }
        }

        private void Busqueda_en_Grid(DataGridView d, int col)
        {
            for (int i = 0; i < d.Rows.Count -1; i++)
            {
                dato =Convert.ToString(d.Rows[i].Cells[col].Value);
                if (dato == txtbuscar.Text.Trim()) 
                {
                    txtidpersona.Text = Convert.ToString(d.Rows[i].Cells[0].Value);
                    txtnombre.Text  = Convert.ToString(d.Rows[i].Cells[1].Value);
                    txtapellido.Text = Convert.ToString(d.Rows[i].Cells[2].Value);
                    txtdni.Text = Convert.ToString(d.Rows[i].Cells[3].Value);
                    break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString("G");
        }
    }
}
