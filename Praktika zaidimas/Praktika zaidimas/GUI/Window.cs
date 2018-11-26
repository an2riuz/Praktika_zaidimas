using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_zaidimas.GUI
{
    class Window : GuiObject
    {
        int frame;
        public Window(int x, int y, int width, int height, char renderChar, int frame) : base(x, y, width, height)
        {
            this.frame = frame;
        }
        void Render()
        {

        }
    }
}
