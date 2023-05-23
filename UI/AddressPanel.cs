using Entities.DTOs;

namespace UI
{
    internal class AddressPanel
    {

        public AddressPanel(AddressDtos address) { 
            InitializeComponent(address);
        }

        private void InitializeComponent(AddressDtos address)
        {
            // editPanelForAddress
            // 
            editPanelForAddress.Controls.Add(saveButtonForAddress);
            editPanelForAddress.Controls.Add(descriptionRichTextBoxForAddress);
            editPanelForAddress.Controls.Add(flatTextBoxForAddress);
            editPanelForAddress.Controls.Add(floorTextBoxForAddress);
            editPanelForAddress.Controls.Add(buildingNumberForAddress);
            editPanelForAddress.Controls.Add(streetTextBoxForAdress);
            editPanelForAddress.Controls.Add(neighbourhoodTextBox);
            editPanelForAddress.Controls.Add(districtTextBoxAddress);
            editPanelForAddress.Controls.Add(cityTextBoxForAddress);
            editPanelForAddress.Enabled = false;
            editPanelForAddress.Location = new Point(128, 53);
            editPanelForAddress.Name = "editPanelForAddress";
            editPanelForAddress.Size = new Size(410, 371);
            editPanelForAddress.TabIndex = 19;
            // 
            // saveButtonForAddress
            // 
            saveButtonForAddress.Location = new Point(313, 337);
            saveButtonForAddress.Name = "saveButtonForAddress";
            saveButtonForAddress.Size = new Size(94, 29);
            saveButtonForAddress.TabIndex = 8;
            saveButtonForAddress.Text = "kaydet";
            saveButtonForAddress.UseVisualStyleBackColor = true;
            saveButtonForAddress.Click += saveButtonForAddress_Click;
            saveButtonForAddress.Visible = false;
            // 
            // descriptionRichTextBoxForAddress
            // 
            descriptionRichTextBoxForAddress.Location = new Point(3, 237);
            descriptionRichTextBoxForAddress.Name = "descriptionRichTextBoxForAddress";
            descriptionRichTextBoxForAddress.Size = new Size(404, 94);
            descriptionRichTextBoxForAddress.TabIndex = 7;
            descriptionRichTextBoxForAddress.Text = address.Description;
            // 
            // flatTextBoxForAddress
            // 
            flatTextBoxForAddress.Location = new Point(3, 201);
            flatTextBoxForAddress.Name = "flatTextBoxForAddress";
            flatTextBoxForAddress.Size = new Size(125, 27);
            flatTextBoxForAddress.Text = address.ApartmentNumber + "";
            flatTextBoxForAddress.TabIndex = 6;
            // 
            // floorTextBoxForAddress
            // 
            floorTextBoxForAddress.Location = new Point(3, 168);
            floorTextBoxForAddress.Name = "floorTextBoxForAddress";
            floorTextBoxForAddress.Size = new Size(125, 27);
            floorTextBoxForAddress.Text = address.Floor + "";
            floorTextBoxForAddress.TabIndex = 5;
            // 
            // buildingNumberForAddress
            // 
            buildingNumberForAddress.Location = new Point(3, 135);
            buildingNumberForAddress.Name = "buildingNumberForAddress";
            buildingNumberForAddress.Size = new Size(125, 27);
            buildingNumberForAddress.TabIndex = 4;
            buildingNumberForAddress.Text = address.BuildingNumber + "";
            // 
            // streetTextBoxForAdress
            // 
            streetTextBoxForAdress.Location = new Point(3, 102);
            streetTextBoxForAdress.Name = "streetTextBoxForAdress";
            streetTextBoxForAdress.Size = new Size(125, 27);
            streetTextBoxForAdress.TabIndex = 3;
            streetTextBoxForAdress.Text = address.StreetName + "";
            // 
            // neighbourhoodTextBox
            // 
            neighbourhoodTextBox.Location = new Point(3, 69);
            neighbourhoodTextBox.Name = "neighbourhoodTextBox";
            neighbourhoodTextBox.Size = new Size(125, 27);
            neighbourhoodTextBox.TabIndex = 2;
            neighbourhoodTextBox.Text = address.NeighborhoodName;
            // 
            // districtTextBoxAddress
            // 
            districtTextBoxAddress.Location = new Point(3, 36);
            districtTextBoxAddress.Name = "districtTextBoxAddress";
            districtTextBoxAddress.Size = new Size(125, 27);
            districtTextBoxAddress.TabIndex = 1;
            districtTextBoxAddress.Text = address.DistrictName;
            // 
            // cityTextBoxForAddress
            // 
            cityTextBoxForAddress.Location = new Point(3, 3);
            cityTextBoxForAddress.Name = "cityTextBoxForAddress";
            cityTextBoxForAddress.Size = new Size(125, 27);
            cityTextBoxForAddress.TabIndex = 0;
            cityTextBoxForAddress.Text = address.CityName;

            // editButtonForAddress
            // 
            editButtonForAddress.Location = new Point(20, 313);
            editButtonForAddress.Name = "editButtonForAddress";
            editButtonForAddress.Size = new Size(105, 29);
            editButtonForAddress.TabIndex = 18;
            editButtonForAddress.Text = "düzenle";
            editButtonForAddress.UseVisualStyleBackColor = true;
            editButtonForAddress.Click += editButtonForAddress_Click;
            // 
            // descriptionTitleLabelForAddress
            // 
            descriptionTitleLabelForAddress.AutoSize = true;
            descriptionTitleLabelForAddress.Location = new Point(45, 290);
            descriptionTitleLabelForAddress.Name = "descriptionTitleLabelForAddress";
            descriptionTitleLabelForAddress.Size = new Size(77, 20);
            descriptionTitleLabelForAddress.TabIndex = 9;
            descriptionTitleLabelForAddress.Text = "Açıklama :";
            // 
            // flatTitleLabelForAddress
            // 
            flatTitleLabelForAddress.AutoSize = true;
            flatTitleLabelForAddress.Location = new Point(70, 257);
            flatTitleLabelForAddress.Name = "flatTitleLabelForAddress";
            flatTitleLabelForAddress.Size = new Size(52, 20);
            flatTitleLabelForAddress.TabIndex = 8;
            flatTitleLabelForAddress.Text = "Daire :";
            // 
            // floorTitleLabelForAddress
            // 
            floorTitleLabelForAddress.AutoSize = true;
            floorTitleLabelForAddress.Location = new Point(84, 224);
            floorTitleLabelForAddress.Name = "floorTitleLabelForAddress";
            floorTitleLabelForAddress.Size = new Size(38, 20);
            floorTitleLabelForAddress.TabIndex = 7;
            floorTitleLabelForAddress.Text = "Kat :";
            // 
            // buildingNumberTitleForAddress
            // 
            buildingNumberTitleForAddress.AutoSize = true;
            buildingNumberTitleForAddress.Location = new Point(13, 191);
            buildingNumberTitleForAddress.Name = "buildingNumberTitleForAddress";
            buildingNumberTitleForAddress.Size = new Size(109, 20);
            buildingNumberTitleForAddress.TabIndex = 6;
            buildingNumberTitleForAddress.Text = "Bina numarası :";
            // 
            // streetTitleLabelForAddress
            // 
            streetTitleLabelForAddress.AutoSize = true;
            streetTitleLabelForAddress.Location = new Point(67, 158);
            streetTitleLabelForAddress.Name = "streetTitleLabelForAddress";
            streetTitleLabelForAddress.Size = new Size(55, 20);
            streetTitleLabelForAddress.TabIndex = 5;
            streetTitleLabelForAddress.Text = "Sokak :";
            // 
            // neighbourhoodTitleLabelForAddress
            // 
            neighbourhoodTitleLabelForAddress.AutoSize = true;
            neighbourhoodTitleLabelForAddress.Location = new Point(53, 125);
            neighbourhoodTitleLabelForAddress.Name = "neighbourhoodTitleLabelForAddress";
            neighbourhoodTitleLabelForAddress.Size = new Size(69, 20);
            neighbourhoodTitleLabelForAddress.TabIndex = 4;
            neighbourhoodTitleLabelForAddress.Text = "Mahalle :";
            // 
            // districtTitleLabelForAddress
            // 
            districtTitleLabelForAddress.AutoSize = true;
            districtTitleLabelForAddress.Location = new Point(83, 92);
            districtTitleLabelForAddress.Name = "districtTitleLabelForAddress";
            districtTitleLabelForAddress.Size = new Size(39, 20);
            districtTitleLabelForAddress.TabIndex = 3;
            districtTitleLabelForAddress.Text = "İlçe :";
            // 
            // cityTitleLabelForAddress
            // 
            cityTitleLabelForAddress.AutoSize = true;
            cityTitleLabelForAddress.Location = new Point(69, 59);
            cityTitleLabelForAddress.Name = "cityTitleLabelForAddress";
            cityTitleLabelForAddress.Size = new Size(53, 20);
            cityTitleLabelForAddress.TabIndex = 2;
            cityTitleLabelForAddress.Text = "Şehir : ";
            // 
            // titleLabelForAddress
            // 
            titleLabelForAddress.BackColor = SystemColors.AppWorkspace;
            titleLabelForAddress.Location = new Point(0, 20);
            titleLabelForAddress.Name = "titleLabelForAddress";
            titleLabelForAddress.Size = new Size(541, 20);
            titleLabelForAddress.TabIndex = 1;
            titleLabelForAddress.Text = "Adres Başlığı";
            titleLabelForAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleOfAddressPanelForAddress
            // 
            titleOfAddressPanelForAddress.BackColor = SystemColors.Highlight;
            titleOfAddressPanelForAddress.Location = new Point(0, 0);
            titleOfAddressPanelForAddress.Name = "titleOfAddressPanelForAddress";
            titleOfAddressPanelForAddress.Size = new Size(541, 20);
            titleOfAddressPanelForAddress.TabIndex = 0;
            titleOfAddressPanelForAddress.Text = "Adres Bigileri";
            titleOfAddressPanelForAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
        }

        private void saveButtonForAddress_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void editButtonForAddress_Click(object? sender, EventArgs e)
        {
            editButtonForAddress.Enabled = false;
            saveButtonForAddress.Visible = true;
        }

        private Label titleOfAddressPanelForAddress;
        private Label titleLabelForAddress;
        private Label cityTitleLabelForAddress;
        private Label descriptionTitleLabelForAddress;
        private Label flatTitleLabelForAddress;
        private Label floorTitleLabelForAddress;
        private Label buildingNumberTitleForAddress;
        private Label streetTitleLabelForAddress;
        private Label neighbourhoodTitleLabelForAddress;
        private Label districtTitleLabelForAddress;
        private Button editButtonForAddress;
        private Panel editPanelForAddress;
        private Button saveButtonForAddress;
        private RichTextBox descriptionRichTextBoxForAddress;
        private TextBox flatTextBoxForAddress;
        private TextBox floorTextBoxForAddress;
        private TextBox buildingNumberForAddress;
        private TextBox streetTextBoxForAdress;
        private TextBox neighbourhoodTextBox;
        private TextBox districtTextBoxAddress;
        private TextBox cityTextBoxForAddress;
    }
}
