using System.ComponentModel.DataAnnotations;

namespace BoardAppCore.Models
{
    public class COpinion
    {
        [Key] // 키 값
        public int board_id { get; set; }
        [Required] //필드가 null이 아닌지 확인
        public string nick_nm { get; set; }
        [Required]
        public string content_ct { get; set; }
    }
}
