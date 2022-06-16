
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Volfinder {
    public partial class MainForm {
        public RadioButton CreateRadioWithName( string name ){
            RadioButton rbutton = new RadioButton();
            rbutton.AutoSize = true;
            rbutton.Text = name;
            return rbutton;
        }
        public GroupBox CreateFlowGroupBox(int width,int height){
            GroupBox groupbox = new GroupBox();
            FlowLayoutPanel flowPnl = new FlowLayoutPanel();

            groupbox.Width = width;
            groupbox.Height = height;
            flowPnl.Width = width - 10;
            flowPnl.Height = height - 20;
            flowPnl.Location = new Point(5,15);

            groupbox.Controls.Add( flowPnl );
            return groupbox;
        }
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

            GroupBox searchOptions = this.CreateFlowGroupBox(605,130);
            searchOptions.Text = "Search Options";
            searchOptions.Location = new Point(10,70);
            searchOptions.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

            GroupBox typeOptionBox = this.CreateFlowGroupBox( searchOptions.Controls[0].Width - 5,48 );
            typeOptionBox.Text = "Value Type";
            typeOptionBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            searchOptions.Controls[0].Controls.Add( typeOptionBox );

            FlowLayoutPanel typeOptionPnl = new FlowLayoutPanel();
            typeOptionPnl.FlowDirection = FlowDirection.LeftToRight;
            typeOptionPnl.Controls.Add( this.CreateRadioWithName("String") );
            typeOptionPnl.Controls.Add( this.CreateRadioWithName("Hex") );
            typeOptionPnl.Controls.Add( this.CreateRadioWithName("Decimal") );
            typeOptionPnl.Controls.Add( this.CreateRadioWithName("Octal") );
            typeOptionBox.Controls[0].Controls.Add( typeOptionPnl );

            GroupBox inputBox = this.CreateFlowGroupBox( searchOptions.Controls[0].Width - 5,48 );
            inputBox.Text = "Input Target Value";
            searchOptions.Controls[0].Controls.Add( inputBox );

            TextBox inputText = new TextBox();
            inputText.Width = inputBox.Controls[0].Width - 5;
            inputBox.Controls[0].Controls.Add( inputText );

            /* Append Controls into the main Window */
            mainForm.Controls.Add( openDirBtn );
            mainForm.Controls.Add( targetPath );
            mainForm.Controls.Add( searchOptions );

            /* Show the Window */
            mainForm.ShowDialog();
        }
    }
}