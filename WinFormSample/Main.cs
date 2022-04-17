using APILibrary.API;
using APILibrary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSample;
public partial class Main : Form
{
    APIHelper _apiHelper = new APIHelper();
    public Main()
    {
        InitializeComponent();
        LoadUsers();
    }

    public async void LoadUsers()
    {
        cboxNames.Items.Clear();
        var data = await _apiHelper.GetUsers();
        foreach (var item in data)
        {
            cboxNames.Items.Add(item.Id);
        }
    }
    private void btnLoadData_Click(object sender, EventArgs e)
    {
        LoadUsers();
    }

    private async void GetUser_Click(object sender, EventArgs e)
    {
        var number = Convert.ToInt32(cboxNames.Text);
        var user = await _apiHelper.GetUser(number);
        TextBoxFirstName.Text = user.FirstName;
        TextBoxLastName.Text = user.LastName;
    }

    private async void PutUser_Click(object sender, EventArgs e)
    {
        var user = new User();
        user.FirstName = TextBoxFirstName.Text;
        user.LastName = TextBoxLastName.Text;
        user.Id = Convert.ToInt32(cboxNames.Text);
        await _apiHelper.UpdateUser(user);
    }

    private async void PostUser_Click(object sender, EventArgs e)
    {
        User user = new User
        {
            FirstName = TextBoxFirstName.Text,
            LastName = TextBoxLastName.Text,
        };
        await _apiHelper.InsertUser(user);
    }

    private async void DeleteUser_Click(object sender, EventArgs e)
    {
        await _apiHelper.DeleteUser(Convert.ToInt32(cboxNames.Text));
    }
}
