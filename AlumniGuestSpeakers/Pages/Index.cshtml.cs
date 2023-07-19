using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AlumniGuestSpeakers.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<(string, string)> Speakers { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            Speakers = new List<(string,string)>()
            {
                ("https://business.okstate.edu/site-files/images/headshots/burkman_jim-19082702.jpg","Professor Jim Burkman"),
                ("https://business.okstate.edu/site-files/images/headshots/wilson_rick_headshot.jpg","Professor Rick Wilson"),
                ("https://business.okstate.edu/site-files/images/headshots/baham_cory.jpg","Professor Corey Baham"),
                ("https://business.okstate.edu/site-files/images/headshots/bao_chenzhang190828007.jpg","Professor Chenzhang Bao"),
                ("https://business.okstate.edu/site-files/images/headshots/dursun_delen.jpg", "Professor Dursun Delen"),
                ("https://business.okstate.edu/site-files/images/headshots/andy_luse-web.jpg", "Professor Andy Luse")
            };
        }

        public void OnGet()
        {

        }
    }
}