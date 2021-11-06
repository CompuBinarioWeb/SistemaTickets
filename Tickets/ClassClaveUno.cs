using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Tickets
{
    class ClassClaveUno
    {
        // Definir min defecto y longitudes de contraseña max
        private static int DEFAULT_MIN_PASSWORD_LENGTH = 5;
        private static int DEFAULT_MAX_PASSWORD_LENGTH = 5;

        // Definir caracteres de contraseña soportados divididos en grupos.
        // Puede agregar (o eliminar) caracteres para (de) estos grupos.
        //private static string PASSWORD_CHARS_LCASE = "abcdefghijklmnopqrstuvwxyz";
        //private static string PASSWORD_CHARS_UCASE = "ABCDEFGHJKLMNOPQRSTUVWXYZ";
        private static string PASSWORD_CHARS_NUMERIC = "1234567890";


        // <Summary>
        /// Genera una contraseña aleatoria.
        /// </ Summary>
        /// <Rendimientos>
        /// Aleatoriamente generados contraseña.
        /// </ Devoluciones>
        /// <Observaciones>
        /// La longitud de la contraseña generada será determinado en
        /// al azar. No será más corto que el valor predeterminado y mínimo
        /// No más de máximo predeterminado.
        /// </ Observaciones>
        public static string Generate()
        {
            return Generate(DEFAULT_MIN_PASSWORD_LENGTH,
                            DEFAULT_MAX_PASSWORD_LENGTH);
        }

        /// <Summary>
        /// Genera una contraseña aleatoria de la longitud exacta.
        /// </ Summary>
        /// <Param name = "longitud">
        /// Longitud de la contraseña exacta.
        /// </ Param>
        /// <Rendimientos>
        /// Aleatoriamente generados contraseña.
        /// </ Devoluciones>
        public static string Generate(int length)
        {
            return Generate(length, length);
        }

        /// <Summary>
        /// Genera una contraseña aleatoria.
        /// </ Summary>
        /// <Param name = "minLength">
        /// Longitud mínima de la contraseña.
        /// </ Param>
        /// <Param name = "maxLength">
        /// Longitud máxima de la contraseña.
        /// </ Param>
        /// <Rendimientos>
        /// Aleatoriamente generados contraseña.
        /// </ Devoluciones>
        /// <Observaciones>
        /// La longitud de la contraseña generada será determinado en
        /// Azar y caerá con la gama determinada por la
        /// Parámetros de la función.
        /// </ Observaciones>
        public static string Generate(int minLength,
                                      int maxLength)
        {
            // Asegúrese de que los parámetros de entrada son válidos.
            if (minLength <= 0 || maxLength <= 0 || minLength > maxLength)
                return null;

            // Crear una matriz local que contiene caracteres de contraseña soportados
            // Agrupados por tipos. Puede eliminar grupos de caracteres de esta
            // Array, pero al hacerlo se debilitará la fuerza contraseña.
            char[][] charGroups = new char[][]
        {
            //PASSWORD_CHARS_LCASE.ToCharArray(),
            //PASSWORD_CHARS_UCASE.ToCharArray(),
            PASSWORD_CHARS_NUMERIC.ToCharArray(),
        };

            // Utilice esta matriz para realizar un seguimiento del número de caracteres utilizados en cada
            // Grupo de caracteres.
            int[] charsLeftInGroup = new int[charGroups.Length];

            // En un principio, no se utilizan todos los caracteres de cada grupo.
            for (int i = 0; i < charsLeftInGroup.Length; i++)
                charsLeftInGroup[i] = charGroups[i].Length;

            // Utilice esta matriz para realizar un seguimiento (recorrer) grupos de caracteres utilizados.
            int[] leftGroupsOrder = new int[charGroups.Length];

            // En un principio, no se utilizan todos los grupos de caracteres.
            for (int i = 0; i < leftGroupsOrder.Length; i++)
                leftGroupsOrder[i] = i;

            // Porque no podemos utilizar la aleatoriedad por defecto, que se basa en la
            // Hora actual (que producirá el mismo número "aleatorio" dentro de un
            // Segundos), vamos a utilizar un generador de números aleatorios para sembrar el
            // Aleatoriedad.

            // Utilizar una matriz de 4 bytes a llenarlo con bytes aleatorios y convertirlo a continuación
            // A un valor entero.
            byte[] randomBytes = new byte[4];

            // Generar 4 bytes aleatorios.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(randomBytes);

            // Convertir 4 bytes en un valor entero de 32 bits.
            int seed = BitConverter.ToInt32(randomBytes, 0);

            // Ahora, se trata de la asignación al azar real.
            Random random = new Random(seed);

            // Este conjunto celebrará caracteres de la contraseña.
            char[] password = null;

            // Asignar memoria adecuada para la contraseña.
            if (minLength < maxLength)
                password = new char[random.Next(minLength, maxLength + 1)];
            else
                password = new char[minLength];

            // Índice del siguiente carácter que se añadirá a la contraseña.
            int nextCharIdx;

            // Índice del siguiente grupo de caracteres a procesar.
            int nextGroupIdx;

            // Índice del siguiente grupo de caractères una Procesar.
            int nextLeftGroupsOrderIdx;

            // Índice del último carácter no procesado en un grupo.
            int lastCharIdx;

            // Índice del último grupo no procesada.
            int lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;

            // Generar caracteres de la contraseña uno a la vez.
            for (int i = 0; i < password.Length; i++)
            {
                // Si sólo hay un grupo de caracteres se mantuvo sin procesar, procesarla;
                // De lo contrario, elija un grupo de caracteres al azar de la no procesada
                // Lista de grupos. Para permitir un carácter especial que aparezca en el
                // Primera posición, incrementar el segundo parámetro de la siguiente
                // Función de llamada a uno, es decir lastLeftGroupsOrderIdx + 1.
                if (lastLeftGroupsOrderIdx == 0)
                    nextLeftGroupsOrderIdx = 0;
                else
                    nextLeftGroupsOrderIdx = random.Next(0,
                                                         lastLeftGroupsOrderIdx);

                // Obtener el índice real del grupo de caracteres, desde el cual lo haremos
                // Escoger el siguiente carácter.
                nextGroupIdx = leftGroupsOrder[nextLeftGroupsOrderIdx];

                // Obtener el índice de los últimos caracteres no procesados en este grupo.
                lastCharIdx = charsLeftInGroup[nextGroupIdx] - 1;

                // Si sólo un carácter no procesado se marchó, recogerlo; de otra manera,
                // Obtener un carácter aleatorio de la lista de caracteres sin usar.
                if (lastCharIdx == 0)
                    nextCharIdx = 0;
                else
                    nextCharIdx = random.Next(0, lastCharIdx + 1);

                // Añadir este carácter a la contraseña.
                password[i] = charGroups[nextGroupIdx][nextCharIdx];

                // Si procesamos el último carácter de este grupo, empezar de nuevo.
                if (lastCharIdx == 0)
                    charsLeftInGroup[nextGroupIdx] =
                                              charGroups[nextGroupIdx].Length;
                // Hay caracteres más no procesados fueron.
                else
                {
                    // Carácter Intercambiar procesado con el último carácter no procesado
                    // Por lo que no recogemos hasta procesamos todos los caracteres de
                    // este grupo.
                    if (lastCharIdx != nextCharIdx)
                    {
                        char temp = charGroups[nextGroupIdx][lastCharIdx];
                        charGroups[nextGroupIdx][lastCharIdx] =
                                    charGroups[nextGroupIdx][nextCharIdx];
                        charGroups[nextGroupIdx][nextCharIdx] = temp;
                    }
                    // Disminuir el número de caracteres sin procesar en
                    // este grupo.
                    charsLeftInGroup[nextGroupIdx]--;
                }

                // Si procesamos el último grupo, empezar de nuevo.
                if (lastLeftGroupsOrderIdx == 0)
                    lastLeftGroupsOrderIdx = leftGroupsOrder.Length - 1;
                // Hay grupos más no procesados fueron.
                else
                {
                    // Intercambiar grupo procesado con el último grupo no procesada
                    // Por lo que no recogemos hasta procesamos todos los grupos.
                    if (lastLeftGroupsOrderIdx != nextLeftGroupsOrderIdx)
                    {
                        int temp = leftGroupsOrder[lastLeftGroupsOrderIdx];
                        leftGroupsOrder[lastLeftGroupsOrderIdx] =
                                    leftGroupsOrder[nextLeftGroupsOrderIdx];
                        leftGroupsOrder[nextLeftGroupsOrderIdx] = temp;
                    }
                    // Disminuir el número de grupos sin procesar.
                    lastLeftGroupsOrderIdx--;
                }
            }

            // Convertir caracteres de la contraseña en una cadena y devolver el resultado.
            return new string(password);
        }
    }
}
