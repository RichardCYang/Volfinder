
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Volfinder {
    public partial class CustomFolderBrowser {
        public void Run(){
            Form browserForm = new Form();
            browserForm.Text = "Folder Browser";
            browserForm.Size = new Size(700,500);
            /* Create toolbar */
            Panel toolbarPnl = new Panel();
            toolbarPnl.Size = new Size(700,40);
            toolbarPnl.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            toolbarPnl.Dock = DockStyle.Top;
            /* Create and Append the Controls into the toolbar */
            TextBox pathText = new TextBox();
            pathText.Size = new Size(480,40);
            pathText.Location = new Point(110,0);
            toolbarPnl.Controls.Add(pathText);
            /* Append Controls into main form */
            browserForm.Controls.Add(toolbarPnl);
            /* Show the folder browser */
            browserForm.ShowDialog();
        }
    }
}