using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico.Entidades;

namespace TallerMecanico.Logica
{
    class LogicaCliente
    {
        public ICollection<Cliente> ListarClientes()
        {
            using (ModelContext context = new ModelContext())
            {
                var lst = from c in context.Clientes
                          select c;
                return lst.ToList();
            }
        }
        public int ContarClientes()
        {
            using (ModelContext context = new ModelContext())
            {
                var lst = from c in context.Clientes
                          select c;
                return lst.ToList().Count;
            }
        }

        public bool IsCedulaValid(Cliente clienteE)
        {
            using (ModelContext context = new ModelContext())
            {
                var lst = from c in context.Clientes
                          where c.Cedula == clienteE.Cedula && c.Id != clienteE.Id
                          select c;

                return (lst.ToList().Count == 0) ? true : false;
            }
        }

        public bool IsTelefonoValid(Cliente clienteE)
        {
            using (ModelContext context = new ModelContext())
            {
                var lst = from c in context.Clientes
                          where c.Telefono == clienteE.Telefono && c.Id != clienteE.Id
                          select c;

                return (lst.ToList().Count == 0) ? true : false;
            }
        }

        public Cliente GetCliente(Cliente clienteE)
        {
            using (ModelContext context = new ModelContext())
            {
                Cliente cliente = new Cliente();
                //Por cedula
                if (!String.IsNullOrEmpty(clienteE.Cedula))
                {
                    var lst = from c in context.Clientes
                              where c.Cedula == clienteE.Cedula
                              select c;
                    cliente = lst.FirstOrDefault();
                }

                //Por ID
                if (clienteE.Id != 0)
                {
                    var lst = from c in context.Clientes
                              where c.Id == clienteE.Id
                              select c;
                    cliente = lst.FirstOrDefault();
                }
                
                return cliente;
            }
        }

        public bool AddCliente(Cliente cliente)
        {
            try
            {
                using (ModelContext context = new ModelContext())
                {
                    context.Clientes.Add(cliente);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditCliente(Cliente cliente)
        {
            try
            {
                using (ModelContext context = new ModelContext())
                {
                    var c = from client in context.Clientes
                                where cliente.Id == client.Id 
                                select client;
                    Cliente clienteE = c.FirstOrDefault();
                    context.Entry(clienteE).State = System.Data.Entity.EntityState.Modified;
                    clienteE.Nombre = cliente.Nombre;
                    clienteE.Apellido = cliente.Apellido;
                    clienteE.Cedula = cliente.Cedula;
                    cliente.Telefono = cliente.Telefono;
                    clienteE.Direccion = cliente.Direccion;

                    context.SaveChanges();


                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DropCliente(Cliente cliente)
        {
            try
            {
                using (ModelContext context = new ModelContext())
                {
                    var c = from client in context.Clientes
                            where cliente.Id == client.Id
                            select client;
                    Cliente clienteARemover = c.FirstOrDefault();
                    context.Clientes.Remove(clienteARemover);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
