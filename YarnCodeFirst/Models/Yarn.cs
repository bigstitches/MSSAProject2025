using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Identity.Client;

namespace YarnCodeFirst.Models
{
    public enum Weight
    {
        FINGERING = 1,
        SOCK,
        DK,
        WORSTED,
        ARAN,
        BULKY
    }
    public class Yarn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int YarnId { get; set; }
        public virtual int ManufacturerID { get; set; }
        public Weight weight { get; set; }
        public int Yards { get; set; }
        public string Color { get; set; }
        public double Wholesale { get; set; }
        // used to track changes
        public virtual ObservableCollectionListSource<Manufacturer> version { get; set; }
    }
}
