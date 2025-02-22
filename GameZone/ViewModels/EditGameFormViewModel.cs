﻿namespace GameZone.ViewModels
{
    public class EditGameFormViewModel : GameFormViewModel
    {
       public int Id { get; set; }

        public String? CurrentCover {  get; set; }

        [AllowedExtensions(FileSettings.AllowedExtensions),
            MaxFileSize(FileSettings.MaxFileSizeInBytes)]
        public IFormFile? Cover { get; set; } = default!;
    }
}
