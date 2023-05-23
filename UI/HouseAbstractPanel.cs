
using Client;
using Entities.DTOs;
using System;
using System.Reflection;

namespace UI
{
    internal class HouseAbstractPanel :Panel
    {
        public Label titleTitleLabelForHouseAbstract;
        public Label titleLabelForHouseAbstract;

        public Label descriptionTitleLabelForHouseAbstract;
        public RichTextBox descriptionRichTextBoxForHouseAbstract;
        
        public Button showButtonForHouseAbstract;
        
        
        public HouseDtos house;
        

        private static Point MOVE_VEKTOR = new Point(0,150);
        

        public HouseAbstractPanel(HouseDtos house)
        {
            this.house = house;
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            
            titleTitleLabelForHouseAbstract = new Label();
            titleLabelForHouseAbstract = new Label();

            descriptionTitleLabelForHouseAbstract = new Label();
            descriptionRichTextBoxForHouseAbstract = new RichTextBox();
            
            showButtonForHouseAbstract = new Button();

            titleTitleLabelForHouseAbstract.AutoSize = false;
            titleTitleLabelForHouseAbstract.BackColor = SystemColors.ControlDarkDark;
            titleTitleLabelForHouseAbstract.Location = new Point(0, 0);
            titleTitleLabelForHouseAbstract.Name = "titleTitleLabelForHouseAbstract";
            titleTitleLabelForHouseAbstract.Size = new Size(100, 25);
            titleTitleLabelForHouseAbstract.Text = "Başlık";

            titleLabelForHouseAbstract.AutoSize = false;
            titleLabelForHouseAbstract.BackColor = SystemColors.ControlDark;
            titleLabelForHouseAbstract.Location = new Point(100, 0);
            titleLabelForHouseAbstract.Name = "titleLabelForHouseAbstract";
            titleLabelForHouseAbstract.Size = new Size(500, 25);
            titleLabelForHouseAbstract.Text = house.Title;
            titleLabelForHouseAbstract.TextAlign = ContentAlignment.MiddleCenter;

            descriptionTitleLabelForHouseAbstract.AutoSize = false;
            descriptionTitleLabelForHouseAbstract.BackColor = SystemColors.ControlDarkDark;
            descriptionTitleLabelForHouseAbstract.Location = new Point(0, 30);
            descriptionTitleLabelForHouseAbstract.Name = "descriptionTitleLabelForHouseAbstract";
            descriptionTitleLabelForHouseAbstract.Size = new Size(100, 25);
            descriptionTitleLabelForHouseAbstract.Text = "Açıklama";

            descriptionRichTextBoxForHouseAbstract.AutoSize = false;
            descriptionRichTextBoxForHouseAbstract.BackColor = SystemColors.ControlDark;
            descriptionRichTextBoxForHouseAbstract.Location = new Point(100, 30);
            descriptionRichTextBoxForHouseAbstract.Name = "descriptionRichTextBoxForHouseAbstract";
            descriptionRichTextBoxForHouseAbstract.Size = new Size(500, 75);
            descriptionRichTextBoxForHouseAbstract.Text = house.Description;
            descriptionRichTextBoxForHouseAbstract.Enabled = false;


            showButtonForHouseAbstract.Location = new Point(466, 110);
            showButtonForHouseAbstract.Name = "showButtonForHouseAbstract";
            showButtonForHouseAbstract.Size = new Size(80, 30);
            showButtonForHouseAbstract.TabIndex = 4;
            showButtonForHouseAbstract.Text = "Göster";
            showButtonForHouseAbstract.Click += showButtonForHouseAbstract_Click;
            showButtonForHouseAbstract.UseVisualStyleBackColor = true;

            Controls.Add(titleTitleLabelForHouseAbstract);
            Controls.Add(titleLabelForHouseAbstract);
            Controls.Add(descriptionTitleLabelForHouseAbstract);
            Controls.Add(descriptionRichTextBoxForHouseAbstract);
            Controls.Add(showButtonForHouseAbstract);
            BackColor = SystemColors.Info;
            Location = new Point(0, 0);
            Name = "houseAbstractPanelForHouseAbstract";
            Size = new Size(600, 150);
        }



        private void showButtonForHouseAbstract_Click(object? sender, EventArgs e)
        {

            Controller.CreateHousePanel(
                new HouseService().GetWithAddressesAndImagesById(house.Id)
            );
            Controller.AddChildPanelToBodyPanel(Controller.HOUSE_PANEL, true);
        }
        public void Move(int index)
        {
            MoveControl.moveControl(this, index, MOVE_VEKTOR);
        }
        public static HouseAbstractPanel create(int index,HouseDtos house)
        {
            HouseAbstractPanel h = new HouseAbstractPanel(house);
            h.Move(index);
            return h;
        }

    }
}
