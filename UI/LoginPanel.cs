
using Client;
using Entities.DTOs;

namespace UI
{
    internal class LoginPanel : Panel
    {
        private string prevUsername = "";
        private string username;
        private string password;
        private string[] messages =
        {
            "Lütfen alanları boş bırakmayınız!",
            "Hatalı şifre!Tekrar deneyiniz.",
            "Kullanıcı adı tanımlı değil",
            "Giriş başarılı."
        };



        private Label usernameLabelForLogin;
        private TextBox usernameTextBoxForLogin;

        private Label passwordLabelForLogin;
        private TextBox passwordTextBoxForLogin;
        
        private Button loginButtonForLogin;
        private Label outputLabelForLogin;

        private void InitializeComponent()
        {
            outputLabelForLogin = new Label();
            loginButtonForLogin = new Button();
            passwordLabelForLogin = new Label();
            passwordTextBoxForLogin = new TextBox();
            usernameTextBoxForLogin = new TextBox();
            usernameLabelForLogin = new Label();


            // userNameLabelForLogin
            // 
            usernameLabelForLogin.AutoSize = true;
            usernameLabelForLogin.Location = new Point(3, 9);
            usernameLabelForLogin.Name = "userNameLabelForLogin";
            usernameLabelForLogin.Size = new Size(75, 20);
            usernameLabelForLogin.TabIndex = 6;
            usernameLabelForLogin.Text = "Username";
            //
            // usernameTextBoxForLogin
            // 
            usernameTextBoxForLogin.Location = new Point(84, 6);
            usernameTextBoxForLogin.Name = "usernameTextBoxForLogin";
            usernameTextBoxForLogin.Size = new Size(145, 27);
            usernameTextBoxForLogin.TabIndex = 7;
            //
            // passwordLabelForLogin
            // 
            passwordLabelForLogin.AutoSize = true;
            passwordLabelForLogin.Location = new Point(6, 42);
            passwordLabelForLogin.Name = "passwordLabelForLogin";
            passwordLabelForLogin.Size = new Size(70, 20);
            passwordLabelForLogin.TabIndex = 9;
            passwordLabelForLogin.Text = "Password";
            //
            // passwordTextBoxForLogin
            // 
            passwordTextBoxForLogin.Location = new Point(84, 39);
            passwordTextBoxForLogin.Name = "passwordTextBoxForLogin";
            passwordTextBoxForLogin.PasswordChar = '*';
            passwordTextBoxForLogin.Size = new Size(145, 27);
            passwordTextBoxForLogin.TabIndex = 8;
            //
            // loginButtonForLogin
            // 
            loginButtonForLogin.Location = new Point(84, 72);
            loginButtonForLogin.Name = "loginButtonForLogin";
            loginButtonForLogin.Size = new Size(145, 29);
            loginButtonForLogin.TabIndex = 10;
            loginButtonForLogin.Text = "login";
            loginButtonForLogin.UseVisualStyleBackColor = true;
            loginButtonForLogin.Click += loginButton_Click;
            // 
            // outputLabelForLogin
            // 
            outputLabelForLogin.Location = new Point(6, 104);
            outputLabelForLogin.TextAlign = ContentAlignment.MiddleCenter;
            outputLabelForLogin.Name = "outputLabelForLogin";
            outputLabelForLogin.Size = new Size(226, 20);
            outputLabelForLogin.TabIndex = 11;
            outputLabelForLogin.Text = "";
            // 


            //this
            // 
            Controls.Add(outputLabelForLogin);
            Controls.Add(loginButtonForLogin);
            Controls.Add(passwordLabelForLogin);
            Controls.Add(passwordTextBoxForLogin);
            Controls.Add(usernameTextBoxForLogin);
            Controls.Add(usernameLabelForLogin);

            Location = new Point(3, 3);
            Name = "loginPanelForLogin";
            Size = new Size(241, 142);
            TabIndex = 1;
            // 

        }

        public LoginPanel() {
            InitializeComponent();
        }

        private void loginButton_Click(object? sender, EventArgs e)
        {
            username = usernameTextBoxForLogin.Text;
            password = passwordTextBoxForLogin.Text;
            if (username == "" || password == "")
                outputLabelForLogin.Text = messages[0];
            else
            {
                UserDtos user = null;
                if (prevUsername != username || user == null)
                {
                    user = new UserService().GetByUserName(username);
                    prevUsername = username;
                }
                if (DefaultObject.isDefault(user))
                    outputLabelForLogin.Text = messages[2];
                else
                    if (user.Password == password)
                    {
                        Controller.USER = user;
                        Controller.CreateOptionsPanel();
                        Controller.AddChildPanelToMenuPanel(Controller.OPTIONS_PANEL);
                    }
                    else
                        outputLabelForLogin.Text = messages[1];
            }
        }
    }
}
