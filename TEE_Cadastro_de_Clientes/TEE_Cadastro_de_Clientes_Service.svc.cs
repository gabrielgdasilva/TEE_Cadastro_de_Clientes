using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TEE_Cadastro_de_Clientes.DataContracts;

namespace TEE_Cadastro_de_Clientes
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ITEE_Cadastro_de_Clientes_Service
    {
        //----------------------------Cliente---------------------------------------------------
        [OperationBehavior]
        public Cliente DetalhesCliente(int id)
        {
            DAO.Models.ClienteModel _clienteDAO = DAO.Cliente.DetalhesCliente(id);
            Cliente cliente = new Cliente();
            cliente.ClienteID = _clienteDAO.ClienteID;
            cliente.Nome = _clienteDAO.Nome;
            cliente.Cnpj = _clienteDAO.Cnpj;
            cliente.RazaoSocial = _clienteDAO.RazaoSocial;
            cliente.Endereco = _clienteDAO.Endereco;

            return cliente;
        }

        [OperationBehavior]
        public bool CadastrarCliente(Cliente _cliente)
        {
            DAO.Models.ClienteModel clienteDAO = new DAO.Models.ClienteModel();
            clienteDAO.ClienteID = _cliente.ClienteID;
            clienteDAO.Nome = _cliente.Nome;
            clienteDAO.Cnpj = _cliente.Cnpj;
            clienteDAO.RazaoSocial = _cliente.RazaoSocial;
            clienteDAO.Endereco = _cliente.Endereco;


            if (DAO.Cliente.CadastrarCliente(clienteDAO))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [OperationBehavior]
        public bool AtualizarCliente(Cliente _cliente)
        {
            DAO.Models.ClienteModel clienteDAO = new DAO.Models.ClienteModel();
            clienteDAO.ClienteID = _cliente.ClienteID;
            clienteDAO.Nome = _cliente.Nome;
            clienteDAO.Cnpj = _cliente.Cnpj;
            clienteDAO.RazaoSocial = _cliente.RazaoSocial;
            clienteDAO.Endereco = _cliente.Endereco;


            if (DAO.Cliente.AtualizarCliente(clienteDAO))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //----------------------------Fabrica-----------------------------------------------
        [OperationBehavior]
        public bool CadastrarFabrica(Fabrica _fabrica)
        {
            DAO.Models.FabricaModel fabricaDAO = new DAO.Models.FabricaModel();
            fabricaDAO.FabricaID = _fabrica.FabricaID;
            fabricaDAO.ClienteID = _fabrica.ClienteID;
            fabricaDAO.Cnpj = _fabrica.Cnpj;
            fabricaDAO.Endereco = _fabrica.Endereco;
            fabricaDAO.DistribuidoraID = _fabrica.DistribuidoraID;

            if (DAO.Fabrica.CadastrarFabrica(fabricaDAO))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [OperationBehavior]
        public bool AtualizarFabrica(Fabrica _fabrica)
        {
            DAO.Models.FabricaModel fabricaDAO = new DAO.Models.FabricaModel();
            fabricaDAO.FabricaID = _fabrica.FabricaID;
            fabricaDAO.ClienteID = _fabrica.ClienteID;
            fabricaDAO.Cnpj = _fabrica.Cnpj;
            fabricaDAO.Endereco = _fabrica.Endereco;
            fabricaDAO.DistribuidoraID = _fabrica.DistribuidoraID;

            if (DAO.Fabrica.CadastrarFabrica(fabricaDAO))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [OperationBehavior]
        public Fabrica DestalhesDaFabrica(int id)
        {
            DAO.Models.FabricaModel _FabricaDAO = DAO.Fabrica.DestalhesDaFabrica(id);
            Fabrica fabrica = new Fabrica();
            fabrica.FabricaID = _FabricaDAO.FabricaID;
            fabrica.ClienteID = _FabricaDAO.ClienteID;
            fabrica.Cnpj = _FabricaDAO.Cnpj;
            fabrica.Endereco = _FabricaDAO.Endereco;
            fabrica.DistribuidoraID = _FabricaDAO.DistribuidoraID;

            return fabrica;
        }

        [OperationBehavior]
        public List<Fabrica> TodasFabricas(int ClienteID)
        {
            List<DAO.Models.FabricaModel> ListFabricaDAO = DAO.Fabrica.TodasFabricas(ClienteID);
            List<Fabrica> listaFabricas = new List<Fabrica>();
            foreach (var item in ListFabricaDAO)
            {
                Fabrica fabrica = new Fabrica();
                fabrica.FabricaID = item.FabricaID;
                fabrica.ClienteID = item.ClienteID;
                fabrica.Cnpj = item.Cnpj;
                fabrica.Endereco = item.Endereco;
                fabrica.DistribuidoraID = item.DistribuidoraID;
                listaFabricas.Add(fabrica);
            }
            return listaFabricas;
        }
        //Deleção de Fabrica
        [OperationBehavior]
        public bool DeletarFabrica(Fabrica _fabrica)
        {
            DAO.Models.FabricaModel fabricaDAO = new DAO.Models.FabricaModel();
            fabricaDAO.FabricaID = _fabrica.FabricaID;
            fabricaDAO.ClienteID = _fabrica.ClienteID;
            fabricaDAO.Cnpj = _fabrica.Cnpj;
            fabricaDAO.Endereco = _fabrica.Endereco;
            fabricaDAO.DistribuidoraID = _fabrica.DistribuidoraID;

            if (DAO.Fabrica.DeletarFabrica(fabricaDAO))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
