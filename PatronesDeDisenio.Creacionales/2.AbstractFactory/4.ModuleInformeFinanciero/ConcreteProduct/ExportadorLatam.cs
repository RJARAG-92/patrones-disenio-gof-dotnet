﻿using PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.AbstractProduct;

namespace PatronesDeDisenio.Creacionales._2.AbstractFactory.Ejemplo4.ConcreteProduct
{
    public class ExportadorLatam : IExporter
    {
        public void Exportar(string nombreArchivo)
        {
            Console.WriteLine($"Exportando informe tributario SUNAT (XML): {nombreArchivo}.xml");
        }
    }
}
