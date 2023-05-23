using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class MoveControl
    {
        public static void moveControl(Control control, int index, Point MOVE_VEKTOR)
        {
            control.Location = new Point(
                control.Location.X + MOVE_VEKTOR.X * index,
                control.Location.Y + MOVE_VEKTOR.Y * index
            );
        }
    }
}
