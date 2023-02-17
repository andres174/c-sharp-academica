using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioLogroC
{
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public string DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Alumno()
        {

        }

        public Alumno(int _IdAlumno, string _DNI, string _Apellido, string _Nombre, string _Sexo, DateTime _FechaNacimiento)
        {
            IdAlumno = _IdAlumno;
            DNI = _DNI;
            Apellido = _Apellido;
            Nombre = _Nombre;
            Sexo = _Sexo;
            FechaNacimiento = _FechaNacimiento;

        }

        public Alumno(string _DNI, string _Apellido, string _Nombre, string _Sexo, DateTime _FechaNacimiento)
        {
            DNI = _DNI;
            Apellido = _Apellido;
            Nombre = _Nombre;
            Sexo = _Sexo;
            FechaNacimiento = _FechaNacimiento;

        }

    }
}
