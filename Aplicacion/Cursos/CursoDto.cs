using System.Collections.Generic;
using System;

namespace Aplicacion.Cursos
{
    public class CursoDto
    {
        public Guid CursoId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public byte[] FotoPortada { get; set; }
        public DateTime FechaCreacion { get; set; }
        public ICollection<InstructorDto> Instructores { get; set; }

        public PrecioDTO Precio { get; set; }

        public ICollection<ComentarioDTO> Comentarios { get; set; }
    }
}