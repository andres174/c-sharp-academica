﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatosLogroC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class ACADEMICAEntities : DbContext
    {
        public ACADEMICAEntities()
            : base("name=ACADEMICAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int eliminarAlumno(Nullable<int> idAlumno)
        {
            var idAlumnoParameter = idAlumno.HasValue ?
                new ObjectParameter("IdAlumno", idAlumno) :
                new ObjectParameter("IdAlumno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("eliminarAlumno", idAlumnoParameter);
        }
    
        public virtual int ingresarAlumno(string dNI, string nombre, string apellido, string sexo, Nullable<System.DateTime> fechaNacimiento)
        {
            var dNIParameter = dNI != null ?
                new ObjectParameter("DNI", dNI) :
                new ObjectParameter("DNI", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("fechaNacimiento", fechaNacimiento) :
                new ObjectParameter("fechaNacimiento", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ingresarAlumno", dNIParameter, nombreParameter, apellidoParameter, sexoParameter, fechaNacimientoParameter);
        }
    
        public virtual int ingresarMatricula(string codigo, Nullable<System.DateTime> fecha, string periodo, Nullable<int> idAlumno, Nullable<int> idSemestre)
        {
            var codigoParameter = codigo != null ?
                new ObjectParameter("Codigo", codigo) :
                new ObjectParameter("Codigo", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            var periodoParameter = periodo != null ?
                new ObjectParameter("Periodo", periodo) :
                new ObjectParameter("Periodo", typeof(string));
    
            var idAlumnoParameter = idAlumno.HasValue ?
                new ObjectParameter("IdAlumno", idAlumno) :
                new ObjectParameter("IdAlumno", typeof(int));
    
            var idSemestreParameter = idSemestre.HasValue ?
                new ObjectParameter("IdSemestre", idSemestre) :
                new ObjectParameter("IdSemestre", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ingresarMatricula", codigoParameter, fechaParameter, periodoParameter, idAlumnoParameter, idSemestreParameter);
        }
    
        public virtual int modificarAlumno(Nullable<int> idAlumno, string dNI, string nombre, string apellido, string sexo, Nullable<System.DateTime> fechaNacimiento)
        {
            var idAlumnoParameter = idAlumno.HasValue ?
                new ObjectParameter("IdAlumno", idAlumno) :
                new ObjectParameter("IdAlumno", typeof(int));
    
            var dNIParameter = dNI != null ?
                new ObjectParameter("DNI", dNI) :
                new ObjectParameter("DNI", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("Apellido", apellido) :
                new ObjectParameter("Apellido", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("fechaNacimiento", fechaNacimiento) :
                new ObjectParameter("fechaNacimiento", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("modificarAlumno", idAlumnoParameter, dNIParameter, nombreParameter, apellidoParameter, sexoParameter, fechaNacimientoParameter);
        }
    
        public virtual ObjectResult<obtenerAlumno_Result> obtenerAlumno()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<obtenerAlumno_Result>("obtenerAlumno");
        }
    
        public virtual ObjectResult<obtenerAsignatura_Result> obtenerAsignatura()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<obtenerAsignatura_Result>("obtenerAsignatura");
        }
    
        public virtual ObjectResult<obtenerMatricula_Result> obtenerMatricula()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<obtenerMatricula_Result>("obtenerMatricula");
        }
    
        public virtual ObjectResult<obtenerSemestre_Result> obtenerSemestre()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<obtenerSemestre_Result>("obtenerSemestre");
        }
    }
}