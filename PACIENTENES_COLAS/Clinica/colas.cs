using System;

namespace PACIENTENES_COLAS.Clinica
{
    class colas
    {

        //ATRIBUTOS PARA CLINICA
        string[] cola;
        int primerlemento, elementofinal, tam;

        //CONSTRUCTOR
        public colas(int n)
        {
            primerlemento = elementofinal = -1;
            tam = n;
            cola = new string[tam];
        }

        public bool esta_llena()
        {
            if (elementofinal >= tam - 1)
                return true;
            return false;
        }

        public bool esta_vacia()
        {
            if (primerlemento == -1)
                return true;
            return false;
        }

        public bool agregar( string nombre)
        {
            if (!esta_llena())
            {

               
                cola[++elementofinal] = nombre;

                if (elementofinal == 0)
                    primerlemento = 0;
                return true;
            }
            return false;
        }

        public bool extraer(ref string nombre)
        {
            //ESTA VRIABLE SE USARA PARA MOVER EL DATO 1 al 0, el 2 al 1, el 3 al 2 ...
            int var = 1;

            //SI LA PILA NO ESTA VACIA:
            if (!esta_vacia())
            {
                //ENTONCES SACAMOS EL PRIMER DATO SERIA EL NOMBRE DEL PACIENTE 1 (P[O])
                
                nombre = cola[primerlemento];



                for (int i = 0; i < cola.Length; i++)
                {
                    //SE PREGUNTA SI var ES MENOR A LA LONGITUD DEL ARREGLO, ESTO SE HACE DEBIDO A QUE var LLEGA A UN VALOR
                    //SUPERIOR A LA LONGITUD DEL ARREGLO
                    if (var < cola.Length)
                    {
                        //PASAMOS EL DATO DE UNA POSICION A OTRA
                        //EJEMPLO: vec[0]=vec[1] EL DATO EN LA POSICION 1 SE PASA A LA POSICION 0 Y ASI HASTA LA LONGITUD DEL ARREGLO
                        cola[i] = cola[var];
                        var++;
                    }
                }

                //AHORA LA VARIABLE QUE SE IRA MOVIENDO SERA u, YA QUE EL PRIMERO SIEMPRE SERA EL ELEMENTO 0
                if (elementofinal == primerlemento)
                {
                    primerlemento = elementofinal = -1;
                }
                else
                    //DECREMENTAMOS u YA QUE QUIERE DECIR QUE "HAY UN DATO MENOS EN LA COLA", EN REALIDAD EL DATO SIGUE ALLI
                    elementofinal--;
                return true;
            }
            return false;
        }



    }
}
