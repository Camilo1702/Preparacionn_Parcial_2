using System;
using System.Collections.Generic;
using System.Text;

namespace AppPrepParcial2.Infrastructure
{
    using AppPrepParcial2.ViewModels;
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
