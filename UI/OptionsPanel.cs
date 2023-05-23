
using Client;
using Entities.DTOs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace UI
{
    internal class OptionsPanel : Panel
    {
        private MenuStrip userInformaitonsMenuStripForOptions;
        private ToolStripMenuItem editUserInformationsToolStripMenuItemForOptions;
        private ToolStripMenuItem userProfileToolStripMenuItemForOptions;
        private ToolStripMenuItem userInformationsToolStripMenuItemForOptions;
        private ToolStripMenuItem userHousesToolStripMenuItemForOptions;
        private ToolStripMenuItem userRequestsToolStripMenuItemForOptions;

        private MenuStrip createHouseMenuStripForOptions;
        private ToolStripMenuItem createHouseToolStripMenuItemForOptions;

        private MenuStrip filterHouseMenuStripForOptions;
        private ToolStripMenuItem filterHosueToolStripMenuItemForOptions;

        private InformationPanel informationPanel;

        public UserDtos User { get; set; }

        public OptionsPanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            userInformaitonsMenuStripForOptions = new MenuStrip();
            editUserInformationsToolStripMenuItemForOptions = new ToolStripMenuItem();
            userInformationsToolStripMenuItemForOptions = new ToolStripMenuItem();
            userHousesToolStripMenuItemForOptions = new ToolStripMenuItem();
            userRequestsToolStripMenuItemForOptions = new ToolStripMenuItem();
            userProfileToolStripMenuItemForOptions = new ToolStripMenuItem();

            createHouseMenuStripForOptions = new MenuStrip();
            createHouseToolStripMenuItemForOptions = new ToolStripMenuItem();

            filterHouseMenuStripForOptions = new MenuStrip();
            filterHosueToolStripMenuItemForOptions= new ToolStripMenuItem();

            // this
            //
            Controls.Add(filterHouseMenuStripForOptions);
            Controls.Add(createHouseMenuStripForOptions);
            Controls.Add(userInformaitonsMenuStripForOptions);
            Location = new Point(0, 0);
            Name = "optionsPanelForOptions";
            Size = new Size(250, 125);
            TabIndex = 2;
            //
            // userInformaitonsMenuStripForOptions
            // 
            userInformaitonsMenuStripForOptions.ImageScalingSize = new Size(20, 20);
            userInformaitonsMenuStripForOptions.Items.AddRange(
                new ToolStripItem[] { 
                    userProfileToolStripMenuItemForOptions,
                }
            );
            userInformaitonsMenuStripForOptions.Location = new Point(0, 0);
            userInformaitonsMenuStripForOptions.Name = "userInformaitonsMenuStripForOptions";
            userInformaitonsMenuStripForOptions.Size = new Size(250, 28);
            userInformaitonsMenuStripForOptions.TabIndex = 1;
            userInformaitonsMenuStripForOptions.Text = "userInformaitonsMenuStripForOptions";
            // 
            // userInformationsToolStripMenuItemForOptions
            // 
            userProfileToolStripMenuItemForOptions.Name = "userProfileToolStripMenuItemForOptions";
            userProfileToolStripMenuItemForOptions.Size = new Size(134, 24);
            userProfileToolStripMenuItemForOptions.Text = "Profilim";
            userProfileToolStripMenuItemForOptions.DropDownItems.AddRange(
                new ToolStripItem[] {
                    userInformationsToolStripMenuItemForOptions,
                    editUserInformationsToolStripMenuItemForOptions,
                    userHousesToolStripMenuItemForOptions,
                    userRequestsToolStripMenuItemForOptions
                }
            );

            userInformationsToolStripMenuItemForOptions.Name = "userInformationsToolStripMenuItemForOptions";
            userInformationsToolStripMenuItemForOptions.Size = new Size(134, 24);
            userInformationsToolStripMenuItemForOptions.Text = "Bilgilerim";
            userInformationsToolStripMenuItemForOptions.Click += userInformationsToolStripMenuItemForOptions_Click;


            editUserInformationsToolStripMenuItemForOptions.Name = "editUserInformationsToolStripMenuItemForOptions";
            editUserInformationsToolStripMenuItemForOptions.Size = new Size(134, 24);
            editUserInformationsToolStripMenuItemForOptions.Text = "Bilgilerimi Güncelle";
            editUserInformationsToolStripMenuItemForOptions.Click += editUserInformationsToolStripMenuItemForOptions_Click;



            //editUserInformationsToolStripMenuItemForOptions
            // userHousesToolStripMenuItemForOptions
            // 
            userHousesToolStripMenuItemForOptions.Name = "userHousesToolStripMenuItemForOptions";
            userHousesToolStripMenuItemForOptions.Size = new Size(134, 24);
            userHousesToolStripMenuItemForOptions.Text = "İlanlarım";
            userHousesToolStripMenuItemForOptions.Click += userHousesToolStripMenuItemForOptions_Click;
            // userRequestsToolStripMenuItemForOptions
            // 
            userRequestsToolStripMenuItemForOptions.Name = "userRequestsToolStripMenuItemForOptions";
            userRequestsToolStripMenuItemForOptions.Size = new Size(134, 24);
            userRequestsToolStripMenuItemForOptions.Text = "İsteklerim";
            userRequestsToolStripMenuItemForOptions.Click += userRequestsToolStripMenuItemForOptions_Click;


            // createHouseMenuStripForOptions
            // 
            createHouseMenuStripForOptions.ImageScalingSize = new Size(20, 20);
            createHouseMenuStripForOptions.Location = new Point(0, 0);
            createHouseMenuStripForOptions.Name = "createHouseMenuStripForOptions";
            createHouseMenuStripForOptions.Size = new Size(250, 28);
            createHouseMenuStripForOptions.TabIndex = 1;
            createHouseMenuStripForOptions.Text = "createHouseMenuStripForOptions";
            createHouseMenuStripForOptions.Items.AddRange(
                new ToolStripItem[] {
                    createHouseToolStripMenuItemForOptions,
                }
            );
            // 
            createHouseToolStripMenuItemForOptions.Name = "createHouseToolStripMenuItemForOptions";
            createHouseToolStripMenuItemForOptions.Size = new Size(134, 24);
            createHouseToolStripMenuItemForOptions.Text = "Ev ekle";


            filterHouseMenuStripForOptions.ImageScalingSize = new Size(20, 20);
            filterHouseMenuStripForOptions.Location = new Point(0, 0);
            filterHouseMenuStripForOptions.Name = "createHouseMenuStripForOptions";
            filterHouseMenuStripForOptions.Size = new Size(250, 28);
            filterHouseMenuStripForOptions.TabIndex = 1;
            filterHouseMenuStripForOptions.Text = "createHouseMenuStripForOptions";
            filterHouseMenuStripForOptions.Items.AddRange(
                new ToolStripItem[] {
                    filterHosueToolStripMenuItemForOptions,
                }
            );
            // 
            filterHosueToolStripMenuItemForOptions.Name = "createHouseToolStripMenuItemForOptions";
            filterHosueToolStripMenuItemForOptions.Size = new Size(134, 24);
            filterHosueToolStripMenuItemForOptions.Text = "Ev ara";

        }

        private void editUserInformationsToolStripMenuItemForOptions_Click(object? sender, EventArgs e)
        {
            Controller.CreateEditUserInformationsPanel();
            Controller.AddChildPanelToBodyPanel(Controller.EDIT_USER_INFO_PANEL, false);

        }

        private void userRequestsToolStripMenuItemForOptions_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void userHousesToolStripMenuItemForOptions_Click(object? sender, EventArgs e)
        {

            HouseAbstractParentPanel parent = new HouseAbstractParentPanel(
                new HouseService().GetByUserId(Controller.USER.Id)
                );
            Controller.AddChildPanelToBodyPanel(parent, false);

        }

        private void userInformationsToolStripMenuItemForOptions_Click(object? sender, EventArgs e)
        {
            UserWithCommunicationDtos userWithCommunicationDtos = new UserService().GetByIdWithCommunication(Controller.USER.Id);
            Controller.CreateInformationPanel(userWithCommunicationDtos);
            Controller.AddChildPanelToBodyPanel(Controller.INFORMATION_PANEL,false);
        }
    }
}
