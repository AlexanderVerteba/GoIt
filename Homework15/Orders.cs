//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homework15
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int IdOrder { get; set; }
        public int IdProduct { get; set; }
        public int Count { get; set; }
    
        public virtual Products Products { get; set; }
    }
}
