using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class PatientController: ControllerBase
{
    [HttpGet("GetPatientInformation/{patientId}")]
  public IActionResult GetPatientInformation(int patientId)
  {
    return Ok();
  }
}