using FiorelloBack.Models;
using System.Collections.Generic;

namespace FiorelloBack.ViewModels
{
    public class HomeVM
    {
        public List<Category> Categories { get; set; }
        
        public List<Flower> Flowers { get; set; }
        public List<HeaderSlider> HeaderSliders { get; set; }
        public List<Setting> settings { get; set; }
        public List<Position> Positions { get; set; }
        public List<FooterSlider> FooterSliders { get; set; }
    }
}
