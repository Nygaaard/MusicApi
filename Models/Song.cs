using System.ComponentModel.DataAnnotations;

namespace MusicApi.Models
{
    public class Song
    {
        //Properties
        public int SongId { get; set; }
        [Required(ErrorMessage = "Du måste ange artistens namn.")]
        [StringLength(100, ErrorMessage = "Artistens namn kan inte vara längre än 100 tecken")]
        public string? Artist { get; set; }
        [Required(ErrorMessage = "Du måste ange titel")]
        [StringLength(100, ErrorMessage = "Titel kan inte vara längre än 100 tecken")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Du måste ange låtens längd")]
        [Range(1, 1000, ErrorMessage = "Längden måste vara mellan 1 och 1000 sekunder")]
        public int Length { get; set; }
        [Required(ErrorMessage = "Du måste ange kategori")]
        [StringLength(50, ErrorMessage = "Kategorin kan inte vara längre än 50 tecken")]
        public string? Category { get; set; }
    }
}