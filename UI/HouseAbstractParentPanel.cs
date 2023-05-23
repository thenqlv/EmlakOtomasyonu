using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class HouseAbstractParentPanel:Panel
    {

        private List<HouseDtos> houses;
        public HouseAbstractParentPanel(List<HouseDtos> houses)
        {
            this.houses = houses;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Size = new Size(600, 150 * houses.Count);
            Location = new Point(0, 0);
            for(int i = 0; i < houses.Count; i++)
            {
                Controls.Add(HouseAbstractPanel.create(i, houses[i]));
            }
        }
        
    }

}
