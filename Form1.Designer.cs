namespace CyberlinkGUI
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            rtbChat = new RichTextBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            grpTask = new GroupBox();
            grpQuiz = new GroupBox();
            btnNextQuestion = new Button();
            rbOption4 = new RadioButton();
            rbOption3 = new RadioButton();
            rbOption2 = new RadioButton();
            rbOption1 = new RadioButton();
            lblQuestion = new Label();
            txtDescription = new TextBox();
            txtTitle = new TextBox();
            dgvTasks = new DataGridView();
            completeTask = new Button();
            deleteTask = new Button();
            viewTasks = new Button();
            addTask = new Button();
            dtpReminder = new DateTimePicker();
            lblReminder = new Label();
            grpTask.SuspendLayout();
            grpQuiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(304, 30);
            label1.TabIndex = 0;
            label1.Text = "CYBERLINK Cybersecurity Bot";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // rtbChat
            // 
            rtbChat.BackColor = SystemColors.ControlLight;
            rtbChat.Location = new Point(12, 42);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(502, 367);
            rtbChat.TabIndex = 1;
            rtbChat.Text = "";
            rtbChat.TextChanged += richTextBox1_TextChanged;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 415);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(695, 23);
            txtMessage.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Coral;
            btnSend.Location = new Point(713, 415);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // grpTask
            // 
            grpTask.BackColor = Color.MistyRose;
            grpTask.Controls.Add(grpQuiz);
            grpTask.Controls.Add(txtDescription);
            grpTask.Controls.Add(txtTitle);
            grpTask.Controls.Add(dgvTasks);
            grpTask.Controls.Add(completeTask);
            grpTask.Controls.Add(deleteTask);
            grpTask.Controls.Add(viewTasks);
            grpTask.Controls.Add(addTask);
            grpTask.Controls.Add(dtpReminder);
            grpTask.Controls.Add(lblReminder);
            grpTask.Location = new Point(520, 42);
            grpTask.Name = "grpTask";
            grpTask.Size = new Size(546, 367);
            grpTask.TabIndex = 4;
            grpTask.TabStop = false;
            grpTask.Text = "Task Assistant";
            grpTask.Enter += groupBox1_Enter;
            // 
            // grpQuiz
            // 
            grpQuiz.BackColor = SystemColors.ControlLight;
            grpQuiz.Controls.Add(btnNextQuestion);
            grpQuiz.Controls.Add(rbOption4);
            grpQuiz.Controls.Add(rbOption3);
            grpQuiz.Controls.Add(rbOption2);
            grpQuiz.Controls.Add(rbOption1);
            grpQuiz.Controls.Add(lblQuestion);
            grpQuiz.Location = new Point(270, 10);
            grpQuiz.Name = "grpQuiz";
            grpQuiz.Size = new Size(270, 190);
            grpQuiz.TabIndex = 13;
            grpQuiz.TabStop = false;
            grpQuiz.Text = "Cybersecurity Quiz";
            // 
            // btnNextQuestion
            // 
            btnNextQuestion.BackColor = Color.Coral;
            btnNextQuestion.Location = new Point(6, 161);
            btnNextQuestion.Name = "btnNextQuestion";
            btnNextQuestion.Size = new Size(157, 23);
            btnNextQuestion.TabIndex = 5;
            btnNextQuestion.Text = "Next Question";
            btnNextQuestion.UseVisualStyleBackColor = false;
            btnNextQuestion.Click += btnNextQuestion_Click;
            // 
            // rbOption4
            // 
            rbOption4.AutoSize = true;
            rbOption4.Location = new Point(6, 135);
            rbOption4.Name = "rbOption4";
            rbOption4.Size = new Size(71, 19);
            rbOption4.TabIndex = 4;
            rbOption4.TabStop = true;
            rbOption4.Text = "Option 4";
            rbOption4.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            rbOption3.AutoSize = true;
            rbOption3.Location = new Point(6, 108);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(71, 19);
            rbOption3.TabIndex = 3;
            rbOption3.TabStop = true;
            rbOption3.Text = "Option 3";
            rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            rbOption2.AutoSize = true;
            rbOption2.Location = new Point(6, 83);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(71, 19);
            rbOption2.TabIndex = 2;
            rbOption2.TabStop = true;
            rbOption2.Text = "Option 2";
            rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption1
            // 
            rbOption1.AutoSize = true;
            rbOption1.Location = new Point(6, 58);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(71, 19);
            rbOption1.TabIndex = 1;
            rbOption1.TabStop = true;
            rbOption1.Text = "Option 1";
            rbOption1.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(6, 20);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(125, 15);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Question appears here";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(6, 51);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(258, 23);
            txtDescription.TabIndex = 12;
            txtDescription.Text = "Description";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(6, 22);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(258, 23);
            txtTitle.TabIndex = 11;
            txtTitle.Text = "Task Title";
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // dgvTasks
            // 
            dgvTasks.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvTasks.DefaultCellStyle = dataGridViewCellStyle5;
            dgvTasks.Location = new Point(6, 206);
            dgvTasks.Name = "dgvTasks";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.Size = new Size(534, 155);
            dgvTasks.TabIndex = 10;
            // 
            // completeTask
            // 
            completeTask.BackColor = Color.Coral;
            completeTask.Location = new Point(139, 145);
            completeTask.Name = "completeTask";
            completeTask.Size = new Size(125, 23);
            completeTask.TabIndex = 9;
            completeTask.Text = "Complete Task";
            completeTask.UseVisualStyleBackColor = false;
            completeTask.Click += completeTask_Click;
            // 
            // deleteTask
            // 
            deleteTask.BackColor = Color.Coral;
            deleteTask.Location = new Point(139, 116);
            deleteTask.Name = "deleteTask";
            deleteTask.Size = new Size(125, 23);
            deleteTask.TabIndex = 8;
            deleteTask.Text = "Delete Task";
            deleteTask.UseVisualStyleBackColor = false;
            deleteTask.Click += deleteTask_Click;
            // 
            // viewTasks
            // 
            viewTasks.BackColor = Color.Coral;
            viewTasks.Location = new Point(6, 145);
            viewTasks.Name = "viewTasks";
            viewTasks.Size = new Size(127, 23);
            viewTasks.TabIndex = 7;
            viewTasks.Text = "View Tasks";
            viewTasks.UseVisualStyleBackColor = false;
            // 
            // addTask
            // 
            addTask.BackColor = Color.Coral;
            addTask.Location = new Point(6, 116);
            addTask.Name = "addTask";
            addTask.Size = new Size(127, 23);
            addTask.TabIndex = 6;
            addTask.Text = "Add Task";
            addTask.UseVisualStyleBackColor = false;
            addTask.Click += addTask_Click;
            // 
            // dtpReminder
            // 
            dtpReminder.Location = new Point(73, 87);
            dtpReminder.Name = "dtpReminder";
            dtpReminder.Size = new Size(191, 23);
            dtpReminder.TabIndex = 5;
            dtpReminder.ValueChanged += dtpReminder_ValueChanged;
            // 
            // lblReminder
            // 
            lblReminder.AutoSize = true;
            lblReminder.Location = new Point(6, 93);
            lblReminder.Name = "lblReminder";
            lblReminder.Size = new Size(61, 15);
            lblReminder.TabIndex = 4;
            lblReminder.Text = "Reminder:";
            lblReminder.Click += assistantReminder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1070, 450);
            Controls.Add(grpTask);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(rtbChat);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpTask.ResumeLayout(false);
            grpTask.PerformLayout();
            grpQuiz.ResumeLayout(false);
            grpQuiz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rtbChat;
        private TextBox txtMessage;
        private Button btnSend;
        private GroupBox grpTask;
        private DateTimePicker dtpReminder;
        private Label lblReminder;
        private Button completeTask;
        private Button deleteTask;
        private Button viewTasks;
        private Button addTask;
        private DataGridView dgvTasks;
        private TextBox txtDescription;
        private TextBox txtTitle;
        public GroupBox grpQuiz;
        private RadioButton rbOption4;
        private RadioButton rbOption3;
        private RadioButton rbOption2;
        private RadioButton rbOption1;
        private Label lblQuestion;
        private Button btnNextQuestion;
    }
}
