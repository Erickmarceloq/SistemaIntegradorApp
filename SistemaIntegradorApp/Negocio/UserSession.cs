namespace SistemaIntegradorApp.Negocio
{
    // Clase estática para mantener los datos del usuario autenticado en memoria
    public static class UserSession
    {
        public static string Username { get; set; }
        public static string Rol { get; set; }
    }
}