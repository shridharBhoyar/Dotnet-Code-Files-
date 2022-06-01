using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using multimodelassestoview.Models;

namespace multimodelassestoview.viewmodel
{
    public class multipledata
    {
        public IEnumerable<studentData> studentdataa { get; set; }
        public IEnumerable<employeeData> employeedataa { get; set; }
    }
}