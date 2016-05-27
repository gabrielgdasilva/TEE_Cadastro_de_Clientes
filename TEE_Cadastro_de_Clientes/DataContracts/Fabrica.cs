using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TEE_Cadastro_de_Clientes.DataContracts
{
    [DataContract]

    public class Fabrica
    {
        [DataMember]
        public int FabricaID { get; set; }
        [DataMember]
        public int ClienteID { get; set; }
        [DataMember]
        public string Cnpj { get; set; }
        [DataMember]
        public string Endereco { get; set; }
        [DataMember]
        public int DistribuidoraID { get; set; }
    }
}