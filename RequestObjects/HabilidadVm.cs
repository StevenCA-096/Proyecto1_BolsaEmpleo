﻿using Proyecto1_BolsaEmpleo.Models;

namespace Proyecto1_BolsaEmpleo.RequestObjects
{
    public class HabilidadVm
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Candidato> candidatos { get; set; }
        public List<Empresa> empresas { get; set; }
    }
}
