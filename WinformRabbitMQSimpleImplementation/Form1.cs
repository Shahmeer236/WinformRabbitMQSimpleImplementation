using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Configuration;
using System.Text;

namespace WinformRabbitMQSimpleImplementation
{
    public partial class Form1 : Form
    {
        private IConnection _rabbitMQConnection;
        private IModel _emailChannel;
        private IModel _smsChannel;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnectRabbitMQ_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["RabbitMQConnection"].ConnectionString;
            var connectionFactory = new ConnectionFactory();
            connectionFactory.Uri = new Uri(connectionString);
            connectionFactory.AutomaticRecoveryEnabled = true;
            connectionFactory.DispatchConsumersAsync = true;
            _rabbitMQConnection = connectionFactory.CreateConnection("DemoAppClient");



        }

        private void btnCreateExchange_Click(object sender, EventArgs e)
        {
            using (var channel = _rabbitMQConnection.CreateModel())
            {
                channel.ExchangeDeclare("CustomerNotification", ExchangeType.Direct, true, false);

            }
        }

        private void btnCreateQueue_Click(object sender, EventArgs e)
        {
            using (var channel = _rabbitMQConnection.CreateModel())
            {
                channel.QueueDeclare("Email", true, false, false);
                channel.QueueDeclare("SMS", true, false, false);

            }

        }

        private void btnBindingQueue_Click(object sender, EventArgs e)
        {
            using (var channel = _rabbitMQConnection.CreateModel())
            {
                channel.QueueBind("Email", "CustomerNotification", "email");
                channel.QueueBind("SMS", "CustomerNotification", "sms");

            }

        }



        private void btnPublishEmail_Click(object sender, EventArgs e)
        {
            using (var channel = _rabbitMQConnection.CreateModel())
            {
                var message = txtPublishEmail.Text;
                var properties = channel.CreateBasicProperties();
                properties.DeliveryMode = 2;
                channel.BasicPublish("CustomerNotification", "email", properties, Encoding.UTF8.GetBytes(message));

                txtPublishEmail.Text = "";


            }


        }

        private void btnPublishSMS_Click(object sender, EventArgs e)
        {
            using (var channel = _rabbitMQConnection.CreateModel())
            {
                var message = txtPublishSMS.Text;
                var properties = channel.CreateBasicProperties();
                properties.DeliveryMode = 2;
                channel.BasicPublish("CustomerNotification", "sms", properties, Encoding.UTF8.GetBytes(message));
                txtPublishSMS.Text = "";


            }

        }

        private void btnSubscribeEmail_Click(object sender, EventArgs e)
        {
            _emailChannel = _rabbitMQConnection.CreateModel();
            _emailChannel.BasicQos(0, 1, false);
            var emailChannelConsumer = new AsyncEventingBasicConsumer(_emailChannel);
            emailChannelConsumer.Received += EmailChannelConsumer_Received;
            _emailChannel.BasicConsume("Email", false, emailChannelConsumer);

        }

        private async Task EmailChannelConsumer_Received(object sender, BasicDeliverEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Body.ToArray());
            lstEmailMessages.Invoke((MethodInvoker)(() => lstEmailMessages.Items.Add(message)));


            _emailChannel.BasicAck(e.DeliveryTag,false);
        }

        private void btnSubscribeSms_Click(object sender, EventArgs e)
        {
            _smsChannel = _rabbitMQConnection.CreateModel();
            _smsChannel.BasicQos(0, 1, false);
            var smsChannelConsumer = new AsyncEventingBasicConsumer(_smsChannel);
            smsChannelConsumer.Received += SmsChannelConsumer_Received;
            _smsChannel.BasicConsume("SMS", false, smsChannelConsumer);

        }

        private async Task SmsChannelConsumer_Received(object sender, BasicDeliverEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Body.ToArray());
            lstSmsMessages.Invoke((MethodInvoker)(() => lstSmsMessages.Items.Add(message)));


            _smsChannel.BasicAck(e.DeliveryTag, false);
        }
    }
}
