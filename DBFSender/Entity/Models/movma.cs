namespace DBFSender.Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("movma")]
    public partial class movma : BaseModel
    {
        public int ID { get; set; }

        public int numero { get; set; }

        [StringLength(250)]
        public string doc { get; set; }

        [StringLength(250)]
        public string Almacen { get; set; }

        public int? Cliente { get; set; }

        public DateTime? fecha { get; set; }

        public DateTime? vence { get; set; }

        [StringLength(250)]
        public string vendedor { get; set; }

        public int? orden { get; set; }

        public int? conduce { get; set; }

        public int? condicion { get; set; }

        [StringLength(500)]
        public string comentario { get; set; }

        public decimal? flujo { get; set; }

        [StringLength(250)]
        public string entidad { get; set; }

        public decimal? pagares { get; set; }

        public DateTime? vencepag { get; set; }

        public decimal? inicial { get; set; }

        public int? fpago { get; set; }

        public decimal? descper { get; set; }

        public decimal? descval { get; set; }

        public bool? itbis { get; set; }

        public decimal? itbisval { get; set; }

        public decimal? bruto { get; set; }

        public decimal? cargo { get; set; }

        public bool? transferid { get; set; }

        public bool? transalm { get; set; }

        [StringLength(250)]
        public string time { get; set; }

        public bool? impreso { get; set; }

        public bool? serial { get; set; }

        [StringLength(250)]
        public string ddoc { get; set; }

        public int? dnumero { get; set; }

        public decimal? pgdo { get; set; }

        public decimal? otrcargo { get; set; }

        [StringLength(250)]
        public string ncf { get; set; }

        [StringLength(50)]
        public string statussync { get; set; }
    }
}
