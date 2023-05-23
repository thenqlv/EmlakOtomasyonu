using Entities.DTOs;

namespace UI
{
    internal class Controller
    {

        public static MenuPanel MENU_PANEL = null;
        private static Panel prevChildPanelOfMenuPanel = null;

        public static BodyPanel BODY_PANEL = null;
        private static Panel prevChildPanelOfBodyPanel = null;

        public static LoginPanel LOGIN_PANEL = null;
        
        public static OptionsPanel OPTIONS_PANEL = null;

        public static InformationPanel INFORMATION_PANEL = null;
        public static EditUserInformationsPanel EDIT_USER_INFO_PANEL = null;

        public static HousePanel HOUSE_PANEL;
        
        public static UserDtos USER = null;

        public static void CreateMenuPanel()
        {
            if (MENU_PANEL == null) MENU_PANEL = new MenuPanel();
        }

        public static void AddChildPanelToMenuPanel(Panel panel)
        {
            if(prevChildPanelOfMenuPanel != null)
            {
                MENU_PANEL.Controls.Remove(prevChildPanelOfMenuPanel);
            }
            prevChildPanelOfMenuPanel = panel;
            MENU_PANEL.Controls.Add(panel);

        }
        public static void CreateBodyPanel()
        {
            if (BODY_PANEL == null) { 
                BODY_PANEL = new BodyPanel();
                BODY_PANEL.AutoScroll = true;
            }

        }
        public static void AddChildPanelToBodyPanel(Panel panel,bool disposeFlag)
        {
            if (prevChildPanelOfBodyPanel != null)
            {
                BODY_PANEL.Controls.Remove(prevChildPanelOfBodyPanel);
                if (disposeFlag)
                    prevChildPanelOfBodyPanel.Dispose();

            }
            prevChildPanelOfBodyPanel = panel;
            BODY_PANEL.Controls.Add(panel);
        }

        public static void CreateLoginPanel()
        {
            if (LOGIN_PANEL == null) LOGIN_PANEL = new LoginPanel();
        }

        public static void CreateOptionsPanel()
        {
            if (OPTIONS_PANEL == null) OPTIONS_PANEL = new OptionsPanel();
        }
        public static void CreateInformationPanel(UserWithCommunicationDtos userWithCommunicationDtos)
        {
            if(INFORMATION_PANEL == null) INFORMATION_PANEL = new InformationPanel(userWithCommunicationDtos);
            else INFORMATION_PANEL.setInformations(userWithCommunicationDtos);
        }

        public static void CreateEditUserInformationsPanel()
        {
            if(EDIT_USER_INFO_PANEL == null) EDIT_USER_INFO_PANEL = new EditUserInformationsPanel();
        }
        public static void CreateHousePanel(HouseWithImagesWithAddressDtos house)
        {
            if(HOUSE_PANEL == null )HOUSE_PANEL = new HousePanel(house);
            else HOUSE_PANEL.setTexts(house);
        }
        
        
    }
}
