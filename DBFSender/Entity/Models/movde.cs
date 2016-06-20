namespace DBFSender.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("movde")]
    public partial class movde : baseModel
    {
        public int Id { get; set; }

        public int? linea { get; set; }

        [StringLength(250)]
        public string buscar { get; set; }

        [StringLength(250)]
        public string doc { get; set; }

        public int? numero { get; set; }

        [StringLength(250)]
        public string almacen { get; set; }

        public int? merc { get; set; }

        public decimal? cantidad { get; set; }

        public int? frag { get; set; }

        public decimal? precio { get; set; }

        public decimal? costo { get; set; }

        public decimal? total { get; set; }

        public DateTime? fecha { get; set; }

        public decimal? flujo { get; set; }

        [StringLength(250)]
        public string unidad { get; set; }

        [StringLength(250)]
        public string serial { get; set; }

        [StringLength(250)]
        public string color { get; set; }

        [StringLength(50)]
        public string statussync { get; set; }

    }
}
