using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_zaidimas.GUI
{
    class Frame : GuiObject
    {
        private char renderChar;
        public Frame(int x, int y, int width, int height, char renderChar) : base(x,y,width,height)
        {
            this.renderChar = renderChar;
        }
        void Render()
        {

        }
    }
}
