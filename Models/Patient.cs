using System.ComponentModel.DataAnnotations;

public class Patient
{
    public string? First_Name { get; set; }
    public string? Last_Name { get; set; }
    public string? Phone_Number { get; set; }

    public string? Street_Address { get; set; }

    public string? City_Address { get; set; }

    public string? State_Address { get; set; }

     public string? Zip_Code { get; set; }

      public string? Gender { get; set; }

      public string? Marital_Status { get; set; }

      public string? Insurance_Name { get; set; }





     








    public int Id { get; set; }
    // [Required(ErrorMessage = "First name is required")]
    // public string? FirstName { get; set; }

    // [Required(ErrorMessage = "Last name is required")]
    // public string? LastName { get; set; }

    // [Required(ErrorMessage = "Gender is required")]
    // public string? Gender { get; set; }


    // [Required(ErrorMessage = "Phone number is required")]
    // [Phone(ErrorMessage = "Invalid phone number")]
    // public string? Phone { get; set; }

    // [Required(ErrorMessage = "Date of Birth is required")]
    // [DataType(DataType.Date)]
    // public DateTime DateOfBirth { get; set; }

    // [Required(ErrorMessage = "Marital Status is required")]
    // public string? MaritalStatus { get; set; }

    // [Required(ErrorMessage = "Street address is required")]
    // public string? StreetAddress { get; set; }

    // [Required(ErrorMessage = "City is required")]
    // public string? City { get; set; }

    // [Required(ErrorMessage = "State is required")]
    // public string? State { get; set; }

    // [Required(ErrorMessage = "Postal/Zip code is required")]
    // public string? ZipCode { get; set; }

    // [Required(ErrorMessage = "Country is required")]
    // public string? Country { get; set; }

    // [Required(ErrorMessage = "Insurance Name is required")]
    // public string? InsuranceName { get; set; }

    // public List<string>? MedicalHistory { get; set; }

    // // Signature Acknowledgement
    // [Required(ErrorMessage = "Signature acknowledgement is required")]
    // public bool IsSigned { get; set; }
}
