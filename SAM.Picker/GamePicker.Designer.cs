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
            System.Windows.Forms.ToolStripSeparator _ToolStripSeparator1;
            System.Windows.Forms.ToolStripSeparator _ToolStripSeparator2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePicker));
            _LogoImageList = new System.Windows.Forms.ImageList(components);
            _CallbackTimer = new System.Windows.Forms.Timer(components);
            _PickerToolStrip = new System.Windows.Forms.ToolStrip();
            _RefreshGamesButton = new System.Windows.Forms.ToolStripButton();
            _AddGameTextBox = new System.Windows.Forms.ToolStripTextBox();
            _AddGameButton = new System.Windows.Forms.ToolStripButton();
            _FilterDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            _FilterGamesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            _FilterDemosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            _FilterModsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            _FilterJunkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            _GameListView = new DoubleBufferedListView();
            _PickerStatusStrip = new System.Windows.Forms.StatusStrip();
            _PickerStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            _DownloadStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            _LogoWorker = new System.ComponentModel.BackgroundWorker();
            _ListWorker = new System.ComponentModel.BackgroundWorker();
            _ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            _ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            _PickerToolStrip.SuspendLayout();
            _PickerStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // _ToolStripSeparator1
            // 
            _ToolStripSeparator1.Name = "_ToolStripSeparator1";
            _ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // _ToolStripSeparator2
            // 
            _ToolStripSeparator2.Name = "_ToolStripSeparator2";
            _ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _LogoImageList
            // 
            _LogoImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            _LogoImageList.ImageSize = new System.Drawing.Size(184, 69);
            _LogoImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // _CallbackTimer
            // 
            _CallbackTimer.Enabled = true;
            _CallbackTimer.Tick += OnTimer;
            // 
            // _PickerToolStrip
            // 
            _PickerToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { _RefreshGamesButton, _ToolStripSeparator1, _AddGameTextBox, _AddGameButton, _ToolStripSeparator2, _FilterDropDownButton });
            _PickerToolStrip.Location = new System.Drawing.Point(0, 0);
            _PickerToolStrip.Name = "_PickerToolStrip";
            _PickerToolStrip.Size = new System.Drawing.Size(1087, 25);
            _PickerToolStrip.TabIndex = 1;
            _PickerToolStrip.Text = "toolStrip1";
            // 
            // _RefreshGamesButton
            // 
            _RefreshGamesButton.Image = Resources.Refresh;
            _RefreshGamesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            _RefreshGamesButton.Name = "_RefreshGamesButton";
            _RefreshGamesButton.Size = new System.Drawing.Size(105, 22);
            _RefreshGamesButton.Text = "Refresh Games";
            _RefreshGamesButton.Click += OnRefresh;
            // 
            // _AddGameTextBox
            // 
            _AddGameTextBox.Name = "_AddGameTextBox";
            _AddGameTextBox.Size = new System.Drawing.Size(116, 25);
            // 
            // _AddGameButton
            // 
            _AddGameButton.Image = Resources.Search;
            _AddGameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            _AddGameButton.Name = "_AddGameButton";
            _AddGameButton.Size = new System.Drawing.Size(83, 22);
            _AddGameButton.Text = "Add Game";
            _AddGameButton.Click += OnAddGame;
            // 
            // _FilterDropDownButton
            // 
            _FilterDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            _FilterDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { _FilterGamesMenuItem, _FilterDemosMenuItem, _FilterModsMenuItem, _FilterJunkMenuItem });
            _FilterDropDownButton.Image = Resources.Filter;
            _FilterDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            _FilterDropDownButton.Name = "_FilterDropDownButton";
            _FilterDropDownButton.Size = new System.Drawing.Size(29, 22);
            _FilterDropDownButton.Text = "Game filtering";
            // 
            // _FilterGamesMenuItem
            // 
            _FilterGamesMenuItem.Checked = true;
            _FilterGamesMenuItem.CheckOnClick = true;
            _FilterGamesMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            _FilterGamesMenuItem.Name = "_FilterGamesMenuItem";
            _FilterGamesMenuItem.Size = new System.Drawing.Size(142, 22);
            _FilterGamesMenuItem.Text = "Show &games";
            _FilterGamesMenuItem.CheckedChanged += OnFilterUpdate;
            // 
            // _FilterDemosMenuItem
            // 
            _FilterDemosMenuItem.CheckOnClick = true;
            _FilterDemosMenuItem.Name = "_FilterDemosMenuItem";
            _FilterDemosMenuItem.Size = new System.Drawing.Size(142, 22);
            _FilterDemosMenuItem.Text = "Show &demos";
            _FilterDemosMenuItem.CheckedChanged += OnFilterUpdate;
            // 
            // _FilterModsMenuItem
            // 
            _FilterModsMenuItem.CheckOnClick = true;
            _FilterModsMenuItem.Name = "_FilterModsMenuItem";
            _FilterModsMenuItem.Size = new System.Drawing.Size(142, 22);
            _FilterModsMenuItem.Text = "Show &mods";
            _FilterModsMenuItem.CheckedChanged += OnFilterUpdate;
            // 
            // _FilterJunkMenuItem
            // 
            _FilterJunkMenuItem.CheckOnClick = true;
            _FilterJunkMenuItem.Name = "_FilterJunkMenuItem";
            _FilterJunkMenuItem.Size = new System.Drawing.Size(142, 22);
            _FilterJunkMenuItem.Text = "Show &junk";
            _FilterJunkMenuItem.CheckedChanged += OnFilterUpdate;
            // 
            // _GameListView
            // 
            _GameListView.BackColor = System.Drawing.Color.Black;
            _GameListView.Dock = System.Windows.Forms.DockStyle.Fill;
            _GameListView.ForeColor = System.Drawing.Color.White;
            _GameListView.LargeImageList = _LogoImageList;
            _GameListView.Location = new System.Drawing.Point(0, 25);
            _GameListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _GameListView.MultiSelect = false;
            _GameListView.Name = "_GameListView";
            _GameListView.Size = new System.Drawing.Size(1087, 610);
            _GameListView.SmallImageList = _LogoImageList;
            _GameListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            _GameListView.TabIndex = 0;
            _GameListView.TileSize = new System.Drawing.Size(184, 69);
            _GameListView.UseCompatibleStateImageBehavior = false;
            _GameListView.VirtualMode = true;
            _GameListView.ItemActivate += OnActivateGame;
            _GameListView.ItemSelectionChanged += OnSelectGame;
            _GameListView.RetrieveVirtualItem += OnGameListViewRetrieveVirtualItem;
            _GameListView.SearchForVirtualItem += OnGameListViewSearchForVirtualItem;
            // 
            // _PickerStatusStrip
            // 
            _PickerStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { _PickerStatusLabel, _DownloadStatusLabel });
            _PickerStatusStrip.Location = new System.Drawing.Point(0, 635);
            _PickerStatusStrip.Name = "_PickerStatusStrip";
            _PickerStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            _PickerStatusStrip.Size = new System.Drawing.Size(1087, 22);
            _PickerStatusStrip.TabIndex = 2;
            _PickerStatusStrip.Text = "statusStrip";
            // 
            // _PickerStatusLabel
            // 
            _PickerStatusLabel.Name = "_PickerStatusLabel";
            _PickerStatusLabel.Size = new System.Drawing.Size(1070, 17);
            _PickerStatusLabel.Spring = true;
            _PickerStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _DownloadStatusLabel
            // 
            _DownloadStatusLabel.Image = Resources.Download;
            _DownloadStatusLabel.Name = "_DownloadStatusLabel";
            _DownloadStatusLabel.Size = new System.Drawing.Size(111, 17);
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
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1087, 657);
            Controls.Add(_GameListView);
            Controls.Add(_PickerStatusStrip);
            Controls.Add(_PickerToolStrip);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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

