using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.DirectoryServices;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Dialog_Window.Models
{
    public class Product
        
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        
        public string Description { get; set; }

        [NotMapped]  public BitmapImage QRCode { get; set; }

        
    }



    
}
