using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text.Json;

namespace ModuleCatalogue2.Pages
{
    public partial class ModuleList
    {
        private List<Module>? modules;
        protected override async Task OnInitializedAsync()
        {
            modules = await Http.GetFromJsonAsync<List<Module>>("modulesInformation.json");
        }
        public class Module
        {
            public string? name { get; set; }
            public string? description { get; set; }
            public string? duration { get; set; }
            public int creditScore { get; set; }
            public string? moduleCoordinator { get; set; }
        }
    }
}
