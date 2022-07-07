using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace digiseiWindowsService
{
    class HTTPEmitter
    {
        HttpClient client;
        private string todo = "https://jsonplaceholder.typicode.com/todos";
        public HTTPEmitter()
        {
            client = new HttpClient();
        }

        
        public async Task<string> GetTodoItems()
        {
            string response = await client.GetStringAsync(todo);
            Console.WriteLine(response);
            return response;
        }

    }
}
