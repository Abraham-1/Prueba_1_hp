using System;
using System.Collections.Generic;

namespace prueba_1_hp.Models;

public partial class Asignatura
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Codigo { get; set; }

    public DateOnly? FechaActualizacion { get; set; }

    public virtual ICollection<EstudianteHasAsignatura> EstudianteHasAsignaturas { get; set; } = new List<EstudianteHasAsignatura>();
}
