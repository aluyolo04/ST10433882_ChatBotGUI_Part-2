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

            rtbChat.AppendText("You: " + userInput + Environment.NewLine);
            if (string.IsNullOrWhiteSpace(userInput))
            {
                rtbChat.AppendText(
                    "Bot: Please enter a message."
                    + Environment.NewLine);

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

        private void Form1_Load(object sender, EventArgs e)
        {
            rtbChat.AppendText("Welcome to CyberLink!" + Environment.NewLine);
        }
    }
}
