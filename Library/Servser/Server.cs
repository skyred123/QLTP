using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Entity;
using Microsoft.EntityFrameworkCore;

namespace Library.Servser
{
    public class Server
    {
        private static Server? instance;
        public static Server Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Server();
                }
                return instance;
            }
        }

        public ApplicationDbContext dbContext;
        public Server()
        {
            dbContext = new ApplicationDbContext();
        }
        public AddData AddData() => new AddData();
        public DeleteData DeleteData() => new DeleteData();
        public GetData GetData() => new GetData();
        public UpdateData UpdateData() => new UpdateData();
    }
}
