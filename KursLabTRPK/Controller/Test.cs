using System;
using System.Windows.Forms;

namespace KursLabTRPK.Controller
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Authentication form = new Authentication();
            form.txtBoxLogin = "GAI";
            form.txtBoxPassword = "1234";
            form.bAuthentication_Click(sender, e);
            if(form.DialogResult==DialogResult.OK)
                MessageBox.Show("Тест успешно пройден");
        }
    }
}
