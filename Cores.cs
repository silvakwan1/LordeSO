using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LordeSO
{
    internal class Cores {
        public static void CorSelecionada(TipoArquivo arquivo) {
            if(arquivo == TipoArquivo.ArquivoDeTexto){
                CorArquivoDeTextosSelecionado();
            }else if(arquivo == TipoArquivo.Pasta) {
                CorPastaSelecionado();
            }else {
                CorArquivosDoSistemaSelecionado();
            }
        }
        public static void CorPadrao(TipoArquivo arquivo) {
            if (arquivo == TipoArquivo.ArquivoDeTexto)
            {
                CorPadraoArquivoDeTexto();
            }
            else if (arquivo == TipoArquivo.Pasta)
            {
                CorPadraoPasta();
            }
            else
            {
                CorPadraoArquivosDoSistema();
            }
        }

        private static void CorPadraoPasta() {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void CorPastaSelecionado() {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        private static void CorPadraoArquivosDoSistema() {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        private static void CorArquivosDoSistemaSelecionado() {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        private static void CorPadraoArquivoDeTexto() {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }

        private static void CorArquivoDeTextosSelecionado() {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
        }


    }
}
