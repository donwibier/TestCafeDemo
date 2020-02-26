using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TestCafeDemo.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

        public EditorsViewModel EditorModel { get; set; } = new EditorsViewModel();

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
        public bool ShowForm { get; set; } = true;
        public void OnPost(EditorsViewModel model)
        {
            if (ModelState.IsValid)
            {
                ShowForm = false;
                EditorModel = model;
            }
            

        }
	}

    public class EditorsViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
