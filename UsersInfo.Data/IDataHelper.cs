using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersInfo.Data
{
    internal interface IDataHelper<Table>
    {
        //Read
        Task<List< Table>> GetAllAsync();
        Task<List<Table>> SearchAsync(string Iteam);
        Task<Table> FindAsync(int Id);
        //Write  
        Task addAsync(Table table); 
        Task removeAsync(int Id );
        Task EditAsync(Table table);

    }
}
