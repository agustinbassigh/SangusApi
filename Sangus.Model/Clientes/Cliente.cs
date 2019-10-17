using Sangus.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sangus.Model.Clientes
{
    public class Cliente : BaseEntity
    {
        public string ApellidoNombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

    }
}
