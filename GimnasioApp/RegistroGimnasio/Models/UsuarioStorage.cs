using System.Text.Json;
using RegistroGimnasio.Models;

namespace RegistroGimnasio.Models
{
    public static class UsuarioStorage
    {
        private static readonly string filePath = "usuarios.json";

        public static List<Usuario> LeerUsuarios()
        {
            if (!File.Exists(filePath))
                return new List<Usuario>();

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();
        }

        public static void GuardarUsuario(Usuario nuevoUsuario)
        {
            var usuarios = LeerUsuarios();
            usuarios.Add(nuevoUsuario);
            var json = JsonSerializer.Serialize(usuarios, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}
