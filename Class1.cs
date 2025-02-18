public class Persona
{
    public string Nombre { get; set; }
    public string CorreoElectronico { get; set; }

    public void EnviarCorreo(string mensaje)
    {
        Console.WriteLine($"Enviando correo a {CorreoElectronico}: {mensaje}");
    }
}
public class EnviarCorreo
{
    public string Correo(string CorreoElectrinico, string mensaje)
    {
        Console.WriteLine($"Se envio un correo electronico a {CorreoElectrinico}, con el mensaje: {mensaje}")
    }
}