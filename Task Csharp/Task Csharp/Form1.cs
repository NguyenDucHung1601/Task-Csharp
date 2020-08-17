using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonAPI_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://graph.facebook.com/me?acess_token=abc");
            HttpResponseMessage respone = await client.GetAsync("api");
            string result = await respone.Content.ReadAsStringAsync();
            textBoxAPI.Text = result;
        }
    }
}
