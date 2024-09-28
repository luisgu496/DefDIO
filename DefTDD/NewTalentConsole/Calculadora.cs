using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalentConsole
{
    public class Calculadora
    {
        private List<string> Listahistorico;        //Fazemos essa variável de lista para armazenar o historico. é privado porque não vamos usar essa variável em teste
                                                    //Assim, toda vez que chamarmos a Calculadora, já vai iniciar o histórico junto
        public Calculadora()
        {
            Listahistorico = new List<string>();
        }        

        public int somar(int num1, int num2)
        {
            int res = num1 + num2;

            Listahistorico.Insert(0, "Res: " + res);                //Assim, sempre que voc~e chamar o método 'somar', você vai inserir no inicio da lista o resultado 'somar', que seria os últimos resultados que você teve
            return res;
        }

        public int subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            
            Listahistorico.Insert(0, "Res: " + res);
            return res;
        }

        public int multiplicar(int num1, int num2)
        {
            int res = num1 * num2;

            Listahistorico.Insert(0, "Res: " + res);
            return res;
        }

        public int dividir(int num1, int num2)
        {
            int res = num1 / num2;

            Listahistorico.Insert(0, "Res: " + res);
            return res;
        }

        public List<string> historico()
        {
            Listahistorico.RemoveRange(3, Listahistorico.Count - 3);                          //Aqui, nós vamos remover da nossa lista todos depois da posição 3(só queremos mostrar os 3 resultados mais recentes)
           return new List<string>();       //Quantos itens tem na listamenos a quantidade que você quer deixar, que nesse caso é 3
        }
    }
}