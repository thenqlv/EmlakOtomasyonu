using Client;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class EditUserInformationsPanel : Panel
    {
        private Label titleOfEditInfoPanelForInfoEdit;
        private Label nextPasswordConfirmLabelForInfoEdit;
        private TextBox nextPasswordConfirmtextBoxForInfoEdit;
        private Label lastNameControlLabelForInfoEdit;
        private Label nameControlLabelForInfoEdit;
        private Label emailControlLabelForInfoEdit;
        private Label nextPasswordControlLabelForInfoEdit;
        private Label usernameControlLabelForInfoEdit;
        private Button saveButtonForInfoEdit;
        private TextBox lastNameTextBoxForInfoEdit;
        private Label lastNameLabelForInfoEdit;
        private TextBox nameTextBoxForInfoEdit;
        private Label nameLabelForInfoEdit;
        private Label emailLabelForInfoEdit;
        private TextBox emailTextBoxForInfoEdit;
        private TextBox nextPasswordTextBoxForInfoEdit;
        private Label nextPasswordLabelForInfoEdit;
        private TextBox usernameTextBoxForInfoEdit;
        private Label usernameLabelForInfoEdit;
        private Label nextPasswordConfirmControlForInfoEdit;
        private Label currentPasswordLabelForInfoEdit;
        private TextBox currentPassswordTextBoxForInfoEdit;
        private Label currentPasswordControlLabelForInfoEdit;



        public EditUserInformationsPanel()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {

            currentPasswordControlLabelForInfoEdit = new Label();
            nextPasswordConfirmControlForInfoEdit = new Label();
            currentPasswordLabelForInfoEdit = new Label();
            currentPassswordTextBoxForInfoEdit = new TextBox();
            nextPasswordConfirmLabelForInfoEdit = new Label();
            nextPasswordConfirmtextBoxForInfoEdit = new TextBox();
            lastNameControlLabelForInfoEdit = new Label();
            nameControlLabelForInfoEdit = new Label();
            emailControlLabelForInfoEdit = new Label();
            nextPasswordControlLabelForInfoEdit = new Label();
            usernameControlLabelForInfoEdit = new Label();
            saveButtonForInfoEdit = new Button();
            lastNameTextBoxForInfoEdit = new TextBox();
            lastNameLabelForInfoEdit = new Label();
            nameTextBoxForInfoEdit = new TextBox();
            nameLabelForInfoEdit = new Label();
            emailLabelForInfoEdit = new Label();
            emailTextBoxForInfoEdit = new TextBox();
            nextPasswordTextBoxForInfoEdit = new TextBox();
            nextPasswordLabelForInfoEdit = new Label();
            usernameTextBoxForInfoEdit = new TextBox();
            usernameLabelForInfoEdit = new Label();
            titleOfEditInfoPanelForInfoEdit = new Label();

            Controls.Add(currentPasswordControlLabelForInfoEdit);
            Controls.Add(nextPasswordConfirmControlForInfoEdit);
            Controls.Add(currentPasswordLabelForInfoEdit);
            Controls.Add(currentPassswordTextBoxForInfoEdit);
            Controls.Add(nextPasswordConfirmLabelForInfoEdit);
            Controls.Add(nextPasswordConfirmtextBoxForInfoEdit);
            Controls.Add(lastNameControlLabelForInfoEdit);
            Controls.Add(nameControlLabelForInfoEdit);
            Controls.Add(emailControlLabelForInfoEdit);
            Controls.Add(nextPasswordControlLabelForInfoEdit);
            Controls.Add(usernameControlLabelForInfoEdit);
            Controls.Add(saveButtonForInfoEdit);
            Controls.Add(lastNameTextBoxForInfoEdit);
            Controls.Add(lastNameLabelForInfoEdit);
            Controls.Add(nameTextBoxForInfoEdit);
            Controls.Add(nameLabelForInfoEdit);
            Controls.Add(emailLabelForInfoEdit);
            Controls.Add(emailTextBoxForInfoEdit);
            Controls.Add(nextPasswordTextBoxForInfoEdit);
            Controls.Add(nextPasswordLabelForInfoEdit);
            Controls.Add(usernameTextBoxForInfoEdit);
            Controls.Add(usernameLabelForInfoEdit);
            Controls.Add(titleOfEditInfoPanelForInfoEdit);
            Location = new Point(0, 0);
            Name = "panel1";
            Size = new Size(600, 384);
            TabIndex = 1;


            // titleOfEditInfoPanelForInfoEdit
            // 
            titleOfEditInfoPanelForInfoEdit.AutoSize = false;
            titleOfEditInfoPanelForInfoEdit.BackColor = SystemColors.Highlight;
            titleOfEditInfoPanelForInfoEdit.Location = new Point(0, 0);
            titleOfEditInfoPanelForInfoEdit.Name = "titleOfEditInfoPanelForInfoEdit";
            titleOfEditInfoPanelForInfoEdit.Size = new Size(600, 27);
            titleOfEditInfoPanelForInfoEdit.Text = "BİLGİLERİMİ GÜNCELLE";
            titleOfEditInfoPanelForInfoEdit.TextAlign = ContentAlignment.MiddleCenter;

            // usernameLabelForInfoEdit
            usernameLabelForInfoEdit.AutoSize = false;
            usernameLabelForInfoEdit.BackColor = SystemColors.ControlDarkDark;
            usernameLabelForInfoEdit.Location = new Point(0, 37);
            usernameLabelForInfoEdit.Name = "usernameLabelForInfoEdit";
            usernameLabelForInfoEdit.Size = new Size(150, 27);
            usernameLabelForInfoEdit.Text = "Kullanıcı Adı";
            usernameLabelForInfoEdit.TextAlign = ContentAlignment.MiddleCenter;

            // usernameTextBoxForInfoEdit
            // 
            usernameTextBoxForInfoEdit.Location = new Point(150, 37);
            usernameTextBoxForInfoEdit.Name = "usernameTextBoxForInfoEdit";
            usernameTextBoxForInfoEdit.Size = new Size(300, 27);
            usernameTextBoxForInfoEdit.TabIndex = 0;


            // usernameControlLabelForInfoEdit
            // 
            usernameControlLabelForInfoEdit.AutoSize = false;
            usernameControlLabelForInfoEdit.BackColor = SystemColors.ControlDarkDark;
            usernameControlLabelForInfoEdit.Location = new Point(450, 37);
            usernameControlLabelForInfoEdit.Name = "usernameControlLabelForInfoEdit";
            usernameControlLabelForInfoEdit.Size = new Size(150, 27);
            usernameControlLabelForInfoEdit.Text = "";
            usernameLabelForInfoEdit.TextAlign = ContentAlignment.MiddleCenter;


            // nextPasswordLabelForInfoEdit
            // 
            nextPasswordLabelForInfoEdit.AutoSize = false;
            nextPasswordLabelForInfoEdit.BackColor= SystemColors.ControlDarkDark;
            nextPasswordLabelForInfoEdit.Location = new Point(0, 74);
            nextPasswordLabelForInfoEdit.Name = "nextPasswordLabelForInfoEdit";
            nextPasswordLabelForInfoEdit.Size = new Size(150, 27);
            nextPasswordLabelForInfoEdit.Text = "Yeni Şifre";
            nextPasswordLabelForInfoEdit.TextAlign = ContentAlignment.MiddleCenter;


            // nextPasswordTextBoxForInfoEdit
            // 
            nextPasswordTextBoxForInfoEdit.Location = new Point(150, 74);
            nextPasswordTextBoxForInfoEdit.Name = "nextPasswordTextBoxForInfoEdit";
            nextPasswordTextBoxForInfoEdit.Size = new Size(300, 27);
            nextPasswordTextBoxForInfoEdit.TabIndex = 1;

            // nextPasswordControlLabelForInfoEdit
            // 
            nextPasswordControlLabelForInfoEdit.AutoSize = false;
            nextPasswordControlLabelForInfoEdit.BackColor = SystemColors.ControlDarkDark;
            nextPasswordControlLabelForInfoEdit.Location = new Point(450, 74);
            nextPasswordControlLabelForInfoEdit.Name = "nextPasswordControlLabelForInfoEdit";
            nextPasswordControlLabelForInfoEdit.Size = new Size(150, 27);
            nextPasswordControlLabelForInfoEdit.Text = "";
            nextPasswordControlLabelForInfoEdit.TextAlign = ContentAlignment.MiddleCenter;


            // nextPasswordConfirmLabelForInfoEdit
            // 
            nextPasswordConfirmLabelForInfoEdit.AutoSize = false;
            nextPasswordConfirmLabelForInfoEdit.BackColor = SystemColors.ControlDarkDark;
            nextPasswordConfirmLabelForInfoEdit.Location = new Point(0, 111);
            nextPasswordConfirmLabelForInfoEdit.Name = "nextPasswordConfirmLabelForInfoEdit";
            nextPasswordConfirmLabelForInfoEdit.Size = new Size(150, 27);
            nextPasswordConfirmLabelForInfoEdit.Text = "Yeni Şifre Tekrar";
            nextPasswordConfirmLabelForInfoEdit.TextAlign = ContentAlignment.MiddleCenter;

            //nextPasswordConfirmtextBoxForInfoEdit
            // 
            nextPasswordConfirmtextBoxForInfoEdit.Location = new Point(150, 111);
            nextPasswordConfirmtextBoxForInfoEdit.Name = "nextPasswordConfirmtextBoxForInfoEdit";
            nextPasswordConfirmtextBoxForInfoEdit.Size = new Size(300, 27);
            nextPasswordConfirmtextBoxForInfoEdit.TabIndex = 2;

            // nextPasswordConfirmControlForInfoEdit
            // 
            nextPasswordConfirmControlForInfoEdit.AutoSize = false;
            nextPasswordConfirmControlForInfoEdit.BackColor = SystemColors.ControlDarkDark;
            nextPasswordConfirmControlForInfoEdit.Location = new Point(450, 111);
            nextPasswordConfirmControlForInfoEdit.Name = "nextPasswordConfirmControlForInfoEdit";
            nextPasswordConfirmControlForInfoEdit.Size = new Size(150, 27);
            nextPasswordConfirmControlForInfoEdit.Text = "";
            nextPasswordConfirmControlForInfoEdit.TextAlign= ContentAlignment.MiddleCenter;


           
            // 
            // currentPasswordLabelForInfoEdit
            // 
            currentPasswordLabelForInfoEdit.AutoSize = false;
            currentPasswordLabelForInfoEdit.BackColor = SystemColors.ControlDarkDark;
            currentPasswordLabelForInfoEdit.Location = new Point(0, 148);
            currentPasswordLabelForInfoEdit.Name = "currentPasswordLabelForInfoEdit";
            currentPasswordLabelForInfoEdit.Size = new Size(150, 27);
            currentPasswordLabelForInfoEdit.Text = "Mevcut Şifre";
            currentPasswordLabelForInfoEdit.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // currentPassswordTextBoxForInfoEdit
            // 
            currentPassswordTextBoxForInfoEdit.Location = new Point(150, 148);
            currentPassswordTextBoxForInfoEdit.Name = "currentPassswordTextBoxForInfoEdit";
            currentPassswordTextBoxForInfoEdit.Size = new Size(300, 27);
            currentPassswordTextBoxForInfoEdit.TabIndex = 3;
            // 

            // currentPasswordControlLabelForInfoEdit
            // 
            currentPasswordControlLabelForInfoEdit.AutoSize = false;
            currentPasswordControlLabelForInfoEdit.BackColor= SystemColors.ControlDarkDark;
            currentPasswordControlLabelForInfoEdit.Location = new Point(450, 148);
            currentPasswordControlLabelForInfoEdit.Name = "currentPasswordControlLabelForInfoEdit";
            currentPasswordControlLabelForInfoEdit.Size = new Size(150, 27);
            currentPasswordControlLabelForInfoEdit.Text = "";
            
            
            // nameLabelForInfoEdit
            // 
            nameLabelForInfoEdit.AutoSize = false;
            nameLabelForInfoEdit.BackColor = SystemColors.ControlDarkDark;
            nameLabelForInfoEdit.Location = new Point(0, 185);
            nameLabelForInfoEdit.Name = "nameLabelForInfoEdit";
            nameLabelForInfoEdit.Size = new Size(150, 27);
            nameLabelForInfoEdit.Text = "İsim";
            nameLabelForInfoEdit.TextAlign = ContentAlignment.MiddleCenter;

            // nameTextBoxForInfoEdit
            nameTextBoxForInfoEdit.Location = new Point(150, 185);
            nameTextBoxForInfoEdit.Name = "nameTextBoxForInfoEdit";
            nameTextBoxForInfoEdit.Size = new Size(300, 27);
            nameTextBoxForInfoEdit.TabIndex = 4;
            // 
            

            // nameControlLabelForInfoEdit
            // 
            nameControlLabelForInfoEdit.AutoSize = false;
            nameControlLabelForInfoEdit.BackColor = SystemColors.ControlDarkDark;
            nameControlLabelForInfoEdit.Location = new Point(450, 185);
            nameControlLabelForInfoEdit.Name = "nameControlLabelForInfoEdit";
            nameControlLabelForInfoEdit.Size = new Size(150, 27);
            nameControlLabelForInfoEdit.Text = "";
            nameControlLabelForInfoEdit.TextAlign = ContentAlignment.MiddleCenter;


            // lastNameLabelForInfoEdit
            // 
            
            lastNameLabelForInfoEdit.AutoSize = false;
            lastNameLabelForInfoEdit.BackColor= SystemColors.ControlDarkDark;
            lastNameLabelForInfoEdit.Location = new Point(0, 222);
            lastNameLabelForInfoEdit.Name = "lastNameLabelForInfoEdit";
            lastNameLabelForInfoEdit.Size = new Size(150, 27);
            lastNameLabelForInfoEdit.Text = "Soyisim";
            lastNameLabelForInfoEdit.TextAlign = ContentAlignment.MiddleCenter;

            // lastNameTextBoxForInfoEdit
            // 
            lastNameTextBoxForInfoEdit.Location = new Point(150, 222);
            lastNameTextBoxForInfoEdit.Name = "lastNameTextBoxForInfoEdit";
            lastNameTextBoxForInfoEdit.Size = new Size(300, 27);
            lastNameTextBoxForInfoEdit.TabIndex = 5;

            // 
            // lastNameControlLabelForInfoEdit
            // 
            lastNameControlLabelForInfoEdit.AutoSize = false;
            lastNameControlLabelForInfoEdit.BackColor = SystemColors.ControlDarkDark;
            lastNameControlLabelForInfoEdit.Location = new Point(450, 222);
            lastNameControlLabelForInfoEdit.Name = "lastNameControlLabelForInfoEdit";
            lastNameControlLabelForInfoEdit.Size = new Size(150, 27);
            lastNameControlLabelForInfoEdit.Text = "";
            lastNameControlLabelForInfoEdit.TextAlign = ContentAlignment.MiddleCenter;



            // emailLabelForInfoEdit
            // 
            emailLabelForInfoEdit.AutoSize = false;
            emailLabelForInfoEdit.BackColor = SystemColors.ControlDarkDark;
            emailLabelForInfoEdit.Location = new Point(0, 259);
            emailLabelForInfoEdit.Name = "emailLabelForInfoEdit";
            emailLabelForInfoEdit.Size = new Size(150, 27);
            emailLabelForInfoEdit.Text = "Email";
            emailLabelForInfoEdit.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // emailTextBoxForInfoEdit
            // 
            emailTextBoxForInfoEdit.Location = new Point(150, 259);
            emailTextBoxForInfoEdit.Name = "emailTextBoxForInfoEdit";
            emailTextBoxForInfoEdit.Size = new Size(300, 27);
            emailTextBoxForInfoEdit.TabIndex = 6;
            // 
            // emailControlLabelForInfoEdit
            // 
            emailControlLabelForInfoEdit.AutoSize = false;
            emailControlLabelForInfoEdit.BackColor = SystemColors.ControlDarkDark;
            emailControlLabelForInfoEdit.Location = new Point(450, 259);
            emailControlLabelForInfoEdit.Name = "emailControlLabelForInfoEdit";
            emailControlLabelForInfoEdit.Size = new Size(150, 27);
            emailControlLabelForInfoEdit.Text = "";
            emailControlLabelForInfoEdit.TextAlign = ContentAlignment.MiddleCenter;
            //

            // 
            // saveButtonForInfoEdit
            // 
            saveButtonForInfoEdit.Location = new Point(450, 296);
            saveButtonForInfoEdit.Name = "saveButtonForInfoEdit";
            saveButtonForInfoEdit.Size = new Size(150, 29);
            saveButtonForInfoEdit.Text = "kaydet";
            saveButtonForInfoEdit.UseVisualStyleBackColor = true;
            saveButtonForInfoEdit.Click += saveButtonForInfoEdit_Click;
            saveButtonForInfoEdit.TabIndex = 7;
            // 
            
            // 
            
            // 
            // 
            // 
            
            // 
            
            // 
            
            // 
            
            // 
        }

        private void saveButtonForInfoEdit_Click(object? sender, EventArgs e)
        {
            string username = usernameTextBoxForInfoEdit.Text;
            string email = emailTextBoxForInfoEdit.Text;
            string nextPassword = nextPasswordTextBoxForInfoEdit.Text;
            string nextPasswordConfirm = nextPasswordConfirmtextBoxForInfoEdit.Text;
            string password = currentPassswordTextBoxForInfoEdit.Text;
            string name = nameTextBoxForInfoEdit.Text;
            string surname = lastNameTextBoxForInfoEdit.Text;

            bool a0,a1, a2, a3,a4;
            if(a0 = (!DefaultObject.isDefault(new UserService().GetByUserName(username)) && username != Controller.USER.UserName))
            {
                usernameControlLabelForInfoEdit.Text = "Bu kullanıcı adı tanımlı!";
            }
            if (a1 = (!DefaultObject.isDefault(new UserService().GetByEmail(email)) && email != Controller.USER.Email))
            {
                emailControlLabelForInfoEdit.Text = "Bu email tanımlı!";
            }
            if(a2 = (nextPassword != nextPasswordConfirm))
            {
                nextPasswordConfirmControlForInfoEdit.Text = "Şifre eşleşmiyor!";
            }
            if(a3 = (password != Controller.USER.Password))
            {
                currentPasswordControlLabelForInfoEdit.Text = "Şifre hatalı";
            }
            if(a4 = (password == ""))
            {
                currentPasswordControlLabelForInfoEdit.Text = "Lütfen mevcut şirenizi giriniz!";
            }

            if(!a0 && !a1 && !a2 && !a3 && !a4)
            {
                new UserService().UpdateUserWithCommunication(new UserWithCommunicationDtos()
                {
                    Id = Controller.USER.Id,
                    Email = email,
                    Password = nextPassword,
                    UserName = username,
                    Communication = new CommunicationDtos()
                    {
                        Name = name,
                        Surname = surname
                    }

                });
                
            }

        }
    }
}
