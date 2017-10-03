namespace DAL.Model
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Drzava")]
    public partial class Drzava
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drzava()
        {
            Grads = new HashSet<Grad>();
        }

        [Key]
        public int IDDrzava { get; set; }

        [StringLength(50)]
        public string Naziv { get; set; }

        [JsonIgnore]
        public virtual ICollection<Grad> Grads { get; set; }
    }
}
