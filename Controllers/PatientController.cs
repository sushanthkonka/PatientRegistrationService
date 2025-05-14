using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class PatientController: ControllerBase
{
    [HttpGet("GetPatientInformation/{patientId}")]
  public IActionResult GetPatientInformation(int patientId)
  {
    var patient = new
        {
            Id = patientId,
            Name = "Sushanth",
            Age = 25,
            Diagnosis = "Hypertension"
        };
    return Ok(patient);
  }
}