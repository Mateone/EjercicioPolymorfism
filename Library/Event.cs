namespace LSPLibrary
{
    public class Event
    {
        /*
            La clase implementa un metodo "Notify", que cambia su funcionamiento
            dependiendo del "EventType", por lo cual esto se podría separar en dos clases
            diferentes que implementen una interfaz IEvent, con metodos distintas
            para la operación "Notify".
        */
        public string EventName { get; set; }
        public string EventType { get; set; }

        public void Notify()
        {
            new Alert().Send("text", this.EventName);

            if (this.EventType == "severe")
            {
                new Alert().Send("trello", this.EventName);
            }
        }
    }
}