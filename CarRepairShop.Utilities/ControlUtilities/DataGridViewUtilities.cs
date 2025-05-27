using System.Drawing;
using System.Windows.Forms;

namespace CarRepairShop.Utilities.ControlUtilities
{
    public static class DataGridViewUtilities
    {
        public static void SetDefaultUI(this DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.NotSet;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
        }
    }
}
