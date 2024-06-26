using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        private int CodProducto { get; set; }
        private string NombreProd { get; set; }
        private DateTime Fechaven { get; set; }
        private int Dia { get; set; }
        private int Mes { get; set; }
        private int Anio { get; set; }
        private string Descripcion { get; set; }
        private decimal PrecioVenta { get; set; }
        private decimal PrecioCompra { get; set; }
        private int Tipo { get; set; }
        private int Cantidad { get; set; }

        //geters
        public int GetCodProducto() { return this.CodProducto; }
        public string GetNombre() { return this.NombreProd; }
        public int GetDia() { return this.Dia; }
        public int GetMes() { return this.Mes; }
        public int GetAnio() { return this.Anio; }
        public DateTime GetFechaven() { return this.Fechaven; }
        public string GetDescripcion() { return this.Descripcion; }
        public decimal GetPrecioVenta() { return this.PrecioVenta; }
        public decimal GetPrecioCompra() { return this.PrecioCompra; }
        public int GetTipo() { return this.Tipo; }
        public int GetCantidad() { return this.Cantidad; }
        //seters
        public void SetCodProducto(int codP) { this.CodProducto = codP; }
        public void SetNombre(string nom) { this.NombreProd = nom; }
        public void SetDia(int Dia) { this.Dia = Dia; }
        public void SetMes(int Mes) { this.Mes = Mes; }
        public void SetAnio(int Anio) { this.Anio = Anio; }
        public void SetFechaven(DateTime fecha) { this.Fechaven = fecha; }
        public void SetDescripcion(string desc) { this.Descripcion = desc; }
        public void SetPrecioVenta(decimal PrecioV) { this.PrecioVenta = PrecioV; }
        public void SetPrecioCompra(decimal PrecioC) { this.PrecioCompra = PrecioC; }
        public void SetTipo(int tipoC) { this.Tipo = tipoC; }
        public void SetCantidad(int cantidad) { this.Cantidad = cantidad; }
    }
}
