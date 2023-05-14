using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ClienteWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Cliente GetData(int value)
        {
            var cliente = new Cliente() { Id = 1, Nome = "joão", CPF = "12345678910" };
            return cliente;
        }

        public List<Cliente> All()
        {
            var clientes = new List<Cliente>();
            //var cliente = new Cliente() { Id = 1, Nome = "joão", CPF = "12345678910" };
            clientes.Add(new Cliente() { Id = 1, Nome = "joão", CPF = "12345678910" });
            clientes.Add(new Cliente() { Id = 2, Nome = "maria", CPF = "98765432101" });
            clientes.Add(new Cliente() { Id = 3, Nome = "josé", CPF = "74185296312" });

            return clientes;
        }

        public bool Save(string nome, string cpf)
        {
            try
            {
                bool saved = new Cliente() { Nome = nome, CPF = cpf }.Save();
                return saved;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
