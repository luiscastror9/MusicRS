using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BandasWeb.Models
{
    public class UsuariosModels
    { }
        public class Tabla_de_salas
        {
            public List<SalasloadModel> lista_salas { get; set; }
        }
        public class SalasloadModel
        {
            public string Nombre_sala { get; set; }
            public string Nombre_dueno { get; set; }
            public int max_musicos { get; set; }
            public decimal ancho { get; set; }
            public decimal largo { get; set; }
            public string Descripcion { get; set; }
        }
        public class SalasSaveModel
        {
        [Display(Name = "Nombre de la sala")]
        public string Nombre_sala { get; set; }
        
        public string Nombre_dueno { get; set; }
        [Display(Name = "capacidad maxima")]
        public int max_musicos { get; set; }
        [Display(Name = "Ancho")]
        public decimal ancho { get; set; }
        [Display(Name = "Largo")]
        public decimal largo { get; set; }
            public string Descripcion { get; set; }
            public bool de8a10 { get; set; }
        public bool de10a12 { get; set; }
        public bool de12a14 { get; set; }
        public bool de14a16 { get; set; }
        public bool de16a18 { get; set; }
        public bool de18a20 { get; set; }
        public bool de20a22 { get; set; }
        public bool de22a24 { get; set; }
        public bool carac_guitarra_ampli_50w { get; set; }
        public bool carac_guitarra_ampli_100w { get; set; }
        public bool carac_bajo_ampli_100w { get; set; }
        public bool carac_bajo_ampli_200w { get; set; }
        public bool carac_bateria_4cuerpos { get; set; }
        public bool carac_bateria_5cuerpos { get; set; }
        public bool carac_bateria_6cuerpos { get; set; }
        public bool carac_parlantes { get; set; }

    }
    }
