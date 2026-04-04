using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationSystem.EF6
{
    [Table("MenuT")]
    public class MenuTModel
    {
        public int Id { get; set; }
        public string MenuText { get; set; }
        public string MenuImage { get; set; }
        public string MenuPage { get; set; }
    }
}
