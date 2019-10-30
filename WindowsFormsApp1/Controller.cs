using ModelosRally;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasRally
{
    class Controller
    {
        List<Persona> Pilotos;
        Form1 vistaPilotos;


        
        public Controller(Form1 vistaPilotos)
        // El controlador reciBe una forma 
        {
            Pilotos = new List<Persona>(); //Crea un objeto piloto
            this.vistaPilotos = vistaPilotos; 
            this.vistaPilotos.OnAgregarPiloto += VistaPilotos_OnAgregarPiloto; // suscribe un evento vista_piloto
         }

        private void VistaPilotos_OnAgregarPiloto(object sender, AgregarPilotoEventArgs e)
        {
            //agregar pilotos

            Persona piloto = new Persona(e.nombre, Rol.Piloto);// creo piloto nuevo con sus caract
            Pilotos.Add(piloto);//lo agrego a la lista
            vistaPilotos.ActualizarListadoPilotos(piloto);//ejecuto el metodo de agregar piloto que hice en el forms
            
            //este metodo se va a suscribir al controlador de arriba en la forma se creará el evento,
            //de que cuando no esté suscrito haga eso, y así irá agregando los datos correspondientes.
        }


    }
}
