using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Micro_Finance.Class
{
    public partial class MyDatagridView : DataGridView
    {
        public MyDatagridView()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public MyDatagridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
