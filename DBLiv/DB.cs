using DBLiv.Model;
using System.Linq;

namespace DBLiv
{
    public class DB
    {
        public info GetByID(int id)
        {
            return Connection.db.info.FirstOrDefault(x => x.id == id);
        }

        public info GetByName(string name)
        {
            return Connection.db.info.FirstOrDefault(x => x.name == name);
        }

        public void Add(int id, string message, string name)
        {
            if (!CheckID(id)) return;

            info inf = new info();
            inf.id = id;
            inf.name = name;
            inf.message = message;

            Connection.db.info.Add(inf);
            Connection.db.SaveChanges();
        }

        public void Update(int id, string newMessage)
        {
            info inf = GetByID(id);
            if (inf != null)
            {
                inf.message = newMessage;
                Connection.db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            info inf = GetByID(id);
            if (inf != null)
            {
                Connection.db.info.Remove(inf);
                Connection.db.SaveChanges();
            }
        }

        public bool CheckID(int id)
        {
            if (Connection.db.info.FirstOrDefault(x => x.id == id) != null) return true;
            return false;
        }
    }
}
