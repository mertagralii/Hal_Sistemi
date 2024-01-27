using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hal_Sistemi.Classlar
{
    public class ComboBoxItem
    {
        public int ID { get; set; }
        public string Unvan { get; set; }

        public ComboBoxItem(int id, string unvan)
        {
            ID = id;
            Unvan = unvan;
        }

        public override string ToString()
        {
            // ComboBox'ta gösterilecek olan metin Unvan olacak.
            return Unvan;
        }
    }
}
