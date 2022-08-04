using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_Helper
{
    public partial class list : Component
    {
        public list()
        {
            InitializeComponent();
        }

        public list(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
