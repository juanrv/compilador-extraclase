using System;
using System.Collections.Generic;
using System.Text;
using lectorArchivo.Analizador;
using lectorArchivo.Transversal;
using System.Windows.Forms;
using lectorArchivo.GestorErrores;

namespace lectorArchivo.AnalisisSintactico
{
    public class AnalizadorSintactico
    {
        private ComponenteLexico Componente;
        private AnalizadorLexico AnaLex;
        private StringBuilder TrazaDerivacion;
        private bool Metodo;

        public ComponenteLexico Analizar(bool depurar, bool Metodo)
        {
            AnaLex = new AnalizadorLexico();
            this.Metodo = Metodo;
            TrazaDerivacion = new StringBuilder();
            
            if (this.Metodo)
            {
                
                Avanzar();
                Morse();
            }
            else
            {
                Avanzar();
                Latin();
            }
            

            return Componente;
        }

        
        //<morse>:: <simboloMorse><morseSec> 
        private void Morse()
        {
            SimboloMorse();
            MorseSec();
        }
       
        //<morseSec> :: <morse>|epsilon {., ,-} 
        private void MorseSec()
        {
            if (!Categoria.FIN_DE_ARCHIVO.Equals(Componente.ObtenerCategoria()))
            {
                Morse();
            }
        }
        //<simboloMorse>:: .| |-  {., ,-}
        private void SimboloMorse()
        {
            if (Categoria.LETRA_A.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_B.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_C.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_D.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_E.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_F.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_G.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_H.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_I.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_J.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_K.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_L.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_M.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_M.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_O.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_P.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_Q.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_R.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_S.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_T.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_U.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_V.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_W.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_X.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_Y.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_Z.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.TILDE_A_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.TILDE_E_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.TILDE_O_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.NUMERO_CERO.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.NUMERO_UNO.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.NUMERO_DOS.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.NUMERO_TRES.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.NUMERO_CUATRO.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.NUMERO_CINCO.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.NUMERO_SEIS.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.NUMERO_SIETE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.NUMERO_OCHO.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.NUMERO_NUEVE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.NUMERO_CERO.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_ET.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_ENYE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.PUNTO.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.COMA.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.INTERROGACION_ABRE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.INTERROGACION_CIERRA.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.DOS_PUNTOS.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.COMILLA_SIMPLE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.ADMIRACION_ABRE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.ADMIRACION_CIERRA.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.PARENTESIS_ABRE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.PARENTESIS_CIERRA.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.PUNTO_Y_COMA.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.IGUAL.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.MAS.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.GUION.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.GUION_BAJO.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.COMILLAS_DOBLES.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.BARRA_INCLINADA.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.ESPACIO.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.SIGNO_PESOS.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.ARROBA.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }

            else
            {
                String Causa = "Caracter leido no valido " + Componente.ObtenerCategoria();
                String falla = "Caracter no valido";
                String Solucion = "Asegurese que el morse esta biene escrito";

                Error Error = Error.CrearErrorSintactico(Componente.ObtenerLexema(), Componente.ObtenerCategoria(), Componente.ObtenerNumeroLinea(), Componente.ObetenerPosicionInicial(), Componente.ObtenerPosicionFinal(), falla, Causa, Solucion);
                ManejadorErrores.Reportar(Error);
                throw new Exception("se ha presentado un error de tipo stopper dentro del proceso de compilacion. Por favor revise la consola de errores...");
            }



        }

        private void Latin()
        {
            Alfabeto();
            LatinSec();
        }
        private void LatinSec()
        {
            if (!Categoria.FIN_DE_ARCHIVO.Equals(Componente.ObtenerCategoria()))
            {
                Latin();
            }
        }
        private void Alfabeto()
        {
            if (Categoria.LETRA_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_TILDE_O.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_TILDE_A.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_TILDE_E.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.LETRA_ENYE_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else {
                Numero();
            }
        }
        private void Numero()
        {
            if (Categoria.NUMERO_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else
            {
                SimboloLatin();
            }
        }
        private void SimboloLatin()
        {
            if (Categoria.ET_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.PREGUNTA_ABRE_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.PREGUNTA_CIERRA_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.COMILLA_SIMPLE_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.ADMIRACION_ABRE_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.ADMIRACION_CIERRA_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.BARRA_INCLINADA_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.PARENTESIS_ABRE_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.PARENTESIS_CIERRA_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.DOS_PUNTOS_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.PUNTO_Y_COMA_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.IGUAL_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.MAS_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.GUION_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            
            else if (Categoria.COMILLAS_DOBLES_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.SIGNO_PESOS_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.ARROBA_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.ESPACIO_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.PUNTO_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.COMA_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.GUION_BAJO_MORSE.Equals(Componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else
            {
                String Causa = "Caracter leido no valido " + Componente.ObtenerCategoria();
                String falla = "Caracter no valido";
                String Solucion = "Asegurese que el morse esta biene escrito";

                Error Error = Error.CrearErrorSintactico(Componente.ObtenerLexema(), Componente.ObtenerCategoria(), Componente.ObtenerNumeroLinea(), Componente.ObetenerPosicionInicial(), Componente.ObtenerPosicionFinal(), falla, Causa, Solucion);
                ManejadorErrores.Reportar(Error);
                throw new Exception("se ha presentado un error de tipo stopper dentro del proceso de compilacion. Por favor revise la consola de errores...");
            }
        }
            
       
        private void Avanzar()
        {
            Componente = AnaLex.Analizador(this.Metodo);
        }
        private void TrazarEntrada(string NombreRegla, int jerarquia)
        {
            TrazaDerivacion.Append(FormarCadenaEspaciosBlanco(jerarquia));
            TrazaDerivacion.Append(NombreRegla).Append("(").Append(Componente.ObtenerCategoria()).Append(")");
            TrazaDerivacion.Append(Environment.NewLine);

        }
        private void TrazarSalida(string NombreRegla, int jerarquia)
        {
            TrazaDerivacion.Append(FormarCadenaEspaciosBlanco(jerarquia));
            TrazaDerivacion.Append(NombreRegla);
            TrazaDerivacion.Append(Environment.NewLine);

        }

        private string FormarCadenaEspaciosBlanco(int jerarquia)
        {
            String EspaciosBlanco = "";
            for (int i = 1; i <= jerarquia; i++)
            {
                EspaciosBlanco = EspaciosBlanco + " | ";
            }
            return EspaciosBlanco;
        }
    }
}
