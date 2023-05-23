
using Entities;
using Entities.DTOs;

namespace UI
{
    internal class InformationPanel : Panel
    {
        private Label usernameTitleLabelForInfo;
        private Label usernameLabelForInfo;

        private Label passwordTitleLabelForInfo;
        private Label passwordLabelForInfo;

        private Label emailTitleLabelForInfo;
        private Label emailLabelForInfo;

        private Label nameTitleLabelForInfo;
        private Label nameLabelForInfo;


        private Label lastnameTitleLabelForInfo;
        private Label lastnameLabelForInfo;

        private Label titleOfInfoPanelForInfo;

        public InformationPanel(UserWithCommunicationDtos userWithCommunicationDtos)
        {
            InitializeComponent();
            setInformations(userWithCommunicationDtos);
        }

        public void setInformations(UserWithCommunicationDtos userWithCommunicationDtos)
        {
            lastnameLabelForInfo.Text = userWithCommunicationDtos.Communication.Surname;
            nameLabelForInfo.Text = userWithCommunicationDtos.Communication.Name;
            emailLabelForInfo.Text = userWithCommunicationDtos.Email;
            passwordLabelForInfo.Text = userWithCommunicationDtos.Password;
            usernameLabelForInfo.Text = userWithCommunicationDtos.UserName;
        }

        private void InitializeComponent()
        {
            usernameTitleLabelForInfo = new Label();
            usernameLabelForInfo = new Label();

            passwordTitleLabelForInfo = new Label();
            passwordLabelForInfo = new Label();

            emailTitleLabelForInfo = new Label();
            emailLabelForInfo = new Label();

            nameTitleLabelForInfo = new Label();
            nameLabelForInfo = new Label();

            lastnameTitleLabelForInfo = new Label();
            lastnameLabelForInfo = new Label();

            titleOfInfoPanelForInfo = new Label();

            // informationPanel
            // 
            Controls.Add(titleOfInfoPanelForInfo);
            Controls.Add(lastnameLabelForInfo);
            Controls.Add(lastnameTitleLabelForInfo);
            Controls.Add(nameLabelForInfo);
            Controls.Add(nameTitleLabelForInfo);
            Controls.Add(emailLabelForInfo);
            Controls.Add(emailTitleLabelForInfo);
            Controls.Add(passwordLabelForInfo);
            Controls.Add(passwordTitleLabelForInfo);
            Controls.Add(usernameLabelForInfo);
            Controls.Add(usernameTitleLabelForInfo);
            Location = new Point(0, 0);
            Name = "informationPanel";
            Size = new Size(600, 210);
            // 
            // titleOfInfoPanelForInfo
            // 
            titleOfInfoPanelForInfo.BackColor = SystemColors.Highlight;
            titleOfInfoPanelForInfo.Location = new Point(0, 0);
            titleOfInfoPanelForInfo.Name = "titleOfInfoPanelForInfo";
            titleOfInfoPanelForInfo.Size = new Size(600, 25);
            titleOfInfoPanelForInfo.Text = "GENEL BİLGİLER";
            titleOfInfoPanelForInfo.TextAlign = ContentAlignment.MiddleCenter;
          
            // 
            // usernameTitleLabelForInfo
            // 
            usernameTitleLabelForInfo.AutoSize = false;
            usernameTitleLabelForInfo.BackColor = SystemColors.ControlDarkDark;
            usernameTitleLabelForInfo.Location = new Point(0, 35);
            usernameTitleLabelForInfo.Name = "usernameTitleLabelForInfo";
            usernameTitleLabelForInfo.Size = new Size(100, 25);
            usernameTitleLabelForInfo.Text = "Kullanıcı Adı :";

            // usernameLabelForInfo
            // 
            usernameLabelForInfo.AutoSize = false;
            usernameLabelForInfo.BackColor = SystemColors.ControlDark;
            usernameLabelForInfo.Location = new Point(100, 35);
            usernameLabelForInfo.Name = "usernameLabelForInfo";
            usernameLabelForInfo.Size = new Size(500, 25);

            // passwordTitleLabelForInfo
            // 
            passwordTitleLabelForInfo.AutoSize = false;
            passwordTitleLabelForInfo.BackColor = SystemColors.ControlDarkDark;
            passwordTitleLabelForInfo.Location = new Point(0, 70);
            passwordTitleLabelForInfo.Name = "passwordTitleLabelForInfo";
            passwordTitleLabelForInfo.Size = new Size(100, 25);
            passwordTitleLabelForInfo.Text = "Şifre :";

            // passwordLabelForInfo
            // 
            passwordLabelForInfo.AutoSize = false;
            passwordLabelForInfo.BackColor = SystemColors.ControlDark;
            passwordLabelForInfo.Location = new Point(100, 70);
            passwordLabelForInfo.Name = "passwordLabelForInfo";
            passwordLabelForInfo.Size = new Size(500, 25);

            // emailTitleLabelForInfo
            // 
            emailTitleLabelForInfo.AutoSize = false;
            emailTitleLabelForInfo.BackColor= SystemColors.ControlDarkDark;
            emailTitleLabelForInfo.Location = new Point(0, 105);
            emailTitleLabelForInfo.Name = "emailTitleLabelForInfo";
            emailTitleLabelForInfo.Size = new Size(100, 25);
            emailTitleLabelForInfo.Text = "Email :";

            // emailLabelForInfo
            // 
            emailLabelForInfo.AutoSize = false;
            emailLabelForInfo.BackColor = SystemColors.ControlDark;
            emailLabelForInfo.Location = new Point(100, 105);
            emailLabelForInfo.Name = "emailLabelForInfo";
            emailLabelForInfo.Size = new Size(500, 25);
            // 


            // nameTitleLabelForInfo
            // 
            nameTitleLabelForInfo.AutoSize = false;
            nameTitleLabelForInfo.BackColor = SystemColors.ControlDarkDark;
            nameTitleLabelForInfo.Location = new Point(0, 140);
            nameTitleLabelForInfo.Name = "nameTitleLabelForInfo";
            nameTitleLabelForInfo.Size = new Size(100, 25);
            nameTitleLabelForInfo.Text = "İsim :";

            // nameLalbelForInfo
            // 
            nameLabelForInfo.AutoSize = false;
            nameLabelForInfo.BackColor = SystemColors.ControlDark;
            nameLabelForInfo.Location = new Point(100, 140);
            nameLabelForInfo.Name = "nameLalbelForInfo";
            nameLabelForInfo.Size = new Size(500, 25);
            // 


            // lastnameTitleLabelForInfo
            // 
            lastnameTitleLabelForInfo.AutoSize = false;
            lastnameTitleLabelForInfo.BackColor = SystemColors.ControlDarkDark;
            lastnameTitleLabelForInfo.Location = new Point(0, 175);
            lastnameTitleLabelForInfo.Name = "lastnameTitleLabelForInfo";
            lastnameTitleLabelForInfo.Size = new Size(100, 25);
            lastnameTitleLabelForInfo.Text = "Soyisim :";


            // lastnameLabelForInfo
            // 
            lastnameLabelForInfo.AutoSize = false;
            lastnameLabelForInfo.BackColor= SystemColors.ControlDark;
            lastnameLabelForInfo.Location = new Point(100, 175);
            lastnameLabelForInfo.Name = "lastnameLabelForInfo";
            lastnameLabelForInfo.Size = new Size(500, 25);
        }
    }
}
