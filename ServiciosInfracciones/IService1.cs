using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiciosInfracciones
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: agregue aquí sus operaciones de servicio
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    // Puede agregar archivos XSD al proyecto. Después de compilar el proyecto, puede usar directamente los tipos de datos definidos aquí, con el espacio de nombres "ServiciosInfracciones.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    public class Auto
    {
        private String _numPlaca;
        private int _año;
        private String _Marca;
        private String _Color;
        private String _Propietario;
        private int _cantPapeletas;

        [DataMember]
        public string NumPlaca { get => _numPlaca; set => _numPlaca = value; }
        [DataMember]
        public int Año { get => _año; set => _año = value; }
        [DataMember]
        public string Marca { get => _Marca; set => _Marca = value; }
        [DataMember]
        public string Color { get => _Color; set => _Color = value; }
        [DataMember]
        public string Propietario { get => _Propietario; set => _Propietario = value; }
        [DataMember]
        public int CantPapeletas { get => _cantPapeletas; set => _cantPapeletas = value; }
    }
}
