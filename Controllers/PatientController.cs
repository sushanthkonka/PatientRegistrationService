using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class PatientController: ControllerBase
{
    [HttpGet("GetPatientInformation/{patientId}")]
  public IActionResult GetPatientInformation(int patientId)
  {
    Patient patient = new Patient();

      
    return Ok(patient);
  }

  [HttpPost ("Register")]
  public IActionResult Register([FromBody] Patient patient)
    {
        // Console.WriteLine($"Received patient: {patient.FirstName} {patient.LastName}");
        return Ok(patient);
    }
  
}