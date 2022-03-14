namespace SolidPDV
{
    static class Conn
    {
        private const string servidor = "127.0.0.1";
        private const string bancoDados = "db_solid_pdv";
        private const string usuario = "root";
        private const string senha = "root";

        static public string strConn = $" Server = {servidor}; Database={bancoDados};Uid={usuario};Pwd={senha};";
    }
}
