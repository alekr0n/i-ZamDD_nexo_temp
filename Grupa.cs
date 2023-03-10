using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikWpfApp3
{
    public class Grupa
    {
        private string nazwa = String.Empty;

        public string Nazwa
        {
            get
            {
                return this.nazwa;
            }
            set
            {
                if(this.nazwa != value)
                {
                    this.nazwa = value;
                }
            }
        }
    }
}
