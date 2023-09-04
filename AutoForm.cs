using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportInterview
{
    enum Status
    {
        NOACTION,
        SENDING,
        RECEVING,
        RECEIVED
    }
    public partial class AutoForm : Form
    {
        Status cur_status = Status.NOACTION;
        string prompt = string.Empty;
        string lastprompt = string.Empty;
        ChatGPTClient chatGPTClient;
        Thread aiBot;
        bool isRunning = true;
        public AutoForm()
        {
            InitializeComponent();
            // Replace with your ChatGPT API key
            string apiKey = "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";
            // Create a ChatGPTClient instance with the API key
            chatGPTClient = new ChatGPTClient(apiKey);

            ThreadStart aiBotStart = new ThreadStart(run);

            aiBot = new Thread(aiBotStart);
            aiBot.Start();
        }
        public void run()
        {

            // Display a welcome message
            PrintMessage("Welcome to the SupportInterviewBot!");

            // Enter a loop to take user input and display chatbot responses
            while (isRunning)
            {
                // Prompt the user for input
                //PrintMessage("You: ");
                prompt = txtPrompt.Text;
                //cur_status = Status.SENDING;
                Thread.Sleep(1000);

                if (cur_status != Status.SENDING || prompt == string.Empty || prompt == lastprompt)
                {
                    continue;
                }

                lastprompt = prompt;
                string initialPrompt = "Find questions from following text and answer.\n";
                prompt = initialPrompt + prompt;

                // Send the user's input to the ChatGPT API and receive a response
                string response = chatGPTClient.SendMessage(prompt);
                cur_status = Status.RECEIVED;
                //txtPrompt.Text = "";
                // Display the chatbot's response
                PrintMessage(response);
            }
        }
        public void PrintMessage(string message)
        {
            txtResult.Text = message;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Geneate();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            txtPrompt.Width = splitContainer.Panel1.Width;
            txtPrompt.Height = splitContainer.Panel1.Height;
            txtResult.Width = splitContainer.Panel2.Width;
            txtResult.Height = splitContainer.Panel2.Height;
        }

        private void AutoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isRunning = false;
            //aiBot.Suspend();
        }

        private void AutoForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "ControlKey")
                Geneate();
        }
        private void Geneate()
        {
            string initialPrompt = "Find questions from following text and answer.\n";
            prompt = initialPrompt + txtPrompt.Text;
            cur_status = Status.SENDING;
        }
        private void AutoForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
