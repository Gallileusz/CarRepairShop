using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRepairShop.Utilities.ControlUtilities
{
    public static class ButtonUtilities
    {
        public static IEnumerable<Button> GetAllButtons(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Button btn)
                    yield return btn;

                if (ctrl.HasChildren)
                {
                    foreach (var childBtn in GetAllButtons(ctrl))
                        yield return childBtn;
                }
            }
        }
    }
}
