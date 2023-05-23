namespace UI
{
    internal class BodyPanel : Panel
    {

        private void InitializeComponent()
        {
            Dock = DockStyle.Fill;
            Location = new Point(250, 0);
            Name = "bodyPanel";
            Size = new Size(600, 600);
            TabIndex = 1;
            AutoScroll = true;
        }
        public BodyPanel()
        {
            InitializeComponent();
        }
    }
}
