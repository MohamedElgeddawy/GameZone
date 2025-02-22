﻿namespace GameZone.ViewModels
{
    public class GameFormViewModel
    {
        [MaxLength(250)]
        public string Name { get; set; }

        [Display(Name = " Category")]
        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();

        [Display(Name = " SupportedDevices")]
        public List<int> SelectedDevices { get; set; } = default!;

        public IEnumerable<SelectListItem> Devices { get; set; } = Enumerable.Empty<SelectListItem>();

        [MaxLength(2500)]
        public string Description { get; set; }
    }
}
