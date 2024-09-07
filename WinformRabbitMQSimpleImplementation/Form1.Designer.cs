namespace WinformRabbitMQSimpleImplementation
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
            btnConnectRabbitMQ = new Button();
            btnCreateExchange = new Button();
            btnCreateQueue = new Button();
            btnBindingQueue = new Button();
            PublishEmail = new Label();
            txtPublishEmail = new TextBox();
            btnPublishEmail = new Button();
            btnPublishSMS = new Button();
            txtPublishSMS = new TextBox();
            PublishSMS = new Label();
            Email = new Label();
            lstEmailMessages = new ListBox();
            lstSmsMessages = new ListBox();
            Messages = new Label();
            btnSubscribeEmail = new Button();
            btnSubscribeSms = new Button();
            SuspendLayout();
            // 
            // btnConnectRabbitMQ
            // 
            btnConnectRabbitMQ.Location = new Point(12, 22);
            btnConnectRabbitMQ.Name = "btnConnectRabbitMQ";
            btnConnectRabbitMQ.Size = new Size(123, 56);
            btnConnectRabbitMQ.TabIndex = 0;
            btnConnectRabbitMQ.Text = "Connect RabbitMQ";
            btnConnectRabbitMQ.UseVisualStyleBackColor = true;
            btnConnectRabbitMQ.Click += btnConnectRabbitMQ_Click;
            // 
            // btnCreateExchange
            // 
            btnCreateExchange.Location = new Point(11, 102);
            btnCreateExchange.Name = "btnCreateExchange";
            btnCreateExchange.Size = new Size(124, 54);
            btnCreateExchange.TabIndex = 1;
            btnCreateExchange.Text = "Create Exchange";
            btnCreateExchange.UseVisualStyleBackColor = true;
            btnCreateExchange.Click += btnCreateExchange_Click;
            // 
            // btnCreateQueue
            // 
            btnCreateQueue.Location = new Point(11, 191);
            btnCreateQueue.Name = "btnCreateQueue";
            btnCreateQueue.Size = new Size(129, 53);
            btnCreateQueue.TabIndex = 2;
            btnCreateQueue.Text = "Create Queue";
            btnCreateQueue.UseVisualStyleBackColor = true;
            btnCreateQueue.Click += btnCreateQueue_Click;
            // 
            // btnBindingQueue
            // 
            btnBindingQueue.Location = new Point(12, 280);
            btnBindingQueue.Name = "btnBindingQueue";
            btnBindingQueue.Size = new Size(129, 49);
            btnBindingQueue.TabIndex = 3;
            btnBindingQueue.Text = "Bind Queues";
            btnBindingQueue.UseVisualStyleBackColor = true;
            btnBindingQueue.Click += btnBindingQueue_Click;
            // 
            // PublishEmail
            // 
            PublishEmail.AutoSize = true;
            PublishEmail.Location = new Point(12, 375);
            PublishEmail.Name = "PublishEmail";
            PublishEmail.Size = new Size(36, 15);
            PublishEmail.TabIndex = 4;
            PublishEmail.Text = "Email";
            // 
            // txtPublishEmail
            // 
            txtPublishEmail.Location = new Point(11, 393);
            txtPublishEmail.Name = "txtPublishEmail";
            txtPublishEmail.Size = new Size(335, 23);
            txtPublishEmail.TabIndex = 5;
            // 
            // btnPublishEmail
            // 
            btnPublishEmail.Location = new Point(203, 422);
            btnPublishEmail.Name = "btnPublishEmail";
            btnPublishEmail.Size = new Size(143, 39);
            btnPublishEmail.TabIndex = 6;
            btnPublishEmail.Text = "Publish Email";
            btnPublishEmail.UseVisualStyleBackColor = true;
            btnPublishEmail.Click += btnPublishEmail_Click;
            // 
            // btnPublishSMS
            // 
            btnPublishSMS.Location = new Point(203, 519);
            btnPublishSMS.Name = "btnPublishSMS";
            btnPublishSMS.Size = new Size(143, 39);
            btnPublishSMS.TabIndex = 9;
            btnPublishSMS.Text = "Publish SMS";
            btnPublishSMS.UseVisualStyleBackColor = true;
            btnPublishSMS.Click += btnPublishSMS_Click;
            // 
            // txtPublishSMS
            // 
            txtPublishSMS.Location = new Point(11, 490);
            txtPublishSMS.Name = "txtPublishSMS";
            txtPublishSMS.Size = new Size(335, 23);
            txtPublishSMS.TabIndex = 8;
            // 
            // PublishSMS
            // 
            PublishSMS.AutoSize = true;
            PublishSMS.Location = new Point(12, 472);
            PublishSMS.Name = "PublishSMS";
            PublishSMS.Size = new Size(72, 15);
            PublishSMS.TabIndex = 7;
            PublishSMS.Text = "Publish SMS";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(546, 9);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 10;
            Email.Text = "Email";
            // 
            // lstEmailMessages
            // 
            lstEmailMessages.FormattingEnabled = true;
            lstEmailMessages.ItemHeight = 15;
            lstEmailMessages.Location = new Point(546, 36);
            lstEmailMessages.Name = "lstEmailMessages";
            lstEmailMessages.Size = new Size(368, 274);
            lstEmailMessages.TabIndex = 11;
            // 
            // lstSmsMessages
            // 
            lstSmsMessages.FormattingEnabled = true;
            lstSmsMessages.ItemHeight = 15;
            lstSmsMessages.Location = new Point(546, 358);
            lstSmsMessages.Name = "lstSmsMessages";
            lstSmsMessages.Size = new Size(368, 274);
            lstSmsMessages.TabIndex = 13;
            // 
            // Messages
            // 
            Messages.AutoSize = true;
            Messages.Location = new Point(546, 331);
            Messages.Name = "Messages";
            Messages.Size = new Size(30, 15);
            Messages.TabIndex = 12;
            Messages.Text = "SMS";
            // 
            // btnSubscribeEmail
            // 
            btnSubscribeEmail.Location = new Point(451, 36);
            btnSubscribeEmail.Name = "btnSubscribeEmail";
            btnSubscribeEmail.Size = new Size(89, 150);
            btnSubscribeEmail.TabIndex = 14;
            btnSubscribeEmail.Text = "Subscribe Email";
            btnSubscribeEmail.UseVisualStyleBackColor = true;
            btnSubscribeEmail.Click += btnSubscribeEmail_Click;
            // 
            // btnSubscribeSms
            // 
            btnSubscribeSms.Location = new Point(451, 404);
            btnSubscribeSms.Name = "btnSubscribeSms";
            btnSubscribeSms.Size = new Size(89, 150);
            btnSubscribeSms.TabIndex = 15;
            btnSubscribeSms.Text = "Subscribe SMS";
            btnSubscribeSms.UseVisualStyleBackColor = true;
            btnSubscribeSms.Click += btnSubscribeSms_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 665);
            Controls.Add(btnSubscribeSms);
            Controls.Add(btnSubscribeEmail);
            Controls.Add(lstSmsMessages);
            Controls.Add(Messages);
            Controls.Add(lstEmailMessages);
            Controls.Add(Email);
            Controls.Add(btnPublishSMS);
            Controls.Add(txtPublishSMS);
            Controls.Add(PublishSMS);
            Controls.Add(btnPublishEmail);
            Controls.Add(txtPublishEmail);
            Controls.Add(PublishEmail);
            Controls.Add(btnBindingQueue);
            Controls.Add(btnCreateQueue);
            Controls.Add(btnCreateExchange);
            Controls.Add(btnConnectRabbitMQ);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnectRabbitMQ;
        private Button btnCreateExchange;
        private Button btnCreateQueue;
        private Button btnBindingQueue;
        private Label PublishEmail;
        private TextBox txtPublishEmail;
        private Button btnPublishEmail;
        private Button btnPublishSMS;
        private TextBox txtPublishSMS;
        private Label PublishSMS;
        private Label Email;
        private ListBox lstEmailMessages;
        private ListBox lstSmsMessages;
        private Label Messages;
        private Button btnSubscribeEmail;
        private Button btnSubscribeSms;
    }
}
