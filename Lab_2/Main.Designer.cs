
namespace Lab_2
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.postsView = new System.Windows.Forms.ListView();
            this.chTitle = new System.Windows.Forms.ColumnHeader();
            this.chAuthor = new System.Windows.Forms.ColumnHeader();
            this.chDescription = new System.Windows.Forms.ColumnHeader();
            this.authorsList = new System.Windows.Forms.ListView();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chSurname = new System.Windows.Forms.ColumnHeader();
            this.chNumber = new System.Windows.Forms.ColumnHeader();
            this.authors = new System.Windows.Forms.Label();
            this.posts = new System.Windows.Forms.Label();
            this.buttonAddPost = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.listViewTopics = new System.Windows.Forms.ListView();
            this.chTopics = new System.Windows.Forms.ColumnHeader();
            this.chTopicPosts = new System.Windows.Forms.ColumnHeader();
            this.labelTopics = new System.Windows.Forms.Label();
            this.chTopic = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // postsView
            // 
            this.postsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitle,
            this.chAuthor,
            this.chTopic,
            this.chDescription});
            this.postsView.FullRowSelect = true;
            this.postsView.HideSelection = false;
            this.postsView.Location = new System.Drawing.Point(276, 34);
            this.postsView.MultiSelect = false;
            this.postsView.Name = "postsView";
            this.postsView.Size = new System.Drawing.Size(616, 554);
            this.postsView.TabIndex = 0;
            this.postsView.UseCompatibleStateImageBehavior = false;
            this.postsView.View = System.Windows.Forms.View.Details;
            this.postsView.SelectedIndexChanged += new System.EventHandler(this.postsView_SelectedIndexChanged);
            // 
            // chTitle
            // 
            this.chTitle.Text = "Title";
            this.chTitle.Width = 150;
            // 
            // chAuthor
            // 
            this.chAuthor.Text = "Author";
            this.chAuthor.Width = 200;
            // 
            // chDescription
            // 
            this.chDescription.Text = "Short Description";
            this.chDescription.Width = 180;
            // 
            // authorsList
            // 
            this.authorsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chSurname,
            this.chNumber});
            this.authorsList.HideSelection = false;
            this.authorsList.Location = new System.Drawing.Point(12, 34);
            this.authorsList.MultiSelect = false;
            this.authorsList.Name = "authorsList";
            this.authorsList.Size = new System.Drawing.Size(258, 261);
            this.authorsList.TabIndex = 1;
            this.authorsList.UseCompatibleStateImageBehavior = false;
            this.authorsList.View = System.Windows.Forms.View.Details;
            this.authorsList.SelectedIndexChanged += new System.EventHandler(this.authorsList_SelectedIndexChanged);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 100;
            // 
            // chSurname
            // 
            this.chSurname.Text = "Surname";
            this.chSurname.Width = 100;
            // 
            // chNumber
            // 
            this.chNumber.Text = "Posts";
            this.chNumber.Width = 50;
            // 
            // authors
            // 
            this.authors.AutoSize = true;
            this.authors.Location = new System.Drawing.Point(13, 9);
            this.authors.Name = "authors";
            this.authors.Size = new System.Drawing.Size(60, 20);
            this.authors.TabIndex = 2;
            this.authors.Text = "Authors";
            // 
            // posts
            // 
            this.posts.AutoSize = true;
            this.posts.Location = new System.Drawing.Point(276, 9);
            this.posts.Name = "posts";
            this.posts.Size = new System.Drawing.Size(42, 20);
            this.posts.TabIndex = 3;
            this.posts.Text = "Posts";
            // 
            // buttonAddPost
            // 
            this.buttonAddPost.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddPost.Location = new System.Drawing.Point(801, 8);
            this.buttonAddPost.Name = "buttonAddPost";
            this.buttonAddPost.Size = new System.Drawing.Size(91, 20);
            this.buttonAddPost.TabIndex = 4;
            this.buttonAddPost.Text = "Add post";
            this.buttonAddPost.UseVisualStyleBackColor = true;
            this.buttonAddPost.Click += new System.EventHandler(this.buttonAddPost_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRefresh.Location = new System.Drawing.Point(704, 8);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(91, 20);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // listViewTopics
            // 
            this.listViewTopics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTopics,
            this.chTopicPosts});
            this.listViewTopics.HideSelection = false;
            this.listViewTopics.Location = new System.Drawing.Point(12, 342);
            this.listViewTopics.MultiSelect = false;
            this.listViewTopics.Name = "listViewTopics";
            this.listViewTopics.Size = new System.Drawing.Size(258, 246);
            this.listViewTopics.TabIndex = 6;
            this.listViewTopics.UseCompatibleStateImageBehavior = false;
            this.listViewTopics.View = System.Windows.Forms.View.Details;
            this.listViewTopics.SelectedIndexChanged += new System.EventHandler(this.listViewTopics_SelectedIndexChanged);
            // 
            // chTopics
            // 
            this.chTopics.Text = "Topic";
            this.chTopics.Width = 190;
            // 
            // chTopicPosts
            // 
            this.chTopicPosts.Text = "Posts";
            // 
            // labelTopics
            // 
            this.labelTopics.AutoSize = true;
            this.labelTopics.Location = new System.Drawing.Point(12, 319);
            this.labelTopics.Name = "labelTopics";
            this.labelTopics.Size = new System.Drawing.Size(51, 20);
            this.labelTopics.TabIndex = 7;
            this.labelTopics.Text = "Topics";
            // 
            // chTopic
            // 
            this.chTopic.Text = "Topic";
            this.chTopic.Width = 80;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 600);
            this.Controls.Add(this.labelTopics);
            this.Controls.Add(this.listViewTopics);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonAddPost);
            this.Controls.Add(this.posts);
            this.Controls.Add(this.authors);
            this.Controls.Add(this.authorsList);
            this.Controls.Add(this.postsView);
            this.Name = "Main";
            this.Text = "Blog";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView postsView;
        private System.Windows.Forms.ListView authorsList;
        private System.Windows.Forms.Label authors;
        private System.Windows.Forms.Label posts;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chAuthor;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chSurname;
        private System.Windows.Forms.ColumnHeader chNumber;
        private System.Windows.Forms.Button buttonAddPost;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ListView listViewTopics;
        private System.Windows.Forms.ColumnHeader chTopics;
        private System.Windows.Forms.ColumnHeader chTopicPosts;
        private System.Windows.Forms.Label labelTopics;
        private System.Windows.Forms.ColumnHeader chTopic;
    }
}

