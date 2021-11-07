using Lab_2.EF.Entities;
using Lab_2.EF.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class PostAddForm : Form
    {
        private readonly IPostRepository _postRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly ITopicRepository _topicRepository;

        public PostAddForm(IPostRepository postRepository, IAuthorRepository authorRepository, ITopicRepository topicRepository)
        {
            _postRepository = postRepository;
            _authorRepository = authorRepository;
            _topicRepository = topicRepository;
            InitializeComponent();
        }

        private void PostAddForm_Load(object sender, EventArgs e)
        {
            InitializeAuthorList();
            InitializeTopicList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var authorId = _authorRepository.GetAuthorIdByName(comboBoxAuthor.Text);
                var topicId = _topicRepository.GetTopicIdByName(comboBoxTopic.Text);

                var post = new Post
                {
                    Title = textBoxTitle.Text,
                    Body = richTextBoxDescription.Text,
                    AuthorId = authorId,
                    TopicId = topicId,
                };

                _postRepository.Create(post);
                Close();
            }
        }

        private void InitializeAuthorList()
        {
            var authors = _authorRepository.GetAll().Select(x => x.Name + " " + x.Surname).OrderBy(x => x).ToArray();
            comboBoxAuthor.Items.AddRange(authors);
        }

        private void InitializeTopicList()
        {
            var authors = _topicRepository.GetAll().Select(x => x.Name).OrderBy(x => x).ToArray();
            comboBoxTopic.Items.AddRange(authors);
        }

        private bool ValidateForm()
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

            if (comboBoxAuthor.Text.Length == 0)
            {
                correct = false;
                comboBoxAuthor.BackColor = Color.Red;
            }
            else
            {
                comboBoxAuthor.BackColor = Color.White;
            }

            if (comboBoxTopic.Text.Length == 0)
            {
                correct = false;
                comboBoxTopic.BackColor = Color.Red;
            }
            else
            {
                comboBoxTopic.BackColor = Color.White;
            }

            return correct;
        }
    }
}
