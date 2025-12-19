namespace ProyectoFinalTecWeb.Entities.Dtos.Auth
{
    public class Reset_password
    {
        public string Email { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
        public string NewPassword { get; set; } = string.Empty;
    }
}
