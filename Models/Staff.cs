using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RegexExercise.Attributes;

namespace RegexExercise.Models;

[Table("staff")]
public class Staff
{
    [Key]
    [Required(ErrorMessage = "Id không được để trống")]
    [RegexValidation(@"^\d+$", ErrorMessage = "Id phải là một số nguyên")]
    [Range(1, int.MaxValue, ErrorMessage = "Id phải là một số nguyên dương")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Họ Tên không được để trống")]
    [StringLength(maximumLength: 100, MinimumLength = 1, ErrorMessage = "Tên phải có độ dài từ 1 đến 100 ký tự")]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Email không được để trống")]
    [RegexValidation( @"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Email không hợp lệ")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Số điện thoại không được để trống")]
    [RegexValidation(@"^0\d{9}$", ErrorMessage = "Số điện thoại phải bắt đầu bằng số 0 và có 10 chữ số.")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Ngày bắt đầu làm việc không được để trống")] 
    public DateTime StartWorkDay { get; set; }
    
    [RegexValidation(@"^.+\.(jpg|jpeg|png|bmp)$", ErrorMessage = "File ảnh không đúng định dạng")]
    public string Photo { get; set; }
}