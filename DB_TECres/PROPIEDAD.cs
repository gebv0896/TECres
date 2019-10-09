//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_TECres
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROPIEDAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROPIEDAD()
        {
            this.ANUNCIO = new HashSet<ANUNCIO>();
            this.FOTO = new HashSet<FOTO>();
            this.TIENE_PISO = new HashSet<TIENE_PISO>();
        }
    
        public int ID { get; set; }
        public int Precio { get; set; }
        public string Direccion_Exacta { get; set; }
        public string Titulo { get; set; }
        public bool Parqueo_Visitas { get; set; }
        public int Niveles { get; set; }
        public bool Piscina { get; set; }
        public bool Gimnasio { get; set; }
        public int Tamano_Terreno { get; set; }
        public int Tamano_Construccion { get; set; }
        public int Cant_Habitaciones { get; set; }
        public int Cant_Banos { get; set; }
        public int Cant_Parqueos { get; set; }
        public string Descripcion { get; set; }
        public string Foto_Principal { get; set; }
        public int ID_Ubicacion { get; set; }
        public string Nombre_Inmueble { get; set; }
        public int Cedula_Cliente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<ANUNCIO> ANUNCIO { get; set; }
        public CLIENTE CLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<FOTO> FOTO { get; set; }
        public UBICACION UBICACION { get; set; }
        public TIPO_INMUEBLE TIPO_INMUEBLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<TIENE_PISO> TIENE_PISO { get; set; }
    }
}