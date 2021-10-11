using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postnumre_csv
{
    class City
    {
        public string Postnummer { get; set; }
        public string By { get; set; }

        public City(string rowData)
        {
            string[] data = rowData.Split(';');

            this.Postnummer = data[0];
            this.By = data[1];
        }

        public override string ToString()
        {

            string str = $"Postnummer: {Postnummer} By: {By}";

            return str;
        }
    }
}
