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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITEE_Cadastro_de_Clientes_Service
    {

        
        //----------------------------Cliente--------------------------------------------------------------
        [OperationContract]
        Cliente DetalhesCliente(int id);

        [OperationContract]
        bool CadastrarCliente(Cliente cliente);

        [OperationContract]
        bool AtualizarCliente(Cliente cliente);

        //----------------------------Fabrica--------------------------------------------------------------
        [OperationContract]
        bool CadastrarFabrica(Fabrica _fabrica);

        [OperationContract]
        Fabrica DestalhesDaFabrica(int id);

        [OperationContract]
        List<Fabrica> TodasFabricas(int ClienteID);

        [OperationContract]
        bool DeletarFabrica(Fabrica _fabrica);

        [OperationContract]
        bool AtualizarFabrica(Fabrica _fabrica);

    }


    
}
