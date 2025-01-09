using System.ComponentModel;
using System.Windows.Forms;

namespace TestApp
{
    partial class Form1 : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            var resources = new ComponentResourceManager(typeof(Form1));
            mainMenu1 = new MenuStrip();
            mnuHelp = new ToolStripMenuItem();
            mnuCheckUpdates = new ToolStripMenuItem();
            menuItem1 = new ToolStripSeparator();
            yourMenuItem = new ToolStripMenuItem();
            menuItem3 = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cvxcvxcvxcvxcvToolStripMenuItem = new ToolStripMenuItem();
            lblVersion = new Label();
            btnRecheckNow = new Button();
            textBox1 = new TextBox();
            automaticUpdater = new wyDay.Controls.AutomaticUpdater();

            // 
            // mainMenu1
            // 
            mainMenu1.Items.AddRange(new ToolStripItem[] { mnuHelp });

            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuCheckUpdates, menuItem1, yourMenuItem, menuItem3 });
            mnuHelp.Text = "Help";

            // 
            // mnuCheckUpdates
            // 
            mnuCheckUpdates.Text = "Check for Updates";

            // 
            // menuItem1
            // 
            // Separator does not need Text, it acts as a visual separator.

            // 
            // yourMenuItem
            // 
            yourMenuItem.Text = "Online Help";

            // 
            // menuItem3
            // 
            menuItem3.Text = "About";

            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cvxcvxcvxcvxcvToolStripMenuItem });

            // 
            // cvxcvxcvxcvxcvToolStripMenuItem
            // 
            cvxcvxcvxcvxcvToolStripMenuItem.Text = "Context Menu Item";

            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new System.Drawing.Point(12, 15);
            lblVersion.Text = "Version 1.1";

            // 
            // btnRecheckNow
            // 
            btnRecheckNow.Location = new System.Drawing.Point(275, 70);
            btnRecheckNow.Size = new System.Drawing.Size(108, 24);
            btnRecheckNow.Text = "Recheck Now";
            btnRecheckNow.UseVisualStyleBackColor = true;
            btnRecheckNow.Click += BtnRecheckNow_Click;

            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(12, 48);
            textBox1.Multiline = true;
            textBox1.Size = new System.Drawing.Size(244, 98);

            // 
            // automaticUpdater
            // 
            automaticUpdater.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            automaticUpdater.GUID = "8b43fb52-1ebb-4cfa-a387-e83afa5afef3";
            automaticUpdater.Location = new System.Drawing.Point(367, 12);
            automaticUpdater.MenuItem = mnuCheckUpdates;
            automaticUpdater.UpdateType = wyDay.Controls.UpdateType.DoNothing;
            automaticUpdater.ClosingAborted += AutomaticUpdater_ClosingAborted;

            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(395, 173);
            Controls.Add(mainMenu1); // Ensure MenuStrip is added to Controls
            Controls.Add(textBox1);
            Controls.Add(automaticUpdater);
            Controls.Add(lblVersion);
            Controls.Add(btnRecheckNow);
            MainMenuStrip = mainMenu1; // Set MainMenuStrip property
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YourApp";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private void BtnRecheckNow_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Rechecking now...");
        }

        private void AutomaticUpdater_ClosingAborted(object sender, System.EventArgs e)
        {
            MessageBox.Show("Update aborted.");
        }

        private MenuStrip mainMenu1;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuCheckUpdates;
        private ToolStripSeparator menuItem1;
        private ToolStripMenuItem yourMenuItem;
        private ToolStripMenuItem menuItem3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cvxcvxcvxcvxcvToolStripMenuItem;
        private Label lblVersion;
        private Button btnRecheckNow;
        private TextBox textBox1;
        private wyDay.Controls.AutomaticUpdater automaticUpdater;
    }
}

