using MahawMedicineAPI.Models;
using MahawMedicineAPI.Services;
using Microsoft.AspNetCore.Mvc;

[Route("user")] // Route
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    // User Registration
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] User user)
    {
        var result = await _authService.RegisterAsync(user);
        if (!result.Success)
            return BadRequest(result.Message);

        return Ok(new { message = "Registration successful" });
    }

    // User Login
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] User user)
    {
        var token = await _authService.AuthenticateAsync(user.Email, user.Password);
        if (token == null) return Unauthorized("Invalid credentials");

        return Ok(new { message = "Login successful", token });
    }
}
