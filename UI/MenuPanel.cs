using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class MenuPanel : Panel
    {
        private void InitializeComponent()
        {
            BackColor = SystemColors.ActiveBorder;
            Dock = DockStyle.Left;
            Location = new Point(0, 0);
            Name = "menuPanel";
            Size = new Size(250, 600);
            TabIndex = 0;
        }
        public MenuPanel()
        {
            InitializeComponent();
        }
    }
}
