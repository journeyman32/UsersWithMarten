using DocumentDbWithMarten.models;
using Marten;

namespace DocumentDbWithMarten
{
    public class DataConnection : iDataConnection
    {
        private string _value = "";
        public DataConnection()
        {
            Connect();
        }
        public void Connect()
        {
            var store = DocumentStore.For("");

            using (var session = store.LightweightSession())
            {
                var user = new User
                {
                    FirstName = "Ted",
                    LastName = "Turner",
                    Internal = true,
                    UserName = "theBoogeyMan"
                };
                session.Store(user);
                
                session.SaveChanges();

                _value = "test";
            }
        }

        public string GetValueString()
        {
            return _value;
        }
    }
}