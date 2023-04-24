using System;
using System.Collections.Generic;

namespace prueba_1_hp.Models;

public partial class Estudiante
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Rut { get; set; }

    public string? Direccion { get; set; }

    public string? Email { get; set; }

    public string? Edad { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public virtual ICollection<EstudianteHasAsignatura> EstudianteHasAsignaturas { get; set; } = new List<EstudianteHasAsignatura>();
}
