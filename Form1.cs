using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
namespace CyberlinkGUI
{
    public partial class Form1 : Form
    {
        string lastTopic = "";
        string favouriteTopic = "";
        string userInterest = "";

        Random random = new Random();
        int currentQuestion = 0;
        int score = 0;

        List<QuizQuestion> quizQuestions = new List<QuizQuestion>()
{
    new QuizQuestion
    {
        Question = "What is phishing?",
        Options = new string[]
        {
            "A fake email trying to steal information",
            "A firewall",
            "An antivirus",
            "A password manager"
        },
        CorrectAnswer = 0
    },

    new QuizQuestion
    {
        Question = "Which password is the strongest?",
        Options = new string[]
        {
            "password123",
            "12345678",
            "P@ssw0rd!2026",
            "abcdef"
        },
        CorrectAnswer = 2
    },

    new QuizQuestion
    {
        Question = "What does 2FA stand for?",
        Options = new string[]
        {
            "Two-Factor Authentication",
            "Two File Access",
            "Two Firewall Accounts",
            "Two Folder Authentication"
        },
        CorrectAnswer = 0
    },

    new QuizQuestion
    {
        Question = "Which of these is a good cybersecurity habit?",
        Options = new string[]
        {
            "Sharing passwords",
            "Using strong unique passwords",
            "Clicking unknown links",
            "Ignoring software updates"
        },
        CorrectAnswer = 1
    },

    new QuizQuestion
    {
        Question = "What should you do before clicking a link in an email?",
        Options = new string[]
        {
            "Click immediately",
            "Verify who sent it",
            "Forward it to everyone",
            "Ignore the sender"
        },
        CorrectAnswer = 1
    },

    new QuizQuestion
    {
        Question = "What is malware?",
        Options = new string[]
        {
            "A type of hardware",
            "Software designed to damage or steal data",
            "A secure password",
            "A web browser"
        },
        CorrectAnswer = 1
    },

    new QuizQuestion
    {
        Question = "Why should you keep software updated?",
        Options = new string[]
        {
            "To use more internet",
            "To fix security vulnerabilities",
            "To make your screen brighter",
            "To delete your files"
        },
        CorrectAnswer = 1
    },

    new QuizQuestion
    {
        Question = "What is the safest way to protect an online account?",
        Options = new string[]
        {
            "Use the same password everywhere",
            "Enable Two-Factor Authentication",
            "Share your password with friends",
            "Write your password on paper"
        },
        CorrectAnswer = 1
    },

    new QuizQuestion
    {
        Question = "What should you do if you receive a suspicious email?",
        Options = new string[]
        {
            "Open every attachment",
            "Reply with your password",
            "Delete or report the email",
            "Forward it to everyone"
        },
        CorrectAnswer = 2
    },

    new QuizQuestion
    {
        Question = "Why is online privacy important?",
        Options = new string[]
        {
            "To protect your personal information",
            "To make your internet slower",
            "To get more advertisements",
            "To reduce computer storage"
        },
        CorrectAnswer = 0
    }
};


        List<string> passwordTips = new List<string>()
{
    "Use a strong password with letters, numbers and symbols.",
    "Avoid using personal information in your password.",
    "Use a different password for each account."
};

        List<string> phishingTips = new List<string>()
{
    "Always verify who sent an email before clicking links.",
    "Be cautious of emails creating a sense of urgency.",
    "Never enter credentials from a suspicious email link."
};

        List<string> privacyTips = new List<string>()
{
    "Review your privacy settings regularly.",
    "Share as little personal information online as possible.",
    "Be careful what you post on social media."
};

        List<string> scamTips = new List<string>()
{
    "Never send money to someone you have not verified.",
    "Be suspicious of offers that seem too good to be true.",
    "Do not share banking information with unknown people."
};
        List<string> positiveResponses = new List<string>()
{
    "I'm glad you're feeling positive about cybersecurity.",
    "That's great to hear. Staying informed is the best defence.",
    "Excellent. Let's continue building your cybersecurity knowledge."
};

        List<string> negativeResponses = new List<string>()
{
    "I understand your concern. Cybersecurity can seem overwhelming at first.",
    "It's completely understandable to feel that way. Let me share some tips to help you stay safe online. Learning basic safety practices goes a long way.",
    "Many people feel that way. Let's work through it together."
};
        List<string> curiousResponses = new List<string>()
{
    "Curiosity is a great way to learn about cybersecurity.",
    "That's a good question. Learning more helps keep you safe online.",
    "Exploring cybersecurity topics is an excellent habit."
};
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtMessage.Text;
            string input = userInput.ToLower();

            rtbChat.AppendText("You: " + userInput + Environment.NewLine);
            if (string.IsNullOrWhiteSpace(userInput))
            {
                rtbChat.AppendText(
                    "Bot: Please enter a message."
                    + Environment.NewLine);

                return;
            }
            if (input.Contains("add task"))
            {
                rtbChat.AppendText("Bot: I can help you with that. Please use the Task Assistant section to add your task." + Environment.NewLine);
                return;
            }

            if (input.Contains("remind me"))
            {
                rtbChat.AppendText("Bot: Please use the reminder date in the Task Assistant to set your reminder." + Environment.NewLine);
                return;
            }

            if (input.Contains("show tasks"))
            {
                LoadTasks();
                rtbChat.AppendText("Bot: Your tasks have been loaded." + Environment.NewLine);
                return;
            }
            if (userInput.ToLower().Contains("happy") ||
                userInput.ToLower().Contains("good") ||
                userInput.ToLower().Contains("excited"))
            {
                int index = random.Next(positiveResponses.Count);

                rtbChat.AppendText(
                    "Bot: " + positiveResponses[index] + Environment.NewLine);
            }
            else if (userInput.ToLower().Contains("worried") ||
                     userInput.ToLower().Contains("sad") ||
                     userInput.ToLower().Contains("confused"))
            {
                int index = random.Next(negativeResponses.Count);

                rtbChat.AppendText(
                    "Bot: " + negativeResponses[index] + Environment.NewLine);
            }
            else if (userInput.ToLower().Contains("my favourite topic is"))
            {
                favouriteTopic = userInput
                    .Replace("my favourite topic is", "")
                    .Trim();

                rtbChat.AppendText(
                    "Bot: I'll remember that your favourite topic is " +
                    favouriteTopic + "." + Environment.NewLine);
            }
            else if (userInput.ToLower().Contains("what do you remember"))
            {
                if (!string.IsNullOrEmpty(favouriteTopic))
                {
                    rtbChat.AppendText(
                        "Bot: Your favourite topic is " +
                        favouriteTopic + "." + Environment.NewLine);
                }
                else
                {
                    rtbChat.AppendText(
                        "Bot: I don't remember a favourite topic yet."
                        + Environment.NewLine);
                }
            }
            else if (userInput.Trim().Equals("hello", StringComparison.OrdinalIgnoreCase) ||
                     userInput.Trim().Equals("hi", StringComparison.OrdinalIgnoreCase))
            {
                rtbChat.AppendText(
                    "Bot: Hello and welcome to CyberLink." +
                    Environment.NewLine);
            }
            else if (userInput.ToLower().Contains("how are you"))
            {
                rtbChat.AppendText(
                    "Bot: I'm functioning correctly and ready to help with cybersecurity questions."
                    + Environment.NewLine);
            }
            else if (userInput.ToLower().Contains("what is your purpose"))
            {
                rtbChat.AppendText(
                    "Bot: My purpose is to educate users about cybersecurity and online safety."
                    + Environment.NewLine);
            }
            else if (userInput.ToLower().Contains("i'm interested in"))
            {
                userInterest = userInput
                    .Replace("I'm interested in", "", StringComparison.OrdinalIgnoreCase)
                    .Trim();

                rtbChat.AppendText(
                    "Bot: Great! I'll remember that you're interested in " +
                    userInterest +
                    ". It's an important cybersecurity topic." +
                    Environment.NewLine);
            }
            else if (userInput.ToLower().Contains("what do you remember"))
            {
                if (!string.IsNullOrEmpty(favouriteTopic))
                {
                    rtbChat.AppendText(
                        "Bot: Your favourite topic is " +
                        favouriteTopic +
                        Environment.NewLine);
                }
                else if (!string.IsNullOrEmpty(userInterest))
                {
                    rtbChat.AppendText(
                        "Bot: I remember that you're interested in " +
                        userInterest +
                        Environment.NewLine);
                }
                else
                {
                    rtbChat.AppendText(
                        "Bot: I haven't learned anything about you yet."
                        + Environment.NewLine);
                }
            }
            else if (userInput.ToLower().Contains("curious"))
            {
                int index = random.Next(curiousResponses.Count);

                rtbChat.AppendText(
                    "Bot: " + curiousResponses[index] + Environment.NewLine);
            }
            if (userInput.ToLower().Contains("password"))
            {
                lastTopic = "password";

                int index = random.Next(passwordTips.Count);

                rtbChat.AppendText(
                    "Bot: " + passwordTips[index] + Environment.NewLine);
            }
            else if (userInput.ToLower().Contains("phishing"))
            {
                lastTopic = "phishing";

                int index = random.Next(phishingTips.Count);

                rtbChat.AppendText(
                    "Bot: " + phishingTips[index] + Environment.NewLine);
            }
            else if (userInput.ToLower().Contains("privacy"))
            {
                lastTopic = "privacy";

                int index = random.Next(privacyTips.Count);

                rtbChat.AppendText(
                    "Bot: " + privacyTips[index] + Environment.NewLine);

                if (userInterest == "privacy")
                {
                    rtbChat.AppendText(
                        "Bot: Since you're interested in privacy, review your account security settings regularly."
                        + Environment.NewLine);
                }
            }
            else if (userInput.ToLower().Contains("scam"))
            {
                lastTopic = "scam";

                int index = random.Next(scamTips.Count);

                rtbChat.AppendText(
                    "Bot: " + scamTips[index] + Environment.NewLine);
            }
            else if (userInput.ToLower().Contains("tell me more"))
            {
                if (lastTopic == "password")
                {
                    rtbChat.AppendText(
                        "Bot: Consider using a password manager to store passwords securely."
                        + Environment.NewLine);
                }
                else if (lastTopic == "phishing")
                {
                    rtbChat.AppendText(
                        "Bot: Phishing attacks often imitate trusted organisations."
                        + Environment.NewLine);
                }
                else if (lastTopic == "privacy")
                {
                    rtbChat.AppendText(
                        "Bot: Check app permissions before installing applications."
                        + Environment.NewLine);
                }
                else if (lastTopic == "scam")
                {
                    rtbChat.AppendText(
                        "Bot: Scammers often pressure victims to act quickly."
                        + Environment.NewLine);
                }
                else
                {
                    rtbChat.AppendText(
                        "Bot: Please ask about a cybersecurity topic first."
                        + Environment.NewLine);
                }
            }
            else
            {
                rtbChat.AppendText(
                    "Bot: I didn't understand that. Try asking about passwords, phishing, scams or privacy."
                    + Environment.NewLine);
            }

            txtMessage.Clear();
        }
        private void LoadTasks()
        {
            try
            {
                Database db = new Database();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM Tasks";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvTasks.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadQuestion()
        {
            lblQuestion.Text = quizQuestions[currentQuestion].Question;

            rbOption1.Text = quizQuestions[currentQuestion].Options[0];
            rbOption2.Text = quizQuestions[currentQuestion].Options[1];
            rbOption3.Text = quizQuestions[currentQuestion].Options[2];
            rbOption4.Text = quizQuestions[currentQuestion].Options[3];

            rbOption1.Checked = false;
            rbOption2.Checked = false;
            rbOption3.Checked = false;
            rbOption4.Checked = false;
        }
        private void LogActivity(string activity)
        {
            try
            {
                Database db = new Database();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO ActivityLog (Activity)
                             VALUES (@activity)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@activity", activity);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            rtbChat.AppendText("Welcome to CyberLink!" + Environment.NewLine);

            LoadTasks();

            LoadQuestion();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void assistantReminder_Click(object sender, EventArgs e)
        {

        }

        private void addTask_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO Tasks
                    (Title, Description, ReminderDate, Status)
                    VALUES
                    (@title, @description, @reminder, @status)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@reminder", dtpReminder.Value);
                    cmd.Parameters.AddWithValue("@status", "Pending");

                    cmd.ExecuteNonQuery();
                    LogActivity("Task added: " + txtTitle.Text);

                    LoadTasks();

                    MessageBox.Show("Task added successfully!");

                    txtTitle.Clear();
                    txtDescription.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to delete.");
                return;
            }

            int taskID = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["TaskID"].Value);

            try
            {
                Database db = new Database();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM Tasks WHERE TaskID=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", taskID);

                    cmd.ExecuteNonQuery();
                }

                LoadTasks();

                MessageBox.Show("Task deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void completeTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task first.");
                return;
            }

            int taskID = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["TaskID"].Value);

            try
            {
                Database db = new Database();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = "UPDATE Tasks SET Status='Completed' WHERE TaskID=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", taskID);

                    cmd.ExecuteNonQuery();
                }

                LoadTasks();

                MessageBox.Show("Task marked as completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpReminder_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            int selectedAnswer = -1;

            if (rbOption1.Checked)
                selectedAnswer = 0;
            else if (rbOption2.Checked)
                selectedAnswer = 1;
            else if (rbOption3.Checked)
                selectedAnswer = 2;
            else if (rbOption4.Checked)
                selectedAnswer = 3;

            if (selectedAnswer == -1)
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            if (selectedAnswer == quizQuestions[currentQuestion].CorrectAnswer)
            {
                score++;
            }

            currentQuestion++;

            if (currentQuestion < quizQuestions.Count)
            {
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("Quiz Complete!\n\nYour score: " + score + " / " + quizQuestions.Count);

                lblQuestion.Text = "Quiz Complete!";
                rbOption1.Visible = false;
                rbOption2.Visible = false;
                rbOption3.Visible = false;
                rbOption4.Visible = false;
                btnNextQuestion.Enabled = false;
            }
        }
    }
}
