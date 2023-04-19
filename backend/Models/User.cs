namespace kmitl_web_app_project_backend.Models; 

public class User {
	public string Username { get; set; } = string.Empty;
	public string Nickname { get; set; } = string.Empty;
	public string Password { get; set; } = string.Empty;
	public string ProfileImage { get; set; } = string.Empty;
	public int Reputation { get; set; } = 0;
}