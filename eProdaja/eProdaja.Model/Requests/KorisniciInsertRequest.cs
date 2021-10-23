using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Model.Requests
{
    public class KorisniciInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        [MaxLength(20)]
        public string Ime { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        [MaxLength(20)]
        public string Prezime { get; set; }
        [Required(AllowEmptyStrings =false)]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Telefon { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string KorisnickoIme { get; set; }
        [Required(AllowEmptyStrings = false)]
        public bool? Status { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        public string Lozinka { get; set; }
    }
}
