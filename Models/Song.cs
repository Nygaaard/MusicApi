using System.ComponentModel.DataAnnotations;

namespace MusicApi.Models
{
    public class Song
    {
        //Properties
        public int SongId { get; set; }
        [Required(ErrorMessage = "Du måste fylla i artist")]
        public string? Artist { get; set; }
        [Required(ErrorMessage = "Du måste fylla i titel")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Du måste fylla i längd")]
        public int Length { get; set; }
        [Required(ErrorMessage = "Du måste fylla i kategori")]
        public string? Category { get; set; }
    }
}