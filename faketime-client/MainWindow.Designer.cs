namespace faketime_client {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tlpMainWindow = new System.Windows.Forms.TableLayoutPanel();
            this.gbConnectedPeople = new System.Windows.Forms.GroupBox();
            this.lvConnectedPeople = new System.Windows.Forms.ListView();
            this.il = new System.Windows.Forms.ImageList(this.components);
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.gbChats = new System.Windows.Forms.GroupBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tlpSendMessage = new System.Windows.Forms.TableLayoutPanel();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.pbServer = new System.Windows.Forms.PictureBox();
            this.cmdConfigure = new System.Windows.Forms.Button();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.cmdSendMessage = new System.Windows.Forms.Button();
            this.tlpMainWindow.SuspendLayout();
            this.gbConnectedPeople.SuspendLayout();
            this.tlpControls.SuspendLayout();
            this.gbServer.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.tlpSendMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbServer)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMainWindow
            // 
            this.tlpMainWindow.ColumnCount = 2;
            this.tlpMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpMainWindow.Controls.Add(this.gbConnectedPeople, 1, 0);
            this.tlpMainWindow.Controls.Add(this.tlpControls, 0, 0);
            this.tlpMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainWindow.Location = new System.Drawing.Point(0, 0);
            this.tlpMainWindow.Name = "tlpMainWindow";
            this.tlpMainWindow.RowCount = 1;
            this.tlpMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainWindow.Size = new System.Drawing.Size(884, 561);
            this.tlpMainWindow.TabIndex = 0;
            // 
            // gbConnectedPeople
            // 
            this.gbConnectedPeople.Controls.Add(this.lvConnectedPeople);
            this.gbConnectedPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbConnectedPeople.Location = new System.Drawing.Point(772, 3);
            this.gbConnectedPeople.Name = "gbConnectedPeople";
            this.gbConnectedPeople.Size = new System.Drawing.Size(109, 555);
            this.gbConnectedPeople.TabIndex = 0;
            this.gbConnectedPeople.TabStop = false;
            this.gbConnectedPeople.Text = "Personas online";
            // 
            // lvConnectedPeople
            // 
            this.lvConnectedPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConnectedPeople.Enabled = false;
            this.lvConnectedPeople.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvConnectedPeople.Location = new System.Drawing.Point(3, 16);
            this.lvConnectedPeople.MultiSelect = false;
            this.lvConnectedPeople.Name = "lvConnectedPeople";
            this.lvConnectedPeople.Size = new System.Drawing.Size(103, 536);
            this.lvConnectedPeople.SmallImageList = this.il;
            this.lvConnectedPeople.TabIndex = 0;
            this.lvConnectedPeople.UseCompatibleStateImageBehavior = false;
            this.lvConnectedPeople.View = System.Windows.Forms.View.List;
            // 
            // il
            // 
            this.il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il.ImageStream")));
            this.il.TransparentColor = System.Drawing.Color.Transparent;
            this.il.Images.SetKeyName(0, "16 (Users).ico");
            this.il.Images.SetKeyName(1, "16 (Minus).ico");
            this.il.Images.SetKeyName(2, "16 (Record).ico");
            this.il.Images.SetKeyName(3, "16 (Stop-2).ico");
            this.il.Images.SetKeyName(4, "16 (User).ico");
            this.il.Images.SetKeyName(5, "24-em-plus.png");
            this.il.Images.SetKeyName(6, "user.ico");
            this.il.Images.SetKeyName(7, "user_female.ico");
            this.il.Images.SetKeyName(8, "user_gray.ico");
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 1;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.Controls.Add(this.gbServer, 0, 0);
            this.tlpControls.Controls.Add(this.gbMessage, 0, 2);
            this.tlpControls.Controls.Add(this.gbChats, 0, 1);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(3, 3);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 3;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpControls.Size = new System.Drawing.Size(763, 555);
            this.tlpControls.TabIndex = 1;
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.pbServer);
            this.gbServer.Controls.Add(this.cmdConfigure);
            this.gbServer.Controls.Add(this.cmdConnect);
            this.gbServer.Controls.Add(this.textBox1);
            this.gbServer.Controls.Add(this.lblUserName);
            this.gbServer.Controls.Add(this.txtHost);
            this.gbServer.Controls.Add(this.lblHost);
            this.gbServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbServer.Location = new System.Drawing.Point(3, 3);
            this.gbServer.Name = "gbServer";
            this.gbServer.Size = new System.Drawing.Size(757, 40);
            this.gbServer.TabIndex = 0;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "Servidor";
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.tlpSendMessage);
            this.gbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMessage.Location = new System.Drawing.Point(3, 488);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(757, 64);
            this.gbMessage.TabIndex = 1;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Enviar mensaje";
            // 
            // gbChats
            // 
            this.gbChats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbChats.Location = new System.Drawing.Point(3, 49);
            this.gbChats.Name = "gbChats";
            this.gbChats.Size = new System.Drawing.Size(757, 433);
            this.gbChats.TabIndex = 2;
            this.gbChats.TabStop = false;
            this.gbChats.Text = "Conversaciones";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(26, 16);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Host:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(55, 13);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(180, 20);
            this.txtHost.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(241, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(47, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 3;
            // 
            // tlpSendMessage
            // 
            this.tlpSendMessage.ColumnCount = 2;
            this.tlpSendMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSendMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpSendMessage.Controls.Add(this.rtbMessage, 0, 0);
            this.tlpSendMessage.Controls.Add(this.cmdSendMessage, 1, 0);
            this.tlpSendMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSendMessage.Location = new System.Drawing.Point(3, 16);
            this.tlpSendMessage.Name = "tlpSendMessage";
            this.tlpSendMessage.RowCount = 1;
            this.tlpSendMessage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSendMessage.Size = new System.Drawing.Size(751, 45);
            this.tlpSendMessage.TabIndex = 0;
            // 
            // rtbMessage
            // 
            this.rtbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMessage.Enabled = false;
            this.rtbMessage.Location = new System.Drawing.Point(3, 3);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(678, 39);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            // 
            // pbServer
            // 
            this.pbServer.Image = global::faketime_client.Properties.Resources.server;
            this.pbServer.Location = new System.Drawing.Point(7, 16);
            this.pbServer.Name = "pbServer";
            this.pbServer.Size = new System.Drawing.Size(16, 16);
            this.pbServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbServer.TabIndex = 6;
            this.pbServer.TabStop = false;
            // 
            // cmdConfigure
            // 
            this.cmdConfigure.Image = global::faketime_client.Properties.Resources.cog;
            this.cmdConfigure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdConfigure.Location = new System.Drawing.Point(552, 12);
            this.cmdConfigure.Name = "cmdConfigure";
            this.cmdConfigure.Size = new System.Drawing.Size(81, 23);
            this.cmdConfigure.TabIndex = 5;
            this.cmdConfigure.Text = "Configurar";
            this.cmdConfigure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdConfigure.UseVisualStyleBackColor = true;
            // 
            // cmdConnect
            // 
            this.cmdConnect.Image = global::faketime_client.Properties.Resources.connect;
            this.cmdConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdConnect.Location = new System.Drawing.Point(471, 12);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(75, 23);
            this.cmdConnect.TabIndex = 4;
            this.cmdConnect.Text = "Conectar";
            this.cmdConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdConnect.UseVisualStyleBackColor = true;
            // 
            // cmdSendMessage
            // 
            this.cmdSendMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSendMessage.Enabled = false;
            this.cmdSendMessage.Image = global::faketime_client.Properties.Resources.pencil_go;
            this.cmdSendMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSendMessage.Location = new System.Drawing.Point(687, 3);
            this.cmdSendMessage.Name = "cmdSendMessage";
            this.cmdSendMessage.Size = new System.Drawing.Size(61, 39);
            this.cmdSendMessage.TabIndex = 1;
            this.cmdSendMessage.Text = "Enviar";
            this.cmdSendMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSendMessage.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tlpMainWindow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faketime";
            this.tlpMainWindow.ResumeLayout(false);
            this.gbConnectedPeople.ResumeLayout(false);
            this.tlpControls.ResumeLayout(false);
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.gbMessage.ResumeLayout(false);
            this.tlpSendMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbServer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainWindow;
        private System.Windows.Forms.GroupBox gbConnectedPeople;
        private System.Windows.Forms.ListView lvConnectedPeople;
        private System.Windows.Forms.ImageList il;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.GroupBox gbChats;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.TableLayoutPanel tlpSendMessage;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button cmdSendMessage;
        private System.Windows.Forms.Button cmdConfigure;
        private System.Windows.Forms.PictureBox pbServer;
    }
}

