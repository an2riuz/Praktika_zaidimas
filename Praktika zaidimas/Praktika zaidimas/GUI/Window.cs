using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_zaidimas.GUI
{
    class Window : GuiObject
    {

        private Frame border;
        private int frame;

        public Window(int x, int y, int width, int height, char borderChar) : base(x, y, width, height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;

            border = new Frame(x, y, width, height, borderChar);
        }

        public Window(int x, int y, int width, int height, char borderChar, int frame) : this(x, y, width, height, borderChar)
        {
            this.frame = frame;
        }

        public void Render()
        {
            border.Render();
        }
    }
}
