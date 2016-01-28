using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;

namespace EntityOnPostgres2
{
    public partial class DataGridViewTest : DataGridView
    {

        private object _dataSourceQuickQuery;

        [AttributeProvider(typeof(IListSource))]
        public object DataSourceQuickQuery
        {
            get
            {
                return this._dataSourceQuickQuery;
            }
            set
            {
                this._dataSourceQuickQuery = value;
            }
        }

        public DataGridViewTest()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public DataGridViewTest(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
