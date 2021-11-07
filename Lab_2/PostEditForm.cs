using Lab_2.DAL.Entities;
using Lab_2.DAL.Repository;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class PostEditForm : Form
    {
        private readonly IPostRepository _postRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly ITopicRepository _topicRepository;

        private readonly long _postId;
        private Post _post;

        public PostEditForm(IPostRepository postRepository,
            IAuthorRepository authorRepository,
            ITopicRepository topicRepository,
            long postId)
        {
            _postRepository = postRepository;
            _authorRepository = authorRepository;
            _topicRepository = topicRepository;

            _postId = postId;
            InitializeComponent();
        }


        private void PostEditForm_Load(object sender, EventArgs e)
        {
            _post = _postRepository.Get(_postId);
            textBoxTitle.Text = _post.Title;
            richTextBoxDescription.Text = _post.Body;

            var authors = _authorRepository.GetAll().Select(x => x.Name + " " + x.Surname).OrderBy(x => x).ToArray();
            comboBoxAuthor.Items.AddRange(authors);
            comboBoxAuthor.Text = _post.Author.Name + " " + _post.Author.Surname;

            var topics = _topicRepository.GetAll().Select(x => x.Name).OrderBy(x => x).ToArray();
            comboBoxTopic.Items.AddRange(topics);
            comboBoxTopic.Text = _post.Topic.Name;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            _postRepository.Delete(_postId);
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var authorId = _authorRepository.GetAuthorIdByName(comboBoxAuthor.Text);
                var topicId = _topicRepository.GetTopicIdByName(comboBoxTopic.Text);

                _post.Id = _postId;
                _post.AuthorId = authorId;
                _post.TopicId = topicId;
                _post.Title = textBoxTitle.Text;
                _post.Body = richTextBoxDescription.Text;

                _postRepository.Update(_postId, _post);

                Close();
            }
        }

        public bool ValidateForm()
        {
            var correct = true;

            if (textBoxTitle.Text.Length == 0)
            {
                correct = false;
                textBoxTitle.BackColor = Color.Red;
            }
            else
            {
                textBoxTitle.BackColor = Color.White;
            }

            if (richTextBoxDescription.Text.Length == 0)
            {
                correct = false;
                richTextBoxDescription.BackColor = Color.Red;
            }
            else
            {
                richTextBoxDescription.BackColor = Color.White;
            }

            return correct;
        }
    }
}
