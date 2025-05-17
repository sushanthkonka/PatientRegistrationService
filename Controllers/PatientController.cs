using System.Runtime.ExceptionServices;
using Microsoft.AspNetCore.Mvc;
using PatientRegistrationService.Data;
using PatientRegistrationService.Models;



[Route("api/[controller]")]
[ApiController]
public class PatientController : ControllerBase
{

  private readonly AppDbContext _context;

  public PatientController(AppDbContext context)
  {
    _context = context;
  }

  [HttpGet("GetPatientInformation/{patientId}")]
  public IActionResult GetPatientInformation(int patientId)
  {
    Patient patient = new Patient();


    return Ok(patient);
  }

  [HttpPost("Register")]
  public async Task<IActionResult> Register([FromBody] Patient patient)
  {
    if (patient == null)
      return BadRequest("Invalid data");
    // string Past_Medical_History = string.Concat(", ", patient.Medical_History);
    List<string>? list = patient?.Medical_History;
    for (int i = 0; i < list?.Count; i++)
    {
      string mh = list[i];
    }
    System.Console.WriteLine($"  {patient?.First_Name} {patient?.Last_Name} {patient?.Date_Of_Birth} {patient?.Gender} {patient?.Phone_Number} {patient?.Street_Address} {patient?.City_Address} {patient?.State_Address} {patient?.Zip_Code} {patient?.Insurance_Name} {patient?.Marital_Status} ");
    System.Console.WriteLine(list);

    await _context.Patients.AddAsync(patient);
    await _context.SaveChangesAsync();

    return Ok(patient);
  }
}