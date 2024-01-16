using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNominasGit
{
    public class Nomina
    {
        // MIEMBROS PRIVADOS DE LA CLASE
        private string _nombre;
        private string _apellidos;
        private string _puesto;
        private int _horasTrabajadas;
        private float _salarioHora;

        // PROPIEDADES
        /// <summary>
        /// Nombre del Empleado
        /// </summary>
        public string NombreEmpleado
        {
            get 
            {
                // Control de Contenido
                if (string.IsNullOrEmpty(_nombre))
                {
                    throw new Exception("Nombre del trabajador no establecido.");
                }

                // Devolución del Valor
                return _nombre;
            }
            set 
            {
                // Validación de los Datos a Establecer
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("El nombre del trabajador no puede ser Null o la cadena vacía.");
                }

                // Establecimiento del valor al miembro privado
                _nombre = value;
            }
        }
    }
}
