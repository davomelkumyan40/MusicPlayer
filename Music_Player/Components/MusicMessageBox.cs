using Music_Player.Components.Custom_Controls;
using System.Drawing;
using System.Windows.Forms;

namespace Music_Player.Components
{
    public partial class MusicMessageBox : Form
    {
        public MusicMessageBox()
        {
            InitializeComponent();
        }

        private string unknownErrorMessage = "Unknown Eroor Please Reinstall Application";
        private string globalWrongAuthMessage = "Oops, Wrong Login or Password";
        private string globalSuccessMessage = "Success!";
        private string successMessage = "Your download is finished. Thanks for using our product, \n\r" + new string(' ', 41) + "Enjoy!";
        private string wrondAuthMessage = "Your Login or Password is wrong press Ok and try again";
        private string warningMessage = "Something's wrong with Music Player and it's has Stoped Working !\n\rPlease be soure that you installed on your PC Microsoft .NET 4.5 and later version \n\rIf you already installed you can try to \"Run Again\" or you can press \n\r\"Don't run\" rand application will be closed and try to run it again.\n\rif its not helping please Reinstall application.";
        private Form baseForm;

        private void Run_anyway_Click(object sender, System.EventArgs e)
        {
            if (baseForm != null)
            {
                baseForm.Show();
                baseForm.BringToFront();
            }
            else
            {
                Application.Exit();
            }
            this.Close();
        }

        public void ShowWindow(Form baseForm, string message)
        {
            this.message.Text = message;
            ShowWindow(baseForm, MessageFlags.UserMessage);
        }

        public void ShowWindow(Form baseForm, MessageFlags flag)
        {
            this.baseForm = baseForm;
            switch (flag)
            {
                case MessageFlags.Warning:
                    {
                        this.message.Text = warningMessage;
                        success_png.Hide();
                    }
                    break;
                case MessageFlags.Error:
                    {
                        success_png.Show();
                        success_png.Image = Image.FromFile(@".\Source\error.png");
                        message.Text = unknownErrorMessage;
                    }
                    break;
                case MessageFlags.WrongAuth:
                    {
                        dont_run_btn.Hide();
                        success_png.Hide();
                        global_message.Text = globalWrongAuthMessage;
                        run_anyway_btn.Text = "OK";
                        run_anyway_btn.Location = new Point(542, 514);
                        message.Text = wrondAuthMessage;
                    }
                    break;
                case MessageFlags.Success:
                    {
                        global_message.Location = new Point(279, 41);
                        global_message.Font = new Font("Segoe UI", 25f);
                        global_message.Text = globalSuccessMessage;
                        message.Text = successMessage;
                        message.Font = new Font("Segoe UI", 15f);
                        message.Location = new Point(110, 142);
                        success_png.Show();
                        run_anyway_btn.Text = "OK";
                        run_anyway_btn.Location = new Point(269, 462);
                        run_anyway_btn.Size = new Size(165, 46);
                        dont_run_btn.Hide();
                    }
                    break;
                case MessageFlags.UserMessage:
                    {
                        run_anyway_btn.Text = "OK";
                        dont_run_btn.Hide();
                    }
                    break;
                default:
                    break;
            }
            Refresh();
        }

        private void Dont_run_btn_Click(object sender, System.EventArgs e) => Application.Exit();
    }
}
