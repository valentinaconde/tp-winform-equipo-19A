﻿namespace TPWinForm_equipo_19A
{
     class Articulo
    {
        public int Id { get;  set; }
        public string Codigo { get;  set; }
        public string Nombre { get;  set; }
        public string Descripcion { get;  set; }
        public Marca marca { get;  set; }
        public Categoria categoria { get; set; }
        public decimal Precio { get;  set; }
        public string UrlImagem { get; set; }
    }
}