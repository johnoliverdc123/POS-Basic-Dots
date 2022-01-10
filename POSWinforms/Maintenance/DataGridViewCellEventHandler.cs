using System;
using System.Windows.Forms;

namespace POSWinforms.Maintenance
{
    internal class DataGridViewCellEventHandler
    {
        private Action<object, DataGridViewCellEventArgs> dgvCategories_CellClick;

        public DataGridViewCellEventHandler(Action<object, DataGridViewCellEventArgs> dgvCategories_CellClick)
        {
            this.dgvCategories_CellClick = dgvCategories_CellClick;
        }
    }
}