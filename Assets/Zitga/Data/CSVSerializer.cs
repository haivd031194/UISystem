using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Loxodon.Framework.Data
{
    public static class CSVSerializer
    {
        public static List<string[]> ParseCSV(string text, char separator = ',', bool contentKey = false)
        {
            List<string[]> lines = new List<string[]>();
            List<string> line = new List<string>();
            StringBuilder token = new StringBuilder();
            bool quotes = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (quotes)
                {
                    if ((text[i] == '\\' && i + 1 < text.Length && text[i + 1] == '\"') ||
                        (text[i] == '\"' && i + 1 < text.Length && text[i + 1] == '\"'))
                    {
                        token.Append('\"');
                        i++;
                    }
                    else if (text[i] == '\\' && i + 1 < text.Length && text[i + 1] == 'n')
                    {
                        token.Append('\n');
                        i++;
                    }
                    else if (text[i] == '\"')
                    {
                        line.Add(token.ToString());
                        token = new StringBuilder();
                        quotes = false;
                        if (i + 1 < text.Length && text[i + 1] == separator)
                            i++;
                    }
                    else
                    {
                        token.Append(text[i]);
                    }
                }
                else if (text[i] == '\r' || text[i] == '\n')
                {
                    if (token.Length > 0)
                    {
                        line.Add(token.ToString());
                        token = new StringBuilder();
                    }

                    if (line.Count > 0)
                    {
                        lines.Add(line.ToArray());
                        line.Clear();
                    }
                }
                else if (text[i] == separator)
                {
                    line.Add(token.ToString());
                    token = new StringBuilder();
                }
                else if (text[i] == '\"')
                {
                    quotes = true;
                }
                else
                {
                    token.Append(text[i]);
                }
            }

            if (token.Length > 0)
            {
                line.Add(token.ToString());
            }

            if (line.Count > 0)
            {
                lines.Add(line.ToArray());
            }

            if (contentKey == false)
                lines.RemoveAt(0);

            return lines;
        }
    }
}