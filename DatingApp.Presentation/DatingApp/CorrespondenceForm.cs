using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.BusinesLogic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatingApp.Presentation.WindowsForm
{
    public partial class CorrespondenceForm : Form
    {
        ChatService _chatService = new ChatService();
        int id;
        public CorrespondenceForm(int id)
        {
            InitializeComponent();
            var allProfiles = profile.GetAll();
            _recepientComboBox.DisplayMember = "FirstName";
            _recepientComboBox.ValueMember = "Id";

            for (int i = 0; i < allProfiles.Count; i++)
            {
                _recepientComboBox.Items.Add(allProfiles[i]);
            }

            this.id = id;
            var reciviedMessages = _chatService.GetReceivedMesaages(this.id);
            foreach (var message in reciviedMessages)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = message.SenderName + " : " + message.TextMessage;
                _tablesListView.Items.Add(lvi);
            }

            var sendMessages = _chatService.GetSendedMesaages(this.id);
            foreach (var mess in sendMessages)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = mess.RecipientName + " : " + mess.TextMessage;
                _listViewSendedMessage.Items.Add(lvi);
            }
        }

        ProfileService profile = new ProfileService();

        private void _sendMessageButton_Click(object sender, EventArgs e)
        {
            _chatService.SendMessage(_messageTextBox.Text , (ProfileModel)_recepientComboBox.SelectedItem, new ProfileModel { Id = this.id});
            
            var reciviedMessages = _chatService.GetReceivedMesaages(this.id);
            foreach (var message in reciviedMessages)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = message.RecipientName + " : " + message.TextMessage;
                _tablesListView.Items.Add(lvi);
            }

            var sendMessages = _chatService.GetSendedMesaages(this.id);
            foreach (var mess in sendMessages)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = mess.SenderName + " : " + mess.TextMessage;
                _listViewSendedMessage.Items.Add(lvi);
            }
            
            _messageTextBox.Clear();
        }
    }
}
