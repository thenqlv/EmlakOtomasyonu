namespace UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Create()
        {
            Controller.CreateBodyPanel();
            Controller.CreateMenuPanel();
            Controller.CreateLoginPanel();
            Controller.AddChildPanelToMenuPanel(Controller.LOGIN_PANEL);
            Controls.Add(Controller.BODY_PANEL);
            Controls.Add(Controller.MENU_PANEL);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            /*
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            nextButtonForHouse = new Button();
            prevButtonForHouse = new Button();
            pictureBoxForHouse = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForHouse).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(nextButtonForHouse);
            panel1.Controls.Add(prevButtonForHouse);
            panel1.Controls.Add(pictureBoxForHouse);
            panel1.Location = new Point(393, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 302);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(27, 515);
            label1.Name = "label1";
            label1.Size = new Size(811, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(3, 179);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // nextButtonForHouse
            // 
            nextButtonForHouse.Location = new Point(302, 214);
            nextButtonForHouse.Name = "nextButtonForHouse";
            nextButtonForHouse.Size = new Size(94, 29);
            nextButtonForHouse.TabIndex = 2;
            nextButtonForHouse.Text = ">";
            nextButtonForHouse.UseVisualStyleBackColor = true;
            // 
            // prevButtonForHouse
            // 
            prevButtonForHouse.Location = new Point(78, 214);
            prevButtonForHouse.Name = "prevButtonForHouse";
            prevButtonForHouse.Size = new Size(94, 29);
            prevButtonForHouse.TabIndex = 1;
            prevButtonForHouse.Text = "<";
            prevButtonForHouse.UseVisualStyleBackColor = true;
            // 
            // pictureBoxForHouse
            //
            pictureBoxForHouse.Image = Image.FromFile("C:\\Users\\MFGGL\\Desktop\\EmlakOtomasyonu-main\\GorselProgramlama\\UI\\bin\\Debug\\net6.0-windows\\Resources\\ev0.jpg");
            pictureBoxForHouse.Location = new Point(99, 3);
            pictureBoxForHouse.Name = "pictureBoxForHouse";
            pictureBoxForHouse.Size = new Size(297, 170);
            pictureBoxForHouse.TabIndex = 0;
            pictureBoxForHouse.TabStop = false;
            pictureBoxForHouse.Click += pictureBoxForHouse_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            */
            Create();
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 600);
            //Controls.Add(label1);
            //Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            //panel1.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)pictureBoxForHouse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button nextButtonForHouse;
        private Button prevButtonForHouse;
        private PictureBox pictureBoxForHouse;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Label label1;
    }
}