using System.ComponentModel.DataAnnotations;

public  class User
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome deve ser preenchido!")]
    [StringLength(20,MinimumLength = 2,ErrorMessage = "O nome deve ter entre dois até vinte caracteres!")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "O email deve ser preenchido!")]
    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    public string? Email { get; set; }

    [Required(ErrorMessage = "A data deve ser preenchida!")]
    [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
    [Range(typeof(DateOnly), "01/01/2000","18/04/2023",ErrorMessage = "Data de nascimento deve estar entre 01/01/2000 e 18/04/2023")]
    public DateOnly? DateOfBirth { get; set; }
    
    public string GetUser()
    {
        return $"Name: {Name}\nEmail: {Email}\nData de nascimento: {DateOfBirth}";
    }
}