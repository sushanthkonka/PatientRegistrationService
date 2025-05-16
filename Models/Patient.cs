using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.VisualBasic;

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

      public string? Date_Of_Birth { get; set; }

      public List<string>? Medical_History { get; set; }

      public int Id { get; set; }
    
}
