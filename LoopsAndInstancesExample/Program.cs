using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoopsAndInstancesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = new Stopwatch();
            time.Start();

            ValidacaoNova();

            time.Stop();
            Console.WriteLine("Tempo nova: {0}", time.Elapsed);

            time.Restart();

            ValidacaoAntiga();

            time.Stop();
            Console.WriteLine("Tempo antiga: {0}", time.Elapsed);

            Console.ReadKey();
        }

        public static void ValidacaoAntiga()
        { 
            var listaDeEmails = new ListaDeEmails().Buscar();

            var emailRegex = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            foreach (var email in listaDeEmails)
            {
                var regex = new Regex(emailRegex, RegexOptions.IgnoreCase);
                var oEmailEstaValido = regex.IsMatch(email);
                if (oEmailEstaValido)
                {
                    //Alguma operacão aqui...
                }
            }
        }

        public static void ValidacaoNova()
        {
            var listaDeEmails = new ListaDeEmails().Buscar();

            var emailRegex = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(emailRegex, RegexOptions.IgnoreCase);

            foreach (var email in listaDeEmails)
            {
                var oEmailEstaValido = regex.IsMatch(email);
                if (oEmailEstaValido)
                {
                    //Alguma operacão aqui...
                }
            }
        }
    }
}
