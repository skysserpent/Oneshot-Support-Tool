using System.Windows.Forms;
namespace GameOptimizer
{
    partial class MainSupportTool
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblStatus;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSupportTool));
            this.lblStatus = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnOption1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnOption2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblWikiLink = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblOneshotlink = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.lblStatus.Location = new System.Drawing.Point(17, 25);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(345, 450);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Initializing...";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2VScrollBar1);
            this.guna2Panel1.Controls.Add(this.lblStatus);
            this.guna2Panel1.Location = new System.Drawing.Point(23, 42);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(389, 229);
            this.guna2Panel1.TabIndex = 3;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.guna2VScrollBar1.BorderRadius = 3;
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(368, 3);
            this.guna2VScrollBar1.Maximum = 200;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 223);
            this.guna2VScrollBar1.TabIndex = 1;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.guna2VScrollBar1.ThumbSize = 50F;
            this.guna2VScrollBar1.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.guna2VScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2VScrollBar1_Scroll);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 1D;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnOption1
            // 
            this.btnOption1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnOption1.BorderRadius = 5;
            this.btnOption1.BorderThickness = 3;
            this.btnOption1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOption1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOption1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOption1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOption1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnOption1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOption1.ForeColor = System.Drawing.Color.White;
            this.btnOption1.Location = new System.Drawing.Point(23, 277);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(180, 45);
            this.btnOption1.TabIndex = 4;
            this.btnOption1.Text = "Option 1";
            this.btnOption1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnOption2.BorderRadius = 5;
            this.btnOption2.BorderThickness = 3;
            this.btnOption2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOption2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOption2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOption2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOption2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnOption2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOption2.ForeColor = System.Drawing.Color.White;
            this.btnOption2.Location = new System.Drawing.Point(232, 277);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(180, 45);
            this.btnOption2.TabIndex = 5;
            this.btnOption2.Text = "Option 2";
            this.btnOption2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.guna2ControlBox1.BorderRadius = 5;
            this.guna2ControlBox1.BorderThickness = 3;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(382, 6);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(346, 15);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(30, 10);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "guna2Button1";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // lblWikiLink
            // 
            this.lblWikiLink.BackColor = System.Drawing.Color.Transparent;
            this.lblWikiLink.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWikiLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.lblWikiLink.IsSelectionEnabled = false;
            this.lblWikiLink.Location = new System.Drawing.Point(242, 8);
            this.lblWikiLink.Name = "lblWikiLink";
            this.lblWikiLink.Size = new System.Drawing.Size(40, 28);
            this.lblWikiLink.TabIndex = 28;
            this.lblWikiLink.Text = "wiki";
            this.lblWikiLink.Click += new System.EventHandler(this.lblWikiLink_Click);
            // 
            // lblOneshotlink
            // 
            this.lblOneshotlink.BackColor = System.Drawing.Color.Transparent;
            this.lblOneshotlink.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneshotlink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblOneshotlink.IsSelectionEnabled = false;
            this.lblOneshotlink.Location = new System.Drawing.Point(160, 8);
            this.lblOneshotlink.Name = "lblOneshotlink";
            this.lblOneshotlink.Size = new System.Drawing.Size(83, 28);
            this.lblOneshotlink.TabIndex = 28;
            this.lblOneshotlink.Text = "oneshot.";
            this.lblOneshotlink.Click += new System.EventHandler(this.guna2HtmlLabel5_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.Location = new System.Drawing.Point(25, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Size = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.TabIndex = 10;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // MainSupportTool
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(440, 340);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.lblWikiLink);
            this.Controls.Add(this.lblOneshotlink);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption1);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainSupportTool";
            this.Text = "Game Optimizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnOption2;
        private Guna.UI2.WinForms.Guna2Button btnOption1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWikiLink;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOneshotlink;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}