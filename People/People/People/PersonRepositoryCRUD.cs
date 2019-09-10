using People.Models;
using SQLite;

namespace People
{
    public class PersonRepositoryCRUD
    {
        SQLiteConnection conn;

        // conn = new SQLiteConnection
        public string StatusMessage { get; set; }

        // Constructor
        public PersonRepositoryCRUD(string dbPath)
        {
            // Creamos la conexión.
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Person>();

            /* PersonRepositoryCRUD Repo = 
            new PersonRepositoryCRUD("c:\dev\datos");*/
        }

        // CRUD OPERATIONS o métodos
        // cREAR

        /* Tipos de datos de retorno:
         *  void = Vacío
         *  int = Entero
         *  string = Cadena
         *  Decimal = decimal
         *  Person = un objeto de tipo Peson.
        */
        public void CreatePerson(Person newPerson)
        {
           
            int result;
            result = conn.Insert(newPerson);
            if (result == 1)
            {
                StatusMessage =
                    $"{result} registro agregado [Nombre: " +
                    $"{newPerson.Name}, ID:{newPerson.Id}";
            }
        }




    }

    class Car
    {
        // Catacterísticas o Propiedades
        public int NPlaca { get; set; }
        public string Modelo { get; set; }

        // Métodos acciones
        void Arrancar()
        {
            //
        }
        void Avanzar()
        {
            //
        }

    }
}
