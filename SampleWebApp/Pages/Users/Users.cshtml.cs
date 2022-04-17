using APILibrary.API;
using APILibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.Configuration;

namespace SampleWebApp.Pages;

public class UsersModel : PageModel
{
    public readonly APIHelper aPIHelper = new APIHelper();
    public IEnumerable<User> Users { get; set; }
    public async Task OnGet()
    {        
        Users = await aPIHelper.GetUsers();
    }

    public async void CreateUser(User user)
    {
        await aPIHelper.InsertUser(user);
    }
}
