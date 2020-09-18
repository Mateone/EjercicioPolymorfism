using System;

namespace LSPLibrary
{
    public class Alert
    { 
        /*
            La clase implementa un metodo "Send", el cual cambia su acción dependiendo
            del "type" que se le pase por parametro. Esto debería estar implementado en
            dos clases diferentes utilizando la misma operación polimórfica.
        */
        public void Send(string type, string text)
        {
            if (type == "trello")
            {
                new TrelloCardCreator().CreateCard(text);
            }
            else if (type == "text") 
            {
                Console.WriteLine(text);
            }
        }
    }
}