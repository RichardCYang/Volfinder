
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

            /* Create Open the Target Directory button */
            Button openDirBtn = new Button();
            openDirBtn.Location = new Point(10,40);
            openDirBtn.Size = new Size(120,25);
            openDirBtn.Text = "Open Directory";
            openDirBtn.FlatAppearance.BorderSize = 1;
            openDirBtn.Click += delegate(object sender,EventArgs eventArgs){
                CustomFolderBrowser browser = new CustomFolderBrowser();
                browser.Run();
            };

            /* Create the target path text box */
            TextBox targetPath = new TextBox();
            targetPath.Text = "C:\\";
            targetPath.Size = new Size(475,26);
            targetPath.Location = new Point(140,40); 
            targetPath.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            /* Sync the height of text box with button */
            targetPath.AutoSize = false;

            /* Create the search options groupbox */
            GroupBox searchOptions = new GroupBox();
            searchOptions.Text = "Search Options";
            searchOptions.Location = new Point(10,70);
            searchOptions.Size = new Size(605,100);
            searchOptions.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

            /* Create the search value type radio button */
            GroupBox valueTypeOptions = new GroupBox();
            valueTypeOptions.Text = "Type";
            valueTypeOptions.Size = new Size(580,40);
            valueTypeOptions.Location = new Point(12,15);
            valueTypeOptions.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            searchOptions.Controls.Add( valueTypeOptions );

            RadioButton stringTypeRadio = new RadioButton();
            stringTypeRadio.Text = "String";
            stringTypeRadio.Width = 145;
            stringTypeRadio.Dock = DockStyle.Left;

            RadioButton hexTypeRadio = new RadioButton();
            hexTypeRadio.Text = "Hexadecimal";
            hexTypeRadio.Width = 145;
            hexTypeRadio.Dock = DockStyle.Left;

            RadioButton binTypeRadio = new RadioButton();
            binTypeRadio.Text = "Binary";
            binTypeRadio.Width = 145;
            binTypeRadio.Dock = DockStyle.Left;

            RadioButton deciamlTypeRadio = new RadioButton();
            deciamlTypeRadio.Text = "Decimal";
            deciamlTypeRadio.Width = 140;
            deciamlTypeRadio.Dock = DockStyle.Left;

            valueTypeOptions.Controls.Add( stringTypeRadio );
            valueTypeOptions.Controls.Add( hexTypeRadio );
            valueTypeOptions.Controls.Add( binTypeRadio );
            valueTypeOptions.Controls.Add( deciamlTypeRadio );

            /* Append Controls into the main Window */
            mainForm.Controls.Add( openDirBtn );
            mainForm.Controls.Add( targetPath );
            mainForm.Controls.Add( searchOptions );

            /* Show the Window */
            mainForm.ShowDialog();
        }
    }
}