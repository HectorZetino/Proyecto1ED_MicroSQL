﻿using ClassLibraryTrees.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTrees.B_Tree
{
    public class BNodo<TKey, T> : INodo<TKey, T>
    {

        private int grado;

        /// <summary>
        /// Metodo Constructor del nodo
        /// </summary>
        /// <param name="grado">grado del arbol</param>
        public BNodo(int grado)
        {
            this.grado = grado;
            this.Hijos = new List<BNodo<TKey, T>>(grado + 1);
            this.Entradas = new List<Entry<TKey, T>>(grado);
        }

        public List<BNodo<TKey, T>> Hijos { get; set; }

        public List<Entry<TKey, T>> Entradas { get; set; }

        public bool EsHoja
        {
            get
            {
                return this.Hijos.Count == 0;
            }
        }

        public bool AlcanzaMaximaEntrada
        {
            get
            {
                return this.Entradas.Count == (this.grado);
            }
        }

        public bool AlcanzaMinimaEntrada
        {
            get
            {
                return this.Entradas.Count == this.grado - 1;
            }
        }
    }
}
