using ServicioInyeccionDependenciasV2.Aplicacion.Services;
using ServicioInyeccionDependenciasV2.Aplicacion.Dependencies;

namespace ServicioInyeccionDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService();
            ISender smsService = new SMSService();

            var communicationService = new CommunicationService(smsService);

            var customers = customerService.GetCustomers();
            var message = "¡Hola! Su pedido ya está disponible, se lo llevamos a casa. Gracias por usar nuestro servicio de email";
            foreach (var customer in customers)
            {
                communicationService.SendMessage(customer.Email, message);
            }
        }
    }
}