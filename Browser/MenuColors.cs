using System.Drawing;
using System.Windows.Forms;

namespace Browser
{
    class MenuColors : ProfessionalColorTable
    {
        public override Color MenuItemBorder
        {
            get { return Color.DarkMagenta; }
        }
        public override Color MenuItemSelected
        {
            get { return Color.DarkMagenta; }
        }
        public override Color ToolStripDropDownBackground
        {
            get { return Color.Black; }
        }
        public override Color ImageMarginGradientBegin
        {
            get { return Color.Black; }
        }
        public override Color ImageMarginGradientMiddle
        {
            get { return Color.Black; }
        }
        public override Color ImageMarginGradientEnd
        {
            get { return Color.Black; }
        }
    }
}
