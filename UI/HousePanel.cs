using Entities.DTOs;

namespace UI
{
    internal class HousePanel : Panel
    {
        private Label titleLabelForHouse;
        private PictureBox pictureBoxForHouse;
        private Button prevButtonForHouse;
        private Button nextButtonForHouse;
        private Label statusTitleLabelForHouse;
        private Label statusLabelForHouse;
        private Label typeLabelForHouse;
        private Label typeTitleLabelForHouse;
        private Label priceLabelForHouse;
        private Label priceTitleLabelForHouse;
        private Label squareMeterTitleLabelForHouse;
        private Label squareMeterLabelForHouse;
        private Label countOfRoomsTitleLabelForHouse;
        private Label countOfRoomsLabelForHouse;
        private Label descriptionTitleLabelForHouse;
        private RichTextBox descriptionRichTextBoxForHouse;

        private HouseWithImagesWithAddressDtos house;
        private int index = 1;

        public HousePanel(HouseWithImagesWithAddressDtos house)
        {
            this.house = house;
            InitializeComponent();
        }

        public void setTexts(HouseWithImagesWithAddressDtos house)
        {
            titleLabelForHouse.Text = house.Title;
            statusLabelForHouse.Text = house.Status;
            typeLabelForHouse.Text = house.Type;
            priceLabelForHouse.Text = house.Price + "";
            squareMeterLabelForHouse.Text = house.SquareMeter + "";
            countOfRoomsLabelForHouse.Text = house.CountOfRooms + "";
            descriptionRichTextBoxForHouse.Text = house.Description;

        }
        private void setLocations()
        {
            int offset = pictureBoxForHouse.Image.Height + 10 + 25;
            prevButtonForHouse.Location = new Point(0, offset);
            nextButtonForHouse.Location = new Point(60, offset);
            statusTitleLabelForHouse.Location = new Point(0, offset += 35);
            statusLabelForHouse.Location = new Point(100, offset);
            typeTitleLabelForHouse.Location = new Point(0, offset += 35);
            typeLabelForHouse.Location = new Point(100, offset);
            priceTitleLabelForHouse.Location = new Point(0, offset += 35);
            priceLabelForHouse.Location = new Point(100, offset);
            squareMeterTitleLabelForHouse.Location = new Point(0, offset += 35);
            squareMeterLabelForHouse.Location = new Point(100, offset);
            countOfRoomsTitleLabelForHouse.Location = new Point(0, offset += 35);
            countOfRoomsLabelForHouse.Location = new Point(100, offset);
            descriptionTitleLabelForHouse.Location = new Point(0, offset += 35);
            descriptionRichTextBoxForHouse.Location = new Point(100, offset);

            pictureBoxForHouse.Size = new Size(
                pictureBoxForHouse.Image.Width,
                pictureBoxForHouse.Image.Height
            );
        }

        private void InitializeComponent()
        {
            
            titleLabelForHouse = new Label();
            pictureBoxForHouse = new PictureBox();
            prevButtonForHouse = new Button();
            nextButtonForHouse = new Button();
            statusTitleLabelForHouse = new Label();
            statusLabelForHouse = new Label();
            typeTitleLabelForHouse = new Label();
            typeLabelForHouse = new Label();
            priceTitleLabelForHouse = new Label();
            priceLabelForHouse = new Label();
            squareMeterTitleLabelForHouse = new Label();
            squareMeterLabelForHouse = new Label();
            countOfRoomsTitleLabelForHouse = new Label();
            countOfRoomsLabelForHouse = new Label();
            descriptionTitleLabelForHouse = new Label();
            descriptionRichTextBoxForHouse = new RichTextBox();


            


            // 
            // titleLabelForHouse
            //
            titleLabelForHouse.AutoSize = false;
            titleLabelForHouse.BackColor = SystemColors.Highlight;
            titleLabelForHouse.Location = new Point(0, 0);
            titleLabelForHouse.Name = "titleLabelForHouse";
            titleLabelForHouse.Size = new Size(600, 25);
            titleLabelForHouse.TabIndex = 0;
            titleLabelForHouse.Text = house.Title;
            titleLabelForHouse.TextAlign = ContentAlignment.MiddleCenter;
            


            pictureBoxForHouse.Image = Image.FromFile(Environment.CurrentDirectory + "\\Resources\\" + house.Images[index].Name);
            Console.WriteLine(Environment.CurrentDirectory + "\\Resources\\" + house.Images[index].Name);
            pictureBoxForHouse.Location = new Point(0, 25);
            pictureBoxForHouse.Name = "pictureBoxForHouse";
            pictureBoxForHouse.Size = new Size(
                pictureBoxForHouse.Image.Width,
                pictureBoxForHouse.Image.Height
            );
            pictureBoxForHouse.TabStop = false;
            int offset = pictureBoxForHouse.Image.Height + 10 + 25;

            prevButtonForHouse.Location = new Point(0, offset);
            prevButtonForHouse.Name = "prevButtonForHouse";
            prevButtonForHouse.Size = new Size(50, 25);
            prevButtonForHouse.Text = "<";
            prevButtonForHouse.TextAlign = ContentAlignment.MiddleCenter;
            prevButtonForHouse.Click += prevButtonForHouse_Click;

            nextButtonForHouse.Location = new Point(60, offset);
            nextButtonForHouse.Name = "nextButtonForHouse";
            nextButtonForHouse.Size = new Size(50, 25);
            nextButtonForHouse.Text = ">";
            nextButtonForHouse.TextAlign = ContentAlignment.MiddleCenter;
            nextButtonForHouse.Click += nextButtonForHouse_Click;

            // statusTitleLabelForHouse
            // 
            statusTitleLabelForHouse.AutoSize = false;
            statusTitleLabelForHouse.BackColor = SystemColors.ControlDarkDark;
            statusTitleLabelForHouse.Location = new Point(0, offset += 35);
            statusTitleLabelForHouse.Name = "statusTitleLabelForHouse";
            statusTitleLabelForHouse.Size = new Size(100, 25);
            statusTitleLabelForHouse.Text = "Durum";
            statusTitleLabelForHouse.TextAlign = ContentAlignment.MiddleCenter;

            // statusLabelForHouse
            // 
            statusLabelForHouse.AutoSize = false;
            statusLabelForHouse.BackColor = SystemColors.ControlDark;
            statusLabelForHouse.Location = new Point(100, offset);
            statusLabelForHouse.Name = "statusLabelForHouse";
            statusLabelForHouse.Size = new Size(500, 25);
            statusLabelForHouse.Text = house.Status;
            statusLabelForHouse.TextAlign = ContentAlignment.MiddleCenter;
            // 


            // typeTitleLabelForHouse
            // 
            typeTitleLabelForHouse.AutoSize = false;
            typeTitleLabelForHouse.BackColor = SystemColors.ControlDarkDark;
            typeTitleLabelForHouse.Location = new Point(0, offset += 35);
            typeTitleLabelForHouse.Name = "typeTitleLabelForHouse";
            typeTitleLabelForHouse.Size = new Size(100, 25);
            typeTitleLabelForHouse.Text = "Type";
            typeTitleLabelForHouse.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // 
            // typeLabelForHouse
            // 
            typeLabelForHouse.AutoSize = false;
            typeLabelForHouse.BackColor = SystemColors.ControlDark;
            typeLabelForHouse.Location = new Point(100, offset);
            typeLabelForHouse.Name = "typeLabelForHouse";
            typeLabelForHouse.Size = new Size(500, 25);
            typeLabelForHouse.Text = house.Type;
            typeLabelForHouse.TextAlign = ContentAlignment.MiddleCenter;
            // 



            // priceTitleLabelForHouse
            // 
            priceTitleLabelForHouse.AutoSize = false;
            priceTitleLabelForHouse.BackColor = SystemColors.ControlDarkDark;
            priceTitleLabelForHouse.Location = new Point(0, offset += 35);
            priceTitleLabelForHouse.Name = "priceTitleLabelForHouse";
            priceTitleLabelForHouse.Size = new Size(100, 25);
            priceTitleLabelForHouse.Text = "Price";
            priceTitleLabelForHouse.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // priceLabelForHouse
            // 
            priceLabelForHouse.AutoSize = false;
            priceLabelForHouse.BackColor = SystemColors.ControlDark;
            priceLabelForHouse.Location = new Point(100, offset);
            priceLabelForHouse.Name = "priceLabelForHouse";
            priceLabelForHouse.Size = new Size(500, 25);
            priceLabelForHouse.Text = house.Price + "";
            priceLabelForHouse.TextAlign = ContentAlignment.MiddleCenter;


            // squareMeterTitleLabelForHouse
            // 
            squareMeterTitleLabelForHouse.AutoSize= false;
            squareMeterTitleLabelForHouse.BackColor = SystemColors.ControlDarkDark;
            squareMeterTitleLabelForHouse.Location = new Point(0, offset += 35);
            squareMeterTitleLabelForHouse.Name = "squareMeterTitleLabelForHouse";
            squareMeterTitleLabelForHouse.Size = new Size(100, 25);
            squareMeterTitleLabelForHouse.Text = "Metre Kare";
            squareMeterTitleLabelForHouse.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // squareMeterLabelForHouse
            // 
            squareMeterLabelForHouse.AutoSize = false;
            squareMeterLabelForHouse.BackColor = SystemColors.ControlDark;
            squareMeterLabelForHouse.Location = new Point(100, offset);
            squareMeterLabelForHouse.Name = "squareTitleLabelForHouse";
            squareMeterLabelForHouse.Size = new Size(500, 25);
            squareMeterLabelForHouse.Text = house.SquareMeter + "";
            squareMeterLabelForHouse.TextAlign = ContentAlignment.MiddleCenter;


            // countOfRoomsTitleLabelForHouse
            // 
            countOfRoomsTitleLabelForHouse.AutoSize = false;
            countOfRoomsTitleLabelForHouse.BackColor = SystemColors.ControlDarkDark;
            countOfRoomsTitleLabelForHouse.Location = new Point(0, offset += 35);
            countOfRoomsTitleLabelForHouse.Name = "squareMeterTitleLabelForHouse";
            countOfRoomsTitleLabelForHouse.Size = new Size(100, 25);
            countOfRoomsTitleLabelForHouse.Text = "Oda Sayısı";
            countOfRoomsTitleLabelForHouse.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // countOfRoomsLabelForHouse
            // 
            countOfRoomsLabelForHouse.AutoSize = false;
            countOfRoomsLabelForHouse.BackColor = SystemColors.ControlDark;
            countOfRoomsLabelForHouse.Location = new Point(100, offset);
            countOfRoomsLabelForHouse.Name = "squareTitleLabelForHouse";
            countOfRoomsLabelForHouse.Size = new Size(500, 25);
            countOfRoomsLabelForHouse.Text = house.SquareMeter + "";
            countOfRoomsLabelForHouse.TextAlign = ContentAlignment.MiddleCenter;

            // descriptionTitleLabelForHouse
            // 
            descriptionTitleLabelForHouse.AutoSize = false;
            descriptionTitleLabelForHouse.BackColor = SystemColors.ControlDarkDark;
            descriptionTitleLabelForHouse.Location = new Point(0, offset += 35);
            descriptionTitleLabelForHouse.Name = "squareMeterTitleLabelForHouse";
            descriptionTitleLabelForHouse.Size = new Size(100, 25);
            descriptionTitleLabelForHouse.Text = "Açıklama";
            descriptionTitleLabelForHouse.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // descriptionRichTextBoxForHouse
            // 
            descriptionRichTextBoxForHouse.BackColor = SystemColors.ControlDark;
            descriptionRichTextBoxForHouse.Location = new Point(100, offset);
            descriptionRichTextBoxForHouse.Name = "squareTitleLabelForHouse";
            descriptionRichTextBoxForHouse.Size = new Size(500, 75);
            descriptionRichTextBoxForHouse.Text = house.Description;

            



            Size = new Size(600, offset + 85);
            Location = new Point(0, 0);
            Controls.Add(titleLabelForHouse);
            Controls.Add(pictureBoxForHouse);
            Controls.Add(prevButtonForHouse);
            Controls.Add(nextButtonForHouse);
            Controls.Add(priceLabelForHouse);
            Controls.Add(priceTitleLabelForHouse);
            Controls.Add(typeLabelForHouse);
            Controls.Add(typeTitleLabelForHouse);
            Controls.Add(statusLabelForHouse);
            Controls.Add(statusTitleLabelForHouse);
            Controls.Add(squareMeterTitleLabelForHouse);
            Controls.Add(squareMeterLabelForHouse);
            Controls.Add(countOfRoomsTitleLabelForHouse);
            Controls.Add(countOfRoomsLabelForHouse);
            Controls.Add(descriptionTitleLabelForHouse);
            Controls.Add(descriptionRichTextBoxForHouse);
        }

        private void nextButtonForHouse_Click(object? sender, EventArgs e)
        {
            index++;
            pictureBoxForHouse.Image = Image.FromFile(
                Environment.CurrentDirectory + 
                "\\Resources\\" + 
                house.Images[index % house.Images.Count].Name
            );
            setLocations();
        }

        private void prevButtonForHouse_Click(object? sender, EventArgs e)
        {
            if (index <= 0)
                index += house.Images.Count;
            index--;
            pictureBoxForHouse.Image = Image.FromFile(
                Environment.CurrentDirectory + 
                "\\Resources\\" + 
                house.Images[index % house.Images.Count].Name
            );
            setLocations();
        }
    }
}
