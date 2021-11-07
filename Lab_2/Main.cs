using Lab_2.DAL.Entities;
using Lab_2.DAL.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Main : Form
    {
        private readonly IPostRepository _postRepositroy;
        private readonly IAuthorRepository _authorRepository;
        private readonly ITopicRepository _topicRepository;

        public PostEditForm postEditForm = null;
        public PostAddForm postAddForm = null;

        public Main()
        {
            InitializeComponent();
            _postRepositroy = new PostRepository();
            _authorRepository = new AuthorRepository();
            _topicRepository = new TopicRepository();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UpdateLists();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            UpdateLists();
        }

        private void postsView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (postsView.SelectedItems.Count > 0)
            {
                if (postEditForm is null)
                {
                    var selectedItem = (Post)postsView.SelectedItems[0].Tag;
                    postEditForm = new PostEditForm(
                        _postRepositroy,
                        _authorRepository,
                        _topicRepository,
                        selectedItem.Id);
                    postEditForm.FormClosed += new FormClosedEventHandler(PostEditForm_FormClosed);
                    postEditForm.Show();
                }
            }
        }

        private void buttonAddPost_Click(object sender, EventArgs e)
        {
            if (postAddForm is null)
            {
                postAddForm = new PostAddForm(_postRepositroy, _authorRepository, _topicRepository);
                postAddForm.FormClosed += new FormClosedEventHandler(PostAddForm_FormClosed);
                postAddForm.Show();
            }
            else
            {
                postAddForm.BringToFront();
            }
        }

        private void PostEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            postEditForm = null;
            UpdateLists();
        }

        private void PostAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            postAddForm = null;
            UpdateLists();
        }

        private void authorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (authorsList.SelectedItems.Count > 0)
            {
                var selectedItem = (Author)authorsList.SelectedItems[0].Tag;
                var posts = _postRepositroy.GetPostListByAuthorId(selectedItem.Id);

                postsView.Items.Clear();
                foreach (var post in posts)
                {
                    postsView.Items.Add(GeneratePostListItem(post));
                }
            }
        }

        private void listViewTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTopics.SelectedItems.Count > 0)
            {
                var selectedItem = (Topic)listViewTopics.SelectedItems[0].Tag;
                var posts = _postRepositroy.GetPostListByTopicId(selectedItem.Id);

                postsView.Items.Clear();
                foreach (var post in posts)
                {
                    postsView.Items.Add(GeneratePostListItem(post));
                }
            }
        }

        private void UpdateLists()
        {
            var posts = _postRepositroy.GetAll();
            var authors = _authorRepository.GetAll();
            var topics = _topicRepository.GetAll();

            postsView.Items.Clear();
            foreach (var post in posts)
            {
                postsView.Items.Add(GeneratePostListItem(post));
            }

            authorsList.Items.Clear();
            foreach (var author in authors)
            {
                var numberOfPosts = _postRepositroy.GetPostListByAuthorId(author.Id).Count();
                var author_row = new string[] {
                    author.Name,
                    author.Surname,
                    numberOfPosts.ToString(),
                };

                var listViewItem = new ListViewItem(author_row);
                listViewItem.Tag = author;
                authorsList.Items.Add(listViewItem);
            }

            listViewTopics.Items.Clear();
            foreach (var topic in topics)
            {
                var numberOfPosts = _postRepositroy.GetPostListByTopicId(topic.Id).Count();
                var topic_row = new string[] {
                    topic.Name,
                    numberOfPosts.ToString(),
                };

                var listViewItem = new ListViewItem(topic_row);
                listViewItem.Tag = topic;
                listViewTopics.Items.Add(listViewItem);
            }
        }

        private ListViewItem GeneratePostListItem(Post post)
        {
            var post_row = new string[] {
                    post.Title,
                    post.Author.Name + " " + post.Author.Surname,
                    post.Topic.Name,
                    post.Body.Length > chDescription.Width ? post.Body.Substring(0, chDescription.Width - 1) : post.Body
                };

            var listViewItem = new ListViewItem(post_row);
            listViewItem.Tag = post;

            return listViewItem;
        }
    }
}
