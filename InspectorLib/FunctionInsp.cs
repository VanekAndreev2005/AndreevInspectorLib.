using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{
    public class FunctionInsp
    {
        public string Title { get; set; }
        public string Inspect { get; set; }
        public string Fio { get; set; }
        public string Gosnomer { get; set; }

        public FunctionInsp(string title, string inspect, string fio, string gosnomer)
        {
            this.Title = title;
            this.Inspect = inspect;
            this.Fio = fio;
            this.Gosnomer = gosnomer;
        }
    }
}
