using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator_App
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public string ImageID { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
