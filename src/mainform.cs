
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Volfinder {
    public partial class MainForm {
        public void Run(){
            Form mainForm = new Form();
            mainForm.Text = "Volfinder";
            mainForm.Size = new Size(640,320);
            /* Resizable => False */
            mainForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            /* Create Open the Target Directory button */
            Button openDirBtn = new Button();
            openDirBtn.Location = new Point(20,40);
            openDirBtn.Size = new Size(120,25);
            openDirBtn.Text = "Open Directory";
            openDirBtn.Click += delegate(object sender,EventArgs eventArgs){
                CustomFolderBrowser browser = new CustomFolderBrowser();
                browser.Run();
            };
            /* Append Controls into the main Window */
            mainForm.Controls.Add( openDirBtn );
            /* Show the Window */
            mainForm.ShowDialog();
        }
    }
}