using System;
using System.Collections.Generic;

namespace prueba_1_hp.Models;

public partial class EstudianteHasAsignatura
{
    public int EstudianteId { get; set; }

    public int AsignaturasId { get; set; }

    public int Id { get; set; }

    public virtual Asignatura Asignaturas { get; set; } = null!;

    public virtual Estudiante Estudiante { get; set; } = null!;
}
