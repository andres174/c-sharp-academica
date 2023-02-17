using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosLogroC;

namespace LogicaNegocioLogroC
{
    public class CatalogoAlumno
    {
        ACADEMICAEntities AlumnoDB = new ACADEMICAEntities();

        public void ingresar_alumno(Alumno dato)
        {
            AlumnoDB.ingresarAlumno(dato.DNI, dato.Nombre, dato.Apellido, dato.Sexo, dato.FechaNacimiento);


        }
         public void eliminar_alumno(Alumno dato)
        {
            AlumnoDB.eliminarAlumno(dato.IdAlumno);
        }

        public void modificar_alumno(Alumno dato)
        {
            AlumnoDB.modificarAlumno(dato.IdAlumno, dato.DNI, dato.Nombre, dato.Apellido, dato.Sexo, dato.FechaNacimiento);
        }

        public List<Alumno> obtenerAlumno()
        {
            List<Alumno> Alu = new List<Alumno>();

            foreach (var item in AlumnoDB.obtenerAlumno())
            {
                Alu.Add(new Alumno(item.IdAlumno, item.DNI, item.Apellido, item.Nombre, item.Sexo, item.fechaNacimiento));
            }
            return Alu;
        }

        public Alumno obtener_alumno(string DNI)
        {
            return obtenerAlumno().Where(p => p.DNI == DNI).FirstOrDefault();
        }

        //public Alumno obtener_alumno(int IdAlumno)
        //{
        //    return obtenerAlumno().Where(p => p.IdAlumno == IdAlumno).FirstOrDefault();
        //}



    }
}
