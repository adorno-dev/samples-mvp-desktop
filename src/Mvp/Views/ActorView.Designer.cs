namespace Mvp.Views
{
    partial class ActorView
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
            this.ActorTitleLabel = new System.Windows.Forms.Label();
            this.panelActors = new System.Windows.Forms.Panel();
            this.actorCloseButton = new System.Windows.Forms.Button();
            this.tabActors = new System.Windows.Forms.TabControl();
            this.tabActorList = new System.Windows.Forms.TabPage();
            this.ActorGridView = new System.Windows.Forms.DataGridView();
            this.ActorDeleteButton = new System.Windows.Forms.Button();
            this.ActorEditButton = new System.Windows.Forms.Button();
            this.ActorAddNewButton = new System.Windows.Forms.Button();
            this.ActorSearchButton = new System.Windows.Forms.Button();
            this.ActorSearchTextbox = new System.Windows.Forms.TextBox();
            this.ActorSearchLabel = new System.Windows.Forms.Label();
            this.tabActorDetail = new System.Windows.Forms.TabPage();
            this.ActorCancelButton = new System.Windows.Forms.Button();
            this.ActorSaveButton = new System.Windows.Forms.Button();
            this.ActorLanguageTextbox = new System.Windows.Forms.TextBox();
            this.ActorLanguageLabel = new System.Windows.Forms.Label();
            this.ActorCountryTextbox = new System.Windows.Forms.TextBox();
            this.ActorCountryLabel = new System.Windows.Forms.Label();
            this.ActorNameTextbox = new System.Windows.Forms.TextBox();
            this.ActorNameLabel = new System.Windows.Forms.Label();
            this.ActorIdTextbox = new System.Windows.Forms.TextBox();
            this.ActorIdLabel = new System.Windows.Forms.Label();
            this.panelActors.SuspendLayout();
            this.tabActors.SuspendLayout();
            this.tabActorList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActorGridView)).BeginInit();
            this.tabActorDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActorTitleLabel
            // 
            this.ActorTitleLabel.AutoSize = true;
            this.ActorTitleLabel.Font = new System.Drawing.Font("Roboto", 10.28571F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ActorTitleLabel.Location = new System.Drawing.Point(59, 14);
            this.ActorTitleLabel.Name = "ActorTitleLabel";
            this.ActorTitleLabel.Size = new System.Drawing.Size(66, 18);
            this.ActorTitleLabel.TabIndex = 0;
            this.ActorTitleLabel.Text = "ACTORS";
            // 
            // panelActors
            // 
            this.panelActors.BackColor = System.Drawing.Color.White;
            this.panelActors.Controls.Add(this.actorCloseButton);
            this.panelActors.Controls.Add(this.ActorTitleLabel);
            this.panelActors.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActors.Location = new System.Drawing.Point(0, 0);
            this.panelActors.Name = "panelActors";
            this.panelActors.Size = new System.Drawing.Size(685, 45);
            this.panelActors.TabIndex = 1;
            // 
            // actorCloseButton
            // 
            this.actorCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.actorCloseButton.Font = new System.Drawing.Font("Roboto", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorCloseButton.Location = new System.Drawing.Point(638, 11);
            this.actorCloseButton.Name = "actorCloseButton";
            this.actorCloseButton.Size = new System.Drawing.Size(32, 25);
            this.actorCloseButton.TabIndex = 8;
            this.actorCloseButton.Text = "X";
            this.actorCloseButton.UseVisualStyleBackColor = true;
            // 
            // tabActors
            // 
            this.tabActors.Controls.Add(this.tabActorList);
            this.tabActors.Controls.Add(this.tabActorDetail);
            this.tabActors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabActors.Font = new System.Drawing.Font("Roboto", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabActors.Location = new System.Drawing.Point(0, 45);
            this.tabActors.Name = "tabActors";
            this.tabActors.SelectedIndex = 0;
            this.tabActors.Size = new System.Drawing.Size(685, 355);
            this.tabActors.TabIndex = 2;
            // 
            // tabActorList
            // 
            this.tabActorList.Controls.Add(this.ActorGridView);
            this.tabActorList.Controls.Add(this.ActorDeleteButton);
            this.tabActorList.Controls.Add(this.ActorEditButton);
            this.tabActorList.Controls.Add(this.ActorAddNewButton);
            this.tabActorList.Controls.Add(this.ActorSearchButton);
            this.tabActorList.Controls.Add(this.ActorSearchTextbox);
            this.tabActorList.Controls.Add(this.ActorSearchLabel);
            this.tabActorList.Location = new System.Drawing.Point(4, 27);
            this.tabActorList.Name = "tabActorList";
            this.tabActorList.Padding = new System.Windows.Forms.Padding(3);
            this.tabActorList.Size = new System.Drawing.Size(677, 324);
            this.tabActorList.TabIndex = 0;
            this.tabActorList.Text = "Actor List";
            this.tabActorList.UseVisualStyleBackColor = true;
            // 
            // ActorGridView
            // 
            this.ActorGridView.AllowUserToAddRows = false;
            this.ActorGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActorGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ActorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActorGridView.Location = new System.Drawing.Point(20, 72);
            this.ActorGridView.Name = "ActorGridView";
            this.ActorGridView.RowHeadersWidth = 45;
            this.ActorGridView.RowTemplate.Height = 27;
            this.ActorGridView.Size = new System.Drawing.Size(558, 233);
            this.ActorGridView.TabIndex = 7;
            // 
            // ActorDeleteButton
            // 
            this.ActorDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActorDeleteButton.Location = new System.Drawing.Point(584, 134);
            this.ActorDeleteButton.Name = "ActorDeleteButton";
            this.ActorDeleteButton.Size = new System.Drawing.Size(82, 25);
            this.ActorDeleteButton.TabIndex = 6;
            this.ActorDeleteButton.Text = "Delete";
            this.ActorDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ActorEditButton
            // 
            this.ActorEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActorEditButton.Location = new System.Drawing.Point(584, 103);
            this.ActorEditButton.Name = "ActorEditButton";
            this.ActorEditButton.Size = new System.Drawing.Size(82, 25);
            this.ActorEditButton.TabIndex = 5;
            this.ActorEditButton.Text = "Edit";
            this.ActorEditButton.UseVisualStyleBackColor = true;
            // 
            // ActorAddNewButton
            // 
            this.ActorAddNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActorAddNewButton.Location = new System.Drawing.Point(584, 72);
            this.ActorAddNewButton.Name = "ActorAddNewButton";
            this.ActorAddNewButton.Size = new System.Drawing.Size(82, 25);
            this.ActorAddNewButton.TabIndex = 4;
            this.ActorAddNewButton.Text = "Add New";
            this.ActorAddNewButton.UseVisualStyleBackColor = true;
            // 
            // ActorSearchButton
            // 
            this.ActorSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActorSearchButton.Location = new System.Drawing.Point(584, 41);
            this.ActorSearchButton.Name = "ActorSearchButton";
            this.ActorSearchButton.Size = new System.Drawing.Size(82, 25);
            this.ActorSearchButton.TabIndex = 3;
            this.ActorSearchButton.Text = "Search";
            this.ActorSearchButton.UseVisualStyleBackColor = true;
            // 
            // ActorSearchTextbox
            // 
            this.ActorSearchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActorSearchTextbox.Location = new System.Drawing.Point(20, 40);
            this.ActorSearchTextbox.Name = "ActorSearchTextbox";
            this.ActorSearchTextbox.Size = new System.Drawing.Size(558, 26);
            this.ActorSearchTextbox.TabIndex = 2;
            // 
            // ActorSearchLabel
            // 
            this.ActorSearchLabel.AutoSize = true;
            this.ActorSearchLabel.Font = new System.Drawing.Font("Roboto", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActorSearchLabel.Location = new System.Drawing.Point(20, 19);
            this.ActorSearchLabel.Name = "ActorSearchLabel";
            this.ActorSearchLabel.Size = new System.Drawing.Size(95, 18);
            this.ActorSearchLabel.TabIndex = 1;
            this.ActorSearchLabel.Text = "Search Actor";
            // 
            // tabActorDetail
            // 
            this.tabActorDetail.Controls.Add(this.ActorCancelButton);
            this.tabActorDetail.Controls.Add(this.ActorSaveButton);
            this.tabActorDetail.Controls.Add(this.ActorLanguageTextbox);
            this.tabActorDetail.Controls.Add(this.ActorLanguageLabel);
            this.tabActorDetail.Controls.Add(this.ActorCountryTextbox);
            this.tabActorDetail.Controls.Add(this.ActorCountryLabel);
            this.tabActorDetail.Controls.Add(this.ActorNameTextbox);
            this.tabActorDetail.Controls.Add(this.ActorNameLabel);
            this.tabActorDetail.Controls.Add(this.ActorIdTextbox);
            this.tabActorDetail.Controls.Add(this.ActorIdLabel);
            this.tabActorDetail.Location = new System.Drawing.Point(4, 27);
            this.tabActorDetail.Name = "tabActorDetail";
            this.tabActorDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabActorDetail.Size = new System.Drawing.Size(677, 324);
            this.tabActorDetail.TabIndex = 1;
            this.tabActorDetail.Text = "Actor Detail";
            this.tabActorDetail.UseVisualStyleBackColor = true;
            // 
            // ActorCancelButton
            // 
            this.ActorCancelButton.Location = new System.Drawing.Point(192, 225);
            this.ActorCancelButton.Name = "ActorCancelButton";
            this.ActorCancelButton.Size = new System.Drawing.Size(160, 35);
            this.ActorCancelButton.TabIndex = 9;
            this.ActorCancelButton.Text = "Cancel";
            this.ActorCancelButton.UseVisualStyleBackColor = true;
            // 
            // ActorSaveButton
            // 
            this.ActorSaveButton.Location = new System.Drawing.Point(20, 225);
            this.ActorSaveButton.Name = "ActorSaveButton";
            this.ActorSaveButton.Size = new System.Drawing.Size(160, 35);
            this.ActorSaveButton.TabIndex = 8;
            this.ActorSaveButton.Text = "Save";
            this.ActorSaveButton.UseVisualStyleBackColor = true;
            // 
            // ActorLanguageTextbox
            // 
            this.ActorLanguageTextbox.Location = new System.Drawing.Point(20, 174);
            this.ActorLanguageTextbox.Name = "ActorLanguageTextbox";
            this.ActorLanguageTextbox.Size = new System.Drawing.Size(332, 26);
            this.ActorLanguageTextbox.TabIndex = 7;
            // 
            // ActorLanguageLabel
            // 
            this.ActorLanguageLabel.AutoSize = true;
            this.ActorLanguageLabel.Location = new System.Drawing.Point(20, 153);
            this.ActorLanguageLabel.Name = "ActorLanguageLabel";
            this.ActorLanguageLabel.Size = new System.Drawing.Size(113, 18);
            this.ActorLanguageLabel.TabIndex = 6;
            this.ActorLanguageLabel.Text = "Actor Language";
            // 
            // ActorCountryTextbox
            // 
            this.ActorCountryTextbox.Location = new System.Drawing.Point(192, 104);
            this.ActorCountryTextbox.Name = "ActorCountryTextbox";
            this.ActorCountryTextbox.Size = new System.Drawing.Size(160, 26);
            this.ActorCountryTextbox.TabIndex = 5;
            // 
            // ActorCountryLabel
            // 
            this.ActorCountryLabel.AutoSize = true;
            this.ActorCountryLabel.Location = new System.Drawing.Point(192, 83);
            this.ActorCountryLabel.Name = "ActorCountryLabel";
            this.ActorCountryLabel.Size = new System.Drawing.Size(101, 18);
            this.ActorCountryLabel.TabIndex = 4;
            this.ActorCountryLabel.Text = "Actor Country";
            // 
            // ActorNameTextbox
            // 
            this.ActorNameTextbox.Location = new System.Drawing.Point(20, 104);
            this.ActorNameTextbox.Name = "ActorNameTextbox";
            this.ActorNameTextbox.Size = new System.Drawing.Size(160, 26);
            this.ActorNameTextbox.TabIndex = 3;
            // 
            // ActorNameLabel
            // 
            this.ActorNameLabel.AutoSize = true;
            this.ActorNameLabel.Location = new System.Drawing.Point(20, 83);
            this.ActorNameLabel.Name = "ActorNameLabel";
            this.ActorNameLabel.Size = new System.Drawing.Size(89, 18);
            this.ActorNameLabel.TabIndex = 2;
            this.ActorNameLabel.Text = "Actor Name";
            // 
            // ActorIdTextbox
            // 
            this.ActorIdTextbox.Enabled = false;
            this.ActorIdTextbox.Location = new System.Drawing.Point(20, 40);
            this.ActorIdTextbox.Name = "ActorIdTextbox";
            this.ActorIdTextbox.Size = new System.Drawing.Size(160, 26);
            this.ActorIdTextbox.TabIndex = 1;
            this.ActorIdTextbox.Text = "0";
            // 
            // ActorIdLabel
            // 
            this.ActorIdLabel.AutoSize = true;
            this.ActorIdLabel.Location = new System.Drawing.Point(20, 19);
            this.ActorIdLabel.Name = "ActorIdLabel";
            this.ActorIdLabel.Size = new System.Drawing.Size(63, 18);
            this.ActorIdLabel.TabIndex = 0;
            this.ActorIdLabel.Text = "Actor ID";
            // 
            // ActorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 400);
            this.Controls.Add(this.tabActors);
            this.Controls.Add(this.panelActors);
            this.Name = "ActorView";
            this.Text = "ActorView";
            this.panelActors.ResumeLayout(false);
            this.panelActors.PerformLayout();
            this.tabActors.ResumeLayout(false);
            this.tabActorList.ResumeLayout(false);
            this.tabActorList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActorGridView)).EndInit();
            this.tabActorDetail.ResumeLayout(false);
            this.tabActorDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label ActorTitleLabel;
        private Panel panelActors;
        private TabControl tabActors;
        private TabPage tabActorList;
        private TabPage tabActorDetail;
        private DataGridView ActorGridView;
        private Button ActorDeleteButton;
        private Button ActorEditButton;
        private Button ActorAddNewButton;
        private Button ActorSearchButton;
        private TextBox ActorSearchTextbox;
        private Label ActorSearchLabel;
        private Label ActorIdLabel;
        private TextBox ActorIdTextbox;
        private TextBox ActorNameTextbox;
        private Label ActorNameLabel;
        private TextBox ActorLanguageTextbox;
        private Label ActorLanguageLabel;
        private TextBox ActorCountryTextbox;
        private Label ActorCountryLabel;
        private Button ActorCancelButton;
        private Button ActorSaveButton;
        private Button actorCloseButton;
    }
}