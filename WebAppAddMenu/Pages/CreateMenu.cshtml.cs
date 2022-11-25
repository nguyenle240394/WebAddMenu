using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net.Mail;
using System.Text;
using WebAppAddMenu.Models;

namespace WebAppAddMenu.Pages
{
    public class CreateMenuModel : PageModel
    {
        SaMenu saMenu = new SaMenu();
        string url = "http://192.168.1.4:8081/api/SaMenus";
        HttpClient client = new HttpClient();
        public void OnGet()
        {
        }

        public async void OnPost()
        {
            saMenu.MenuCode = Request.Form["menuCode"];
            saMenu.MenuName = Request.Form["menuName"];
            saMenu.Description = Request.Form["description"];
            saMenu.ModuleCode = Request.Form["moduleCode"];
            saMenu.CreatedBy = "PLCAdmin";
            saMenu.ModifiedBy = "PLCAdmin";
            var json = JsonConvert.SerializeObject(saMenu);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, data);
            await response.Content.ReadAsStringAsync();

        }

    }
}
