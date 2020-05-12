namespace ISADFrontEnd
{
    partial class Form1
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
            this.cbxQueryChoice = new System.Windows.Forms.ComboBox();
            this.dgvProfile = new System.Windows.Forms.DataGridView();
            this.dgvFriendLink = new System.Windows.Forms.DataGridView();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.dgvRelationships = new System.Windows.Forms.DataGridView();
            this.dgvWorkPlace = new System.Windows.Forms.DataGridView();
            this.dgvUniversities = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFriendLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelationships)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniversities)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxQueryChoice
            // 
            this.cbxQueryChoice.FormattingEnabled = true;
            this.cbxQueryChoice.Items.AddRange(new object[] {
            "Profile",
            "FriendLink",
            "Messages",
            "Universities",
            "Workplaces",
            "Relationships"});
            this.cbxQueryChoice.Location = new System.Drawing.Point(293, 392);
            this.cbxQueryChoice.Name = "cbxQueryChoice";
            this.cbxQueryChoice.Size = new System.Drawing.Size(174, 21);
            this.cbxQueryChoice.TabIndex = 0;
            this.cbxQueryChoice.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvProfile
            // 
            this.dgvProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfile.Location = new System.Drawing.Point(12, 12);
            this.dgvProfile.Name = "dgvProfile";
            this.dgvProfile.Size = new System.Drawing.Size(240, 150);
            this.dgvProfile.TabIndex = 1;
            // 
            // dgvFriendLink
            // 
            this.dgvFriendLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFriendLink.Location = new System.Drawing.Point(258, 12);
            this.dgvFriendLink.Name = "dgvFriendLink";
            this.dgvFriendLink.Size = new System.Drawing.Size(240, 150);
            this.dgvFriendLink.TabIndex = 2;
            // 
            // dgvMessages
            // 
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Location = new System.Drawing.Point(504, 12);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.Size = new System.Drawing.Size(240, 150);
            this.dgvMessages.TabIndex = 3;
            // 
            // dgvRelationships
            // 
            this.dgvRelationships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelationships.Location = new System.Drawing.Point(504, 168);
            this.dgvRelationships.Name = "dgvRelationships";
            this.dgvRelationships.Size = new System.Drawing.Size(240, 150);
            this.dgvRelationships.TabIndex = 4;
            // 
            // dgvWorkPlace
            // 
            this.dgvWorkPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkPlace.Location = new System.Drawing.Point(258, 168);
            this.dgvWorkPlace.Name = "dgvWorkPlace";
            this.dgvWorkPlace.Size = new System.Drawing.Size(240, 150);
            this.dgvWorkPlace.TabIndex = 5;
            // 
            // dgvUniversities
            // 
            this.dgvUniversities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUniversities.Location = new System.Drawing.Point(12, 168);
            this.dgvUniversities.Name = "dgvUniversities";
            this.dgvUniversities.Size = new System.Drawing.Size(240, 150);
            this.dgvUniversities.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.dgvUniversities);
            this.Controls.Add(this.dgvWorkPlace);
            this.Controls.Add(this.dgvRelationships);
            this.Controls.Add(this.dgvMessages);
            this.Controls.Add(this.dgvFriendLink);
            this.Controls.Add(this.dgvProfile);
            this.Controls.Add(this.cbxQueryChoice);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFriendLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelationships)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniversities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxQueryChoice;
        private System.Windows.Forms.DataGridView dgvProfile;
        private System.Windows.Forms.DataGridView dgvFriendLink;
        private System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.DataGridView dgvRelationships;
        private System.Windows.Forms.DataGridView dgvWorkPlace;
        private System.Windows.Forms.DataGridView dgvUniversities;
    }
}

