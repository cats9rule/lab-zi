using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Homework1
{
    internal class PlayfairCipher
    {
        private string keyMatrix;

        public PlayfairCipher()
        {
            Initialize();
        }

        public void Initialize()
        {
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            keyMatrix = GenerateKeyMatrix(username);
        }

        public void Encrypt(string filePath, string destinationFolderPath)
        {
            SaveFile(Cipher(LoadPlaintext(filePath)), destinationFolderPath, filePath.Split("\\").Last(), true);
        }

        public void Decrypt(string filePath, string destinationFolderPath)
        {
            SaveFile(Cipher(LoadPlaintext(filePath)), destinationFolderPath, filePath.Split("\\").Last(), false);
        }

        private string GenerateKeyMatrix(string username)
        {
            return FillMatrix(ExpandKey(RemoveInvalidLetters(username)));
        }

        private string RemoveInvalidLetters(string username)
        {
            username = Regex.Replace(username.ToLower(), @"[^a-z]+", String.Empty); 
            string result = "";
            HashSet<char> unique = new HashSet<char>(username);
            foreach (char c in unique)
            {
                if (c != 'j')
                {
                    result += c;
                }
            }
            return result;
        }

        private string ExpandKey(string transformedUsername)
        {
            if (transformedUsername.Length > 6) return transformedUsername;
            string result = transformedUsername;
            string alphabet = "abcdefghiklmnopqrstuvwxyz";
            if (transformedUsername.Length == 0)
            {
                throw new Exception("Cannot make key from empty string.");
            }
            for (int i = 0; i < 7 - transformedUsername.Length; i++)
            {
                char current = result[i];
                int indexOfCurrentInAlphabet = alphabet.IndexOf(current);
                while (result.Contains(current))
                {
                    indexOfCurrentInAlphabet = indexOfCurrentInAlphabet == 24 ? 0 : ++indexOfCurrentInAlphabet;
                    current = alphabet[indexOfCurrentInAlphabet];
                }
                result += current;
            }
            return result;
        }

        private string FillMatrix(string key)
        {
            string alphabet = "abcdefghiklmnopqrstuvwxyz";
            for(int i = 0; i < 25; i++)
            {
                if (key.Contains(alphabet[i])) continue;
                key += alphabet[i];
            }
            return key;
        }

        private string LoadPlaintext(string filePath)
        {
            string plaintext = "";
            if (File.Exists(filePath))
            {
                using (StreamReader sr = 
                    new StreamReader(
                        new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)
                        ))
                {
                    plaintext = sr.ReadToEnd();
                }
            }
            else throw new IOException("File does not exist:\n" + filePath);
            return plaintext;
        }

        private void SaveFile(string text, string folderPath, string fileName, bool isEncrypt)
        {
            fileName = fileName.Substring(0, fileName.IndexOf(".txt"))
                    + (isEncrypt ? ".encrypt" : ".decrypt") + ".txt";
            using (StreamWriter sw = 
                new StreamWriter(
                    new FileStream(folderPath + "\\" + fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)
                    ))
            {
                sw.Write(text);
            }
        }

        private string Cipher(string plaintext)
        {
            if (plaintext.Length == 0) return "";
            string formattedText = FormatTextForCipher(plaintext);
            string ciphertext = "";
            for (int i = 0; i < formattedText.Length; i += 2)
            {
                ciphertext += ResolveDigraph(formattedText[i], formattedText[i + 1]);
            }
            return ciphertext;
        }

        private string FormatTextForCipher(string text)
        {
            string bogus1 = "x";
            string bogus2 = "y";
            text.Replace('j', 'i');
            text = Regex.Replace(text, @"[^a-z]+", String.Empty);
            int length = text.Length;
            for (int i = 0; i < length; i++)
            {
                if (i < length-1 && text[i] == text[i + 1])
                {
                    text = text.Insert(i + 1, text[i] != 'x' ? bogus1 : bogus2);
                    length++;
                }
            }
            if (text.Length % 2 == 1) text += 'z';
            return text;
        }

        private string ResolveDigraph(char char1, char char2)
        {
            int index1 = keyMatrix.IndexOf(char1);
            int index2 = keyMatrix.IndexOf(char2);
            string result = "";
            int row1 = index1 / 5;
            int column1 = index1 % 5;
            int row2 = index2 / 5;
            int column2 = index2 % 5;
            if (row1 == row2)
            {
                index1 = (index1 + 1) % 5 == 0 ? index1 - 4 : index1 + 1;
                index2 = (index2 + 1) % 5 == 0 ? index2 - 4 : index2 + 1;
            }
            else if (column1 == column2)
            {
                index1 = (index1 - 5 < 0) ? 20 + index1 : index1 - 5;
                index2 = (index2 - 5 < 0) ? 20 + index2 : index2 - 5;
            }
            else
            {
                index1 = row1 * 5 + column2;
                index2 = row2 * 5 + column1;
            }
            result += keyMatrix[index1].ToString() + keyMatrix[index2].ToString();
            return result;
        }
    }
}
