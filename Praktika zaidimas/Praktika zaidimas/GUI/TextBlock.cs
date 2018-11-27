﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_zaidimas.GUI
{
    class TextBlock : GuiObject
    {
        private List<TextLine> textBlocks = new List<TextLine>();
        public TextBlock(int x, int y, int width, List<string> textList) : base(x, y, width, 0)
        {
            for (int i = 0; i < textList.Count; i++)
            {
                textBlocks.Add(new TextLine(x, y + i, width, textList[i]));
            }
        }
        public void Render()
        {

        }
        
    }
}
