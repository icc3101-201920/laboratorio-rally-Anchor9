using ModelosRally;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasRally
{
    public partial class Form1 : Form
    {
        public event EventHandler<AgregarPilotoEventArgs> OnAgregarPiloto;

        public Form1()
        {
            InitializeComponent();
            this.RolComboBox.DataSource = Enum.GetValues(typeof(Rol));
        }

        private void AgregarPilotoButton_Click(object sender, EventArgs e)//Boton agregar piloto
        {
            if (OnAgregarPiloto != null) // si el evento no está suscrito que haga lo sgte
            {
                AgregarPilotoEventArgs pilotoArgs = new AgregarPilotoEventArgs(); //crear el objeto
                pilotoArgs.nombre = this.NameTextBox.Text; //el textbox se va a llamar de esa forma
                OnAgregarPiloto(this, pilotoArgs);
                // object sender = lo que escribo le va a llegar al OnAgregarPiloto 
            }
               
        }

        public void ActualizarListadoPilotos(Persona pilotoNuevo)//metodo para agregar pilotos en la forma

        {
            //agrega un piloto a la lista
            PilotNameComboBox.Items.Add(pilotoNuevo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PilotNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
