﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub.Entidades
{
    public class Pelicula
    {
        private int _anio;
        private int _duracion;
        private string _titulo;
        private string _director;
        private string _productora;
        private string _genero;
        private int _idPelicula;

        public Pelicula(int anio, int duracion, string titulo, string director, string productora, string genero)
        {
            _anio = anio;
            _duracion = duracion;
            _titulo = titulo;
            _director = director;
            _productora = productora;
            _genero = genero;            
        }

        public int Anio { get { return _anio; } set { _anio = value; } }
        public int Duracion { get { return _duracion; } set { _duracion = value; } }
        public string Titulo { get { return _titulo; } set { _titulo = value; } }
        public string Director { get { return _director; } set { _director = value; } }
        public string Productora { get { return _productora; } set { _productora = value; } }
        public string Genero { get { return _genero; } set { _genero = value; } }
        public int Id { get { return _idPelicula; } set { _idPelicula = value; } }
        public string ComboDisplay { get => $"  ({this._idPelicula}) Pelicula:  {this._titulo} Director: {this._director} "; }

        public override string ToString()
        {
            return " Pelicula: " + this._titulo + "\n Año: " + this._anio + "\n Duración: " + this._duracion + "\n Director: " + this._director +
                "\n Preductora: " + this._productora + "\n Género: " + this._genero; ;
        }
    }
}
