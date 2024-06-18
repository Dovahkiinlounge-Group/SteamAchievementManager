namespace SAM.Picker
{
	partial class GamePicker
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
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
            components = new System.ComponentModel.Container();
            ToolStripSeparator _ToolStripSeparator1;
            ToolStripSeparator _ToolStripSeparator2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePicker));
            _LogoImageList = new ImageList(components);
            _CallbackTimer = new System.Windows.Forms.Timer(components);
            _PickerToolStrip = new ToolStrip();
            _RefreshGamesButton = new ToolStripButton();
            _AddGameTextBox = new ToolStripTextBox();
            _AddGameButton = new ToolStripButton();
            _FilterDropDownButton = new ToolStripDropDownButton();
            _FilterGamesMenuItem = new ToolStripMenuItem();
            _FilterDemosMenuItem = new ToolStripMenuItem();
            _FilterModsMenuItem = new ToolStripMenuItem();
            _FilterJunkMenuItem = new ToolStripMenuItem();
            _GameListView = new DoubleBufferedListView();
            _PickerStatusStrip = new StatusStrip();
            _PickerStatusLabel = new ToolStripStatusLabel();
            _DownloadStatusLabel = new ToolStripStatusLabel();
            _LogoWorker = new System.ComponentModel.BackgroundWorker();
            _ListWorker = new System.ComponentModel.BackgroundWorker();
            _ToolStripSeparator1 = new ToolStripSeparator();
            _ToolStripSeparator2 = new ToolStripSeparator();
            _PickerToolStrip.SuspendLayout();
            _PickerStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // _ToolStripSeparator1
            // 
            _ToolStripSeparator1.Name = "_ToolStripSeparator1";
            _ToolStripSeparator1.Size = new Size(6, 25);
            // 
            // _ToolStripSeparator2
            // 
            _ToolStripSeparator2.Name = "_ToolStripSeparator2";
            _ToolStripSeparator2.Size = new Size(6, 25);
            // 
            // _LogoImageList
            // 
            _LogoImageList.ColorDepth = ColorDepth.Depth32Bit;
            _LogoImageList.ImageSize = new Size(210, 95);
            _LogoImageList.TransparentColor = Color.Transparent;
            // 
            // _CallbackTimer
            // 
            _CallbackTimer.Enabled = true;
            _CallbackTimer.Tick += OnTimer;
            // 
            // _PickerToolStrip
            // 
            _PickerToolStrip.Items.AddRange(new ToolStripItem[] { _RefreshGamesButton, _ToolStripSeparator1, _AddGameTextBox, _AddGameButton, _ToolStripSeparator2, _FilterDropDownButton });
            _PickerToolStrip.Location = new Point(0, 0);
            _PickerToolStrip.Name = "_PickerToolStrip";
            _PickerToolStrip.Size = new Size(1198, 25);
            _PickerToolStrip.TabIndex = 1;
            _PickerToolStrip.Text = "toolStrip1";
            // 
            // _RefreshGamesButton
            // 
            _RefreshGamesButton.Image = Resources.Refresh;
            _RefreshGamesButton.ImageTransparentColor = Color.Magenta;
            _RefreshGamesButton.Name = "_RefreshGamesButton";
            _RefreshGamesButton.Size = new Size(105, 22);
            _RefreshGamesButton.Text = "Refresh Games";
            _RefreshGamesButton.Click += OnRefresh;
            // 
            // _AddGameTextBox
            // 
            _AddGameTextBox.Name = "_AddGameTextBox";
            _AddGameTextBox.Size = new Size(116, 25);
            // 
            // _AddGameButton
            // 
            _AddGameButton.Image = Resources.Search;
            _AddGameButton.ImageTransparentColor = Color.Magenta;
            _AddGameButton.Name = "_AddGameButton";
            _AddGameButton.Size = new Size(83, 22);
            _AddGameButton.Text = "Add Game";
            _AddGameButton.Click += OnAddGame;
            // 
            // _FilterDropDownButton
            // 
            _FilterDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _FilterDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { _FilterGamesMenuItem, _FilterDemosMenuItem, _FilterModsMenuItem, _FilterJunkMenuItem });
            _FilterDropDownButton.Image = Resources.Filter;
            _FilterDropDownButton.ImageTransparentColor = Color.Magenta;
            _FilterDropDownButton.Name = "_FilterDropDownButton";
            _FilterDropDownButton.Size = new Size(29, 22);
            _FilterDropDownButton.Text = "Game filtering";
            // 
            // _FilterGamesMenuItem
            // 
            _FilterGamesMenuItem.Checked = true;
            _FilterGamesMenuItem.CheckOnClick = true;
            _FilterGamesMenuItem.CheckState = CheckState.Checked;
            _FilterGamesMenuItem.Name = "_FilterGamesMenuItem";
            _FilterGamesMenuItem.Size = new Size(142, 22);
            _FilterGamesMenuItem.Text = "Show &games";
            _FilterGamesMenuItem.CheckedChanged += OnFilterUpdate;
            // 
            // _FilterDemosMenuItem
            // 
            _FilterDemosMenuItem.CheckOnClick = true;
            _FilterDemosMenuItem.Name = "_FilterDemosMenuItem";
            _FilterDemosMenuItem.Size = new Size(142, 22);
            _FilterDemosMenuItem.Text = "Show &demos";
            _FilterDemosMenuItem.CheckedChanged += OnFilterUpdate;
            // 
            // _FilterModsMenuItem
            // 
            _FilterModsMenuItem.CheckOnClick = true;
            _FilterModsMenuItem.Name = "_FilterModsMenuItem";
            _FilterModsMenuItem.Size = new Size(142, 22);
            _FilterModsMenuItem.Text = "Show &mods";
            _FilterModsMenuItem.CheckedChanged += OnFilterUpdate;
            // 
            // _FilterJunkMenuItem
            // 
            _FilterJunkMenuItem.CheckOnClick = true;
            _FilterJunkMenuItem.Name = "_FilterJunkMenuItem";
            _FilterJunkMenuItem.Size = new Size(142, 22);
            _FilterJunkMenuItem.Text = "Show &junk";
            _FilterJunkMenuItem.CheckedChanged += OnFilterUpdate;
            // 
            // _GameListView
            // 
            _GameListView.BackColor = Color.Black;
            _GameListView.Dock = DockStyle.Fill;
            _GameListView.ForeColor = Color.White;
            _GameListView.LargeImageList = _LogoImageList;
            _GameListView.Location = new Point(0, 25);
            _GameListView.Margin = new Padding(4, 3, 4, 3);
            _GameListView.MultiSelect = false;
            _GameListView.Name = "_GameListView";
            _GameListView.Size = new Size(1198, 610);
            _GameListView.SmallImageList = _LogoImageList;
            _GameListView.Sorting = SortOrder.Ascending;
            _GameListView.TabIndex = 0;
            _GameListView.TileSize = new Size(184, 69);
            _GameListView.UseCompatibleStateImageBehavior = false;
            _GameListView.VirtualMode = true;
            _GameListView.ItemActivate += OnActivateGame;
            _GameListView.ItemSelectionChanged += OnSelectGame;
            _GameListView.RetrieveVirtualItem += OnGameListViewRetrieveVirtualItem;
            _GameListView.SearchForVirtualItem += OnGameListViewSearchForVirtualItem;
            // 
            // _PickerStatusStrip
            // 
            _PickerStatusStrip.Items.AddRange(new ToolStripItem[] { _PickerStatusLabel, _DownloadStatusLabel });
            _PickerStatusStrip.Location = new Point(0, 635);
            _PickerStatusStrip.Name = "_PickerStatusStrip";
            _PickerStatusStrip.Padding = new Padding(1, 0, 16, 0);
            _PickerStatusStrip.Size = new Size(1198, 22);
            _PickerStatusStrip.TabIndex = 2;
            _PickerStatusStrip.Text = "statusStrip";
            // 
            // _PickerStatusLabel
            // 
            _PickerStatusLabel.Name = "_PickerStatusLabel";
            _PickerStatusLabel.Size = new Size(1181, 17);
            _PickerStatusLabel.Spring = true;
            _PickerStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _DownloadStatusLabel
            // 
            _DownloadStatusLabel.Image = Resources.Download;
            _DownloadStatusLabel.Name = "_DownloadStatusLabel";
            _DownloadStatusLabel.Size = new Size(111, 17);
            _DownloadStatusLabel.Text = "Download status";
            _DownloadStatusLabel.Visible = false;
            // 
            // _LogoWorker
            // 
            _LogoWorker.WorkerSupportsCancellation = true;
            _LogoWorker.DoWork += DoDownloadLogo;
            _LogoWorker.RunWorkerCompleted += OnDownloadLogo;
            // 
            // _ListWorker
            // 
            _ListWorker.WorkerSupportsCancellation = true;
            _ListWorker.DoWork += DoDownloadList;
            _ListWorker.RunWorkerCompleted += OnDownloadList;
            // 
            // GamePicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 657);
            Controls.Add(_GameListView);
            Controls.Add(_PickerStatusStrip);
            Controls.Add(_PickerToolStrip);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "GamePicker";
            _PickerToolStrip.ResumeLayout(false);
            _PickerToolStrip.PerformLayout();
            _PickerStatusStrip.ResumeLayout(false);
            _PickerStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DoubleBufferedListView _GameListView;
		private System.Windows.Forms.ImageList _LogoImageList;
		private System.Windows.Forms.Timer _CallbackTimer;
		private System.Windows.Forms.ToolStrip _PickerToolStrip;
		private System.Windows.Forms.ToolStripButton _RefreshGamesButton;
		private System.Windows.Forms.ToolStripTextBox _AddGameTextBox;
        private System.Windows.Forms.ToolStripButton _AddGameButton;
        private System.Windows.Forms.ToolStripDropDownButton _FilterDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem _FilterGamesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _FilterJunkMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _FilterDemosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _FilterModsMenuItem;
        private System.Windows.Forms.StatusStrip _PickerStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel _DownloadStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel _PickerStatusLabel;
        private System.ComponentModel.BackgroundWorker _LogoWorker;
        private System.ComponentModel.BackgroundWorker _ListWorker;
	}
}

