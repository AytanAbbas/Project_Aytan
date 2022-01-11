using DirectList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.ViewModels
{
    public class VmAbout : VmLayout
    {
        public About About { get; set; }
        public List<AboutProcess> AboutProcesses { get; set; }
        public Banner Banner { get; set; }
       
    }
}