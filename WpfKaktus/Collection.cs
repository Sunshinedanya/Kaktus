//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfKaktus
{
    using System;
    using System.Collections.Generic;
    
    public partial class Collection
    {
        public string id_collection { get; set; }
        public int id_kaktus { get; set; }
        public int id_exibition { get; set; }
    
        public virtual Exibition Exibition { get; set; }
        public virtual Kaktus Kaktus { get; set; }
    }
}
